using ComponentUserControl.Config;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComponentUserControl.TextBoxs
{
    public partial class InputCustom : UserControl
    {
        // Category
        const string CategorySetValue = "Custom:Set value";
        //Fields
        private Color borderColor;
        private int borderSize = 2;
        private bool underlinedStyle = false;
        private Color borderFocusColor;
        private bool isFocused = false;

        //Constructor
        public InputCustom()
        {
            InitializeComponent();
            borderFocusColor = ColorTranslator.FromHtml(UIKit.PrimaryColor);
            // Init controls
            lblError.Text = string.Empty;
        }


        [Category(CategorySetValue)]
        public string SetLabel
        {
            get { return label.Text; }
            set
            {
                label.Text = value;
                this.Invalidate();
            }
        }


        [Category(CategorySetValue)]
        public string SetText
        {
            get { return txt.Text; }
            set { txt.Text = value; }
        }

        /// <summary>
        /// Handle Validation : Error
        /// </summary>
        [Category(CategorySetValue)]
        public string SetErrorText
        {
            get { return lblError.Text; }
            set
            {
                lblError.Text = value;
                // Error
                if (isFocused && value != null && value != string.Empty)
                {
                    label.ForeColor = Color.Firebrick;
                }
                // Pass
                else
                {
                    label.ForeColor = ColorTranslator.FromHtml(UIKit.SecondaryColor);
                }
                this.Invalidate();
            }
        }

        [Category(CategorySetValue)]
        public Image SetImageForLabel
        {
            get { return label.Image; }
            set { label.Image = value; }
        }




        //Properties
        [Category("RJ Code Advance")]
        public Color BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value;
                this.Invalidate();
            }
        }
        [Category("RJ Code Advance")]
        public int BorderSize
        {
            get { return borderSize; }
            set
            {
                borderSize = value;
                this.Invalidate();
            }
        }

        [Category("RJ Code Advance")]
        public bool UnderlinedStyle
        {
            get { return underlinedStyle; }
            set
            {
                underlinedStyle = value;
            }
        }


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


        [Category("RJ Code Advance")]
        public Color BorderFocusColor
        {
            get { return borderFocusColor; }
            set { borderFocusColor = value; }
        }

        //Overridden methods
        //Events

        public event EventHandler UCTextChanged
        {
            add
            {
                txt.TextChanged += value;
            }
            remove { txt.TextChanged -= value; }
        }

        public event KeyPressEventHandler UCKeyPress
        {
            add
            {
                txt.KeyPress += value;
            }
            remove { txt.KeyPress -= value; }
        }
    }
}
