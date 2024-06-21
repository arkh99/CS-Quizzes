namespace Quizzes;

public class Quiz
{
  // fields
  private List<Question> questions;

  // constructor
  public Quiz(List<Question> questions)
  {
    this.questions = questions;
  }

  // methods
  public void AddQuestion(string text, string answer, string category, string difficulty)
  {
    if (questions.Exists(question => question.Text == text))
    {
      throw new Exception("This question has already been added to the quiz.");
    }

    questions.Add(new Question(text, answer, category, difficulty));
  }

  public void Play()
  {
    if (questions.Count == 0)
    {
      throw new Exception("No questions in the quiz.");
    }

    var shuffled = Helper.Shuffle(questions);
    int score = 0;

    foreach (var question in shuffled)
    {
      Console.WriteLine($"\nCategory: {question.Category} | Difficulty: {question.Difficulty}");
      Console.WriteLine(question.Text);

      string? response = Console.ReadLine();
      while (string.IsNullOrWhiteSpace(response))
      {
        Console.WriteLine(question.Text);
        response = Console.ReadLine();
      }

      if (question.CheckAnswer(response))
      {
        Console.WriteLine("Correct!");
        score++;
      }
      else
      {
        Console.WriteLine($"Wrong! The correct answer is: {question.Answer}");
      }
    }

    Console.WriteLine($"You got {score} out of {questions.Count} correct.");
  }
}
