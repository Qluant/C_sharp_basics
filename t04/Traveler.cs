using System;

namespace Travelling
{
    public class Traveler
    {
        private readonly string name;

        public Traveler(string name)
        {
            this.name = name;
        }
        public string GetName()
        {
            return this.name;
        }
    }

    internal class Program
    {
        static void Main()
        {
            Traveler traveler = new Traveler("Neo");
            Console.WriteLine(traveler.GetName());
        }
    }
}
