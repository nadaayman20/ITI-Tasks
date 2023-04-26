using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Answers
{
    internal class TrueOrFalseAnswer
    {
        public string TrueAnswer { get; set; }
        public string FalseAnswer { get; set; }

        public override string ToString()
        {
            return this.TrueAnswer + "\n" + this.FalseAnswer;
        }
    }
}
