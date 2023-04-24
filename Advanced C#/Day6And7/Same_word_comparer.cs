using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{



    class Same_word_comparer : IEqualityComparer<string>
    {

        bool IEqualityComparer<string>.Equals(string? x, string? y)
        {
         

            char[] X = x.ToCharArray(); 
            Array.Sort(X);
            string word = string.Join("", X); 

            char[] Y = y.ToCharArray();
            Array.Sort(Y);
            string word1 = string.Join("", Y);

            return word.ToLower() == word1.ToLower();
        }
        public int GetHashCode([DisallowNull] string obj)
        {
            char[] X = obj.ToCharArray();
            Array.Sort(X);
            string word = string.Join("", X); 

            return word.GetHashCode();


        }
    }
}
