namespace _06.Redecorating
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nylonAmount = int.Parse(Console.ReadLine());
            int paintLiters = int.Parse(Console.ReadLine());
            int thinnerLiters = int.Parse(Console.ReadLine());
            int craftsmenHours = int.Parse(Console.ReadLine());

            double nylonPrice = (nylonAmount + 2) * 1.50;
            double paintPrice = paintLiters * 1.1 * 14.50;
            double thinnerPrice = thinnerLiters * 5;

            double totalMats = nylonPrice + paintPrice + thinnerPrice + 0.40;

            double craftsmanHourPrice = totalMats * 0.3;
            double grandTotal = totalMats + craftsmanHourPrice * craftsmenHours;

            Console.WriteLine(grandTotal);
        }
    }
}