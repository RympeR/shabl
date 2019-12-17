using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShablMethod
{
    abstract class Building
    {

        public void BuildBuilding()
        {
            string ff;
            string f = Foundament();

            if (CustomerWantsBigger())
            {
                int n = Convert.ToInt32(Console.ReadLine());
                ff = Floor(f, n);
            }
            else
                ff = Floor(f);
            string house = Roof(ff);
                
            
            TriangleRoof(house);
        }
        public virtual bool CustomerWantsBigger()
        {
            return true;
        }
        public abstract string Foundament();
        public abstract string Floor(string floor, int n = 1);

        public string Roof(string ff)
        {
            Console.Clear();
            return "__________" + "\n" + ff;
        }
        public void TriangleRoof(string house)
        {
            Console.Clear();
            Console.WriteLine("       /\\");
            Console.WriteLine("      /  \\");
            Console.WriteLine("     /    \\");
            Console.WriteLine("    /      \\");
            Console.WriteLine("   /        \\");
            Console.WriteLine("  /          \\");
            Console.WriteLine(" /            \\");
            Console.WriteLine("/              \\\n");
            Console.WriteLine(house);
        }
    }
}
