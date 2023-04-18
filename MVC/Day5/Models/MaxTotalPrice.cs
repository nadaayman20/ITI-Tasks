using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Day5.Models
{
    public class MaxTotalPrice : ValidationAttribute
    {
        int Value;
        public MaxTotalPrice(int num)
        {
            Value = num;
        }
        public override bool IsValid(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            else
            {
                if (obj is int)
                {
                    int suppliedValue = (int)obj;
                    if (suppliedValue < Value)
                    {
                        return true;
                    }
                    else
                    {
                        ErrorMessage = "Maximum value for TotalPrice should be + " + Value; //user validation error
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }

        }
    }   
}
