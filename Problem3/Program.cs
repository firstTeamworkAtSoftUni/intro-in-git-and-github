////CONFIRMED from <martingganev>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilesToKM
{
    class Program
    {
        static void Main(string[] args)
        {
            //We receive in the Console the number of miles -> float number.
            var miles = float.Parse(Console.ReadLine());
            var km = miles * 1.60934;
            //Calculate the number of kilometers.
            Console.WriteLine("{0:F2}", km);
            //Print on the Console the kilometers, rounded up to the second digit.
        }
    }
}
