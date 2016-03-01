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
        private Boolean openAdvancedSearch = true;
        public TestAdvancedSearch()
        {
            InitializeComponent();
        }

        private void openAdvancedSearchPanel()
        {
            if (openAdvancedSearch)
            {
                addUC();
                openAdvancedSearch = false;
            }
        }
        private void addUC()
        {
            UserControlFolder.AdvancedSearchUC uc = new UserControlFolder.AdvancedSearchUC();
            uc.fieldEventHandler += new UserControlFolder.AdvancedSearchUC.FieldEventHandler(handleFieldEvent);
            uc.Location = new Point(uc.Location.X, customUCList.Count * uc.Height);
            pnlAdvanced.Size = new Size(pnlAdvanced.Width, pnlAdvanced.Size.Height + uc.Height + 5);

            relocateControls(uc.Height);

            customUCList.Add(uc);
            pnlAdvanced.Controls.Add(uc);
            if(customUCList.Count >= 2)
            {
                customUCList[customUCList.Count - 2].disableButton();
            }
        }

        private void removeUC()
        {
            UserControlFolder.AdvancedSearchUC uc = customUCList[customUCList.Count - 1];
            pnlAdvanced.Size = new Size(pnlAdvanced.Width, pnlAdvanced.Size.Height - uc.Height);

            relocateControls(uc.Height * -1);

            customUCList.Remove(uc);
            pnlAdvanced.Controls.Remove(uc);
            if (customUCList.Count >= 1)
            {
                customUCList[customUCList.Count - 1].enableButton();
            }
        }

        private void relocateControls(int modifier)
        {
            panel1.Location = new Point(panel1.Location.X, panel1.Location.Y + modifier);
            m_btnLouerFilm.Location = new Point(m_btnLouerFilm.Location.X, m_btnLouerFilm.Location.Y + modifier);
        }

        private void btnAdvancedSearch_Click(object sender, EventArgs e)
        {
            openAdvancedSearchPanel();
            this.btnAdvancedSearch.Enabled = false;
        }

        private void handleFieldEvent(object sender, int eventIdentification)
        {
            if (eventIdentification == UserControlFolder.AdvancedSearchUC.ADD_EVENT_IDENTIFIER)
            {
                addUC();
            }
            else if (eventIdentification == UserControlFolder.AdvancedSearchUC.REMOVE_EVENT_IDENTIFIER)
            {
                if (customUCList.Count == 1)
                {
                    this.btnAdvancedSearch.Enabled = true;
                    openAdvancedSearch = true;
                }
                removeUC();
            }
        }
    }
}
