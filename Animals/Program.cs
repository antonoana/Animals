using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Animals.Animals;

namespace Animals
{
    class Program
    {
        private static List<Animal> animals;
        public static void Main(string[] args)
        {
            animals = new List<Animal>();
            animals.Add(new Lion());
            animals.Add(new Bird());
            animals.Add(new Fish());

            foreach (var animal in animals)
            {
                animal.Display();
            }

            Console.ReadKey();
        }
    }
}
