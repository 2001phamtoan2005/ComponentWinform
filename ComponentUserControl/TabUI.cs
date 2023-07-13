using ComponentUserControl.Config;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComponentUserControl
{
    public partial class TabUI : Form
    {
        public TabUI()
        {
            InitializeComponent();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TabPage currentTab = tabControl1.SelectedTab;
            currentTab.BackColor = ColorTranslator.FromHtml(UIKit.PrimaryColor);
            currentTab.ForeColor = Color.White;
        }
    }
}
