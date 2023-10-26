namespace _05.VacationExpenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            string accType = Console.ReadLine();
            int daysCount = int.Parse(Console.ReadLine());

            double finalPrice = 0;

            if (season == "Spring")
            {
                if (accType == "Hotel")
                {
                    finalPrice = daysCount * 30;
                }
                else if (accType == "Camping")
                {
                    finalPrice = daysCount * 10;
                }
                finalPrice *= 1 - 0.20;
            }
            else if (season == "Summer")
            {
                if (accType == "Hotel")
                {
                    finalPrice = daysCount * 50;
                }
                else if (accType == "Camping")
                {
                    finalPrice = daysCount * 30;
                }
            }
            else if (season == "Autumn")
            {
                if (accType == "Hotel")
                {
                    finalPrice = daysCount * 20;
                }
                else if (accType == "Camping")
                {
                    finalPrice = daysCount * 15;
                }
                finalPrice *= 1 - 0.30;
            }
            if (season == "Winter")
            {
                if (accType == "Hotel")
                {
                    finalPrice = daysCount * 40;
                }
                else if (accType == "Camping")
                {
                    finalPrice = daysCount * 10;
                }
                finalPrice *= 1 - 0.10;
            }
            Console.WriteLine($"{finalPrice:f2}");
        }
    }
}