using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Answers;

namespace Questions
{
    internal class ChooseOne : Question
    {
     internal ChooseOneAnswer CH=new ChooseOneAnswer();
        public override string Body { get ; set ; }

        public override string Head()
        {
            return $"Choose The Correct Answer From The Folowing :- ";

        }

        public override void Marks()
        {
            Console.WriteLine("\t\t\t\t\t\t\t\t\t\t (5-Marks)");
        }
    }
}
