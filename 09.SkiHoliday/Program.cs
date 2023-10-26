namespace _09.SkiHoliday
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string assesment = Console.ReadLine();

            double nightPrice = 0;

            switch (type)
            {
                case "room for one person":
                    nightPrice = 118;
                    break;
                case "apartment":
                    nightPrice = 155;
                    if (days < 10)
                    {
                        nightPrice *= 0.7;
                    }
                    else if (days >= 10 && days <= 15)
                    {
                        nightPrice *= 0.65;
                    }
                    else if (days > 15) 
                    {
                        nightPrice *= 0.5;
                    }
                    break;
                case "president apartment":
                    nightPrice = 235;
                    if (days < 10)
                    {
                        nightPrice *= 0.9;
                    }
                    else if (days >= 10 && days <= 15)
                    {
                        nightPrice *= 0.85;
                    }
                    else if (days > 15)
                    {
                        nightPrice *= 0.8;
                    }
                    break;
            }
            double totalStayPrice = (days -1) * nightPrice;

            switch(assesment)
            {
                case "positive": totalStayPrice *= 1.25; break;
                case "negative": totalStayPrice *= 0.9; break;
            }
            Console.WriteLine("{0:f2}", totalStayPrice);
        }
    }
}