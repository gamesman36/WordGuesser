namespace WordGuesser
{
    internal class StringShuffler
    {
        private readonly Random random = new Random();
        public string shuffledString { get; private set; }

        public StringShuffler(string input)
        {
            ShuffleString(input);
        }
        
        public void ShuffleString(string input)
        {
            List<char> characters = new List<char>(input.ToCharArray());
            characters.Sort((a, b) => random.Next(-1, 2));

            shuffledString = new string(characters.ToArray());
        }
    }
}