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
using Components.Buttons;

namespace ComponentUserControl.Buttons
{
    public class ButtonOutline : ButtonCustom
    {
        //Constructor
        public ButtonOutline()
        {
            base.BorderRadius = UIKit.BorderRadious;
            base.BorderSize = 2;
            this.BackColor = Color.White;
            this.ForeColor =  ColorTranslator.FromHtml(UIKit.PrimaryColor);
            this.BorderColor = ColorTranslator.FromHtml(UIKit.PrimaryColor);
        }
    }
}
