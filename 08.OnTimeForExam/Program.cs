namespace _08.OnTimeForExam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int exHour = int.Parse(Console.ReadLine());
            int exMin = int.Parse(Console.ReadLine());
            int arHour = int.Parse(Console.ReadLine());
            int arMin = int.Parse(Console.ReadLine());

            int arTotalM = arHour * 60 + arMin;
            int exTotalM = exHour * 60 + exMin;
            int diff = exTotalM - arTotalM;

            string status = "";
            string comparison = "";

            if (diff >= 0 && diff <= 30)
            {
                status = "On time";
                comparison = "before";
            }
            else if (diff < 0)
            {
                status = "Late";
                comparison = "after";
                diff = -diff;
            }
            else
            {
                status = "Early";
                comparison = "before";
            }

            int compHours = diff / 60;
            int compMin = diff % 60;

            Console.WriteLine(status);
            if (compHours > 0)
                Console.WriteLine($"{compHours}:{compMin:D2} hours {comparison} the start");
            else if (compMin > 0)
                Console.WriteLine($"{compMin} minutes {comparison} the start");
        }
    }
}