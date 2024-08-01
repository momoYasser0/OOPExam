using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exam02.Questions;

namespace Exam02.Exams
{
    public abstract class Exam
    {

        public int TimeOfExam { get; set; }
        public int NumOfQuestions { get; set; }
        public Question[] ListOfQuestions { get; set; }
        protected Exam(int timeOfExam, int numOfQuestions)
        {
            TimeOfExam = timeOfExam;
            NumOfQuestions = numOfQuestions;
        }

        public abstract void CreateExam();
        public abstract void ShowExam();

    }
}
