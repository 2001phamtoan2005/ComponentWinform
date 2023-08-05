using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComponentUserControl.TextBoxs
{
    public partial class InputCustom
    {
        #region Enum
        public enum eValidationType
        {
            OnlyLetter,
            NumberAndLetter,
        }

        #endregion
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
        public override string Text
        {
            get { return txt.Text; }
            set { txt.Text = value; }
        }

        //[Category(CategoryDisplay)]
        //public override string PlaceHolder
        //{
        //    get { return txt.Text; }
        //    set { txt.Text = value; }
        //}

        /// <summary>
        /// Thuộc tính dùng để gán và lấy giá trị lỗi của quá trình validation
        /// </summary>
        [Category(CategoryDisplay)]
        public string Error
        {
            get
            {
                if (!DesignMode)
                {
                    // Allow null
                    if (!NotNull)
                    {
                        return string.Empty;
                    }

                    if (txt.Text == null || txt.Text == string.Empty)
                    {
                        lblError.Text = NOT_NULL;
                        errorProvider.SetError(txt, NOT_NULL);
                        return NOT_NULL;
                    }
                    return lblError.Text;
                }
                return string.Empty;
            }
            set
            {
                lblError.Text = value;
                txt.Focus();
                errorProvider.SetError(txt, value);
            }
        }

        //[Category(CategoryDisplay)]
        //public Image ImageForLabel
        //{
        //    get { return label.Image; }
        //    set { label.Image = value; }
        //}

        [Category(CategoryDisplay)]
        public bool NotNull { get; set; } = true;



        [Category(CategoryDisplay)]
        public eValidationType @ValidationType { get; set; } = eValidationType.NumberAndLetter;



        [Category(CategoryDisplay)]
        public bool AllowWhiteSpace { get; set; } = true;
        #endregion

        #region Make Color


        [Category("RJ Code Advance")]
        public bool Multiline
        {
            get { return txt.Multiline; }
            set { txt.Multiline = value; }
        }

        [Category("RJ Code Advance")]
        public override Color BackColor
        {
            get { return base.BackColor; }
            set
            {
                base.BackColor = value;
                txt.BackColor = value;
            }
        }

        [Category("RJ Code Advance")]
        public override Color ForeColor
        {
            get { return base.ForeColor; }
            set
            {
                base.ForeColor = value;
                txt.ForeColor = value;
            }
        }
        #endregion

    }
}
