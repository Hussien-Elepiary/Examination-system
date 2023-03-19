namespace Examination_Library
{
    internal interface Question
    {
        public string HeaderOfTheQuestion { get; set; }
        public string BodyOfTheQuestion { get; set; }
        public int Mark { get; set; }

    }
}
