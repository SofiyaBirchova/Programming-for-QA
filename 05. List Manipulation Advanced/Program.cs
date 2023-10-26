List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
string command = Console.ReadLine();

while (command != "end")
{
    string[] commandParts = command.Split(" ");
    string commandName = commandParts[0];

    if (commandName == "Contains")
    {
        if (numbers.Contains(int.Parse(commandParts[1])))
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No such number");
        }
    }
    else if (commandName == "PrintEven")
    {
        Console.WriteLine(string.Join(" ", numbers.Where(number => number % 2 == 0)));
    }
    else if (commandName == "PrintOdd")
    {
        Console.WriteLine(string.Join(" ", numbers.Where(number => number % 2 != 0)));
    }
    else if (commandName == "GetSum")
    {
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine(string.Join(" ", sum));
    }
    else if (commandName == "Filter")
    {
        string condition = commandParts[1];
        int num = int.Parse(commandParts[2]);

        switch (condition)
        {
            case "<":
                Console.WriteLine(string.Join(" ", numbers.Where(n => n < num)));
                break;
            case ">":
                Console.WriteLine(string.Join(" ", numbers.Where(n => n > num)));
                break;
            case "<=":
                Console.WriteLine(string.Join(" ", numbers.Where(n => n <= num)));
                break;
            case ">=":
                Console.WriteLine(string.Join(" ", numbers.Where(n => n >= num)));
                break;
        }
    }
    command = Console.ReadLine();
}
Console.WriteLine(string.Join(" ", numbers));