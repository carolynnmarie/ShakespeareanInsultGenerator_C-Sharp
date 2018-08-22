using System;

namespace C_Sharp_Shakespeare
{
    class Program
    {
        static void Main(string[] args)
        {
            RandomInsultGenerator generator = new RandomInsultGenerator();
            string repeat = "";
            do{
            Console.WriteLine("If you would like to create your own random Shakespearean insult, type random. If you would" +
            " like a classic Shakespearean insult, type classic");
            string answer = Console.ReadLine();
            Console.WriteLine("\n" + generator.pickRandomOrClassic(answer));
            Console.WriteLine("\nWould you like to go again?  Type y for yes, or any other key to exit.");
            repeat = Console.ReadLine();
            } while(repeat == "y");
        }
    }
}
