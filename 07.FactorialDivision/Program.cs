﻿int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());

static double FactorialCalculator(int number)
{
    double output = 1.0;

    for (int factorial = 1; factorial <= number; factorial++)
    {
        output = output * factorial;
    }

    return output;
}

double factorialOne = FactorialCalculator(num1);
double factorialTwo = FactorialCalculator(num2);

double sum = factorialOne / factorialTwo;

Console.WriteLine(sum);
