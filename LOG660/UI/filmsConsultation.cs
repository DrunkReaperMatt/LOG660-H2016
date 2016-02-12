using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LOG660.FACADE;

namespace LOG660.UI
{
    public partial class filmsConsultation : Form
    {
        public filmsConsultation()
        {
            InitializeComponent();

            // test
            m_dataFilms.DataSource = WebFlixFacade.getInstance.FILMs.Local.ToBindingList();
        }

        /// <summary>
        /// Recherche envoyée à partir du text
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void m_btnRechercher_Click(object sender, EventArgs e)
        {
            var recherche = m_txtRecherche.Text;
            if(recherche != string.Empty)
            {

            }
        }

        /// <summary>
        /// Effacer la recherche courante
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void m_btnEffacer_Click(object sender, EventArgs e)
        {
            m_txtRecherche.Text = string.Empty;
        }

        /// <summary>
        /// Film selection changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void m_dataFilms_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
