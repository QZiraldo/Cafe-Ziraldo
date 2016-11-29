﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CafeZiraldo.Models;

namespace CafeZiraldo.Controllers
{
    public class MainController : Controller
    {
        // GET: Main
        public ActionResult Index()
        {
            
            ViewBag.ProductList = GetProductList();

            return View();
        }

        private static List<Product> GetProductList()
        {
            CafeZiraldoDBEntities dbContext = new CafeZiraldoDBEntities();

           return dbContext.Products.ToList();
        }

        public ActionResult Order(string product)
        {
           if (Session["shoppingCart"] == null)
            {
                Dictionary<string, Product> tempSC = new
                    Dictionary<string, Product>();

                Session["shoppingCart"] = tempSC;
            }
            Dictionary<string, Product> shoppingCart =
                   (Dictionary<string, Product>)Session["shoppingCart"];


            if (!shoppingCart.ContainsKey(product)) //first time adding product
            {
                shoppingCart.Add(product, new Product(product, 1, 1));
            }

            else
            {
                shoppingCart[product].Quantity += 1;
            }

            ViewBag.ShoppingCart=shoppingCart.Values.ToList();
            ViewBag.ProductList = GetProductList();
            return View("Index");
        }

        
        public ActionResult ProcessSignUp(UserData data)
        {
            ViewBag.Message = "Thanks " + data.Uname+ " ("+data.Email+")";
            return View("Index");
            // return Redirect("https://www.google.com");
        }


    }
}