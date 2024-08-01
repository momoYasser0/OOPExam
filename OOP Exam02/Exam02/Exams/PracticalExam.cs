using Exam02.Answers;
using Exam02.Questions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02.Exams
{
    public class PracticalExam : Exam
    {
        public PracticalExam(int timeOfExam, int numOfQuestions) : base(timeOfExam, numOfQuestions)
        {
        }

        public override void CreateExam()
        {
            ListOfQuestions = new Question[NumOfQuestions];
            for (int i = 0; i < ListOfQuestions.Length; i++)
            {
                ListOfQuestions[i] = new McqQuestions();
                ListOfQuestions[i].ShowQuestion();
                Console.Clear();

            }
        }

        private int UserAnswerId;
        private int TotalMarks, marks;
        public override void ShowExam()
        {
            foreach (var Qs in ListOfQuestions)
            {
                Console.WriteLine(Qs);
                for (int i = 0; i < Qs.AnswerList.Length; i++)
                {
                    Console.WriteLine(Qs.AnswerList[i]);
                }
                Console.WriteLine("-----------------------------");
                do
                {
                    Console.WriteLine("enter number of your answer:");

                }
                while (!int.TryParse(Console.ReadLine(), out UserAnswerId) || UserAnswerId < 1 || UserAnswerId > 3);

                TotalMarks += Qs.Marks;
                Console.WriteLine("------------------------------");

            }
            Console.Clear();
            for (int i = 0; i < ListOfQuestions.Length; i++)
            {
                if (ListOfQuestions[i].RightAnswer.AnswerId == UserAnswerId)
                {
                    marks += ListOfQuestions[i].Marks;
                    Console.WriteLine("Hiii");
                }


                Console.WriteLine($"Question({i + 1}): {ListOfQuestions[i].BodyOfQuestion}");
                Console.WriteLine($"Your Answer: {UserAnswerId}");
                Console.WriteLine($"Right Answer: {ListOfQuestions[i].RightAnswer.AnswerId}");
            }
            Console.WriteLine($"Your Grade Is {marks} From {TotalMarks}");


        }
    }
}
