using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamLibrary.ExamFiles;

namespace ExamLibrary
{
    public class supject
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public  Exam subjectExam { get; set; }
        public supject(int _ID,string _Name)
        {
            ID = _ID;
            Name = _Name;
        }

        public void CreateExam()
        {
            int ExamType;
            do
            {
                Console.Write("1 - Practical | 2 - Final: ");
            } while (!int.TryParse(Console.ReadLine(),out ExamType) || ExamType < 0 || ExamType > 2);

            int QNumbers;
            do
            {
                Console.Write("How many Questions Do You want?  ");
            } while (!int.TryParse(Console.ReadLine(), out QNumbers) || QNumbers < 0);

            Console.Clear();
            switch (ExamType)
            {
                case 1:
                    subjectExam = new Practical(QNumbers);
                    subjectExam.Create();
                    break;
                case 2:
                    subjectExam = new FinalExam(QNumbers);
                    subjectExam.Create();
                    break;
            }
        }
    }
}
