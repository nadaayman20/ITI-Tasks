using System;
using System.Collections.Generic;

#nullable disable

namespace Task1.Models
{
    public partial class City
    {
        public int CityId { get; set; }
        public string CityName { get; set; }
        public int CId { get; set; }

        public virtual Country CIdNavigation { get; set; }
    }
}
