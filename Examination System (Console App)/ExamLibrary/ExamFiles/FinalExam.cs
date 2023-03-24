using ExamLibrary.QuestionFiles;
using static ExamLibrary.Helpers.Helpers;

namespace ExamLibrary.ExamFiles
{
    internal class FinalExam : Exam
    {
        public QuestionBase[] Questions { get; set; }
        public FinalExam(int _NumberofQuestions) : base(_NumberofQuestions)
        {
            Questions = new QuestionBase[_NumberofQuestions];
        }
        public override void Create()
        {
            for (int i = 0; i < Questions.Length; i++)
            {
                int QuestionType;
                do
                {
                    Console.WriteLine("Enter Question Type Number (1- MCQ, 2- True or False)");
                } while (!int.TryParse(Console.ReadLine(), out QuestionType) || QuestionType > 2 || QuestionType < 0);

                Console.Clear();
                switch (QuestionType)
                {
                    case 1:
                        MCQMaker(i, Questions);
                        break;
                    case 2:
                        TrueFalseMaker(i, Questions);
                        break;
                }
                Console.Clear();
            }
            
        }

        public override void Show()
        {
            ShowExams(Questions);
        }
    }
}
