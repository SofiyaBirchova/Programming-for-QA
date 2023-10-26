namespace _08.PrimeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            for (int i = start; i <= end; i += 1)
            {
                bool isPrime = true;
                int divider = 2;

                while (divider < end)
                {
                    if (i == divider)
                    {
                        divider += 1;
                        continue;
                    }

                    if (i % divider == 0)
                    {
                        isPrime = false;
                        break;
                    }
                    divider += 1;
                }
                if (isPrime)
                {
                    Console.Write($"{i} ");
                }
            }
        }
    }
}