using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bowling.Classes
{
    public class Roll
    {
        private int pins;

        public int Pins { get => pins; }
        public Roll(int p)
        {
            pins = p;
        }
    }
}
