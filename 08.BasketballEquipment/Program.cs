namespace _08.BasketballEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int annualFee = int.Parse(Console.ReadLine());

            double sneakersPrice = annualFee * 0.6;
            double teamPrice = sneakersPrice * 0.8;
            double basketballPrice = teamPrice * 0.25;
            double accesoriesPrice = basketballPrice * 0.2;

            double totalBasketballCost = annualFee + sneakersPrice + teamPrice + basketballPrice + accesoriesPrice;

            Console.WriteLine(totalBasketballCost);
        }
    }
}