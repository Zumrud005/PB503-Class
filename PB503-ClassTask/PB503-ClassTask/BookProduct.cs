using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PB503_ClassTask
{
    public class BookProduct : Product
    {
        public string Author;
        public string Genre;
        public BookProduct(int productID, string productName, double productPrice) : base(productID, productName, productPrice)
        {

        }

        public BookProduct(int productID, string productName, double productPrice, string author) : this(productID, productName, productPrice)
        {
            Author=author;  

        }

        public BookProduct(int productID, string productName, double productPrice, string author, string genre) : this(productID, productName, productPrice, author )
        {
            Genre=genre;
        }

        public void ShowFullDatas()
        {
            Console.WriteLine($"{ProductId} {ProductName} {ProductPrice} {Author}  {Genre} ");
        }
    }
}
