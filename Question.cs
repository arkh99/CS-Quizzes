namespace Quizzes;

public class Question
{
  // properties
  public string Text { get; set; }
  public string Answer { get; set; }
  public string Category { get; set; }
  public string Difficulty { get; set; }

  // constructor
  public Question(string text, string answer, string category = "General", string difficulty = "Medium")
  {
    Text = text;
    Answer = answer;
    Category = category;
    Difficulty = difficulty;
  }

  // methods
  public bool CheckAnswer(string answer)
  {
    return Answer.Equals(answer.Trim(), StringComparison.OrdinalIgnoreCase);
  }
}
