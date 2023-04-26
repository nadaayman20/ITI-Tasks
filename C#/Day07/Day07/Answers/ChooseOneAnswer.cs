using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Answers
{
    internal class ChooseOneAnswer
    {
        public string CH1 { get; set; }
        public string CH2 { get; set; }
        public string CH3 { get; set; }
        public string CH4 { get; set; }

        public override string ToString()
        {
            return this.CH1 + "\n" + this.CH2 + "\n" + this.CH3 + "\n" + this.CH4; 
        }
    }
}
