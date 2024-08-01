using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02.Questions
{
    internal class McqQuestions : Question
    {
        public override string? HeaderOfQuestion => "MCQ Question";
        public McqQuestions()
        {
            AnswerList = new Answer[3];
        }
        public override void ShowQuestion()
        {
            int marks;
            Console.WriteLine(HeaderOfQuestion);
            Console.WriteLine("Please Enter Question Body");
            BodyOfQuestion = Console.ReadLine();

            do
            {
                Console.WriteLine("enter marks of question");
            } while (!int.TryParse(Console.ReadLine(), out marks) || marks < 1);

            Marks = marks;
            Console.WriteLine("The Choices of Question :");

            for (int i = 0; i < 3; i++)
            {
                AnswerList[i] = new Answer
                {
                    AnswerId = i + 1
                };
                Console.WriteLine($"Please enter the choice num ({i + 1}) :");
                AnswerList[i].AnswerText = Console.ReadLine();
            }
            int rightAnswerId;
            do
            {
                Console.WriteLine("Please Specify the right choice of question: ");

            } while (!int.TryParse(Console.ReadLine(), out rightAnswerId) || rightAnswerId < 1 || rightAnswerId > 3);

            RightAnswer.AnswerId = rightAnswerId;
            RightAnswer.AnswerText = AnswerList[rightAnswerId - 1].AnswerText;
        }
    }
}
