using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyPattern.Interfaces.Behavioral;

namespace StrategyPattern.Classes.Behavioural.Bark
{
    class WildBark : IBarkBehaviour
    {
        void IBarkBehaviour.Bark()
        {
            Console.WriteLine("RAWWWWWRRRR-RAWWWWWRRRR!");
        }
    }
}
