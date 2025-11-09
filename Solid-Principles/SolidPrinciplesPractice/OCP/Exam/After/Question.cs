namespace SolidPrinciplesPractice.Exam.After
{
    public abstract class Question
    {
       public int Mark { get; set; }
       public string? Title { get; set; }
       public abstract void Print();
    }
}