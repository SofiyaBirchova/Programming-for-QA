namespace _04.MandatoryLiterature
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalPages = int.Parse(Console.ReadLine()); 
            int pagesPerHour = int.Parse(Console.ReadLine());
            int daysReading = int.Parse(Console.ReadLine());

            int hoursForTheBook = totalPages / pagesPerHour;
            int hoursReadingPerDay = hoursForTheBook / daysReading;

            Console.WriteLine(hoursReadingPerDay);

        }
    }
}