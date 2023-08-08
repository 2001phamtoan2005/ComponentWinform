using ComponentUserControl.TextBoxs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComponentUserControl
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void InputCustom1_UCTextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void buttonPrimary1_Click(object sender, EventArgs e)
        {
            string Errors = string.Empty;
            foreach(Control control in tableLayoutPanel1.Controls)
            {
                if (control is InputCustom) {
                    InputCustom inputCustom = (InputCustom)control;
                    if (inputCustom.Error != string.Empty)
                    {
                        Errors += $"Name của input: {inputCustom.Name} = Error: {inputCustom.Text} \n";
                    }
                }
            }

            MessageBox.Show($"{Errors}");

        }
    }
}
