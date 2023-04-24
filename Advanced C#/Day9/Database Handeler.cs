using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9_WPF
{
    internal class Database_Handeler
    {
        public static SqlConnection DBHandeler { get; set; }
        static Database_Handeler()
        {
            DBHandeler = new("Data Source=.;Initial Catalog=Northwind;Integrated Security=true;Encrypt=false;");
        }
    }
}
