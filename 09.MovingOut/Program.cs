namespace _09.MovingOut
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            int volume = width * length * height;

            while (volume >= 0)
            {
                string input = Console.ReadLine();
                if (input == "Done")
                    break;
                volume -= int.Parse(input);
            }

            if (volume >= 0)
                Console.WriteLine($"{volume} Cubic meters left.");
            else
                Console.WriteLine($"No more free space! You need {-volume} Cubic meters more.");
        }
    }
}