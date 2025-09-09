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

        public void ClearRoute()
        {
            this.route.Clear();
        }

        public int GetStopCount()
        {
            return this.route.Count;
        }

        public bool HasCity(string city)
        {
            if (string.IsNullOrWhiteSpace(city))
                return false;

            city = char.ToUpper(city[0]).ToString() + city.Substring(1);
            return this.route.Contains(city);
        }
        
        public void SortRoute()
        {
            this.route.Sort();
        }
    }

    internal class Program
    {
        static void Main()
        {
            Traveler traveler = new Traveler("Alice");
            traveler.AddCity("Warsaw");
            traveler.AddCity("Amsterdam");
            traveler.SortRoute();
            // Output: Amsterdam -> Warsaw
            Console.WriteLine(traveler.GetRoute());
        }
    }
}
