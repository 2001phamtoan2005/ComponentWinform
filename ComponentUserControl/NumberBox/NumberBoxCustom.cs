using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ComponentUserControl.TextBoxs.InputCustom;
using static System.Net.Mime.MediaTypeNames;

namespace ComponentUserControl.NumberBox
{
    public partial class NumberBoxCustom : UserControl
    {
        // Category
        const string CategoryDisplay = "Custom: WrittenByToan";
        public NumberBoxCustom()
        {
            InitializeComponent();
            lblhHelper.Text = string.Empty;
            errorProvider.SetIconPadding(numberBox, -20);
            numberBox.Controls.RemoveAt(0);
            lblhHelper.Text = $"Giá trị trong khoảng [ {numberBox.Minimum},{numberBox.Maximum} ]";
        }
        #region Custom Field
        /// <summary>
        /// Thuộc tính dùng để gán và truy xuất giá trị của label
        /// </summary>
        [Category(CategoryDisplay)]
        public string Label
        {
            get { return label.Text; }
            set
            {
                label.Text = value;
                this.Invalidate();
            }
        }

        /// <summary>
        /// Thuộc tính dùng để gán và lấy giá trị của input 
        /// </summary>
        [Category(CategoryDisplay)]
        public decimal Value
        {
            get { return numberBox.Value; }
            set { numberBox.Value = value; }
        }

        [Category(CategoryDisplay)]
        public decimal MinValue
        {
            get { return numberBox.Minimum; }
            set
            {
                numberBox.Minimum = value;
            }
        }

        [Category(CategoryDisplay)]
        public decimal MaxValue
        {
            get { return numberBox.Maximum; }
            set
            {
                numberBox.Maximum = value;
            }
        }

        #endregion

        private void numberBox_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = sender as NumericUpDown;
            if(numericUpDown.Value < numberBox.Minimum)
            {
                numericUpDown.Value = numberBox.Minimum;
                MessageBox.Show($"Giá trị nhập tối thiểu phải là: {numberBox.Minimum}");
                return;
            }

            if (numericUpDown.Value > numberBox.Maximum)
            {
                numericUpDown.Value = numberBox.Maximum;
                MessageBox.Show($"Giá trị nhập tối đa phải là: {numberBox.Maximum}");
                return;
            }
        }
    }
}
