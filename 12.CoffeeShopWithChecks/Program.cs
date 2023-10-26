namespace _12.CoffeeShopWithChecks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string order = Console.ReadLine();
            string extra = Console.ReadLine();
            double price = 0;
            bool orderValid = true;

            if (order == "coffee")
            {
                price = 1.00;
            }
            else if (order == "tea")
            {
                price = 0.60;
            }
            else
            {
                Console.WriteLine("Unknown drink");
                orderValid = false;               
            }
            if (orderValid)
            {
                if (extra == "sugar")
                {
                    price = price + 0.40;
                }
                else if (extra == "no")
                {
                    price = price + 0.00;
                }
                else
                {
                    Console.WriteLine("Unknown extra");
                    orderValid = false;
                }
            }
            if (orderValid)
            {
                Console.WriteLine($"Final price: ${price:F2}");
            }                                
        }
    }
}