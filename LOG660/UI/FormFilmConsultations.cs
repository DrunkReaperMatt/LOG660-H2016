using LOG660.DATA;
using LOG660.FACADE;
using LOG660.HELPERS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOG660.UI
{
    public partial class FormFilmConsultations : Form
    {
        #region Fields

        private List<UserControlFolder.AdvancedSearchUC> customUCList = new List<UserControlFolder.AdvancedSearchUC>();
        private Boolean openAdvancedSearch = true;
        USAGER currentUser = null;
        FILM currentMovie = null;
        login m_loginPage = null;
        WebFlixFacade m_facade = WebFlixFacade.getInstance;
        System.Timers.Timer m_timer = new System.Timers.Timer(400);

        #endregion

        #region Constructors

        public FormFilmConsultations(object user, login loginPage)
        {
            InitializeComponent();

            m_timer.Elapsed += m_timer_Elapsed;
            m_loginPage = loginPage;
            this.currentUser = (USAGER)user;
            m_lblNomClient.Text = currentUser.NOM;
        }

        #endregion

        #region Private Methods

        private void openAdvancedSearchPanel()
        {
            if (openAdvancedSearch)
            {
                addUC();
                openAdvancedSearch = false;
            }
        }
        private void addUC()
        {
            UserControlFolder.AdvancedSearchUC uc = new UserControlFolder.AdvancedSearchUC();
            uc.searchChangedEventHandler += new UserControlFolder.AdvancedSearchUC.SearchChangedEventHandler(SearchChanged);
            uc.fieldEventHandler += new UserControlFolder.AdvancedSearchUC.FieldEventHandler(handleFieldEvent);
            uc.Location = new Point(uc.Location.X, customUCList.Count * uc.Height);
            pnlAdvanced.Size = new Size(pnlAdvanced.Width, pnlAdvanced.Size.Height + uc.Height);

            relocateControls(uc.Height);

            customUCList.Add(uc);
            pnlAdvanced.Controls.Add(uc);
            if (customUCList.Count >= 2)
            {
                customUCList[customUCList.Count - 2].disableButton();
            }
        }

        private void removeUC()
        {
            UserControlFolder.AdvancedSearchUC uc = customUCList[customUCList.Count - 1];
            pnlAdvanced.Size = new Size(pnlAdvanced.Width, pnlAdvanced.Size.Height - uc.Height);

            relocateControls(uc.Height * -1);

            customUCList.Remove(uc);
            pnlAdvanced.Controls.Remove(uc);
            if (customUCList.Count >= 1)
            {
                customUCList[customUCList.Count - 1].enableButton();
            }
        }

        private void relocateControls(int modifier)
        {
            // JP: Plus besoin de ça, parce que dock.
            //panel1.Location = new Point(panel1.Location.X, panel1.Location.Y + modifier);
            //m_btnLouerFilm.Location = new Point(m_btnLouerFilm.Location.X, m_btnLouerFilm.Location.Y + modifier);
        }

        private void ClearListsSelection(DataGridView sender)
        {
            if (!m_clearingSelection)
            {
                m_clearingSelection = true;

                if(sender != m_dataScreenWriters)
                    m_dataScreenWriters.ClearSelection();

                if (sender != m_dataActors)
                    m_dataActors.ClearSelection();

                if (sender != m_dataProducer)
                    m_dataProducer.ClearSelection();

                m_clearingSelection = false;
            }
        }

        private void displayPersonneInfoById(int id)
        {
            var naString = "NA";
            if (id >= 0)
            {
                var personne = m_facade.getEntity.PERSONNEs.FirstOrDefault(a => a.IDPERSONNE == id);
                if (personne != null)
                {
                    m_lblNomActeur.Text = personne.NOM;
                    m_lblDateNaissance.Text = personne.DATENAISSANCE != null ? personne.DATENAISSANCE.Value.ToString() : naString;
                    m_lblLieuNaissance.Text = personne.LIEUNAISSANCE != null ? personne.LIEUNAISSANCE : naString;
                    m_lblBiographie.Text = personne.BIOGRAPHIE.BIOGRAPHIE1 != null ? personne.BIOGRAPHIE.BIOGRAPHIE1 : naString;
                }
            }
            else
            {
                m_lblNomActeur.Text = "Acteur";
                m_lblDateNaissance.Text = naString;
                m_lblLieuNaissance.Text = naString;
                m_lblBiographie.Text = naString;
            }
        }

        private void displayMovieInfoById(int id)
        {
            var film = m_facade.getEntity.FILMs.FirstOrDefault(f => f.IDFILM == id);
            if (film != null)
            {
                currentMovie = film;

                m_lblAnnee.Text = film.ANNEESORTIE.Value.ToString();
                m_lblLangue.Text = film.LANGUEORIGINAL;
                m_lblDuree.Text = film.DUREE.Value.ToString();
                m_lblResume.Text = getResumeById(Convert.ToInt32(film.IDRESUME)).RESUME1;

                displayMovieCountries(film.PAYSPRODUCTIONs);
                displayMovieProducer(Convert.ToInt32(film.IDREALISATEUR));
                displayScreenWriters(film.PERSONNEs);
                displayActors(film.ACTEURFILMs);
            }
        }

        private void DisplayMovies(List<FILM> films)
        {
            m_dataFilms.Rows.Clear();

            foreach (var movie in films)
            {
                m_dataFilms.Rows.Add(movie.IDFILM, movie.TITRE + " (" + movie.ANNEESORTIE + ")");
            }
        }

        private void displayActors(ICollection<ACTEURFILM> collection)
        {
            m_dataActors.Rows.Clear();

            var actors = m_facade.getEntity.ACTEURs;
            foreach (var movieActor in collection)
            {
                var actor = actors.FirstOrDefault(a => a.IDPERSONNE == movieActor.IDPERSONNE);
                m_dataActors.Rows.Add(actor.IDPERSONNE, actor.PERSONNE.NOM);
            }
        }

        private void displayMovieCountries(ICollection<PAYSPRODUCTION> collection)
        {
            m_dataCountries.Rows.Clear();

            var countries = m_facade.getEntity.PAYSPRODUCTIONs;
            foreach (var productionCountry in collection)
            {
                var country = countries.FirstOrDefault(c => c.IDPAYS == productionCountry.IDPAYS);
                m_dataCountries.Rows.Add(country.IDPAYS, country.NOM);
            }
        }

        private void displayMovieProducer(int producerId)
        {
            m_dataProducer.Rows.Clear();

            var producerName = getRealisateurById(producerId).PERSONNE.NOM;
            m_dataProducer.Rows.Add(producerId, producerName);
        }

        private void displayScreenWriters(ICollection<PERSONNE> collection)
        {
            m_dataScreenWriters.Rows.Clear();

            var screenWriters = m_facade.getEntity.SCENARISTEs;
            foreach (var screenWriterPersonne in collection)
            {
                var screenWriter = screenWriters.FirstOrDefault(a => a.IDPERSONNE == screenWriterPersonne.IDPERSONNE);
                m_dataScreenWriters.Rows.Add(screenWriter.IDPERSONNE, screenWriter.PERSONNE.NOM);
            }
        }

        private REALISATEUR getRealisateurById(int id)
        {
            return m_facade.getEntity.REALISATEURs.FirstOrDefault(r => r.IDPERSONNE == id);
        }

        private RESUME getResumeById(int id)
        {
            return m_facade.getEntity.RESUMEs.FirstOrDefault(r => r.IDRESUME == id);
        }

        #endregion

        #region Event Handlers

        private void handleFieldEvent(object sender, int eventIdentification)
        {
            if (eventIdentification == UserControlFolder.AdvancedSearchUC.ADD_EVENT_IDENTIFIER)
            {
                addUC();
            }
            else if (eventIdentification == UserControlFolder.AdvancedSearchUC.REMOVE_EVENT_IDENTIFIER)
            {
                if (customUCList.Count == 1)
                {
                    this.m_btnOptionsRecherche.Enabled = true;
                    openAdvancedSearch = true;
                }
                removeUC();
            }
        }

        private void m_btnOptionsRecherche_Click(object sender, EventArgs e)
        {
            openAdvancedSearchPanel();
            ((System.Windows.Forms.Button)sender).Enabled = false;
        }

        private void FormFilmConsultations_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void FormFilmConsultations_Load(object sender, EventArgs e)
        {
            var films = m_facade.getEntity.FILMs.ToList();
            DisplayMovies(films);
        }

        private void m_btnEffacer_Click(object sender, EventArgs e)
        {
            m_txtRecherche.Text = String.Empty;
            while(customUCList.Count != 0)
            {
                removeUC();
            }
            this.m_btnOptionsRecherche.Enabled = true;
            openAdvancedSearch = true;
        }

        private void m_btnDeconnexion_Click(object sender, EventArgs e)
        {
            if (m_loginPage != null)
            {
                this.Hide();
                m_loginPage.Show();
            }
        }

        private void m_btnLouerFilm_Click(object sender, EventArgs e)
        {
            if(m_dataFilms.CurrentCell != null)
            {
                var idMovie = Convert.ToInt32(m_dataFilms[0, m_dataFilms.CurrentCell.RowIndex].Value);
                if (Helpers.isClient(currentUser.IDUSAGER))
                {
                    string message = string.Empty;
                    var success = WebFlixFacade.makeMovieRental(Convert.ToInt32(currentUser.IDUSAGER), idMovie, out message);
                    MessageBox.Show(message, "Louer Film", MessageBoxButtons.OK, success ? MessageBoxIcon.Information : MessageBoxIcon.Error);
                }
            }


        }
        private bool m_clearingSelection = false;

        private void m_dataActors_SelectionChanged(object sender, EventArgs e)
        {
            // Clear selection of other list
            if(!m_clearingSelection)
            {
                ClearListsSelection(m_dataActors);

                var id = m_dataActors[0, m_dataActors.CurrentCell.RowIndex].Value;
                displayPersonneInfoById(Convert.ToInt32(id));
            }
        }

        private void m_dataCountries_SelectionChanged(object sender, EventArgs e)
        {
            m_dataCountries.ClearSelection();
        }

        private void m_dataFilms_Paint(object sender, PaintEventArgs e)
        {
            DataGridView dataGrid = (DataGridView)sender;

            if (dataGrid.Rows.Count == 0)
            {
                using (Graphics graphics = e.Graphics)
                {
                    graphics.FillRectangle(Brushes.WhiteSmoke, new Rectangle(new Point(3, 3), new Size(dataGrid.Width - 6, dataGrid.Height - 6)));
                    graphics.DrawString("Aucun film trouvé", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new PointF(((dataGrid.Width / 2) - 65), ((dataGrid.Height / 2)) - 20));
                }
            }
        }

        private void m_dataFilms_SelectionChanged(object sender, EventArgs e)
        {
            var id = m_dataFilms[0, m_dataFilms.CurrentCell.RowIndex].Value;
            displayMovieInfoById(Convert.ToInt32(id));
        }

        private void m_dataProducer_SelectionChanged(object sender, EventArgs e)
        {
            if(!m_clearingSelection)
            {
                ClearListsSelection(m_dataProducer);

                var id = m_dataProducer[0, m_dataProducer.CurrentCell.RowIndex].Value;
                displayPersonneInfoById(Convert.ToInt32(id));
            }
        }

        private void m_dataScreenWriters_SelectionChanged(object sender, EventArgs e)
        {
            // Clear selection of other list
            if (!m_clearingSelection)
            {
                ClearListsSelection(m_dataScreenWriters);

                var id = m_dataScreenWriters[0, m_dataScreenWriters.CurrentCell.RowIndex].Value;
                displayPersonneInfoById(Convert.ToInt32(id));
            }
        }

        private void SearchChanged(object sender, KeyEventArgs e)
        {
            /*if(e.KeyCode == Keys.Escape)
            {
                m_txtRecherche.Text = String.Empty;
            }*/
            m_timer.Start();
        }

        private void m_timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            m_timer.Stop();

            BeginInvoke(new Action(() =>
            {
                var web = WebFlixFacade.getInstance;
                List<FILM> films = new List<FILM>();
                if(openAdvancedSearch)
                {
                    films = WebFlixFacade.getFilmList(m_txtRecherche.Text);
                }
                else 
                {
                    films = WebFlixFacade.getFilmList(m_txtRecherche.Text, customUCList);
                }
                DisplayMovies(films);
            }
            ));
        }

        #endregion      
    }
}
