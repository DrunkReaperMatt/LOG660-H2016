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
        private event addFieldEvent;
        public AdvancedSearchUC()
        {
            InitializeComponent();
        }
        public int Height
        {
            get { return this.Height; }
        }

    }
}
