using System;
using System.Collections.Generic;
using System.Text;

namespace SwagApp.Models.Servce
{
    internal class CartItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string gender { get; set; }
        public string size { get; set; }

        public int cartitem { get; set; }
        public string ShippingAddress { get; set; }
        public string color { get; set; }
    }
}
