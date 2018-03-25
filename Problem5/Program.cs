//CONFIRMED from <martingganev>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterStats
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            var health = int.Parse(Console.ReadLine());
            var FullHealth = int.Parse(Console.ReadLine());
            var energy = int.Parse(Console.ReadLine());
            var fullEnergy = int.Parse(Console.ReadLine());
            //We receive in the Console name -> string, current health -> integer,maximum health -> integer,current energy -> integer and maximum energy -> integer.

            Console.WriteLine($"Name: {name}");
            Console.WriteLine("Health: {0}{1}{2}{3}",new string('|',1),new string('|', health), new string('.', FullHealth-health), new string('|', 1));
            Console.WriteLine("Energy: {0}{1}{2}{3}", new string('|', 1), new string('|', energy), new string('.', fullEnergy - energy), new string('|', 1));
            //We print on the console the name and the corresponding health and energy, using | ..
        }
    }
}
