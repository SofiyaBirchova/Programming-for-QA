namespace _08.SortedNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1 = double.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());
            double n3 = double.Parse(Console.ReadLine());

            if (n1 > n2 && n2 > n3)
            {
                Console.WriteLine("Descending");
            }
            else if (n1 < n2 && n2 < n3)
            {
                Console.WriteLine("Ascending");
            }
            else
                Console.WriteLine("Not sorted");
        }
    }
}