using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonDataLib
{
    public static class PersonDataLib
    {
        private static float height;
        private static float weight;
        public static float SetHeight()
        {
            Console.WriteLine("Enter Height In Meters");
            height = float.Parse(Console.ReadLine());
            return height;

        }
        public static float SetWeight()
        {
            Console.WriteLine("Enter Weight In Kilos");
            weight = float.Parse(Console.ReadLine());
            return weight;
        }
    }
}
