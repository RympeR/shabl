using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShablMethod
{
    class Cottege : Building
    {
        public override bool CustomerWantsBigger()
        {

            Console.WriteLine("Do you want Bigger Cottege?: ");
            var userInput = Console.ReadLine();
            return userInput.ToLower() == "yes" || userInput.ToLower() == "y";
        }
        public override string Foundament()
        {
            string f = @"_______________";
            f += "\n";
            f += "/               \\";
            f += "\n";
            return f;
        }
        public override string Floor(string floor, int n = 1)
        {
            string a = @"";
            for (int i = 0; i < n; i++)
            {
                a += @"|-------------|
|    |    |    |
|     ----     |
";
            }
            a += floor;
            a += "\n";
            return a;
        }
    }
}
