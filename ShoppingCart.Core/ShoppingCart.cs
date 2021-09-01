using ShoppingCart.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Core
{
    public class ShoppingCart
    {
        public  void Comprar()
        {

        }
        public int ObtenerCantidadDeItems(List<Item> list)
        {
            var totalItems = list.Sum(x => x.Cantidad);
            return totalItems;
        }
        public decimal ObtenerTotalCompra(List<Item> list)
        {
            var totalCompra = list.Sum(x => (x.Precio * x.Cantidad));
            return totalCompra;
        }
        public List<Item> GetCartList(List<int> itemsId)
        {
            var items = this.GetProductList();
            var result = items.Where(x => itemsId.Contains(x.Id));
            foreach(var rs in result)
            {
                rs.Cantidad = itemsId.Where(x => x == rs.Id).Count();
            }
            return result.ToList();

        }
        public List<Item> GetProductList()
        {
            return new List<Item> { 
               new Item
               {
                   Id =1,
                   Imagen = "gab.jpg",
                   Nombre = " Producto 1",
                   Cantidad = 1,
                   Precio = 10
               },
                new Item
               {
                   Id =2,
                   Imagen = "gcard.jpg",
                   Nombre = " Producto 2",
                   Cantidad = 1,
                   Precio =  12
               },
                 new Item
                {
                   Id =3,
                   Imagen = "mother.jpg",
                   Nombre = " Producto 3",
                   Cantidad = 1,
                   Precio = 14
               },
                  new Item
                {
                   Id =4,
                   Imagen = "ram.jpg",
                   Nombre = " Producto 4",
                   Cantidad = 1,
                   Precio = 16
               },
                   new Item
                {
                   Id =5,
                   Imagen = "ryzen.jpg",
                   Nombre = " Producto 5",
                   Cantidad = 1,
                   Precio = 18
               }
            };
        }
    }
}
