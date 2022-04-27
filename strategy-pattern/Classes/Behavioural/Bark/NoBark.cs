using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyPattern.Interfaces.Behavioral;

namespace StrategyPattern.Classes.Behavioural.Bark
{
    class NoBark : IBarkBehaviour
    {
        void IBarkBehaviour.Bark()
        {
            Console.WriteLine("I can't bark, I'm just a toy silly!");
        }
    }
}
