using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02.Questions
{
    public abstract class Question
    {

        public abstract string? HeaderOfQuestion { get; }
        public string? BodyOfQuestion { get; set; }
        public int Marks { get; set; }
        public Answer[] AnswerList { get; set; }
        public Answer RightAnswer { get; set; }
        public Answer UserAnswer { get; set; }

        public Question()
        {
            RightAnswer = new Answer();
            UserAnswer = new Answer();
        }

        public abstract void ShowQuestion();
        public override string ToString()
        {
            return $"{HeaderOfQuestion} \t Marks: {Marks} \n ------------ \n {BodyOfQuestion} \n";
        }


    }
}
