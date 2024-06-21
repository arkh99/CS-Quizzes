# CS-Quizzes
Welcome to the Quiz Application! This project is a simple console-based quiz game where users can add questions and play a quiz to test their knowledge. Below are the key points and features of the project.

Key Features
Add Questions: Users can add new questions to the quiz. Each question has a text prompt and an answer.
Play Quiz: Users can play the quiz, where they will be asked the questions in a random order, and their answers will be checked for correctness.
Check Answers: The program provides immediate feedback on whether the user's answer is correct or incorrect.
Score Display: At the end of the quiz, the user is given a score based on the number of correct answers.
Project Structure
The project consists of three main files:

1. question.cs
Defines the Question class with properties and methods to handle quiz questions.

Properties:

Text: The text of the question.
Answer: The answer to the question.
Methods:

CheckAnswer(string answer): Checks if the provided answer is correct, ignoring case and leading/trailing whitespace.
2. program.cs
Contains the Main method and handles user interaction through the console.

Main Method:

Displays a menu for users to choose actions: Add Question, Play Quiz, or Exit.
Calls respective methods based on user input.
Methods:

Add(): Prompts the user to enter a question and an answer, then adds it to the quiz.
Play(): Starts the quiz, asking questions and checking answers, then displays the user's score.
3. quiz.cs
Defines the Quiz class that manages the collection of questions and the gameplay logic.

Fields:

questions: A list of Question objects.
Constructor:

Quiz(List<Question> questions): Initializes the quiz with a list of questions.
Methods:

AddQuestion(string text, string answer): Adds a new question to the quiz, ensuring no duplicates.
Play(): Shuffles the questions, asks each one, checks the answers, and calculates the score.
Usage
Add Questions:

Choose option 1 to add a question.
Enter the question text and the correct answer when prompted.
Play Quiz:

Choose option 2 to start the quiz.
Answer each question as it appears.
At the end, the application will display your score.
Exit:

Choose option 3 to exit the application.
