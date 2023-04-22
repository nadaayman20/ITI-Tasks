using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_4
{
    public delegate string bookFunctionsDel(Book b);

    public class LibraryEngine
    {
        //public static void ProcessBooks(List<Book> bList, bookFunctionsDel fPtr)
        //{
        //    foreach (Book B in bList)
        //    {
        //        Console.WriteLine(fPtr(B));
        //    }
        //}
    public static void ProcessBooks(List<Book> bList, Func<Book, string> fPtr)
    {
        foreach (Book B in bList)
        {
            Console.WriteLine(fPtr(B));
        }
    }
}
}
