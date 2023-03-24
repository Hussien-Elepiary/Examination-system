using ExamLibrary.QuestionFiles;

namespace ExamLibrary.Helpers
{
    public static class Helpers
    {
        private static void QuestionCreator(string QuestionHeader, out QuestionBase question)
        {
            int Mark;
            do
            {
                Console.Write("Enter Question Mark: ");
            } while (!int.TryParse(Console.ReadLine(), out Mark) || Mark < 1);

            string QBody;
            do
            {
                Console.Write("Enter Your Question: ");
                QBody = Console.ReadLine() ?? "";
            } while (QBody is null || QBody == "");

            question = new QuestionBase(QuestionHeader, QBody, Mark);
        }
        public static void MCQMaker(int i, QuestionBase[] Questions)
        {
            Console.WriteLine($"Enter Your MCQ Question number {i + 1}");
            QuestionCreator("Choose the Correct Awnser", out QuestionBase question);

            Anwsers[] anwsers = new Anwsers[3];
            for (int j = 0; j < anwsers.Length; j++)
            {
                Console.Write($"Enter Answer Number {j + 1}: ");
                anwsers[j] = new Anwsers(j + 1, Console.ReadLine());
            }

            int CorrectAnwser;
            do
            {
                Console.Write("Enter Correct Awnser: ");
            } while (!int.TryParse(Console.ReadLine(), out CorrectAnwser) || CorrectAnwser < 1 || CorrectAnwser > 3);

            Questions[i] = new MCQ(anwsers, CorrectAnwser, question.Header, question.Body, question.Mark);
        }
        public static void TrueFalseMaker(int i, QuestionBase[] Questions)
        {
            Console.WriteLine($"Enter Your True Or False Question number {i + 1}");
            QuestionCreator("True Or False? (1) For True || (2) For False", out QuestionBase question);

            int CorrectAnwser;
            do
            {
                Console.Write("Enter Correct Awnser [(1) For True || (2) For False]: ");
            } while (!int.TryParse(Console.ReadLine(), out CorrectAnwser) || CorrectAnwser < 1 || CorrectAnwser > 2);

            Questions[i] = new TOFQuestion(CorrectAnwser, question.Header, question.Body, question.Mark);
        }
        public static void ShowExams(QuestionBase[] Questions)
        {
            int total = 0, ExamTotal = 0;
            if (Questions is not null)
            {
                for (int i = 0; i < Questions.Length; i++)
                {
                    ExamTotal += Questions[i].Mark;
                    Console.WriteLine(Questions[i]);
                    int Anwser;
                    do
                    {
                        Console.Write("Enter You Awnser: ");
                    } while (!int.TryParse(Console.ReadLine(), out Anwser) || Anwser < 0);

                    switch (Questions[i].QuestionType)
                    {
                        case 1:
                            MCQ MCQ = Questions[i] as MCQ;
                            if (MCQ != null)
                            {
                                ;
                                if (Anwser == MCQ.CorrectAwnserID)
                                {
                                    total += MCQ.Mark;
                                }
                            }
                            break;
                        case 2:
                            TOFQuestion TOF = Questions[i] as TOFQuestion;
                            if (TOF != null)
                            {
                                if (Anwser == TOF.CorrectAwnser)
                                { 
                                    total += TOF.Mark;
                                }
                            }
                            break;
                    }
                    Console.Clear();
                }
            }
            Console.WriteLine($"Your Total = {total} \nExam Total = {ExamTotal}");
        }
    }
}
