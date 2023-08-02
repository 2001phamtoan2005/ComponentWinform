using ComponentUserControl.Config;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
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
        #region Constant
        public class ColumnName
        {
            public const string Index = "Index";
            public const string Delete = "btnDelete";
        }
        #endregion
        #region Declare delegate
        public DelegateDataSource delegateDataSource { get; set; } = null;
        #endregion
        #region Initial properties
        string[] headerTexts = new string[] { };
        string[] propertyNames = new string[] { };
        string[] booleanPropertyNames = new string[] { };
        /// <summary>
        /// Mảng gồm danh sách các tên thuộc tính mang giá trị boolean
        /// </summary>
        public string[] SetBooleanPropertyNames
        {
            get { return booleanPropertyNames; }
            set
            {
                booleanPropertyNames = booleanPropertyNames.Concat(value).ToArray();
            }
        }

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

        public DataGridViewAutoSizeColumnsMode AutoSizeColumnMode
        {
            set
            {
                dgv.AutoSizeColumnsMode = value;
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

        /// <summary>
        /// số button bên trái và
        /// </summary>
        public int rangePage { get; set; } = 2;



        #endregion

        /// <summary>
        /// Biến local lưu trữ các dataTable theo current page
        /// </summary>
        Dictionary<int, DataTable> storage = new Dictionary<int, DataTable>();
        public DataGridViewCustom()
        {
            InitializeComponent();
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;
            cbbSelectPageSize.DataSource = new[] { 10, 50, 100, 200, 500, 1000 };
        }


        /// <summary>
        /// Chuyển dữ liệu từ List thành DataTable
        /// </summary>
        /// <typeparam name="T">Generic Type</typeparam>
        /// <param name="list"></param>
        /// <returns>a DataTable object</returns>
        private DataTable ConvertListToDataTable<T>(List<T> list)
        {
            DataTable dt = new DataTable();
            // add index column, thêm vào đầu dataTable
            //dt.Columns.Add(ColumnName.Index, typeof(Int32));

            if (list != null && list.Count > 0)
            {
                // fill Header for dataTable
                foreach (PropertyInfo prop in list[0].GetType().GetProperties())
                {
                    dt.Columns.Add($"{prop.Name}");
                }
                // fill data
                for (int i = 0; i < list.Count; i++)
                {
                    DataRow newRow = dt.NewRow();
                    // add index for first columns
                    //int startIndex = (CurrentPage - 1) * PageSize + i + 1;
                    //newRow[ColumnName.Index] = startIndex;
                    foreach (PropertyInfo prop in list[i].GetType().GetProperties())
                    {
                        newRow[prop.Name] = prop.GetValue(list[i], null);
                    }
                    dt.Rows.Add(newRow);
                }
            }
            return dt;
        }


        public DataGridViewRow GetCurrentRow()
        {
            DataGridViewRow currentRow = dgv.CurrentRow;
            return currentRow;
        }

        /// <summary>
        /// Hàm xử lý việc hiển thị lại dữ liệu trên dataGridView, 
        /// </summary>
        private void RenderDataGridView()
        {
            if (dgv.Rows.Count > 0)
            {
                // Rename header column name via 
                for (int i = 0; i < headerTexts.Length; i++)
                {
                    dgv.Columns[i].HeaderText = headerTexts[i];
                    dgv.Columns[i].DataPropertyName = propertyNames[i];
                    dgv.Columns[i].Frozen = false;
                }
                foreach (DataGridViewRow row in dgv.Rows)
                    row.HeaderCell.Value = (row.Index + 1).ToString();


                //// Add more button Delete here
                //if (dgv.Columns[ColumnName.Delete] == null)
                //{
                //    var colDelete = new DataGridViewButtonColumn
                //    {
                //        Text = "Xoá",
                //        UseColumnTextForButtonValue = true,
                //        Name = ColumnName.Delete,
                //        HeaderText = "Delete",
                //    };
                //    colDelete.FlatStyle = FlatStyle.Flat;
                //    colDelete.DefaultCellStyle.BackColor = Color.Red;
                //    dgv.Columns.Add(colDelete);
                //    colDelete.Frozen = false;
                //}

                //  Case 1: Value is Boolean
                //  loop qua mảng danh sách properties name mà có giá trị bool cho trước
                for (int i = 0; i < booleanPropertyNames.Length; i++)
                {
                    // loop qua số lượng item hiển thị hiện tại trên dgv
                    foreach (DataGridViewRow row in dgv.Rows)
                    {
                        DataGridViewCheckBoxCell checkbox = new DataGridViewCheckBoxCell();
                        checkbox.FlatStyle = FlatStyle.Standard;
                        checkbox.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        // Tìm index của tên thuộc tính trong mảng PropertyNames 
                        // để đảm bảo thuộc tính này có tồn tại
                        int booleanPropertyIndex = Array.IndexOf(propertyNames, booleanPropertyNames[i]);
                        if (booleanPropertyIndex != -1)
                        {
                            try
                            {
                                // Check value is boolean ?
                                bool parsionResult;
                                if (Boolean.TryParse(row.Cells[booleanPropertyIndex].Value.ToString(), out parsionResult))
                                {
                                    // Parsing success=> value kiểu boolean
                                    string a = row.Cells[booleanPropertyIndex].Value.ToString();
                                    int indexCurrent = row.Index;
                                    checkbox.Value = parsionResult;
                                    row.Cells[booleanPropertyIndex] = checkbox;
                                }
                                else
                                {
                                    // Nếu kết quả parsing fail => value ko hợp lệ => không làm gì.
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Có lỗi xảy ra ở" + ex.Message.ToString());
                                return;
                            }
                        }
                    }
                }
            }
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
            // Current chưa được fetch data
            if (!storage.ContainsKey(CurrentPage))
            {
                storage.Add(CurrentPage, ConvertListToDataTable(list));
            }

            LoadDataOnCurrentPage();

        }

        /// <summary>
        /// Làm mới dữ liệu tại trang chỉ định
        /// </summary>
        /// <param name="currentPage">Trang hiện tại</param>
        public void RefreshDataSource<T>(List<T> newList, int currentPage)
        {
            // update data
            if (storage.ContainsKey(currentPage))
            {
                storage[CurrentPage] = ConvertListToDataTable(newList);
            }
            // do nothing
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
        /// Hàm xử lý nhận tham chiếu hàm xử lý fetch dữ liệu
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

        #region Event Handler Exposing
        public event DataGridViewCellEventHandler DGVCellClick
        {
            add
            {
                dgv.CellClick += value;
            }
            remove { dgv.CellClick -= value; }
        }

        public event EventHandler DGVDoubleClick
        {
            add
            {
                dgv.DoubleClick += value;
            }
            remove { dgv.DoubleClick -= value; }
        }

        public event EventHandler DGVRightClickDelete
        {
            add
            {
                xoáToolStripMenuItem.Click += value;
            }
            remove { xoáToolStripMenuItem.Click -= value; }
        }

        #endregion

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

            if (!storage.ContainsKey(CurrentPage))
            {
                // Nếu chưa tồn tại thì thực hiện fetch thêm data
                delegateDataSource?.Invoke(PageSize, CurrentPage);
            }
            else
            {
                // otherwise: hiển thị lại dữ liệu của page đã fetch trước đó
                dgv.DataSource = storage[CurrentPage];
                ToggleBackAndNextButtons();
                ShowCurrentAndTotalPage();
                GenerateButtonsPage();
            }
            RenderDataGridView();
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

        /// <summary>
        /// Hàm xử lý sự kiện khi người dùng click chuột phải vào dgv
        /// => mở menu action cho row đó, cần implement sự kiện click on Menu action item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                DataGridView dgvInside = (DataGridView)sender;
                int currentMouseOverRow = dgv.HitTest(e.X, e.Y).RowIndex;
                dgv.Rows[currentMouseOverRow].Selected = true;
                contextMenuStrip.Show(dgv, new Point(e.X, e.Y));
            }
        }


    }
}
