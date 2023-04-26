using Answers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions
{
    internal class ChooseAllCorrect : Question
    {
      internal  ChooseAllAnswer CH = new ChooseAllAnswer();
        public override string Body { get ; set; }

        public override string Head()
        {
            return $"Choose All Correct Answer From The Folowing :- ";
        }

        public override void Marks()
        {
            Console.WriteLine("\t\t\t\t\t\t\t\t\t\t (10-Marks)");
        }
    }
}
