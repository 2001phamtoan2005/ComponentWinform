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
        List<KhachHangDTO> list = new List<KhachHangDTO>();
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
            dataGridViewCustom1.SetHeaderTexts = new string[] { "Mã khách hàng", "Tên khách hàng" };
            dataGridViewCustom1.SetPropertyNames = new string[] { "MaKhachHang", "TenKhachHang" };
            dataGridViewCustom1.TotalItem = db.GetSoLuongSanPham();
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
            list = db.GetSanPham<KhachHangDTO>(filter);
            dataGridViewCustom1.SetDataSource(list);
        }

    }
}
