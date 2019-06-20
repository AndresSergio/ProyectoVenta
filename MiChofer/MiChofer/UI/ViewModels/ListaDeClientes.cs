using MiChofer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MiChofer.UI.ViewModels
{
    public class ListaDeClientes
    {

        public List<ItemCliente> itemClientes { get; set; }

        public ListaDeClientes()
        {
            itemClientes = new List<ItemCliente>();
            itemClientes.Add(new ItemCliente
            {
                Nombre = "Sergio",
                Apellido = "Garcia",
                Carnet = "8873352",
                Telefono = "69022766",
                Direccion = "Km 9 doble via la guardia"
            });
        }

    }
}
