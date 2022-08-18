using System;

namespace _1.RandomizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] WORDS = Console.ReadLine().Split(' ');
            Random random = new Random();
            for (int i = 0; i < WORDS.Length; i++)
            {
                int nextRandom = random.Next(0, WORDS.Length);
                string currentWord = WORDS[i];
                WORDS[i] = WORDS[nextRandom];
                WORDS[nextRandom] = currentWord;
            }
            foreach (string word in WORDS)
            {
                Console.WriteLine(word);
            }
        }
    }
}
