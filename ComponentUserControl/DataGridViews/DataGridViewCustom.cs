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
        public int TotalItem { get; set; } = 0;


        #endregion
        public Action<int, int> action1;

        DataTable dtAll = new();

        public DataGridViewCustom()
        {
            InitializeComponent();
        }


        private DataTable ConvertListToDataTable<T>(List<T> list, int continueIndex)
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
                newRow["Index"] = continueIndex + i + 1;
                foreach (PropertyInfo prop in list[i].GetType().GetProperties())
                {
                    newRow[prop.Name] = prop.GetValue(list[i], null);
                }
                dt.Rows.Add(newRow);
            }
            return dt;
        }


        /// <summary>
        /// Hàm dùng để gán list dữ liệu vào table
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        public void SetDataSource<T>(List<T> list)
        {
            ShowCurrentAndTotalPage();
            ToggleBackAndNextButtons();
            dgv.AutoGenerateColumns = false;
            dtAll.Merge(ConvertListToDataTable(list, dtAll.Rows.Count));
            LoadDataOnCurrentPage();
            // rename header column name
            for (int i = 0; i < headerTexts.Length; i++)
            {
                dgv.Columns[i].HeaderText = headerTexts[i];
                dgv.Columns[i].DataPropertyName = propertyNames[i];
            }
        }

        private void ShowCurrentAndTotalPage()
        {
            
            lblTrangHienTai.Text = $"Trang: {CurrentPage} / {GetTotalPage(TotalItem,PageSize)}";
        }

        public int GetTotalPage(int totalItems,int psize)
        {
            int totalPages = (totalItems / psize);
            int odd = totalItems % psize;
            if (odd > 0)
            {
                totalPages += 1;
            }
            return totalPages;
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

        /// <summary>
        /// Hàm xử lý hiển thị dữ liệu theo pageSize lên dataGridView 
        /// </summary>
        private void LoadDataOnCurrentPage()
        {
            if (CurrentPage > 0)
            {
                //Vị trí của page trước hoặc sau
                int currentPageOffSet = CurrentPage - 1;
                int startOffSet = currentPageOffSet * PageSize;
                int endOffSet = startOffSet + PageSize;
                DataTable currentTable = dtAll.Clone();
                for (int i = startOffSet; i < endOffSet; i++)
                {
                    if (i > TotalItem)
                    {
                        break;
                    }
                    DataRow newRow = currentTable.NewRow();
                    newRow.ItemArray = dtAll.Rows[i].ItemArray;
                    currentTable.Rows.Add(newRow);
                }
                dgv.DataSource = currentTable;
            }
        }


        private void ToggleBackAndNextButtons()
        {
            int minPage = 1;
            if (CurrentPage <= minPage)
            {
                btnBack.Enabled = false;
            }
            else
            {
                btnBack.Enabled = true;
            }
            if (CurrentPage >= GetTotalPage(TotalItem,PageSize))
            {
                btnNext.Enabled = false;
            }
            else
            {
                btnNext.Enabled = true;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

            if (delegateDataSource != null)
            {
                --CurrentPage;
                ToggleBackAndNextButtons();
                ShowCurrentAndTotalPage();
                LoadDataOnCurrentPage();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {

            if (delegateDataSource != null)
            {
                ++CurrentPage;
                ToggleBackAndNextButtons();
                ShowCurrentAndTotalPage();
                int totalFetchedPage = dtAll.Rows.Count / PageSize;
                // Kiểm tra nếu đã có data thì ko cần fetch thêm 
                bool isFetching = CurrentPage > totalFetchedPage;
                if (isFetching)
                {
                    // gọi Hàm để fetch thêm data
                    delegateDataSource?.Invoke(PageSize, CurrentPage);
                }
                else
                {
                    LoadDataOnCurrentPage();
                }
            }
        }
    }
}
