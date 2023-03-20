using Examination_Library.BaseQuestion;
using Examination_Library.BaseQuestion.QuestionTypes;


namespace Examination_Library.ExamTypes
{
    internal class Practical
    {
        public static List<MCQ> MCQuestionsList { get; set; }
        public static void ExamMaker(List<Awnser> _Awnsers, Awnser TrueAwnser, string QuestionHeader,string QuestionBody, int Mark)
        {
            MCQ ExamQuestions= new MCQ(_Awnsers, TrueAwnser, QuestionHeader, QuestionBody, Mark);
            MCQuestionsList.Add(ExamQuestions);
        }
    }
}
