using MiChofer.Models;
using MiChofer.UI.Views;
using MiChofer.UI.Views.Login.Clientes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace MiChofer.UI.ViewModels
{
    public class MasterPageViewModel : INotifyPropertyChanged
    {
        //INotify Event
        public event PropertyChangedEventHandler PropertyChanged;


        //Propiedades de el view model.
        private string m_name;
        public string Name
        {
            get { return m_name; }
            set { m_name = value; PropertyChanged(this, new PropertyChangedEventArgs(Name));
            }
        }

        //.. TODO: Rellenar mas datos



        private List<MasterPageItem> m_masterPageItems;
        public List<MasterPageItem> MasterPageItems
        {
            get { return m_masterPageItems; }
            set { m_masterPageItems = value; }
        }

        

        
        //Constructor
        public MasterPageViewModel()
        {
            m_masterPageItems = new List<MasterPageItem>();

            m_name = "Usuario";

            SetMenuItems();
        }


        //Funciones privadas
        private void SetMenuItems()
        {
            m_masterPageItems.Add(new MasterPageItem
            {
                Title = "Promocion",
                IconSource = "promociones.png",
                TargetType = typeof(HomePage)
            });

            m_masterPageItems.Add(new MasterPageItem
            {
                Title = "Productos",
                IconSource = "carro.png",
                TargetType = typeof(MenuPedidoPage)
            });
         

            m_masterPageItems.Add(new MasterPageItem
            {
                Title = "Clientes",
                IconSource = "usuario.png",
                TargetType = typeof(Lista_de_clientes)
            });

           
        }


        //Funciones publicas
        public void SetUserData(User _user)
        {
            this.m_name = _user.Name;
        }
    }
}
