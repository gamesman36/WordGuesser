namespace WordGuesser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string testWord = "indefatigable";
            var shuffler = new StringShuffler(testWord);
            Console.WriteLine(shuffler.shuffledString);
        }
    }
}
