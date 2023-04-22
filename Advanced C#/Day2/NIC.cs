using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2
{
    public enum Type
    {
        Ethernet , token
    }; 

    public class NIC
    {
       private StringBuilder Manufacture;
       private StringBuilder MAC_Address;
       private Type type;

        public NIC() {
           Manufacture =new StringBuilder("Device") ;
           MAC_Address =new StringBuilder("00-B0-D0-63-C2-26") ;
           type = Type.Ethernet ;
         }


        public static NIC CreateObj { get; }  = new NIC();

        public void printData()
        {
            Console.WriteLine($"Manufacture is {Manufacture} and MAC Address is{MAC_Address} and Type is {type} ");
        }
    }

}
