using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VirtualVendingMachine.Models
{
    public class ProductDetailsResponseEntity
    {
        private sbyte productId;
        private string productName = "";
        private decimal productPrice;

        public sbyte ProductId
        {
            get { return productId; }
            set { productId = value; }
        }

        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }

        public decimal ProductPrice
        {
            get { return productPrice; }
            set { productPrice = value; }
        }
    }
}