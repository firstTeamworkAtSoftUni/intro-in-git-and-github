//CONFIRMED from <KonstantinLukov>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle_area
{
    class Program
    {
        static void Main(string[] args)
        {   
            /* in the next two lines , we recieve rectangle width
            and height as floats */ 
            var width = float.Parse(Console.ReadLine()); 
            var height = float.Parse(Console.ReadLine());
            /* we calculate rectangle area*/
            var area = width * height;
            /* then we print the area result rounded to the 
            second digit after the float point */
            Console.Write("{0:F2}", area);
        }
    }
}
