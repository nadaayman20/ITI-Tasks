using Questions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    internal class ShowExam
    {

       protected ChooseAllCorrect[] allCorrect = new ChooseAllCorrect[3];
       
       protected ChooseOne[] Choose= new ChooseOne[3];

       protected TrueOrFalse[] TrueOrFalse = new TrueOrFalse[3];

       public ShowExam(ChooseAllCorrect[] CA, ChooseOne[] CO, TrueOrFalse[] TF):base(CA,CO,TF)
        {
            allCorrect = CA;
            Choose = CO;
            TrueOrFalse = TF;
        }

        public int Time { get; set; }
        public int NumberOfQuestion { get; set; }
        public virtual void Show_Exam()
        {
            
        }
             
    }

  public  class PracticExam : ShowExam
    {
        public override void Show_Exam()
        {
          
        }
    }

   public class FinalExam : ShowExam
    {
       public FinalExam(ChooseAllCorrect[] CA, ChooseOne[] CO, TrueOrFalse[] TF):base(CA,CO,TF)
        {
          
        }
        public override void Show_Exam()
        {
             ChooseOne head = new ChooseOne();
            Console.WriteLine(head.Head());

            //Console.WriteLine(Choose[0].Head());

            for (int i = 0; i < Choose.Length; i++)
            {
                Choose[i]=new ChooseOne();
                switch (i)
                {
                    case 0:
                        Console.WriteLine($"{Choose[i].Body}\n{Choose[i].CH.CH1}\n{Choose[i].CH.CH2}\n{Choose[i].CH.CH3}\n{Choose[i].CH.CH4}");
                        break;

                    case 1:
                        Console.WriteLine($"{Choose[i].Body}\n{Choose[i].CH.CH1}\n{Choose[i].CH.CH2}\n{Choose[i].CH.CH3}\n{Choose[i].CH.CH4}");  
                        break;

                    case 2:
                        Console.WriteLine($"{Choose[i].Body}\n{Choose[i].CH.CH1}\n{Choose[i].CH.CH2}\n{Choose[i].CH.CH3}\n{Choose[i].CH.CH4}");
                        break;

                }
            }
            for (int i = 0; i < allCorrect.Length; i++)
            {
                allCorrect[i] = new ChooseAllCorrect();
                switch (i)
                {
                    case 0:
                        Console.WriteLine($"{allCorrect[i].Body}\n{allCorrect[i].CH.CH1}\n{allCorrect[i].CH.CH2}\n{allCorrect.CH.CH3}\n{allCorrect[i].CH.CH4}");
                        break;

                    case 1:
                        Console.WriteLine($"{allCorrect[i].Body}\n{allCorrect[i].CH.CH1}\n{allCorrect[i].CH.CH2}\n{allCorrect.CH.CH3}\n{allCorrect[i].CH.CH4}");
                        break;

                    case 2:
                        Console.WriteLine($"{allCorrect[i].Body}\n{allCorrect[i].CH.CH1}\n{allCorrect[i].CH.CH2}\n{allCorrect.CH.CH3}\n{allCorrect[i].CH.CH4}");
                        break;

                }
            }
            for (int i = 0; i < TrueOrFalse.Length; i++)
            {
                TrueOrFalse[i] = new TrueOrFalse();
                switch (i)
                {
                    case 0:
                        Console.WriteLine($"{TrueOrFalse[i].Body}\n{TrueOrFalse[i].TOR.TrueAnswer}\n{TrueOrFalse[i].TOR.FalseAnswer}");
                        break;

                    case 1:
                        Console.WriteLine($"{TrueOrFalse[i].Body}\n{TrueOrFalse[i].TOR.TrueAnswer}\n{TrueOrFalse[i].TOR.FalseAnswer}");
                        break;

                }
            }
        }
    }
}
