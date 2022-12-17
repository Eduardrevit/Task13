using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task13
{
    class Program
    {
        static void Main(string[] args)
        {
            Building Building = new Building("г. Ростов-на-Дону, Садовая, 40", 40, 20, 16);
            Console.WriteLine(Building.Print());
            MultiBuilding MultiBuilding = new MultiBuilding("г. Ростов-на-Дону, Кировский, 15", 50, 18, 12, -4);
            Console.WriteLine(MultiBuilding.Print());
            Console.ReadKey();
        }
    }
}
