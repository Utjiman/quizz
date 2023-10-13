class MultipleChoises : Quiz
{
    List<MultipleChoises> Choices = new List<MultipleChoises>();
    public string choice;
    //add funktion
    //ta bort funktion
}
public class YearQuestion : Quiz
{
    public int year {get; set;}
}
class TrueOrFalseQuestion : Quiz
{
    public bool IsTrue {get; set;}
    public override void CreateQuestion()
    {
        Thequerytext = Console.ReadLine();
    }
}