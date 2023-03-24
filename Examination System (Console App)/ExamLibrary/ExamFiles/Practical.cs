using ExamLibrary.QuestionFiles;
using static ExamLibrary.Helpers.Helpers;

namespace ExamLibrary.ExamFiles
{
    internal class Practical : Exam
    {
        public MCQ[] Mcq { get; set; }
        public Practical(int _NumberofQuestions) : base(_NumberofQuestions)
        {
            Mcq = new MCQ[_NumberofQuestions];
        }

        public override void Create()
        {
            for (int i = 0; i < Mcq.Length; i++)
            {
                MCQMaker(i, Mcq);
                Console.Clear();
            }
        }

        public override void Show()
        {
            ShowExams(Mcq);
        }
    }
}
