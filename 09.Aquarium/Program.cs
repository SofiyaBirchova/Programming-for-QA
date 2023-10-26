using System.Runtime.InteropServices;

namespace _09.Aquarium
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var lenght = int.Parse(Console.ReadLine());
            var width = int.Parse(Console.ReadLine());
            var height = int.Parse(Console.ReadLine()); 
            var percentage = double.Parse(Console.ReadLine());
            var volume = lenght * width * height * 0.001;
            var space = percentage / 100;

            Console.WriteLine($"{volume * (1  - space):F2}");
        }
    }
}