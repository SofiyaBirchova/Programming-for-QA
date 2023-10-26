namespace _09.Graduation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int classNumber = 1;
            double totalGrades = 0;
            int expelled = 0;
            while (classNumber <= 12)
            {
                double grade = double.Parse(Console.ReadLine());
                if (grade < 4.00)
                {
                    expelled += 1;
                }
                if (expelled > 1)
                {
                    Console.WriteLine($"{name} has been excluded at {classNumber - 1} grade");
                    break;
                }
                totalGrades += grade;
                classNumber += 1;
            }
            double averageGrade = totalGrades / 12;
            if (expelled <= 1)
            {
                Console.WriteLine($"{name} graduated. Average grade: {averageGrade:F2}");
            }
        }
    }
}