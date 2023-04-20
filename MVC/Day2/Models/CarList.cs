using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Day2.Models
{
    public class CarList
    {
        public static List<Car> Cars { get; set; } = new List<Car>()
        {
            new Car(){Num=1 , Color="Black" , Model="Heisei" , Manfacture="Toyota"},
            new Car(){Num=2 , Color="Silver" , Model="Cherokee" , Manfacture="Jeep"},
            new Car(){Num=3 , Color="Red" , Model="C180" , Manfacture="Mercedes-Benz"},
            new Car(){Num=4 , Color="White" , Model="M3" , Manfacture="BMW"},
        
        };
    }
}