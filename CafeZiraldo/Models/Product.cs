﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CafeZiraldo.Models
{
    public class Product
    {

        private string name;
        private float price;
        private int quantity;

        public Product(string name, float price, int quantity)
        {
            this.name = name;
            this.price = price;
            this.quantity = quantity;
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public float Price
        {
            get
            {
                return price;
            }

            set
            {
                price = value;
            }
        }

        public int Quantity
        {
            get
            {
                return quantity;
            }

            set
            {
                quantity = value;
            }
        }
    }
}