using ExamLibrary;
using System.Diagnostics;

namespace Examination_System
{
    internal class Program
    {
        static void Main()
        {
            supject C = new supject(10,"C#");
            C.CreateExam();
            char Awnser;
            do
            {
                Console.WriteLine("Do You Want to Start The Exam(Y/N)");
            } while (!char.TryParse(Console.ReadLine(),out Awnser));

            if (Awnser == 'Y')
            {
                Stopwatch sw = Stopwatch.StartNew();
                C.subjectExam.Show();
                Console.WriteLine($"The Elapsed Time = {sw.Elapsed}");
            }
        }
    }
}