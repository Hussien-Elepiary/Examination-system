namespace Examination_Library.BaseQuestion.QuestionTypes
{
    internal class TrueOrFalse: MainQuestion
    {
        static public string RightAwnser { get; set; }

        public TrueOrFalse(string _RightAwnser, string _HeaderOfTheQuestion, string _BodyOfTheQuestion, int _Mark):base(_HeaderOfTheQuestion, _BodyOfTheQuestion,_Mark)
        {
            RightAwnser = _RightAwnser;
        }
    }
}
