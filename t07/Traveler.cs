using System;
using System.Collections.Generic;

namespace Travelling
{
    public class Traveler
    {
        private readonly string name;
        private string currentLocation = string.Empty;
        private readonly List<string> route;

        public Traveler(string name)
        {
            this.name = name;
            this.route = new List<string>();
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

        public void AddCity(string city)
        {
            if (string.IsNullOrWhiteSpace(city))
                return;

            city = char.ToUpper(city[0]) + city.Substring(1);
            this.route.Add(city);
        }

        public string GetRoute()
        {
            var parts = new List<string>();
            this.route.ForEach(c => parts.Add(c));
            return string.Join(" -> ", parts);
        }
        
        public override string ToString()
        {
            return $"Traveler: {this.name} | Location: {this.currentLocation} | Route: {GetRoute()}";
        }
    }

    internal class Program
    {
        static void Main()
        {
            Traveler traveler = new Traveler("Alice");
            traveler.SetLocation("Berlin");
            traveler.AddCity("Paris");
            traveler.AddCity("London");
            // Output: Traveler: Alice | Location: Berlin | Route: Paris -> London
            Console.WriteLine(traveler);
        }
    }
}
