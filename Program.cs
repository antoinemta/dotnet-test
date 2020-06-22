using System;

namespace dotnet_test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose a game (enter 1, 2 or 3) :");
            bool accessGame = false;

            while (!accessGame)
            {
                string indexGame = Console.ReadLine();
                if (indexGame != "1" && indexGame != "2" && indexGame != "3")
                {
                    Console.WriteLine("Error, enter 1, 2 or 3 :");
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
