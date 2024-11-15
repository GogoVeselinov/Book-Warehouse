using BookWarehouse;

class Warehouse
{
    public List<Book> Books { get; set; } = new List<Book>();

    public void AddBook(string title, string author, double price, int count)
    {
        Book newBook = new Book(title, author, price, count, 0, 0);
        Books.Add(newBook);

        Console.WriteLine($"Book '{title}' by {author} added successfully!");
    }
    public void Print()
    {
        foreach (var book in Books)
        {
            Console.WriteLine($"Title: {book._title}, Author: {book._author}, Price: {book._price}, Price after VAT: {book._price:F2}, Count: {book._count}, Sales: {book._sales}, Profit: {book._profit:F2}");
        }
    }
    public void SellBook(int index)
    {
        if (index >= 0 && index < Books.Count)
        {
            if (Books[index]._count > 0)
            {
                Books[index]._count--; // Reduce the book's count
                Books[index]._sales++;
                Books[index]._profit += Books[index]._price * 1.2;

                Console.WriteLine($"Sold 1 copy of '{Books[index]._title}' by {Books[index]._author}. Remaining stock: {Books[index]._count}. Profit earned: {Books[index]._profit:F2}");
            }
            else
            {
                Console.WriteLine($"Book '{Books[index]._title}' by {Books[index]._author} is out of stock.");
            }
        }
        else
        {
            Console.WriteLine("Invalid book index.");
        }
    }
}