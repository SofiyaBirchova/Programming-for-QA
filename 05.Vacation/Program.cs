namespace _05.Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double neededMoney = double.Parse(Console.ReadLine());
            double ownedMoney = double.Parse(Console.ReadLine());
            int daysCounter = 0;
            int spendingCounter = 0;

            while (ownedMoney < neededMoney && spendingCounter < 5)
            {
                daysCounter++;
                String type = Console.ReadLine();
                double amount = double.Parse(Console.ReadLine());
                
                if (type == "spend")
                {
                    ownedMoney -= amount;
                    if (ownedMoney < 0)
                        ownedMoney = 0;
                    spendingCounter++;
                }
                else
                {
                    ownedMoney += amount;
                    spendingCounter = 0;
                }
            }
            if (spendingCounter >= 5)
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine(daysCounter);
            }
            else if (ownedMoney >= neededMoney)
            {
                Console.WriteLine($"You saved the money for {daysCounter} days.");
            }
        }
    }
}