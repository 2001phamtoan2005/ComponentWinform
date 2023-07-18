using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace ComponentUserControl.DataGridViews
{
    /// <summary>
    /// delegate xử lý đổ dữ liệu
    /// </summary>
    /// <param name="pageSize"></param>
    /// <param name="page"></param>
    public delegate void DelegateDataSource(int pageSize, int page);
    public partial class DataGridViewCustom : UserControl
    {
        #region Declare delegate


        public DelegateDataSource delegateDataSource { get; set; } = null;
        #endregion
        #region Initial properties
        string[] headerTexts = new string[] { "STT" };
        string[] propertyNames = new string[] { "Index" };
        /// <summary>
        /// Mảng gồm danh sách các text muốn hiển thị lên header column
        /// </summary>
        public string[] SetHeaderTexts
        {
            get { return headerTexts; }
            set
            {
                headerTexts = headerTexts.Concat(value).ToArray();
            }
        }
        /// <summary>
        /// Mảng gồm danh sách các tên thuộc tính
        /// </summary>
        public string[] SetPropertyNames
        {
            get { return propertyNames; }
            set
            {
                propertyNames = propertyNames.Concat(value).ToArray();
                dgv.ColumnCount = propertyNames.Length;
            }
        }

        /// <summary>
        /// Tổng sô item trong 1 trang
        /// </summary>
        public int PageSize { get; set; } = 10;
        /// <summary>
        /// Trang hiện tại
        /// </summary>
        public int CurrentPage { get; set; } = 1;

        public int TotalPages { get; set; } = 5;

        #endregion

        public Action<int, int> action1;



        public DataGridViewCustom()
        {
            InitializeComponent();
        }



        private DataTable ConvertListToDataTable<T>(List<T> list)
        {
            DataTable dt = new DataTable();
            DataColumn workCol = dt.Columns.Add("Index", typeof(Int32));
            // create Header for dataTable
            foreach (PropertyInfo prop in list[0].GetType().GetProperties())
            {
                dt.Columns.Add($"{prop.Name}");
            }

            // fill data
            for (int i = 0; i < list.Count; i++)
            {
                DataRow newRow = dt.NewRow();
                // add index for first columns
                newRow["Index"] = i + 1;
                foreach (PropertyInfo prop in list[i].GetType().GetProperties())
                {
                    newRow[prop.Name] = prop.GetValue(list[i], null);
                }
                dt.Rows.Add(newRow);
            }
            return dt;
        }


        public void SetDataSource<T>(List<T> list)
        {
            label1.Text = "tổng số trang "+TotalPages.ToString();
            int minPage = 1;


            if (CurrentPage <= minPage)
            {
                btnBack.Enabled = false;
            }
            else
            {
                btnBack.Enabled = true;
            }
            if (CurrentPage >= TotalPages)
            {
                btnNext.Enabled = false;
            }
            else
            {
                btnNext.Enabled = true;
            }


            dgv.AutoGenerateColumns = false;
            dgv.DataSource = ConvertListToDataTable<T>(list);
            // rename header column name
            for (int i = 0; i < headerTexts.Length; i++)
            {
                dgv.Columns[i].HeaderText = headerTexts[i];
                dgv.Columns[i].DataPropertyName = propertyNames[i];
            }
        }

        /// <summary>
        /// Gán tham chiếu hàm xử lý cập nhật dataSource
        /// </summary>
        /// <param name="delegateDataSource">Hàm tham chiếu</param>
        public void SetDelegateUpdateFilter(DelegateDataSource dlgDataSource)
        {
            if (dlgDataSource != null)
            {
                delegateDataSource = dlgDataSource;
                delegateDataSource.Invoke(PageSize, CurrentPage);
            }
        }

        private void tblLayoutControls_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DataGridViewCustom_Load(object sender, EventArgs e)
        {
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

            if (delegateDataSource != null)
            {
                --CurrentPage;
                delegateDataSource?.Invoke(PageSize, CurrentPage);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {

            if (delegateDataSource != null)
            {
                ++CurrentPage;
                delegateDataSource?.Invoke(PageSize, CurrentPage);
            }
        }
    }
}
