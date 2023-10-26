namespace _05.Journey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string destination = "";
            string vacationType = "";
            double cost = 0;

            if (budget <= 100)
            {
                destination = "Bulgaria";
                if (season == "summer")
                {
                    cost = budget * 0.3;
                    vacationType = "Camp";
                }
                else
                {
                    cost = budget * 0.7;
                    vacationType = "Hotel";
                }
            } else if (budget <= 1000)
            {
                destination = "Balkans";
                if(season == "summer")
                {
                    cost = budget * 0.4;
                    vacationType = "Camp";
                }
                else
                {
                    cost = budget * 0.8;
                    vacationType = "Hotel";
                }
            } else
            {
                destination = "Europe";
                cost = budget * 0.9;
                vacationType = "Hotel";
            }
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{vacationType} - {(cost):F2}");
        }
    }
}