using LOG660.DATA;
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
        USAGER currentUser = null;
        FILM currentMovie = null;

        public FormFilmConsultations(object user)
        {
            InitializeComponent();

            this.currentUser = (USAGER)user;
            m_lblNomClient.Text = currentUser.NOM;
        }

        private void m_btnRechercher_Click(object sender, EventArgs e)
        {

        }

        private void m_btnEffacer_Click(object sender, EventArgs e)
        {

        }

        private void m_btnLouerFilm_Click(object sender, EventArgs e)
        {

        }
    }
}
