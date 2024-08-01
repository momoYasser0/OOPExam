using Exam02.Questions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace Exam02.Exams
{
    public class FinalExam : Exam
    {

        public FinalExam(int timeOfExam, int numOfQuestions) : base(timeOfExam, numOfQuestions)
        {

        }
        public override void CreateExam()
        {
            ListOfQuestions = new Question[NumOfQuestions];
            for (int i = 0; i < ListOfQuestions.Length; i++)
            {
                int Choice;
                do
                {
                    Console.Write($"Please Choose the type of question Num {i + 1} (1 for true of false || 2 for MCQ): ");
                } while (!int.TryParse(Console.ReadLine(), out Choice) || Choice > 2 || Choice < 1);
                Console.Clear();
                if (Choice == 1)
                {
                    ListOfQuestions[i] = new TrueOrFalseQuestion();
                    ListOfQuestions[i].ShowQuestion();
                }
                if (Choice == 2)
                {
                    ListOfQuestions[i] = new McqQuestions();
                    ListOfQuestions[i].ShowQuestion();
                }

            }

        }

        public override void ShowExam()
        {

            int TotalMarks = 0, Mark = 0;

            foreach (var Qs in ListOfQuestions)
            {
                Console.WriteLine(Qs);


                for (int i = 0; i < Qs.AnswerList.Length; i++)
                {

                    Console.WriteLine(Qs.AnswerList[i]);
                }

                Console.WriteLine("-----------------------------");


                int UserAnswerID;


                if (Qs.HeaderOfQuestion == "MCQ Question")
                {

                    do
                    {
                        Console.WriteLine("enter number of your answer:");
                    }
                    while (!int.TryParse(Console.ReadLine(), out UserAnswerID) || UserAnswerID < 1 || UserAnswerID > 3);


                    Qs.UserAnswer.AnswerId = UserAnswerID;
                    Qs.UserAnswer.AnswerText = Qs.AnswerList[UserAnswerID - 1].AnswerText;

                    Console.WriteLine("------------------------------");

                }

                else if (Qs.HeaderOfQuestion == "True || False Question")
                {
                    do
                    {
                        Console.WriteLine("enter number of your answer:");

                    }
                    while (!int.TryParse(Console.ReadLine(), out UserAnswerID) || UserAnswerID < 1 || UserAnswerID > 2);
                    Qs.UserAnswer.AnswerId = UserAnswerID;
                    Qs.UserAnswer.AnswerText = Qs.AnswerList[UserAnswerID - 1].AnswerText;
                    Console.WriteLine("------------------------------");

                }


                Console.WriteLine("------------------------------");
                Console.Clear();
                TotalMarks += Qs.Marks;

            }


            for (int i = 0; i < ListOfQuestions.Length; i++)
            {
                if (ListOfQuestions[i].RightAnswer.AnswerId == ListOfQuestions[i].UserAnswer.AnswerId)
                {
                    Mark += ListOfQuestions[i].Marks;
                }
                Console.WriteLine($"Question({i + 1}): {ListOfQuestions[i].BodyOfQuestion}");
                Console.WriteLine($"Your Answer: {ListOfQuestions[i].UserAnswer.AnswerText}");
                Console.WriteLine($"Right Answer: {ListOfQuestions[i].RightAnswer.AnswerText}");
            }

            Console.WriteLine($"Your Grade Is {Mark} From {TotalMarks}");

        }
    }
}
