using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComponentUserControl.Config
{
    public class UIKit
    {
        // 100% #FF6B00
        public const string PrimaryColor = "#FF6B00";
        // 90% #ff6b00e6
        public const string PrimaryColor_90 = "#ff6b00e6";
        // 80% #ff6b00cc
        public const string PrimaryColor_80 = "#ff6b00cc";
        // 70% #ff6b00b3
        public const string PrimaryColor_70 = "#ff6b00b3";
        // 60% #ff6b0099
        public const string PrimaryColor_60 = "#ff6b0099";
        // 50% #ff6b0080
        public const string PrimaryColor_50 = "#ff6b0080";
        // 40% #ff6b0066
        public const string PrimaryColor_40 = "#ff6b0066";
        // 30% #ff6b004d
        public const string PrimaryColor_30 = "#ff6b004d";
        // 20% #ff6b0033
        public const string PrimaryColor_20 = "#ff6b0033";
        // 10% #ff6b001a
        public const string PrimaryColor_10 = "#ff6b001a";


        public const string SecondaryColor = "#636569";
        public const string SecondaryColor_90 = "#636569e6";
        public const string SecondaryColor_80 = "#636569cc";
        public const string SecondaryColor_70 = "#636569b3";
        public const string SecondaryColor_60 = "#63656999";
        public const string SecondaryColor_50 = "#63656980";
        public const string SecondaryColor_40 = "#63656966";
        public const string SecondaryColor_30 = "#6365694d";
        public const string SecondaryColor_20 = "#63656933";
        public const string SecondaryColor_10 = "#6365691a";


        //public const string SecondaryColor = "#949699";
        //public const string SecondaryColor = "#c8c9cb";
        public const string DisableColor = "#c8c9cb";

        public static Font PrimaryFont = new Font(new FontFamily("Roboto"), 9, FontStyle.Bold);
        public static int VerticalSpacing = 8;
        public static int HorizontalSpacing = 12;
        public static Padding Padding = new Padding(12, 0, 12, 0);
        public static int BorderRadious = 8;
    }
}
