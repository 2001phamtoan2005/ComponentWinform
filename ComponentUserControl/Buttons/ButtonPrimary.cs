using ComponentUserControl.Config;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Components.Buttons
{
    public class ButtonPrimary : ButtonCustom
    {
        //Constructor
        public ButtonPrimary()
        {
            this.BackColor = ColorTranslator.FromHtml(UIKit.PrimaryColor);
            this.ForeColor = Color.White;
        }
       
    }
}
