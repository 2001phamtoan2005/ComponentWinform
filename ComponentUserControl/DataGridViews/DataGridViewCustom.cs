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


    public partial class DataGridViewCustom : UserControl
    {

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
            dgv.DataSource = ConvertListToDataTable<T>(list);
            //for (int i = 0; i < list.Count - 1; i++)
            //{
            //    dgv.Rows[i].Cells[0].Value = i.ToString();
            //}
            //dgv.Refresh();

            //foreach (DataGridViewRow row in dgv.Rows)
            //{
            //    row.Cells["Index"].Value = row.Index + 1;
            //}

        }


    }
}
