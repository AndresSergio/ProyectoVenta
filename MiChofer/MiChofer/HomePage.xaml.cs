using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiChofer.UI.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Syncfusion.SfAutoComplete.XForms;

namespace MiChofer
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HomePage : ContentPage
	{
		public HomePage ()
		{
			InitializeComponent ();

            List<String> countryNames = new List<String>
            {
                "Uganda",
                "Ukraine",
                "Canada",
                "United Arab Emirates",
                "France",
                "United Kingdom",
                "China",
                "United States",
                "Japan"
            };
            autoComplete.DataSource = countryNames;
            //autoComplete.SuggestionMode = SuggestionMode.StartsWithCaseSensitive;


        }

 
    }
    
}