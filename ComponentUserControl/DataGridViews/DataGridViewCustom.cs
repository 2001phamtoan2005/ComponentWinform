using ComponentUserControl.Config;
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
using Button = System.Windows.Forms.Button;

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
        string[] headerTexts = new string[] { };
        string[] propertyNames = new string[] { };
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
        public int PageSize { get; set; } = 50;
        /// <summary>
        /// Trang hiện tại
        /// </summary>
        public int CurrentPage { get; set; } = 1;
        public int TotalItem { get; set; } = 0;


        #endregion
        public Action<int, int> action1;

        Dictionary<int, DataTable> storage = new Dictionary<int, DataTable>();

        public DataGridViewCustom()
        {
            InitializeComponent();
            dgv.AllowUserToResizeRows = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;
            dgv.RowHeadersVisible = false;
            cbbSelectPageSize.DataSource = new[] { 50, 100, 200, 500, 1000 };
        }


        private DataTable ConvertListToDataTable<T>(List<T> list)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Index", typeof(Int32));
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
                int startIndex = (CurrentPage - 1) * PageSize + i + 1;
                newRow["Index"] = startIndex;
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
            GenerateButtonsPage();
            dgv.AutoGenerateColumns = false;
            //dtAll.Merge(ConvertListToDataTable(list));
            storage.Add(CurrentPage, ConvertListToDataTable(list));
            LoadDataOnCurrentPage();
            // rename header column name
            for (int i = 0; i < headerTexts.Length; i++)
            {
                dgv.Columns[i].HeaderText = headerTexts[i];
                dgv.Columns[i].DataPropertyName = propertyNames[i];
            }

            // re-render pagination zone when fetch more data
        }

        private void ShowCurrentAndTotalPage()
        {

            lblTrangHienTai.Text = $"Trang: {CurrentPage} / {GetTotalPage(TotalItem, PageSize)}";
        }

        public int GetTotalPage(int totalItems, int psize)
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
        /// <summary>
        /// Hàm sinh các button thể hiện số trang hiện có
        /// </summary>
        //private void GenerateButtonsPage()
        //{
        //    int totalPage = GetTotalPage(TotalItem, PageSize);
        //    // max range có thể hiển thị là 3
        //    int rangePage = Math.Min(3, totalPage / 2);
        //    flowLayoutPagination.Controls.Clear();
        //    if (totalPage > 0)
        //    {
        //        int index = CurrentPage - rangePage;
        //        if (CurrentPage + rangePage >= totalPage)
        //        {
        //            index -= (CurrentPage + rangePage) - totalPage;
        //        }

        //        while (index <= CurrentPage + rangePage)
        //        {
        //            if (index > totalPage)
        //            {
        //                return;
        //            }

        //            if (index >= 1)
        //            {
        //                Button btn = new Button();
        //                Cursor = Cursors.Hand;
        //                btn.Text = index.ToString();
        //                btn.BackColor = Color.White;
        //                btn.ForeColor = Color.Black;
        //                btn.FlatAppearance.BorderSize = 0;
        //                btn.FlatStyle = FlatStyle.Flat;
        //                btn.Anchor = AnchorStyles.Top;
        //                btn.Padding = new Padding(0);
        //                btn.Width = 40;
        //                btn.Left = 40 * index + btn.Margin.Horizontal;
        //                btn.Height = flowLayoutPagination.Height;
        //                btn.Click += Btn_Click;
        //                //btn.FlatAppearance.MouseOverBackColor = ColorTranslator.FromHtml(UIKit.PrimaryColor_90);
        //                if (index == CurrentPage)
        //                {
        //                    btn.ForeColor = Color.WhiteSmoke;
        //                    btn.BackColor = ColorTranslator.FromHtml(UIKit.PrimaryColor);
        //                    btn.FlatAppearance.BorderColor = ColorTranslator.FromHtml(UIKit.PrimaryColor);
        //                }
        //                flowLayoutPagination.Controls.Add(btn);
        //            }
        //            else
        //            {
        //                rangePage++;
        //            }
        //            index++;
        //        }
        //    }
        //}


        private void CreateButonWithIndex(int index)
        {
            Button btn = new Button();
            Cursor = Cursors.Hand;
            btn.Text = index.ToString();
            btn.BackColor = Color.White;
            btn.ForeColor = ColorTranslator.FromHtml(UIKit.SecondaryColor);
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatStyle = FlatStyle.Flat;
            btn.Anchor = AnchorStyles.Top;
            btn.Padding = new Padding(0);
            btn.Font = new Font(this.Font.FontFamily, 8.25F, FontStyle.Bold);
            btn.Width = 40;
            btn.Left = 40 * index + btn.Margin.Horizontal;
            btn.Height = flowLayoutPagination.Height;
            btn.Click += Btn_Click;
            //btn.FlatAppearance.MouseOverBackColor = ColorTranslator.FromHtml(UIKit.PrimaryColor_90);
            if (index == CurrentPage)
            {
                btn.ForeColor = Color.WhiteSmoke;
                btn.BackColor = ColorTranslator.FromHtml(UIKit.PrimaryColor);
                btn.FlatAppearance.BorderColor = ColorTranslator.FromHtml(UIKit.PrimaryColor);
            }
            flowLayoutPagination.Controls.Add(btn);
        }

        private void GenerateButtonsPage()
        {
            int totalPage = GetTotalPage(TotalItem, PageSize);
            // max range có thể hiển thị là 3
            int rangePage = 3;
            int maxRangePage = (rangePage * 2) + 1;
            flowLayoutPagination.Controls.Clear();
            // Case A: TotalPage nhỏ hơn max range page
            // example: rangePage = 3 =>
            //          maxRangePage = (rangePage x 2) + 1 (page hiển thị ) = 7
            //          totalPage <= maxRangePage
            //          => fill 1-7 buttons
            if (totalPage <= maxRangePage)
            {
                for (int i = 1; i <= totalPage; i++)
                {
                    CreateButonWithIndex(i);
                }
                return;
            }

            // Case B: TotalPage lớn hơn max range page
            // Case 2: Current page rơi vào rangePage đầu 
            // example: rangePage = 3 & currentPage <=3
            if (CurrentPage <= rangePage)
            {
                for (int i = 1; i <= maxRangePage; i++)
                {
                    CreateButonWithIndex(i);
                }
                return;
            }


            // Case 3: Current page rơi vào rangePage cuối 
            // example: rangePage = 3 & currentPage >= totalPage - rangePage 

            if (CurrentPage >= totalPage - rangePage)
            {
                for (int i = (totalPage - maxRangePage) + 1; i <= totalPage; i++)
                {
                    CreateButonWithIndex(i);
                }
                return;
            }
            // Case 4: Current page rơi vào vị trí sau [rangePage+1,totalPage - rangePage - 1]
            // => fill từ [currentPage - 3, currentPage +3]

            int offsetFooter = totalPage - rangePage;
            if (CurrentPage > rangePage && CurrentPage < offsetFooter)
            {
                for (int i = CurrentPage - rangePage; i <= CurrentPage + rangePage; i++)
                {
                    CreateButonWithIndex(i);
                }
                return;
            }

        }




        /// <summary>
        /// Hàm xử lý sự kiện onClick cho các button tự sinh
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int clickedIndex = int.Parse(button.Text);
            CurrentPage = clickedIndex;
            LoadDataOnCurrentPage();
        }


        /// <summary>
        /// Hàm xử lý hiển thị dữ liệu theo Range lên dataGridView 
        /// </summary>
        private void LoadDataOnCurrentPage()
        {
            // Nếu chưa tồn tại thì thực hiện fetch thêm data
            if (!storage.ContainsKey(CurrentPage))
            {
                delegateDataSource?.Invoke(PageSize, CurrentPage);
            }
            else
            {
                dgv.DataSource = storage[CurrentPage];
                ToggleBackAndNextButtons();
                ShowCurrentAndTotalPage();
                GenerateButtonsPage();
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
            if (CurrentPage >= GetTotalPage(TotalItem, PageSize))
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
                LoadDataOnCurrentPage();

            }
        }


        private void btnNext_Click(object sender, EventArgs e)
        {

            if (delegateDataSource != null)
            {
                ++CurrentPage;
                LoadDataOnCurrentPage();
            }
        }

        private void cbbSelectPageSize_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbbSelectPageSize.SelectedValue != null)
            {
                storage.Clear();
                PageSize = int.Parse(cbbSelectPageSize.SelectedValue.ToString());
                CurrentPage = 1;
                LoadDataOnCurrentPage();
            }
        }
    }
}
