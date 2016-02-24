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

        USAGER currentUser = null;
        FILM currentMovie = null;
        login m_loginPage = null;
        WebFlixFacade m_facade = WebFlixFacade.getInstance;

        #endregion

        #region Constructors

        public FormFilmConsultations(object user, login loginPage)
        {
            InitializeComponent();

            m_loginPage = loginPage;
            this.currentUser = (USAGER)user;
            m_lblNomClient.Text = currentUser.NOM;
        }

        #endregion

        #region Private Methods

        private void displayActorInfoById(int id)
        {
            var naString = "NA";
            if (id >= 0)
            {
                var actor = m_facade.getEntity.ACTEURs.FirstOrDefault(a => a.IDPERSONNE == id);
                if (actor != null)
                {
                    m_lblNomActeur.Text = actor.PERSONNE.NOM;
                    m_lblDateNaissance.Text = actor.PERSONNE.DATENAISSANCE != null ? actor.PERSONNE.DATENAISSANCE.Value.ToString() : naString;
                    m_lblLieuNaissance.Text = actor.PERSONNE.LIEUNAISSANCE != null ? actor.PERSONNE.LIEUNAISSANCE : naString;
                    m_lblBiographie.Text = actor.PERSONNE.BIOGRAPHIE.BIOGRAPHIE1 != null ? actor.PERSONNE.BIOGRAPHIE.BIOGRAPHIE1 : naString;
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
                m_lblRealisateur.Text = getRealisateurById(Convert.ToInt32(film.IDREALISATEUR)).PERSONNE.NOM;
                m_lblResume.Text = getResumeById(Convert.ToInt32(film.IDRESUME)).RESUME1;

                displayMovieCountries(film.PAYSPRODUCTIONs);
                //displayScreenWriters(m_facade.getEntity.SCENARISTEs);
                displayActors(film.ACTEURFILMs);
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

        private void displayScreenWriters(ICollection<PERSONNE> collection)
        {
            // TODO
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

        private void FormFilmConsultations_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void FormFilmConsultations_Load(object sender, EventArgs e)
        {
            var films = m_facade.getEntity.FILMs.ToList();

            foreach (var film in films)
            {
                m_dataFilms.Rows.Add(film.TITRE + " (" + film.ANNEESORTIE + ")", film.IDFILM);
            }
        }

        private void m_btnRechercher_Click(object sender, EventArgs e)
        {

        }

        private void m_btnEffacer_Click(object sender, EventArgs e)
        {
            m_txtRecherche.Text = String.Empty;
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
            if (Helpers.isClient(currentUser.IDUSAGER))
            {

            }
        }

        private void m_dataActors_SelectionChanged(object sender, EventArgs e)
        {
            var id = m_dataActors[0, m_dataActors.CurrentCell.RowIndex].Value;
            displayActorInfoById(Convert.ToInt32(id));
        }

        private void m_dataCountries_SelectionChanged(object sender, EventArgs e)
        {
            m_dataCountries.ClearSelection();
        }

        private void m_dataFilms_SelectionChanged(object sender, EventArgs e)
        {
            var id = m_dataFilms[1, m_dataFilms.CurrentCell.RowIndex].Value;
            displayMovieInfoById(Convert.ToInt32(id));
        }

        #endregion
    }
}
