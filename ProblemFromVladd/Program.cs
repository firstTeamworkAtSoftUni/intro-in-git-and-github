//CONFIRMED from <martingganev>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01
{
    class Program
    {
        static void Main(string[] args)
        {
            //We receive from the Console the number of inputs -> integer value and density -> double value.
            int n = int.Parse(Console.ReadLine());
            double density = double.Parse(Console.ReadLine());
            double sum = 0.0;

            for (int i = 0; i < n; i++)
            {
                double[] nums = Console.ReadLine().Split().Select(double.Parse).ToArray();

                double raindropsCount = nums[0];
                double squareMeters = nums[1];
                //We receive input from the Console as raindropsCount -> double and squareMeters -> double.
                sum += raindropsCount / squareMeters;
                //We calculate the sum..
            }

            if (sum != 0 && density != 0)
            {
                double totalSum = sum / density;
                Console.WriteLine("{0:f3}", totalSum);
                //Calculate the totalSum and print it on the Console.
            }
            else
            {
                Console.WriteLine("{0:f3}", sum);
                //Print the sum on the Console.
            }
        }
    }
}
