﻿using FreeDelivery.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MiChofer.UI.Views.Login.Clientes
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPedidoPage : ContentPage
    {
        public MenuPedidoPage()
        {
            InitializeComponent();
            MenuViewModel items = new MenuViewModel();
            this.BindingContext = items;
            lista.ItemsSource = items.items;

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

        }
    }
}