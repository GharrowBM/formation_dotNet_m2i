using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bowling.Classes
{
    public interface IGenerator
    {
        int RandomPins(int max);
    }
}
