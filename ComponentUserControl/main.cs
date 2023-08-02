using ComponentUserControl.DataGridViews;
using ComponentUserControl.Services;
using ComponentUserControl.TextBoxs;
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
            //dataGridViewCustom1.SetHeaderTexts = new string[] { "Mã khách hàng", "Tên khách hàng", "Được duyệt", "Email", "SĐT", "Trạng thái hoạt động", "CodeMonet", "Mã Khách Hàng B2B", "Mã Khách Hàng B2C" };
            //dataGridViewCustom1.SetBooleanPropertyNames = new string[] { "TrangThaiHoatDong", "DuocDuyet" };
            //dataGridViewCustom1.SetPropertyNames = new string[] { "MaKhachHang", "TenKhachHang", "DuocDuyet", "Email", "SoDt", "TrangThaiHoatDong", "CodeMonet", "MaKhachHangB2b", "MaKhachHangB2c" };
            //DelegateDataSource delegateCall = test;
            //dataGridViewCustom1.SetDelegateUpdateFilter(delegateCall);
            //dataGridViewCustom1.DGVCellClick += DataGridViewCustom1_DGVCellContentClick;
            //dataGridViewCustom1.DGVRightClickDelete += xoáToolStripMenuItem_Click;
        }

        private void DataGridViewCustom1_DGVCellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgvInside = (DataGridView)sender;
            //TextBoxCustom txt = sender as TextBoxCustom;
        }

        private void inputCustom1_UCKeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (txt.Text != null && txt.Text.Length > 1)
            {
                inputCustom1.SetErrorText = "Có lỗi rồi";

            }
            else
            {
                inputCustom1.SetErrorText = string.Empty;
            }
        }

        //private void xoáToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    DataGridViewRow row = dataGridViewCustom1.GetCurrentRow();
        //    if (row != null)
        //    {

        //    }
        //}

        //private void test(int a,int b)
        //{
        //    Filter filter = new Filter()
        //    {
        //        count = a,
        //        pageNums = b

        //    };

        //    list = db.GetSanPham<KhachHangDTO>(filter);
        //    dataGridViewCustom1.TotalItem = db.GetSoLuongSanPham();
        //    dataGridViewCustom1.SetDataSource(list);
        //}
    }
}
