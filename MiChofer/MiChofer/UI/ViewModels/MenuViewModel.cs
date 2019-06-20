using System;
using System.Collections.Generic;
using System.Text;
using FreeDelivery.Models;

namespace FreeDelivery.ViewModels
{
    public class MenuViewModel
    {
        
        public List<item> items { get; set; }

        public MenuViewModel()
        {
            items = new List<item>();
            items.Add(new item
            {
                Title = "Pollo 1/4 a la brasa Pierna",
                Price = "25bs",
                Img = "usuario.png"
            });
            items.Add(new item
            {
                Title = "Pollo 1/4 a la brasa Pecho",
                Price = "25bs",
                Img = "usuario.png"
            });
            items.Add(new item
            {
                Title = "Pollo 1-4  al broaster Pierna",
                Price = "25bs",
                Img = "usuario.png"
            });
            items.Add(new item
            {
                Title = "Pollo 1x4 a la brasa Pecho",
                Price = "25bs",
                Img = "usuario.png"
            });
            items.Add(new item
            {
                Title = "Pollo 1x4  al brasa Pierna",
                Price = "25bs",
                Img = "usuario.png"
            });
            items.Add(new item
            {
                Title = "Pollo 1x4",
                Price = "25bs",
                Img = "usuario.png"
            });
            items.Add(new item
            {
                Title = "Pollo 1x4",
                Price = "25bs",
                Img = "usuario.png"
            });
            items.Add(new item
            {
                Title = "Pollo 1x4",
                Price = "25bs",
                Img = "usuario.png"
            });

        }


    }
}
