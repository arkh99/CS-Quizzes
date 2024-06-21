using Quizzes;

internal class Program
{
  private static Quiz quiz = new Quiz(Helper.GetAvailableQuestions());

  private enum Action
  {
    Add = 1,
    Play,
    Exit
  }

  private static void Main(string[] args)
  {
    bool isActive = true;

    while (isActive)
    {
      Console.WriteLine("\nQuiz Application");
      Console.WriteLine("1. Add Question");
      Console.WriteLine("2. Play Quiz");
      Console.WriteLine("3. Exit");
      Console.Write("Enter an action: ");

      bool isValid = int.TryParse(Console.ReadLine(), out int action);

      switch ((Action)action)
      {
        case Action.Add:
          Add();
          break;
        case Action.Play:
          Play();
          break;
        case Action.Exit:
          isActive = false;
          break;
        default:
          Console.WriteLine("Not a valid response.");
          break;
      }
    }
  }

  private static void Add()
  {
    string text = GetInput("Enter the question: ");
    string answer = GetInput("Enter the answer: ");
    string category = GetInput("Enter the category: ");
    string difficulty = GetInput("Enter the difficulty (Easy, Medium, Hard): ");

    try
    {
      quiz.AddQuestion(text, answer, category, difficulty);
      Console.WriteLine("Question added successfully.");
    }
    catch (Exception e)
    {
      Console.WriteLine(e.Message);
    }
  }

  private static void Play()
  {
    try
    {
      quiz.Play();
    }
    catch (Exception e)
    {
      Console.WriteLine(e.Message);
    }
  }

  private static string GetInput(string prompt)
  {
    Console.Write(prompt);
    string? input = Console.ReadLine();
    while (string.IsNullOrWhiteSpace(input))
    {
      Console.Write(prompt);
      input = Console.ReadLine();
    }
    return input;
  }
}
