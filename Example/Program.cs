using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int caseSwitch = rnd.Next(1,4);

            switch (caseSwitch)
            {
                case 1:
                    Console.WriteLine("Case 1");
            }
        }
    }
}
