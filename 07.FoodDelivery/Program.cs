namespace _07.FoodDelivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int chickenMenus = int.Parse(Console.ReadLine());
            int fishMenus = int.Parse(Console.ReadLine());
            int vegetarianMenus = int.Parse(Console.ReadLine());

            double chickenPrice = chickenMenus * 10.35;
            double fishPrice = fishMenus * 12.40;
            double veganPrice = vegetarianMenus * 8.15;

            double totalMenusPrice = chickenPrice + fishPrice + veganPrice;
            double dessertPrice = totalMenusPrice * 0.2;

            double grandTotal = totalMenusPrice + dessertPrice + 2.50;

            Console.WriteLine(grandTotal);
            
        }
    }
}