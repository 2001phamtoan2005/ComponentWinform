using Components.Buttons;
using ComponentUserControl.Config;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComponentUserControl.Buttons
{
    public class ButtonSecondary:ButtonCustom
    {
        public ButtonSecondary()
        {
            this.BackColor = ColorTranslator.FromHtml(UIKit.SecondaryColor);
            this.ForeColor = Color.White;
        }
    }
}
