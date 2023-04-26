using Exam;
using Questions;
using System.Text.RegularExpressions;

namespace Day07
{
    internal class Program
    {
        #region Recursion Function
        // static void Main(string[] args)
        // {

        //     Console.WriteLine(fact(5));

        // }

        //static int fact(int x)
        // {
        //     if (x == 1)
        //         return 1;

        //     return x * fact(x - 1);
        // }

        #endregion

        static void Main(string[] args)
        {
            #region SET DATA
            #region CHOOSE ONE

            ChooseOne[] Choose = new ChooseOne[3];

            for (int i = 0; i < Choose.Length; i++)
            {
                Choose[i] = new ChooseOne();
                switch (i)
                {
                    case 0:
                        Choose[i].Body = "Which class can have member functions without their implementation";
                        Choose[i].CH.CH1 = "a) Default class";
                        Choose[i].CH.CH2 = "b) String class";
                        Choose[i].CH.CH3 = "c) Template class";
                        Choose[i].CH.CH4 = "d) Abstract class";
                        break;

                    case 1:
                        Choose[i].Body = "Which of the following describes a friend class";
                        Choose[i].CH.CH1 = " a) Friend class can access all the private members of the class, of which it is a friend";
                        Choose[i].CH.CH2 = " b) Sum of the size of all the variables along with inherited variables in the class";
                        Choose[i].CH.CH3 = " c) Size of the largest size of variable";
                        Choose[i].CH.CH4 = " d) Classes doesn’t have any size";
                        break;

                    case 2:
                        Choose[i].Body = "What is the scope of a class nested inside another class?";
                        Choose[i].CH.CH1 = " a) Protected scope";
                        Choose[i].CH.CH2 = " b) Private scope";
                        Choose[i].CH.CH3 = " c) Global scope";
                        Choose[i].CH.CH4 = " d) Depends on access specifier and inheritance used";
                        break;

                }
            }

            #endregion

          



            #region CHOOSE ALL
            
            ChooseAllCorrect[] ChooseAll= new ChooseAllCorrect[3];

            for (int i = 0; i < ChooseAll.Length; i++)
            {
                ChooseAll[i] = new ChooseAllCorrect();
                switch (i)
                {
                    case 0:
                        ChooseAll[i].Body = "Which Access Modifier are allowed in The namespace";
                        ChooseAll[i].CH.CH1 = "a) Public";
                        ChooseAll[i].CH.CH3 = "b) Protected";
                        ChooseAll[i].CH.CH2 = "c) Internal";
                        ChooseAll[i].CH.CH4 = "d) private";
                        break;

                    case 1:
                        ChooseAll[i].Body = "What are types of classes";
                        ChooseAll[i].CH.CH1 = " a) Static";
                        ChooseAll[i].CH.CH2 = " b) Concret";
                        ChooseAll[i].CH.CH3 = " c) Virtual";
                        ChooseAll[i].CH.CH4 = " d) Abstract";
                        break;

                    case 2:
                         ChooseAll[i].Body = "What are the OOP Principles ";
                         ChooseAll[i].CH.CH1 = " a) Inheritance";
                         ChooseAll[i].CH.CH2 = " b) Abstraction";
                         ChooseAll[i].CH.CH3 = " c) Polimorphism";
                         ChooseAll[i].CH.CH4 = " d) Encapsulation";
                        break;

                }
            }

            
            #endregion

            #region TRUE OR FALSE

            TrueOrFalse[] TR=new TrueOrFalse[3];

            for (int i = 0; i < TR.Length; i++)
            {
                TR[i] = new TrueOrFalse();
                switch (i)
                {
                    case 0:
                       TR[i].Body = "Super classes are also called Parent classes/Base classes";
                       TR[i].TOR.TrueAnswer= "a)True";
                       TR[i].TOR.FalseAnswer = "b)False";
                    
                        break;

                    case 1:
                        TR[i].Body= "It is not possible to achieve inheritance of structures in c++";
                        TR[i].TOR.TrueAnswer = "a)True";
                        TR[i].TOR.FalseAnswer = "b)False";

                        break;

                    case 2:
                        TR[i].Body = "Sub classes may also be called Child classes/Derived classes";
                        TR[i].TOR.TrueAnswer = "a)True";
                        TR[i].TOR.FalseAnswer = "b)False";
                        break;

                }
            }
            #endregion

            #endregion
            FinalExam f = new FinalExam(ChooseAll, Choose, TR);
            f.Show_Exam();
        }

    }
}