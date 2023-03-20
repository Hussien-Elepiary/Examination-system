using Examination_Library.BaseQuestion;
using Examination_Library.BaseQuestion.QuestionTypes;


namespace Examination_Library.ExamTypes
{
    internal class FinalExam
    {
        public static List<MCQ> MCQuestionsList { get; set; }
        public static List<TrueOrFalse> TOFQuestions { get; set; }

        public static void MCQuestionMaker(List<Awnser> _Awnsers, Awnser TrueAwnser, string QuestionHeader, string QuestionBody, int Mark)
        {
            MCQ ExamQuestions = new MCQ(_Awnsers, TrueAwnser, QuestionHeader, QuestionBody, Mark);
            MCQuestionsList.Add(ExamQuestions);
        }
        public static void TOFQuestionMaker(string TrueAwnser, string QuestionHeader, string QuestionBody, int Mark)
        {
            TrueOrFalse TOFQuestion = new TrueOrFalse(TrueAwnser,QuestionHeader, QuestionBody, Mark);
            TOFQuestions.Add(TOFQuestion);
        }
    }
}
