using System;
using System.Collections.Generic;
using System.Text;

namespace FreeDelivery.Models
{
    public class item
    {
        private string title;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        private string price;

        public string Price
        {
            get { return price; }
            set { price = value; }
        }
        private string img;

        public string Img
        {
            get { return img; }
            set { img = value; }
        }
    }
}
