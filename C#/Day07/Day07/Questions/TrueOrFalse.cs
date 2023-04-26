using Answers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions
{
    internal class TrueOrFalse : Question
    {
       internal TrueOrFalseAnswer TOR = new TrueOrFalseAnswer(); //obj ot t or f answer
        public override string Body { get ; set; }

        public override string Head()
        {
            return $"Put True Or False For The Folowing Question :- ";
        }

        public override void Marks()
        {
            Console.WriteLine("\t\t\t\t\t\t\t\t\t\t (5-Marks)");
        }
    }
}
