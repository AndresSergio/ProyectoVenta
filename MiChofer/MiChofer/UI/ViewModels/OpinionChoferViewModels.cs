using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using MiChofer.Models;

namespace MiChofer.UI.ViewModels
{
    public class OpinionChoferViewModels
    {
        public ObservableCollection<OpinionChofer> OpinionChofers { get; set; }

        public string Nombre { get; set; }
        public string Image { get; set; }
        public string Ratin { get; set; }
        public string Ciudad { get; set; }
        public string UltimoViaje { get; set; }

        
        public OpinionChoferViewModels()
        {
            Nombre = "pedro";
            Image = "https://img-cdn.hipertextual.com/files/2018/05/Thanos-comic.jpeg?strip=all&lossy=1&quality=70&resize=670%2C410&ssl=1&webp=1";
            Ratin = "5";
            Ciudad = "SantaCruz";
            UltimoViaje = "tarija";



            OpinionChofers = new ObservableCollection<OpinionChofer>();

            OpinionChofers.Add(new OpinionChofer
            {
                Nombre = "Pablo",
                Ciudad = "santa cruz",
                Ultimo_viaje = "tarija",
                Opinion_empresas = "5",
                Imagen = "https://img-cdn.hipertextual.com/files/2018/05/Thanos-comic.jpeg?strip=all&lossy=1&quality=70&resize=670%2C410&ssl=1&webp=1",
                Descripcion = "buen conductor",
                NombreEmpresa = "Controladora universal",
                raiting ="5"
                


            });

            OpinionChofers.Add(new OpinionChofer
            {
                Nombre = "Pablo",
                Ciudad = "santa cruz",
                Ultimo_viaje = "tarija",
                Opinion_empresas = "4",
                Imagen = "https://img-cdn.hipertextual.com/files/2018/05/Thanos-comic.jpeg?strip=all&lossy=1&quality=70&resize=670%2C410&ssl=1&webp=1",
                Descripcion = "buen conductor",
                NombreEmpresa = "Controladora universal",
                raiting = "5"

            });

            OpinionChofers.Add(new OpinionChofer
            {
                Nombre = "Pablo",
                Ciudad = "santa cruz",
                Ultimo_viaje = "tarija",
                Opinion_empresas = "4",
                Imagen = "https://img-cdn.hipertextual.com/files/2018/05/Thanos-comic.jpeg?strip=all&lossy=1&quality=70&resize=670%2C410&ssl=1&webp=1",
                Descripcion = "buen conductor",
                NombreEmpresa = "Controladora universal",
                raiting = "5"

            });

            OpinionChofers.Add(new OpinionChofer
            {
                Nombre = "Pablo",
                Ciudad = "santa cruz",
                Ultimo_viaje = "tarija",
                Opinion_empresas = "5",
                Imagen = "https://img-cdn.hipertextual.com/files/2018/05/Thanos-comic.jpeg?strip=all&lossy=1&quality=70&resize=670%2C410&ssl=1&webp=1",
                Descripcion = "buen conductor",
                NombreEmpresa = "Controladora universal",
                raiting = "5"

            });
        }
    }
}
