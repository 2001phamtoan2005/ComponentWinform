using ComponentUserControl.DataGridViews;
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

        private void main_Load(object sender, EventArgs e)
        {
            dataGridViewCustom1.SetHeaderTexts = new string[] { "Volvo", "BMW" };
            dataGridViewCustom1.SetPropertyNames = new string[] { "MaSanPham", "TenSanPham" };
            dataGridViewCustom1.TotalItem = db.GetSoLuongSanPham();
            dataGridViewCustom1.PageSize = 100;
            DelegateDataSource delegateCall = test;
            dataGridViewCustom1.SetDelegateUpdateFilter(delegateCall);
        }


        private void test(int a,int b)
        {
            Filter filter = new Filter()
            {
                count = a,
                pageNums = b
            };
            list = db.GetSanPham<ChiTietDonHangDTO>(filter);
            dataGridViewCustom1.SetDataSource(list);
        }

    }
}
