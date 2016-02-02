using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualTester
{
    class JewelThief : Locksmith
    {
        private Jewels _stolenJewels = null;

        public new void ReturnContents(Jewels safeContents, Owner owner)
        {
            _stolenJewels = safeContents;
            Console.WriteLine("Im stealing the contents! " + _stolenJewels.Sparkle());
        }


    }
}
