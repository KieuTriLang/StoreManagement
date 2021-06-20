using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManagement
{
    class ProductOrder
    {
        public string ProductName { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public ProductOrder(string prodName, double price, int quantity)
        {
            this.ProductName = prodName;
            this.Price = price;
            this.Quantity = quantity;
        }

    }
}
