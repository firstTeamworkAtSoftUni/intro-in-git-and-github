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
            var width = float.Parse(Console.ReadLine());
            var height = float.Parse(Console.ReadLine());
            var area = width * height;

            Console.Write("{0:F2}", area);
        }
    }
}
