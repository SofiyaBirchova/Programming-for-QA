namespace _09.Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string movieType = Console.ReadLine();
            int rowsCount = int.Parse(Console.ReadLine());
            int seatsCount = int.Parse(Console.ReadLine());

            int totalSeats = rowsCount * seatsCount;
            double totalSum = 0;

            if (movieType == "Premiere")
            {
                totalSum = totalSeats * 12.00;
            }
            else if (movieType == "Normal")
            {
                totalSum = totalSeats * 7.50;
            }
            else if (movieType == "Discount")
            {
                totalSum = totalSeats * 5.00;
            }
            Console.WriteLine($"{totalSum:F2}");
        }
    }
}