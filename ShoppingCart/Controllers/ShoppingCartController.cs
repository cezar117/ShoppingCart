using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShoppingCart.Core;
using Microsoft.AspNetCore.Http;
using System.Text.Json;
using ShoppingCart.Entities;

namespace ShoppingCart.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly ShoppingCart.Core.ShoppingCart shopping;
        public ShoppingCartController(ShoppingCart.Core.ShoppingCart _shoppingcart)
        {
            shopping = _shoppingcart;
        }

        public ActionResult ItemList(int? id)
        {
            var itemList = new List<int>();
            if (id != null)
            {
                if (!string.IsNullOrEmpty(HttpContext.Session.GetString("ItemList")))
                {
                    var itemslist = HttpContext.Session.GetString("ItemList");
                    itemList = JsonSerializer.Deserialize<List<int>>(itemslist);
                    itemList.Add(id.Value);
                }
            }
            else
            {
                if (!string.IsNullOrEmpty(HttpContext.Session.GetString("ItemList")))
                {
                    var itemslist = HttpContext.Session.GetString("ItemList");
                    itemList = JsonSerializer.Deserialize<List<int>>(itemslist);
                }
             }

            HttpContext.Session.SetString("ItemList", JsonSerializer.Serialize(itemList));
            var productList = shopping.GetProductList();
            return View(productList);
        }

        public ActionResult Cart(int? id)
        {
            var cartList = new List<Item>();

            if (!string.IsNullOrEmpty(HttpContext.Session.GetString("ItemList")))
            {
                var itemslist = HttpContext.Session.GetString("ItemList");
                var itemList = JsonSerializer.Deserialize<List<int>>(itemslist);
                if (id != null)
                {
                    itemList.Remove(id.GetValueOrDefault());
                }
                HttpContext.Session.SetString("ItemList", JsonSerializer.Serialize(itemList));
                cartList = shopping.GetCartList(itemList);
                ViewBag.totalCompra = shopping.ObtenerTotalCompra(cartList);
                ViewBag.totalItems = shopping.ObtenerCantidadDeItems(cartList);
            }

            return View(cartList);
        }

        public ActionResult Purchase()
        {
            var shoppingList = new ShoppingCart.Entities.ShoppingCart();
            if (!string.IsNullOrEmpty(HttpContext.Session.GetString("ItemList")))
            {
                var itemslist = HttpContext.Session.GetString("ItemList");
                var itemList = JsonSerializer.Deserialize<List<int>>(itemslist);
                var cartList = shopping.GetCartList(itemList);
                ViewBag.totalCompra = shopping.ObtenerTotalCompra(cartList);
                ViewBag.totalItems = shopping.ObtenerCantidadDeItems(cartList);
                shoppingList.Items = cartList;
                shoppingList.FechaCompra = DateTime.Now; 
                shoppingList.TotalCompra = ViewBag.totalCompra;
            }
            HttpContext.Session.SetString("ItemList", JsonSerializer.Serialize(new List<int>()));
            return View(shoppingList);
        }
    }
}
