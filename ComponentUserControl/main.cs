using ComponentUserControl.Services;
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
    public partial class main : Form
    {
        BackEnd db = new BackEnd();
        List<ChiTietDonHangDTO> list = new List<ChiTietDonHangDTO>();
        public main()
        {
            InitializeComponent();
            list = db.GetCTDHTest<ChiTietDonHangDTO>();
            dataGridViewCustom1.SetDataSource(list);
            //dataGridView1.DataSource = list;
        }


        private void btnButtons_Click(object sender, EventArgs e)
        {
            ButtonDesignForm form = new ButtonDesignForm();
            form.ShowDialog();
        }

        private void btnTabs_Click(object sender, EventArgs e)
        {
            TabUI form = new TabUI();
            form.ShowDialog();
        }
    }
}
