//CONFIRMED from <martingganev>
using System;

namespace Problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            var volume = int.Parse(Console.ReadLine());
            var energy = int.Parse(Console.ReadLine());
            var sugarContent = int.Parse(Console.ReadLine());
            /*We receive in the Console the name of the product -> string, the volume -> integer, the energy per 100gr. -> integer
            and the sugarContent per 100gr.-> integer. */

            var calories = (double)volume * energy / 100.0;
            var sugar = volume * sugarContent / 100.0;
            //Calculate the amount of calories and sugar..

            Console.WriteLine($"{volume}ml {name}:");
            Console.WriteLine($"{calories}kcal, {sugar}g sugars");
            //Print the results on the Console.

        }
    }
}
