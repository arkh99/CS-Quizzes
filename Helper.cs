namespace Quizzes;

public class Helper
{
  public static List<Question> GetAvailableQuestions () {
    return [
      new Question("Who developed C#?", "Microsoft"),
      new Question("What keyword is used to create an object in C#?", "new"),
      new Question("What keyword is used to indicate that a method does not return a value in C#?", "void")
    ];
  }
  public static List<Question> Shuffle (List<Question> questions) {
    var random = new Random();
    for (int i = questions.Count - 1; i > 0; i--)
    {
        int j = random.Next(i + 1);
        var temp = questions[i];
        questions[i] = questions[j];
        questions[j] = temp;
    }

    return questions;
  }
}
