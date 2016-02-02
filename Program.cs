using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualTester
{
    class Program
    {
        static void Main(string[] args)
        {
            Owner owner = new Owner();
            Safe safe = new Safe();
            JewelThief jewelThief = new JewelThief();
            Locksmith lockSmith = new Locksmith();
            jewelThief.OpenSafe(safe, owner);
            lockSmith.OpenSafe(safe, owner);

            Console.ReadKey();
        }
    }
}