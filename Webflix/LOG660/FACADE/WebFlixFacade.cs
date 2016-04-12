using LOG660.DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Core.Objects;
using System.Globalization;

namespace LOG660.FACADE
{
    public class WebFlixFacade
    {
        private static WebFlixFacade _webFlixInstance;

        public static MovieEntityDataManager _entityWebFlixMgr;
        public WebFlixFacade() { }

        //Singleton de  l'objet de la BD
        public static WebFlixFacade getInstance
        {
            get
            {
                if (_webFlixInstance == null)
                {
                    _webFlixInstance = new WebFlixFacade();
                    _entityWebFlixMgr = new MovieEntityDataManager();
                }

                return _webFlixInstance;

            }
        }

        public MovieEntityDataManager getEntity
        {
            get { return _entityWebFlixMgr; }
        }

        /// <summary>
        /// Function for user connection
        /// </summary>
        /// <param name="usercode"></param>
        /// <param name="userPassword"></param>
        /// <returns></returns>
        public static USAGER connectUserWithCredentials(string usercode, string userPassword)
        {
            if (!String.IsNullOrEmpty(usercode) && !String.IsNullOrEmpty(userPassword))
                return _entityWebFlixMgr.USAGERs.FirstOrDefault(u => u.COURRIEL.ToLower().Equals(usercode.ToLower()) && u.MOTPASSE.Equals(userPassword));

            return null;
        }

        /// <summary>
        /// Function that returns a message according to the status of location
        /// </summary>
        /// <param name="idUsager"></param>
        /// <param name="idFilm"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public static bool makeMovieRental(int idUsager, int idFilm, out string message)
        {
            //get client object
            var currentClient = _entityWebFlixMgr.USAGERs.Where(c => c.IDUSAGER == idUsager).FirstOrDefault();

            //get the number of copies of the requested movie
            var exemplaires = _entityWebFlixMgr.EXEMPLAIREs.Count(e => e.IDFILM == idFilm);

            //get the current movie object
            var film = _entityWebFlixMgr.FILMs.FirstOrDefault(f => f.IDFILM == idFilm);
            if (film == null)
            {
                message = "Identifiant du film invalide.";
                return false;
            }

            //Movies that have copies not used in a command already.
            var availableExemplaire = film.EXEMPLAIREs.FirstOrDefault(e => !e.LIGNELOCATIONs.Any());
            if (availableExemplaire == null)
            {
                message = "Aucune copie de ce film n'est disponible pour le moment";
                return false;
            }

            //Verify if the choosen copy of this movie has already been took
            var isCoypAlreadyBeTaken = _entityWebFlixMgr.LIGNELOCATIONs.Include(l => l.LOCATIONs).
                                        Any(lg => lg.IDEXEMPLAIRE == availableExemplaire.IDEXEMPLAIRE);

            if (isCoypAlreadyBeTaken)
            {
                message = "Vous ne pouvez pas louer cette copie  de ce film.\nIl est déjà emprunté";
                return false;
            }


            //get the user account type and the allowed number of locations for it
            var maxLocationAllowed = (from forfait in _entityWebFlixMgr.FORFAITs
                                      join cl in _entityWebFlixMgr.CLIENTs
                                      on forfait.IDFORFAIT equals cl.IDFORFAIT
                                      where currentClient.IDUSAGER == cl.IDUSAGER
                                      select forfait.LOCATIONMAX).FirstOrDefault();

            // Get All locations from the current user
            var currentClientLocationAmount = _entityWebFlixMgr.USAGERs.Include(l => l.LOCATIONs).FirstOrDefault(u => u.IDUSAGER == idUsager).LOCATIONs.Count();

            //Verify if the user can make rent this movie on his current amount of location
            if (currentClientLocationAmount < maxLocationAllowed)
            {
                if (exemplaires != 0)
                {
                    //We allow the location to be made
                    _entityWebFlixMgr.PROC_RENTMOVIE2(idUsager, idFilm, availableExemplaire.IDEXEMPLAIRE);

                    message = "La location du film a bel et bien été accepté.";

                    RefreshEntities();
                    return true;
                }
                else
                {
                    message = "Aucune copie de ce film n'est disponible pour le moment";
                    return false;
                }
            }
            else
            {
                message = "Vous ne pouvez faire la location d'un film.\nAucune location restante pour le forfait courant.";
                return false;
            }


        }

        private static void RefreshEntities()
        {
            var context = ((IObjectContextAdapter)_entityWebFlixMgr).ObjectContext;
            if (context != null)
            {
                var objects = (from entry in context.ObjectStateManager.GetObjectStateEntries(
                                                   EntityState.Added
                                                  | EntityState.Deleted
                                                  | EntityState.Modified
                                                  | EntityState.Unchanged)
                               where entry.EntityKey != null
                               select entry.Entity);

                context.Refresh(RefreshMode.StoreWins, objects);
            }
        }

        public static List<FILM> getFilmList(string query)
        {
            List<FILM> films = new List<FILM>();

            var filmRechercheQuery = (
                from film in _entityWebFlixMgr.FILMs.ToList()
                where film.TITRE.ToLower().Contains(query.ToLower())
                select film
                ).ToList();

            films.AddRange(filmRechercheQuery);

            return films;
        }

        public static List<FILM> getFilmList(string query, List<UserControlFolder.AdvancedSearchUC> UCs)
        {
            List<FILM> x = new List<FILM>();
            String textToSearch = "";
            var advancedSearch = (
                from film in _entityWebFlixMgr.FILMs
                select film
                ).ToList();
            var basicSearch = (
                from film in _entityWebFlixMgr.FILMs
                select film
                ).ToList();

            if (!query.Equals(""))
            {
                basicSearch = (
                from film in _entityWebFlixMgr.FILMs
                where film.TITRE.ToLower().Contains(query.ToLower())
                select film
                ).ToList();
            }
            for (int i = 0; i < UCs.Count; i++)
            {
                textToSearch = UCs[i].getText().Trim().ToLower();
                if (!(textToSearch.Equals("")))
                {
                    if (UCs[i].getValue() == UserControlFolder.AdvancedSearchUC.LANGUE_IDENTIFIER)
                    {
                        advancedSearch = (
                        from film in _entityWebFlixMgr.FILMs
                        where film.LANGUEORIGINAL != null && film.LANGUEORIGINAL.ToLower().Equals(textToSearch)
                        select film
                        ).ToList();
                    }
                    else if (UCs[i].getValue() == UserControlFolder.AdvancedSearchUC.PAYS_IDENTIFIER)
                    {
                        advancedSearch = (
                        from film in _entityWebFlixMgr.FILMs
                        where film.PAYSPRODUCTIONs.Any(p => p.NOM.ToLower().Equals(textToSearch))
                        select film
                        ).ToList();
                    }
                    else if (UCs[i].getValue() == UserControlFolder.AdvancedSearchUC.GENRE_IDENTIFIER)
                    {
                        advancedSearch = (
                        from film in _entityWebFlixMgr.FILMs
                        where film.GENREs.Any(g => g.NOM.ToLower().Equals(textToSearch))
                        select film
                        ).ToList();
                    }
                    else if (UCs[i].getValue() == UserControlFolder.AdvancedSearchUC.ACTEUR_IDENTIFIER)
                    {
                        advancedSearch = (
                        from film in _entityWebFlixMgr.FILMs
                        where film.ACTEURFILMs.Any(a => a.PERSONNE.NOM.ToLower().Contains(textToSearch))
                        select film
                        ).ToList();
                    }
                    else if (UCs[i].getValue() == UserControlFolder.AdvancedSearchUC.REALISATEUR_IDENTIFIER)
                    {
                        textToSearch = UCs[i].getText().ToLower();
                        advancedSearch = (
                        from film in _entityWebFlixMgr.FILMs
                        where film.PERSONNE.NOM.ToLower().Contains(textToSearch)
                        select film
                        ).ToList();
                    }
                    else if (UCs[i].getValue() == UserControlFolder.AdvancedSearchUC.ANNEE_IDENTIFIER)
                    {
                        int pos1 = textToSearch.IndexOf("[");
                        int pos2 = textToSearch.IndexOf(",");
                        int pos3 = textToSearch.IndexOf("]");
                        if (pos1 == 0 && pos3 == 10)
                        {
                            int start = Convert.ToInt32(textToSearch.Substring(1, 4));
                            int end = Convert.ToInt32(textToSearch.Substring(pos2 + 1, 4));
                            advancedSearch = (
                            from film in _entityWebFlixMgr.FILMs
                            where film.ANNEESORTIE >= start && film.ANNEESORTIE <= end
                            select film
                            ).ToList();
                        }
                    }
                    else if (UCs[i].getValue() == UserControlFolder.AdvancedSearchUC.TITRE_IDENTIFIER)
                    {
                        textToSearch = UCs[i].getText().ToLower();
                        advancedSearch = (
                        from film in _entityWebFlixMgr.FILMs
                        where film.TITRE.ToLower().Contains(textToSearch)
                        select film
                        ).ToList();
                    }
                    basicSearch = basicSearch.Intersect(advancedSearch).ToList();
                }
            }

            return basicSearch.ToList();
        }


        public int getMovieLocationCountFromCriteria(string ageRange, int? day, int? month, string province) 
        {            
            int? groupeage = !String.IsNullOrEmpty(ageRange) ? (int?)((int.Parse(ageRange.Split('-')[0]) - 18) / 5) : null;
            string dayName = day.HasValue ? Enum.GetName(typeof(DayOfWeek), day.Value) : null;
            string monthName = month.HasValue ? DateTimeFormatInfo.CurrentInfo.GetMonthName(month.Value) : null;

            return _entityWebFlixMgr.FAITLOCATIONFILMCLIENTINSTANTs.Where(locationAmount => String.IsNullOrEmpty(ageRange) 
                                    || locationAmount.DIMENSIONCLIENT.GROUPEAGE == groupeage
                 && !day.HasValue   || dayName.Equals( locationAmount.DIMENSIONTEMP.JOUR ) 
                 && !month.HasValue || monthName.Equals( locationAmount.DIMENSIONTEMP.MOIS)
                 && String.IsNullOrEmpty(province) || province.Equals(locationAmount.DIMENSIONCLIENT.PROVINCE)).Count();
        }

        public float? GetMovieCote(int idMovie)
        {
            return null;
        }
    }

}

