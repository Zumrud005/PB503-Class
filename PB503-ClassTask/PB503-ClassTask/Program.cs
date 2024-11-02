namespace PB503_ClassTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ElectronicsProduct electronics1= new ElectronicsProduct(11,"telephone",2345.5);
            electronics1.WarrantyPeriod = 1;
            Console.WriteLine("electronics1 datas:");
            electronics1.ShowFullDatas();


            ElectronicsProduct electronics2= new ElectronicsProduct(12,"computer",2004,8);
            electronics2.WarrantyPeriod=5;
            Console.WriteLine("electronics2 datas:");
            electronics2.ShowFullDatas();



            BookProduct bookProduct1 = new BookProduct(14, "1984", 25.1);
            bookProduct1.Author = "George Orwell";
            bookProduct1.Genre = "Politica";
            Console.WriteLine("bookProduct1 datas:");
            bookProduct1.ShowFullDatas();



            BookProduct bookProduct2 = new BookProduct(15, "Bilinmeyen Bir Kadının Mektubu", 32.6);
            bookProduct2.Author = "Stefan Zweig";
            bookProduct2.Genre = "Kurgu";
            Console.WriteLine("bookProduct2 datas:");
            bookProduct2.ShowFullDatas();




        }
    }
}
