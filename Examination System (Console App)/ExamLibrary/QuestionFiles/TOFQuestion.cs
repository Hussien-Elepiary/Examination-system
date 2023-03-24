using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamLibrary.QuestionFiles
{
    internal class TOFQuestion : QuestionBase
    {
        public int CorrectAwnser { get; set; }
        public TOFQuestion(int _CorrectAwnser, string _Header, string _Body, int _mark) : base(_Header, _Body, _mark, 2)
        {
            CorrectAwnser = _CorrectAwnser;
        }

        public override string ToString()
        {
            return $"{Header}\n {Body}\n";
        }
    }
}
