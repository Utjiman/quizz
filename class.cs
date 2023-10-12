public class Quiz{

public string Thequerytext {get; set;}
public Quiz(string thequerytext)
{
    Thequerytext = thequerytext;
}




}

public class Stringanswer : Quiz
{
    public string correct {set; get;}
    public string thequerytext;

    public Stringanswer(string correct, string thequerytext) : base(thequerytext)
    {
        this.correct =correct;
    }

}
class YearQuestion : Quiz
{
    public int year {get; set;}
}

class MultipleChoises : Questions
{
    List<MultipleChoises> Choices = new List<MultipleChoises>();
    public string choice;
    //add funktion
    //ta bort funktion
}
class NumericQuestion : Questions
{
    //minValue
    //MaxValue
}
class TrueOrFalseQuestion : Questions
{
    public bool IsTrue {get; set;}
}
