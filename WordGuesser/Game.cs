internal class Game
{
    private bool isFinished;

    public Game(string shuffledWord, string solution)
    {
        isFinished = false;
        while (!isFinished)
        {
            Console.WriteLine($"Shuffled word: {shuffledWord}");

            Console.Write("Your guess: ");
            string userGuess = Console.ReadLine();

            if (userGuess == solution)
            {
                Console.WriteLine("Congratulations! You guessed correctly.");
                isFinished = true;
            }
            else
            {
                Console.WriteLine("Incorrect. Try again.");
            }
        }

        Console.WriteLine($"The correct word was: {solution}");
    }
}