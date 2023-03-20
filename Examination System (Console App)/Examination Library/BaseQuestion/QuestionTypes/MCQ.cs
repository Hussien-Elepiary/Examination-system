using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_Library.BaseQuestion.QuestionTypes
{
    internal class MCQ: MainQuestion
    {
        static List<Awnser> Choices { get; set; }
        static Awnser TrueAwnser { get; set; }

        public MCQ(List<Awnser> _Choices, Awnser _TrueAwnser, string _HeaderOfTheQuestion, string _BodyOfTheQuestion, int _Mark):base(_HeaderOfTheQuestion, _BodyOfTheQuestion, _Mark)
        {
            Choices = _Choices;
            TrueAwnser = _TrueAwnser;
        }
    }
}
