using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02.Questions
{
    internal class TrueOrFalseQuestion : Question
    {
        public override string? HeaderOfQuestion { get => "True || False Question"; }
        public TrueOrFalseQuestion()
        {
            AnswerList = new Answer[2];

            AnswerList[0] = new Answer(1, "True");
            AnswerList[1] = new Answer(2, "False");


        }

        public override void ShowQuestion()
        {
            Console.WriteLine(HeaderOfQuestion);
            Console.WriteLine("Please Enter Question Body");
            BodyOfQuestion = Console.ReadLine();

            int marks;

            do
            {
                Console.WriteLine("enter marks of question");


            } while (!int.TryParse(Console.ReadLine(), out marks) || Marks < 0);


            Marks = marks;


            int rightAnswerID;

            do
            {
                Console.WriteLine("Please Enter The Right Answer id (1 For True | 2 For False) :");
            }
            while (!int.TryParse(Console.ReadLine(), out rightAnswerID) || rightAnswerID < 1 || rightAnswerID > 2);

            RightAnswer.AnswerId = rightAnswerID;
            RightAnswer.AnswerText = AnswerList[rightAnswerID - 1].AnswerText;


            Console.Clear();

        }
    }
}
