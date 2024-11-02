using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PB503_ClassTask
{
    public class Product
    {
        public int ProductId;
        public string ProductName;
        public double ProductPrice;

        public Product(int productId, string productName, double productPrice ) 
        {
            ProductId = productId;
            ProductName = productName;
            ProductPrice = productPrice;
          
        }
    }
}
