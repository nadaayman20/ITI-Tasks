using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2.DAL.Data.Models
{
    internal class AgeCustomValidation : ValidationAttribute
    {

        public override bool IsValid(object? value) =>
             value is DateTime date && date.Year < DateTime.Now.Year;
    }
}

