namespace Examination_Library.BaseQuestion
{
    internal class Awnser
    {
        static public int ID { get; set; }
        static public string Text { get; set; }

        public Awnser(int iD, string text)
        {
            ID = iD;
            Text = text;
        }
    }
}
