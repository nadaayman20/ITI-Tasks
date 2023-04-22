using System.Diagnostics;

namespace Day_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Book> AllBooks = new()
            {
                new("9780132", "The India Story", new string[] { "Bimal ", "Ruskin " }, new DateTime(2020, 3, 12),  1000.0M ),
                new(  "745321","Pride, Prejudice and Punditry",  new [] { "Shashi ", "Talwar " },  new DateTime(2015, 8, 4), 250.0M),
                new( "231654", "‘Hear Yourself’", new [] { "Rajesh", "Devika" },  new DateTime(2018, 6, 15), 500.0M)
            };

            Console.WriteLine("----- user define ------");
            LibraryEngine.ProcessBooks(AllBooks, BookFunctions.GetTitle);
            LibraryEngine.ProcessBooks(AllBooks, BookFunctions.GetAuthors);
            LibraryEngine.ProcessBooks(AllBooks, BookFunctions.GetPrice);

 
            Console.WriteLine("----- Anonymous Method ------");
            LibraryEngine.ProcessBooks(AllBooks, delegate (Book b) { return b.ISBN; });

            Console.WriteLine("----- Lambda Expression ------");
            LibraryEngine.ProcessBooks(AllBooks, b => b.PublicationDate.ToString());


        }
    }
}