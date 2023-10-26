namespace _05.SpecialNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine() ?? "1");

            for (int cn = 1111; cn <= 9999; cn++)
            {
                String cnDigits = cn.ToString();

                bool isSpecial = true; 

                for (int curDigit = 0; curDigit < cnDigits.Length; curDigit++)
                {
                    int curDigitNumber = int.Parse(cnDigits[curDigit].ToString()); 

                    if (curDigitNumber == 0 || number % curDigitNumber != 0)
                    {
                        isSpecial = false;
                        break; 
                    }
                }

                if (isSpecial)
                    Console.Write(cn + " ");
            }
        }
   } 
}