using LOG660.DATA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOG660.FACADE
{
    public class WebFlixFacade
    {
        private static WebFlixFacade _webFlixInstance;

        private static MovieEntityDataManager _entityWebFlixMgr;
        public WebFlixFacade() { }
        
        //Singleton de  l'objet de la BD
        public static WebFlixFacade getInstance
        {
            get
            {
                if (_webFlixInstance == null)
                {
                    _webFlixInstance = new WebFlixFacade();
                    
                }

                _entityWebFlixMgr = new MovieEntityDataManager();

                return _webFlixInstance;

            }
        }

        /// <summary>
        /// Function for user connection
        /// </summary>
        /// <param name="usercode"></param>
        /// <param name="userPassword"></param>
        /// <returns></returns>
        public static USAGER connectUserWithCredentials(string usercode, string userPassword)
        {
            var users = _entityWebFlixMgr.USAGERs.ToList();
          
            if (!String.IsNullOrEmpty(usercode) && !String.IsNullOrEmpty(userPassword))
                return _entityWebFlixMgr.USAGERs.FirstOrDefault(u => u.COURRIEL.ToLower().Equals(usercode.ToLower()) && u.MOTPASSE.Equals(userPassword));
         
            return null;
        }

        /// <summary>
        /// Function that returns a message according to the status of location
        /// </summary>
        /// <param name="idUsager"></param>
        /// <param name="idFilm"></param>
        /// <param name="idExemplaire"></param>
        /// <returns></returns>
        public static String makeMovieRental(int idUsager, int idFilm, int idExemplaire)
        {
            //get client object
            var currentClient = _entityWebFlixMgr.USAGERs.Where(c => c.IDUSAGER == idUsager).FirstOrDefault();

            //get the number of copies of the requested movie
            var exemplaires = _entityWebFlixMgr.EXEMPLAIREs.Count(e => e.IDFILM == idFilm);

            //get the user account type and the allowed number of locations for it
            var maxLocationAllowed = (from forfait in _entityWebFlixMgr.FORFAITs.ToList()
                                      join cl in _entityWebFlixMgr.CLIENTs
                                      on forfait.IDFORFAIT equals cl.IDFORFAIT
                                      where currentClient.IDUSAGER == cl.IDUSAGER
                                      select forfait.LOCATIONMAX).FirstOrDefault();

            var currentClientLocationAmount = (from e in _entityWebFlixMgr.EXEMPLAIREs
                                               join location in _entityWebFlixMgr.LIGNELOCATIONs
                                               on e.IDEXEMPLAIRE equals location.IDEXEMPLAIRE
                                               select location).Count();

            //Verify if the user can make some rent this movie
            if (currentClientLocationAmount < maxLocationAllowed &&  exemplaires !=  0)
            {
                //We allow the location to be made
                _entityWebFlixMgr.PROC_RENTMOVIE(idUsager, idFilm, idExemplaire);
                return "La location du film a bel et bien été accepté.";
            }           

            return "Aucune copie de ce film n'est disponible pour le moment";
        }

    }
}
