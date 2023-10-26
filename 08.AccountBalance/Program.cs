namespace _08.AccountBalance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double balance = 0;

            while (input != "End")
            {
                double amount = double.Parse(input);

                if (amount > 0)
                {
                    balance += amount;
                    Console.WriteLine($"Increase: {amount:F2}");
                }
                else if (amount < 0)
                {
                    balance -= Math.Abs(amount);
                    Console.WriteLine($"Decrease: {Math.Abs(amount):F2}");
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Balance: {balance:F2}");
        }
    }
}