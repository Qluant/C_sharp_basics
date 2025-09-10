using System;
using System.Collections.Generic;

namespace Travelling
{
    public class Traveler : ICloneable
    {
        private readonly string name;
        private string currentLocation = string.Empty;
        private readonly List<string> route;

        public Traveler(string name)
        {
            this.name = name;
            this.route = new List<string>();
        }

        public static bool operator ==(Traveler a, Traveler b)
        {
            if (a is null || b is null)
                return false;

            return a.name == b.name && a.currentLocation == b.currentLocation;
        }

        public static bool operator !=(Traveler a, Traveler b)
        {
            return !(a == b);
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
                throw new ArgumentException("City name cannot be null or empty.", nameof(city));

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
        
        public bool RemoveCity(string city)
        {
            if (string.IsNullOrWhiteSpace(city))
                return false;

            city = char.ToUpper(city[0]).ToString() + city.Substring(1);
            return this.route.Remove(city);
        }
        
        public string GetNextStop()
        {
            if (this.route.Count == 0)
                return null;

            return this.route[0];
        }
        
        public string this[int index]
        {
            get { return this.route[index]; }
        }
        
        public object Clone()
        {
            Traveler copy = new Traveler(this.name);
            copy.currentLocation = this.currentLocation;

            this.route.ForEach(city => copy.route.Add(city));

            return copy;
        }
    }

    internal class Program
    {
        static void Main()
        {
            Traveler traveler1 = new Traveler("Alice");
            
            try
            {
                traveler1.AddCity("");
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid city!");
            }
        }
    }
}
