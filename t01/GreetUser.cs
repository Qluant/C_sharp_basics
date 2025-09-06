using System;

class GreetUser
{
    static void Main()
    {
        Console.Write("What is your name?\n");
        string? name = Console.ReadLine();

        Console.WriteLine($"Welcome, {name}!");
    }
}
