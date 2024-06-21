namespace Quizzes;

public class Question (string text, string answer)
{
  // properties
  public string Text { get; set; } = text;
  public string Answer { get; set; } = answer;
 
  // Methods
  public bool CheckAnswer (string answer) {
    return Answer.ToLower() == answer.Trim().ToLower();
  } 
}
