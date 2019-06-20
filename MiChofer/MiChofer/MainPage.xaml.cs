using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


using MiChofer.UI.Views;
using MiChofer.UI.Views.Login;
using MiChofer.Models;

namespace MiChofer
{
    public partial class MainPage : MasterDetailPage
    {

        Master m_master;
        public MainPage()
        {
            InitializeComponent();

            m_master = new Master();
            this.Master = m_master;
            this.Detail = new NavigationPage(new HomePage());


            m_master.listView.ItemSelected += ListView_ItemSelected; 

        }
        //esta funcion hace que de una lista me mande a una pagina dependiendo de a que lista quiera ir
        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as MasterPageItem;
            if (item != null)
            {
                
                Detail = new NavigationPage((Page)Activator.CreateInstance(item.TargetType));
                m_master.listView.SelectedItem = null;
                IsPresented = false;
            }
        }

        public int OnItemSelected { get; private set; }


        

       
    }
}
