using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using MiChofer.Models;


namespace MiChofer.UI.ViewModels
{
    public class Drivers
    {
       
        public ObservableCollection<DriverTotales1> DriversTotales { get; set; }

        public Drivers()
        {
            DriversTotales = new ObservableCollection<DriverTotales1>();

            DriversTotales.Add(new DriverTotales1
            {
                Nombre = "Goran",
                Ciudad = "santa cruz",
            });

            DriversTotales.Add(new DriverTotales1
            {
                Nombre = "Sergio",
                Ciudad = "santa cruz",
            });

            DriversTotales.Add(new DriverTotales1
            {
                Nombre = "Alejandro",
                Ciudad = "santa cruz",
            });

            DriversTotales.Add(new DriverTotales1
            {
                Nombre = "Diego",
                Ciudad = "santa cruz",       
            });
            DriversTotales.Add(new DriverTotales1
            {
                Nombre = "Julio",
                Ciudad = "santa cruz",
            });

            DriversTotales.Add(new DriverTotales1
            {
                Nombre = "Carlos",
                Ciudad = "santa cruz",
            });

            DriversTotales.Add(new DriverTotales1
            {
                Nombre = "Miguel",
                Ciudad = "santa cruz",
            });

            DriversTotales.Add(new DriverTotales1
            {
                Nombre = "Arturo",
                Ciudad = "santa cruz",
            });
        }
    }
}
