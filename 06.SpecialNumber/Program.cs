namespace _06.SpecialNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            bool isSpecial = true;
            int startNum = num;

            while (num > 0)
            {
                int lastDigit = num % 10;
                if (startNum % lastDigit != 0 )
                {
                    isSpecial = false;
                    break;
                }
                num = num / 10;
            }
            if (isSpecial == true)
            {
                Console.WriteLine(startNum + " is special");
            }
            else
            {
                Console.WriteLine(startNum + " is not special");
            }
        }
    }
}