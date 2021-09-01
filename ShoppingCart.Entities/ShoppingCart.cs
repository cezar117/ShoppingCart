using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Entities
{
    public class ShoppingCart
    {
        public DateTime FechaCompra { get; set; }
        public List<Item> Items { get; set; }
        public decimal TotalCompra { get; set; }
    }
}
