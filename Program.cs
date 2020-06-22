using System;

namespace dotnet_test
{
    class Program
    {
        static void Main(string[] args)
        {
            bool accessGame = false;

            while (!accessGame)
            {
                Console.WriteLine("Choose a game (enter 1, 2 or 3) :");
                string indexGame = Console.ReadLine();
                if (indexGame != "1" && indexGame != "2" && indexGame != "3")
                {
                    Console.WriteLine("An error occurred, you may have probably entered a wrong character.");
                }
                else
                {
                    Console.WriteLine("Ok");
                    accessGame = true;
                }
            }
        }
    }
}
