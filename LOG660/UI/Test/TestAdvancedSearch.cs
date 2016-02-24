using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LOG660.UI.Test
{
    public partial class TestAdvancedSearch : Form
    {
        public TestAdvancedSearch()
        {
            InitializeComponent();
        }

        private void btnAdvancedSearch_Click(object sender, EventArgs e)
        {
            openAdvancedSearchPanel();
        }
        private void openAdvancedSearchPanel()
        {
            pnlAdvanced.Controls.Add(new LOG660.UserControlFolder.AdvancedSearchUC());
        }
    }
}
