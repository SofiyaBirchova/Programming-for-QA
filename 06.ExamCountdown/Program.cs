namespace _06.ExamCountdown
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int day = int.Parse(Console.ReadLine());

            for (int i = day; i > 0; i -= 1)
            {
                Console.WriteLine($"{i} days before the exam");
            }
            Console.WriteLine("The exam has come");
        }
    }
}