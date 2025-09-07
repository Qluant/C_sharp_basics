using System;

namespace Travelling
{
    public class Traveler
    {
        private readonly string name;
        private string currentLocation = string.Empty;

        public Traveler(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return this.name;
        }

        public void SetLocation(string location)
        {
            if (string.IsNullOrWhiteSpace(location))
                return;

            this.currentLocation = char.ToUpper(location[0]).ToString() + location.Substring(1);
        }

        public string GetLocation()
        {
            return this.currentLocation;
        }
    }

    internal class Program
    {
        static void Main()
        {
            Traveler traveler = new Traveler("Alice");
            traveler.SetLocation("berlin");
            Console.WriteLine(traveler.GetLocation());
        }
    }
}
