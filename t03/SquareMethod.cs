using System;

namespace SquareNamespace
{
    public class SquareClass
    {
        public static int Square(int number)
        {
            return number * number;
        }

        public static void Main()
        {
            Console.WriteLine(Square(4));
        }
    }
}
