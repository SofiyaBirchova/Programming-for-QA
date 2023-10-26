﻿namespace _06.Walking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int stepsGoal = 10000;
            int stepsToday = 0;
            string input;
            bool finished = false;

            while (!finished && stepsToday < stepsGoal)
            {
                input = Console.ReadLine();

                if (input == "Going home")
                {
                    finished = true;
                    input = Console.ReadLine();
                }
                stepsToday += int.Parse(input);
            }

            if (stepsToday < stepsGoal)
            {
                Console.WriteLine($"{stepsGoal - stepsToday} more steps to reach goal.");
            }
            else
            {
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{stepsToday - stepsGoal} steps over the goal!");
            }
        }
    }
}