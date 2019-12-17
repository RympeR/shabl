using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShablMethod
{
    class Smallhouse : Building
    {
        public override bool CustomerWantsBigger()
        {
            Console.ReadKey();
            return false;
        }
        public override string Foundament()
        {
            string f = @"_______________";
            f += "\n";
            return f;
        }
        public override string Floor(string floor, int n = 1)
        {
            string a = @"";
            for (int i = 0; i < n; i++)
            {
                a += @"|--------------|";
                a += "\n";
                a += "|    |\\||/|    |";
                a += "\n";
                a += "|     ----     |";
                a += "\n";
            }
            a += floor;
            a += "\n";
            return a;
        }
    }
}
