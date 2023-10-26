namespace _07.HotelRoom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            double studioPrice = 0;
            double appPrice = 0;

            switch (month)
            {
                case "May":
                case "October":
                    studioPrice = 50;
                    appPrice = 65;
                    break;

                case "June":
                case "September":
                    studioPrice = 75.20;
                    appPrice = 68.70;
                    break;

                case "July":
                case "August":
                    studioPrice = 76;
                    appPrice = 77;
                    break;
            }
            double studioTotal = studioPrice * nights;
            double appTotal = appPrice * nights;

            if (nights > 14)
            {
                if (month == "May" || month == "October")
                {
                    studioTotal = studioTotal * 0.7;
                } else if ( month == "June" || month == "September")
                {
                    studioTotal = studioTotal * 0.8;
                }
                    appTotal *= 0.9;
            }
            else if ( nights > 7)
            {
                if (month == "May" || month == "October")
                {
                    studioTotal = studioTotal * 0.95;
                }
            }
            Console.WriteLine($"Apartment: {appTotal:f2} lv.");
            Console.WriteLine($"Studio: {studioTotal:f2} lv.");
        }
    }
}