public class MultipleChoises : Quiz
{
    List<MultipleChoises> Choices = new List<MultipleChoises>();
    public string choice;

    public MultipleChoises (string choice, string thequerytext) : base(thequerytext)
    {
        this.choice = choice;
    }

    /*public override void CreateQuestion()
    {
        Thequerytext = Console.ReadLine();
    }*/
   
}
public class YearQuestion : Quiz
{
    public int Year {get; set;}

        public YearQuestion(int year, string thequerytext) : base(thequerytext)
        {
            this.Year = year;
        }
}
public class TrueOrFalseQuestion : Quiz
{
    public bool IsTrue {get; set;}

    public TrueOrFalseQuestion(bool IsTrue, string thequerytext) : base(thequerytext)
    {
        this.IsTrue = IsTrue;
    }
    public override void CreateQuestion(List<Quiz> truequiz, out bool truefalse)
    {
        System.Console.WriteLine("enter the question text");
        string text = Console.ReadLine();
        System.Console.WriteLine("is this right or wrong ?");
        bool IsTrue = Console.ReadLine().ToLower() == "true";
        truefalse = IsTrue;

        TrueOrFalseQuestion question = new TrueOrFalseQuestion(IsTrue, text);
        truequiz.Add(question);
        System.Console.WriteLine("True or false question added");
        
    }
    
}
