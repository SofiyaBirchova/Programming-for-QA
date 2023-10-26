
int num = int.Parse(Console.ReadLine());

for (int first = 2; first <= num; first += 2)
{
    for (int second = 1; second <= num; second += 2)
    {
        Console.Write($"{first}{second}{first * second} ");
    }
}
