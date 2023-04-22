using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_4
{
    public class BookFunctions
    {
        public static string GetTitle(Book B)
        {
            return $"Book Title : {B.Title}";
        }
        public static string GetAuthors(Book B)
        {
            string user = "";
            foreach (string author in B.Authors)
                user+= author;
            return $"Book Author : {user}" ;
           
        }
        public static string GetPrice(Book B)
        {
         
            return $"Book Price : {B.Price}";
        }
    }
}
