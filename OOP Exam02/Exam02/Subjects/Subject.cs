using Exam02.Exams;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam02.Subjects
{
    public class Subject
    {
        public Subject(int subjectID, string? subjectName)
        {
            SubjectName = subjectName;
            SubjectID = subjectID;
        }

        public string? SubjectName { get; set; }
        public int SubjectID { get; set; }
        public Exam SubjectExam { get; set; }
        public void CreateExam()
        {
            int ExamChoice, Time, QuestionsNum;
            do
            {
                Console.Write("Please Enter the type of Exam you want to create (1 for Practical and 2 for Final): ");
            } while (!int.TryParse(Console.ReadLine(), out ExamChoice) || ExamChoice < 1 || ExamChoice > 2);
            do
            {
                Console.WriteLine("Please Enter Time Of The Exam From (30 to 180 min):");
            }
            while (!int.TryParse(Console.ReadLine(), out Time) || Time < 30 || Time > 180);
            do
            {
                Console.WriteLine("Please Enter The Number of questions :");
            }
            while (!int.TryParse(Console.ReadLine(), out QuestionsNum) || QuestionsNum < 1);

            if (ExamChoice == 1)
            {
                SubjectExam = new PracticalExam(Time, QuestionsNum);

            }
            else if (ExamChoice == 2)
            {
                SubjectExam = new FinalExam(Time, QuestionsNum);
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
            Console.Clear();
            SubjectExam.CreateExam();

        }
    }
}
