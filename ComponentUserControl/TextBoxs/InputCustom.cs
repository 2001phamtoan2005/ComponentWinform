using ComponentUserControl.Config;
using Newtonsoft.Json.Linq;
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
        // Message Error
        const string NOT_NULL = "Trường này là bắt buộc!";
        const string SPECIAL_CHARACTER = "Kí tự vừa nhập không hợp lệ";
        const string ONLY_LETTER_AND_DIGIT = "Phải là ký tự và số";
        const string ONLY_DIGIT = "Phải là ký tự!";
        const string NO_WHITE_SPACE = "Phải không khoảng trắng!";
        private string MAX_LENGHT_ERROR()
        {
            return $"Tổi đa chỉ dc phép {MaxLenght} kí tự!";
        }

        private string MIN_LENGHT_ERROR()
        {
            return $"Tổi thiểu phải đủ {MinLenght} kí tự!";
        }
        // Category
        const string CategoryDisplay = "Custom: WrittenByToan";


        //Constructor
        public InputCustom()
        {
            InitializeComponent();
            // Init controls
            lblError.Text = string.Empty;
            errorProvider.SetIconPadding(txt, -20);
        }


        //Overridden methods
        //Events
        #region Event Exposing
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
        #endregion

        #region Pre-Validation Input
        private bool isEnableTextChanged = true;
        /// <summary>
        /// Sự kiện này sẽ được thực thi đầu tiên => validate cơ bản cho input
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Only allow backspace control (Esc, Enter,...)
            if (Char.IsControl(e.KeyChar) && e.KeyChar != ((char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txt_TextChanged(object sender, EventArgs e)
        {
            if (!isEnableTextChanged)
            {
                return;
            }

            Error = string.Empty;
            TextBox textbox = (TextBox)sender;
            // Case 1: Not null when focused
            if (NotNull && textbox.Text == string.Empty)
            {
                Error = NOT_NULL;
                return;
            }

            // case 2: Allow white space 
            if (!AllowWhiteSpace && textbox.Text.Any(s => Char.IsWhiteSpace(s)))
            {
                Error = NO_WHITE_SPACE;
                return;
            }
            // case 3: Not special character 
            if (textbox.Text.Any(s => Char.IsControl(s)))
            {
                Error = SPECIAL_CHARACTER;
                return;
            }
            if (textbox.Text != string.Empty && textbox.Text.Length > MaxLenght)
            {
                Error = MAX_LENGHT_ERROR();
                return;
            }

            // case 4: MaxLenght character


            switch (ValidationType)
            {
                case eValidationType.OnlyLetter:
                    {
                        OnlyLetterHandler(textbox.Text);
                    }; break;
                case eValidationType.NumberAndLetter:
                    {
                        NumberAndLetterHandler(textbox.Text);
                    }; break;
                default:
                    {

                    }; break;
            }
        }


        private void NumberAndLetterHandler(string text)
        {
            // Nếu toàn bộ chuỗi là kí tự ,số hoặc khoảng trắng => ok
            if (!text.All(s => Char.IsLetterOrDigit(s) || Char.IsWhiteSpace(s)))
            {
                Error = ONLY_LETTER_AND_DIGIT;
            }
        }

        private void OnlyLetterHandler(string text)
        {
            // Nếu toàn bộ chuỗi là kí tự hoặc khoảng trắng => ok
            if (!text.All(s => Char.IsLetter(s) || Char.IsWhiteSpace(s)))
            {
                Error = ONLY_DIGIT;
            }

        }
        #endregion

    }
}
