using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Day5.Models
{
    public class Order
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:yyyy-mm-dd}")]
        public DateTime Date { get; set; }

        [Required]
        [MaxTotalPrice(30000)]
        public int TotalPrice { get; set; }

        [ForeignKey("Customer")]
        public int CustomerID { get; set; }

        public Customer Customer { get; set; }
    }
}