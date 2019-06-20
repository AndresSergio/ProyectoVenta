using System;
using Syncfusion.SfRotator.XForms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MiChofer.UI.Views.Login
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class NoInternetPage : ContentPage
	{
        SfRotator m_rotator;

        public NoInternetPage()
        {
        }

        public NoInternetPage (SfRotator _sfrotator)
        {
            InitializeComponent();

            m_rotator = _sfrotator;
        }
     

    }
}