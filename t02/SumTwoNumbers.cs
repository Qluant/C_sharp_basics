using System;

class SumTwoNumbers
{
    static void Main()
    {
        string? firstInput = Console.ReadLine();
        int firstNumber = int.Parse(firstInput!);

        string? secondInput = Console.ReadLine();
        int secondNumber = int.Parse(secondInput!);

        int sum = firstNumber + secondNumber;
        Console.WriteLine(sum);
    }
}
