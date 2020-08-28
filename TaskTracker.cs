using System;

namespace TaskTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Story Number");
            int storyNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Tittle");
            string Tittle = Console.ReadLine();

            Console.WriteLine("Time");
            double Time = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Track: " + storyNum  + " " + Tittle + " " + Time);
 
            
        }
    }
}
