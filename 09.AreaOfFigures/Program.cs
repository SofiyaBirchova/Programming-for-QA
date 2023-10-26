namespace _09.AreaOfFigures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            double area = 0;

            if (figure == "square")
            {
                double a = double.Parse(Console.ReadLine());
                area = a * a;
                Console.WriteLine($"{area:F2}");
            }
            else if (figure == "rectangle")
            {
                double w = double.Parse(Console.ReadLine());
                double h = double.Parse(Console.ReadLine());    
                area = w * h;
                Console.WriteLine($"{area:F2}");
            }
            else if (figure == "circle")
            {
                double r = double.Parse(Console.ReadLine());
                area = Math.PI * r * r;
                Console.WriteLine($"{area:F2}");
            }
            else
            {
                Console.WriteLine("Invalid figure.");
            }
        }
    }
}