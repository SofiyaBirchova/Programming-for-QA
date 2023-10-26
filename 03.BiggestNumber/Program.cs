namespace _03.BiggestNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countNum = int.Parse(Console.ReadLine());
            int maxNum = int.MinValue;

            for (int num = 1; num <= countNum; num++)
            {
                int value = int.Parse(Console.ReadLine());

                if (value > maxNum)
                {
                    maxNum = value;
                }
            }
            Console.WriteLine(maxNum);
        }
    }
}