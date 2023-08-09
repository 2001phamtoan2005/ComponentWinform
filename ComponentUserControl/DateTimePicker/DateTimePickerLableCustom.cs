using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace GUI.Components.Textboxs
{
    public partial class DateTimePickerLableCustom : UserControl
    {
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
        public DateTime Value
        {
            get { return dtp.Value; }
            set { dtp.Value = value; }
        }

        [Category(CategoryDisplay)]
        public bool Enable { get; set; } = true;
        #endregion

        public DateTimePickerLableCustom()
        {
            InitializeComponent();
        }
        private void Custom_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                lblError.Text = string.Empty;
                errorProvider.SetIconPadding(dtp, -20);
                dtp.Enabled = Enable;
            }
        }

        // Category
        const string CategoryDisplay = "Custom: WrittenByToan";


        //Overridden methods
        //Events
        #region Event Exposing
        public event EventHandler UCValueChanged
        {
            add
            {
                dtp.ValueChanged += value;
            }
            remove { dtp.ValueChanged -= value; }
        }
        #endregion

        #region Pre-Validation Input
        //private bool isEnableTextChanged = true;
        ///// <summary>
        ///// Sự kiện này sẽ được thực thi đầu tiên => validate cơ bản cho input
        ///// </summary>
        ///// <param name="sender"></param>
        ///// <param name="e"></param>
        //private void Txt_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    // Only allow backspace control (Esc, Enter,...)
        //    if (Char.IsControl(e.KeyChar) && e.KeyChar != ((char)Keys.Back))
        //    {
        //        e.Handled = true;
        //    }
        //}

        //private void dtp_TextChanged(object sender, EventArgs e)
        //{
        //    if (!isEnableTextChanged)
        //    {
        //        return;
        //    }

        //    Error = string.Empty;
        //    TextBox textbox = (TextBox)sender;
        //    // Case 1: Not null when focused
        //    if (NotNull && textbox.Text == string.Empty)
        //    {
        //        Error = NOT_NULL;
        //        return;
        //    }

        //    // case 2: Allow white space 
        //    if (!AllowWhiteSpace && textbox.Text.Any(s => Char.IsWhiteSpace(s)))
        //    {
        //        Error = NO_WHITE_SPACE;
        //        return;
        //    }
        //    // case 3: Not special character 
        //    if (textbox.Text.Any(s => Char.IsControl(s)))
        //    {
        //        Error = SPECIAL_CHARACTER;
        //        return;
        //    }
        //}
        #endregion


    }
}
