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
        public delegate void FieldEventHandler(object sender, int eventArgIdentifier);
        public event FieldEventHandler fieldEventHandler;

        public AdvancedSearchUC()
        {
            InitializeComponent();
            cboField.SelectedIndex = 0;
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
