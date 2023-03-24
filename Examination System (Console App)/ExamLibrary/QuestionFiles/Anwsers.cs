namespace ExamLibrary.QuestionFiles
{
    sealed class Anwsers
    {
        public int id { get; set; }
        public string Anwser { get; set; }

        public Anwsers(int _id, string anwser)
        {
            id = _id;
            Anwser = anwser;
        }
        public override string ToString()
        {
            return $"{id}- {Anwser}";
        }
    }
}
