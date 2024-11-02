using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PB503_ClassTask
{
    public class ElectronicsProduct :Product
    {

        public ElectronicsProduct(int productId, string productName, double productPrice) :base(productId, productName, productPrice) 
        {
        
            
        }
        public int WarrantyPeriod;

        public ElectronicsProduct(int productId, string productName, double productPrice, int warrantyPeriod) : this(productId, productName, productPrice)
        {
            WarrantyPeriod = warrantyPeriod;
        }

        public void ShowFullDatas()
        {
            Console.WriteLine($"{ProductId}   {ProductName} {ProductPrice}  {WarrantyPeriod}");
        }
    }
}
