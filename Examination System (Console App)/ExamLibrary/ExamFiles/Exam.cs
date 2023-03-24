using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamLibrary.ExamFiles
{
    public abstract class Exam
    {
        public int Timeofexam { get; }
        public int NumberofQuestions { get; set; }

        public Exam(int _NumberofQuestions)
        {
            NumberofQuestions = _NumberofQuestions;
        }

        public abstract void Create();
        public abstract void Show();
    }
}
