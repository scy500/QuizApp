string question 1 = "What is the capital of Island?";
string answer 1 = "Reykyavik";
string question 2 = "What is the capital of Norway?";
string answer 2 = "Oslo";
string question 3 = "What do you call chinese characters used in the japanese writing system?";
string answer 3 = "Kanji";
string question 4 = "What is the data type called to store integers?";
string answer 4 = "int";


int score = 0;

Console.WriteLine("Do you want to start the Quiz? Yes(y) or No(n)?");


if (Console.ReadLine() == "y")
{
    Console.WriteLine("Quiz is starting!");
}
else Console.WriteLine("Let's play next time!");