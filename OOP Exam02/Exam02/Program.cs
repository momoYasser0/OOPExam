using Exam02.Questions;
using Exam02.Subjects;
using System.Diagnostics;

namespace Exam02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /// you need to declare subject object to create one type of exams

            #region Main
            Subject S01 = new Subject(10, "C#");
            S01.CreateExam();
            Console.Clear();
            Console.Write("Do You Want to start the exam (y|n): ");

            if (char.Parse(Console.ReadLine().ToLower()) == 'y')
            {
                Stopwatch Sw = new Stopwatch();
                Sw.Start();
                S01.SubjectExam.ShowExam();
                Console.WriteLine($"The Elapsed Time = {Sw.Elapsed}");
            }
            #endregion

        }
    }
}
