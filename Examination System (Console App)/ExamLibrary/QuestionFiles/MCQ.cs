using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamLibrary.QuestionFiles
{
    internal class MCQ : QuestionBase
    {
        public Anwsers[] Choises { get; set; }
        public int CorrectAwnserID { get; set; }

        public MCQ(Anwsers[] _Choises, int _CorrectAwnserID, string _Header, string _Body, int _mark) : base(_Header, _Body, _mark, 1)
        {
            Choises = _Choises;
            CorrectAwnserID = _CorrectAwnserID;
        }



        public override string ToString()
        {
            return $"{Header}\n {Body}\n {Choises[0]}\n {Choises[1]}\n {Choises[2]}";
        }
    }
}
