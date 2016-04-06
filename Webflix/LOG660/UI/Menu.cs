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
    public partial class Menu : Form
    {
        USAGER currentUser = null;
        login login = null;
        public Menu(object user, login login)
        {
            InitializeComponent();

            this.currentUser = (USAGER)user;
            this.login = login;
        }

        private void btnMovieCounter_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormMovieLocationCounter(currentUser, login).Show();
        }

        private void btnConsultMovie_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormFilmConsultations(currentUser, login).Show();
        }
    }
}
