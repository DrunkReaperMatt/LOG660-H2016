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
        private List<UserControlFolder.AdvancedSearchUC> customUCList = new List<UserControlFolder.AdvancedSearchUC>();
        private Boolean openAdvancedSearch = false;
        public TestAdvancedSearch()
        {
            InitializeComponent();
        }

        private void handleNewUC(object sender, EventArgs e)
        {
            ((UserControlFolder.AdvancedSearchUC)sender).disableButton();
            addNewUC();
        }

        private void btnAdvancedSearch_Click(object sender, EventArgs e)
        {
            openAdvancedSearchPanel();
        }
        private void openAdvancedSearchPanel()
        {
            if(!openAdvancedSearch)
            {
                addNewUC();
                openAdvancedSearch = false;
            }
        }
        private void addNewUC()
        {
            UserControlFolder.AdvancedSearchUC uc = new UserControlFolder.AdvancedSearchUC();
            uc.addField += new UserControlFolder.AdvancedSearchUC.AddFieldEventHandler(handleNewUC);
            uc.Location = new Point(uc.Location.X, (customUCList.Count * uc.Height) + 5);
            customUCList.Add(uc);
            pnlAdvanced.Controls.Add(uc);
        }
    }
}
