namespace WordGuesser
{
    internal class Program
    {
        private static readonly Random random = new Random();

        static void Main(string[] args)
        {
            string[] testWords = { "indefatigable", "enlightened", "spectacular" };
            int randomValue = random.Next(testWords.Length);
            string testWord = testWords[randomValue];

            var shuffler = new StringShuffler(testWord);
            string shuffledWord = shuffler.shuffledString;

            var game = new Game(shuffledWord, testWord);
        }
    }
}