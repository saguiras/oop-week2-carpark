using System;
using System.Collections.Generic;

namespace carpark
{
    public class Custumers
    {
        public string name { get; set; }
        public float hours { get; set; }

        public Custumers(string _name, float _hours)
        {
            name = _name;
            hours = _hours;
        }
        public float calculateCharge(float _hours)
        {
            float charge = 2f;
            while (_hours > 3)
            {
                charge += 0.5f;
                _hours--;
            }
            return (charge > 10) ? 10 : charge;
        }

        public override string ToString()
        {
            return $"Name : {name} \n" +
                   $"hours : {hours} \n" +
                   $"Charge : {calculateCharge(hours)} \n";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Custumers> _Custumers = new List<Custumers>();

            _Custumers.Add(new Custumers("Marc", 2f));
            _Custumers.Add(new Custumers("Pierrickr", 20.5f));
            _Custumers.Add(new Custumers("Louis", 3f));
            _Custumers.Add(new Custumers("Chloe", 3.2f));

            foreach (Custumers custumer in _Custumers)
            {
                Console.WriteLine(custumer);
            }
        }
    }
}
