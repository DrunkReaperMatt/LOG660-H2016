using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOG660.UserControlFolder
{
    public partial class AdvancedSearchUC : UserControl
    {
        public const int ADD_EVENT_IDENTIFIER = 1;
        public const int REMOVE_EVENT_IDENTIFIER = 2;
        public const int CHAINE_IDENTIFIER = 0;
        public const int ANNEE_IDENTIFIER = 1;
        public const int PAYS_IDENTIFIER = 2;
        public const int LANGUE_IDENTIFIER = 3;
        public const int GENRE_IDENTIFIER = 4;
        public const int REALISATEUR_IDENTIFIER = 5;
        public const int ACTEUR_IDENTIFIER = 6;
        public delegate void FieldEventHandler(object sender, int eventArgIdentifier);
        public event FieldEventHandler fieldEventHandler;

        public AdvancedSearchUC()
        {
            InitializeComponent();
            Dictionary<string, int>  item = new Dictionary<string, int>();
            item.Add("Chaine", CHAINE_IDENTIFIER);
            item.Add("Annee", ANNEE_IDENTIFIER);
            item.Add("Pays", PAYS_IDENTIFIER);
            item.Add("Langue", LANGUE_IDENTIFIER);
            item.Add("Genre", GENRE_IDENTIFIER);
            item.Add("Realisateur", REALISATEUR_IDENTIFIER);
            item.Add("Acteur", ACTEUR_IDENTIFIER);
            cboField.DataSource = new BindingSource(item, null);
            cboField.DisplayMember = "Key";
            cboField.ValueMember = "Value";
            cboField.SelectedIndex = 0;
        }

        public int getValue()
        {
            return ((KeyValuePair<string, int>)cboField.SelectedItem).Value;
        }

        public void disableButton()
        {
            btnAddField.Enabled = false;
            btnRemoveField.Enabled = false;
        }

        public void enableButton()
        {
            btnAddField.Enabled = true;
            btnRemoveField.Enabled = true;
        }

        private void btnAddField_Click(object sender, EventArgs e)
        {
            if (fieldEventHandler != null)
            {
                fieldEventHandler(this, ADD_EVENT_IDENTIFIER);
            }
        }

        private void btnRemoveField_Click(object sender, EventArgs e)
        {
            if (fieldEventHandler != null)
            {
                fieldEventHandler(this, REMOVE_EVENT_IDENTIFIER);
            }
        }
    }
}
