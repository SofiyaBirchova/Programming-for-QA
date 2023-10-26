namespace _05.TeachingMaterials
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int penPacs = int.Parse(Console.ReadLine());
            int markerPacs = int.Parse(Console.ReadLine());
            int boardCleanerLiters = int.Parse(Console.ReadLine());
            int discount = int.Parse(Console.ReadLine());

            double pensPrice = 5.80 * penPacs;
            double markersPrice = 7.20 * markerPacs;
            double boardCleanerPrice = 1.20 * boardCleanerLiters;
            double totalPrice = pensPrice + markersPrice + boardCleanerPrice;
            double discountAmount = totalPrice * discount / 100;
            double neededMoney = totalPrice - discountAmount;

            Console.WriteLine(neededMoney);
        }
    }
}