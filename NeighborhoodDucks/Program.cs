using System.Collections.Generic;
using System;

namespace NeighborhoodDucks
{
    class Program
    {
        public static void PrintDucks(List<Duck> ducks)
        {
            foreach (Duck duck in ducks)
            {
                Console.WriteLine($"{duck.Size} inch {duck.Kind}");
            }
        }
        static void Main(string[] args)
        {
            List<Duck> ducks = new List<Duck>()
            {
                new Duck() { Kind = KindOfDuck.Mallard, Size = 17 },
                new Duck() { Kind = KindOfDuck.Moscovy, Size = 18 },
                new Duck() { Kind = KindOfDuck.Loon, Size = 14 },
                new Duck() { Kind = KindOfDuck.Moscovy, Size = 11 },
                new Duck() { Kind = KindOfDuck.Mallard, Size = 14 },
                new Duck() { Kind = KindOfDuck.Loon, Size = 13},
            };
            PrintDucks(ducks);
        }
    }
}
