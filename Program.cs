using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookWarehouse
{
    class Program
    {
        static void Main(string[] args)
        {
            Warehouse warehouse = new Warehouse();

            // Adding books to the warehouse
            warehouse.AddBook("The Great Gatsby", "F. Scott Fitzgerald", 10.99, 100);
            warehouse.AddBook("1984", "George Orwell", 14.99, 50);
            warehouse.AddBook("To Kill a Mockingbird", "Harper Lee", 12.99, 80);

            warehouse.Print();

            // Selling books
            warehouse.SellBook(0);
            warehouse.SellBook(1); 
            warehouse.SellBook(1);

            // Print the updated list of books after sales
            warehouse.Print();
        }
    }
}