using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShablMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var BigHouse = new BigHouse();
            var Cottege = new Cottege();
            var Smallhouse = new Smallhouse();
            BigHouse.BuildBuilding();
            Console.WriteLine("\nBighouse");

            Cottege.BuildBuilding();
            Console.WriteLine("\nCottege");

            Smallhouse.BuildBuilding();
            Console.WriteLine("\nSmallhouse");
            Console.ReadKey();
        }
    }
}