namespace ExamLibrary.QuestionFiles
{
    public class QuestionBase
    {
        public int QuestionType { get; set; }
        public string Header { get; set; }
        public string Body { get; set; }
        public int Mark { get; set; }



        public QuestionBase(string _Header, string _Body, int _mark)
        {
            Header = _Header;
            Body = _Body;
            Mark = _mark;
        }

        public QuestionBase(string _Header, string _Body, int _mark, int questionType)
        {
            Header = _Header;
            Body = _Body;
            Mark = _mark;
            QuestionType = questionType;
        }
    }
}
