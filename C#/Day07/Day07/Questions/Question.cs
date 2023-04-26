using Exam;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions
{
    internal abstract class Question
    {
        //to linking between each question with its answer take object of answer in class question of its type
        //then when taking object of question the object of answer will be auto generated
        public abstract string Head(); // return head of ques
        public abstract string Body { get; set; }
        public abstract void Marks();
    }
}
