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
        public delegate void AddFieldEventHandler(object sender, EventArgs e);

        public event AddFieldEventHandler addField;
        public AdvancedSearchUC()
        {
            InitializeComponent();
        }

        public int getHeight()
        {
            return this.Height;
        }

        private void btnAddField_Click(object sender, EventArgs e)
        {
            if(addField != null)
            {
                addField(this, e);
            }
        }

        public void disableButton()
        {
            btnAddField.Enabled = false;
        }
    }
}
