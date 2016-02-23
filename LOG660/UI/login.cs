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
        }

        private void cmdConnect_Click(object sender, EventArgs e)
        {
            var web = WebFlixFacade.getInstance;

            var usager = WebFlixFacade.connectUserWithCredentials(txtUser.Text, txtPassword.Text);

            if (usager != null)
            {
                this.Hide();
                FormFilmsConsultation form = new FormFilmsConsultation(usager);
                form.Show();
            }
            else
            {
                MessageBox.Show("Vos paramètres de connexion  sont invalides veuillez recommencer","Erreur de connexion",MessageBoxButtons.OK,MessageBoxIcon.Error);
                this.txtPassword.Text = "";
                this.txtUser.Text = "";
                this.Refresh();
            }

        }
    }
}
