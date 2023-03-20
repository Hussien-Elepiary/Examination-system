namespace Examination_Library.BaseQuestion
{
    internal class MainQuestion
    {
        static public string HeaderOfTheQuestion { get; set; }
        static public string BodyOfTheQuestion { get; set; }
        static public int Mark { get; set; }

        public MainQuestion(string _HeaderOfTheQuestion, string _BodyOfTheQuestion, int _Mark)
        {
            HeaderOfTheQuestion = _HeaderOfTheQuestion;
            BodyOfTheQuestion= _BodyOfTheQuestion;
            Mark = _Mark;
        }
    }
}
