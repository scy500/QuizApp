List<Question> questions = new List<Question>
{
    new Question { Prompt = "What is the capital of Iceland?", Answer = "Reykjavik" },
    new Question { Prompt = "What is the capital of Norway?", Answer = "Oslo" },
    new Question { Prompt = "What do you call chinese characters used in the japanese writing system?", Answer = "Kanji" },
    new Question { Prompt = "What is the data type called to store integers?", Answer = "int" }
};

int score = 0;
string userAnswer;
bool isPlaying = true;

Console.WriteLine("Do you want to start the Quiz? Yes(y) or No(n)? \r\n  ");

while (isPlaying)
{
    if (Console.ReadLine() == "y")
    {
        Random random = new Random();
        int countRound = 0;
        int[] showedQuestions = new int[questions.Count];
        int randomNum = random.Next(0, 4);
        Console.WriteLine($"First question debug: {questions[0]}");

        while (countRound < questions.Count)
        { 
        for (int i = 0; i < questions.Count ; i++)
        {
                // Prüfe ob randomNum schon in showedQuestions ist
                while (showedQuestions.Contains(randomNum))
                {
                    randomNum = random.Next(0, 4);
                    Console.WriteLine($"Debug: randomNumber has been rerolled in while: {randomNum}" );
                    Console.WriteLine($"Debug: showedQuestions array contains {showedQuestions}");
                    Thread.Sleep(1000);
                }
               
            Console.WriteLine($"Round {i +1}! Current score: {score}");
            Console.WriteLine(questions[randomNum].Prompt);
            userAnswer = Console.ReadLine();
            countRound++;
            showedQuestions[i] = randomNum;
            Console.WriteLine($"Debug: Added {randomNum} to showedQuestions array");

            if (userAnswer.Trim().ToLower() == questions[randomNum].Answer.ToLower())
            {
                Console.WriteLine($"Correct! You gained a score point! \r\n ");
                score++;
            }
            else Console.WriteLine("Wrong!");
        }
        }
        Console.WriteLine($"\r\n -------------------- \r\n  The quiz is over! Your score is {score} out of 3!  \r\n  Closing now");
        isPlaying = false;
    }
    else Console.WriteLine("Let's play again next time! \r\n  Closing now");
    isPlaying = false;
}
public class Question
{
    public string Prompt { get; set; }
    public string Answer { get; set; }
}
