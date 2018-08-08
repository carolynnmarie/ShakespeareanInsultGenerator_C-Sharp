using System;

namespace C_Sharp_Shakespeare
{
    class Program
    {
        static void Main(string[] args)
        {
            RandomInsultGenerator generator = new RandomInsultGenerator();
            Console.WriteLine("If you would like to create your own random Shakespearean insult, type random. If you would" +
            " like a classic Shakespearean insult, type classic");
            string answer = Console.ReadLine();
            Console.WriteLine(generator.pickRandomOrClassic(answer));
        }
    }
}
