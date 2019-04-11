using System;

namespace C_Sharp_Shakespeare
{
    class Program
    {
        static void Main(string[] args)
        {
            RandomInsultGenerator generator = new RandomInsultGenerator();
            Console.WriteLine("Welcome to the Shakespearean Insult Generator! \nFinding it difficult to adequately express your " + 
            "low opinion of someone?  What something creative on hand for the next time a family member annoys you? " + 
            " \nGet help from the Master of Insults, Shakespeare himself!\n");
            generator.Run();
            // string repeat = "";
            // do{
            // Console.WriteLine(generator.Start());
            // Console.WriteLine("\nWould you like to go again?  Type y for yes, or any other key to exit.");
            // repeat = Console.ReadLine();
            // } while(repeat == "y");
        }
    }
}
