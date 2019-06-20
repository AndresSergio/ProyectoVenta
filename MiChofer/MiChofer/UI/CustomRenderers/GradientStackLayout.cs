using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace MiChofer.UI.CustomRenderer
{
    public class GradientStackLayout : Xamarin.Forms.StackLayout
    {
        public Color StartColor
        {
            get;
            set;
        }
        public Color EndColor
        {
            get;
            set;
        }

        public float LeftBottomCornerRadius { get; set; }
    }
}
