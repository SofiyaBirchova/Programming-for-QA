namespace _07.LatinLetters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());

            for (char i = first; i <= second; i++)
            {
                Console.Write(i + " ");
            }
        }
    }
}