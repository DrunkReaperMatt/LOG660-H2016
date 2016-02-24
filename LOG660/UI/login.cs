using LOG660.FACADE;
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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
            resetTextbox();
        }

        private void cmdConnect_Click(object sender, EventArgs e)
        {
            var web = WebFlixFacade.getInstance;

            var usager = WebFlixFacade.connectUserWithCredentials(txtUser.Text, txtPassword.Text);

            if (usager != null)
            {
                this.Hide();
                FormFilmConsultations form = new FormFilmConsultations(usager, this);
                form.Show();
            }
            else
            {
                MessageBox.Show("Vos paramètres de connexion  sont invalides veuillez recommencer","Erreur de connexion",MessageBoxButtons.OK,MessageBoxIcon.Error);
                resetTextbox();
                this.Refresh();
            }

        }
        private void resetTextbox()
        {
            this.txtPassword.Text = "vonej2ooT";
            this.txtUser.Text = "ThomasCBaggett12@yahoo.com";
        }
    }
}
