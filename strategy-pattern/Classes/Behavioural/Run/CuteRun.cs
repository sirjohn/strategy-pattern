using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyPattern.Interfaces.Behavioral;

namespace StrategyPattern.Classes.Behavioural.Run
{
    class CuteRun : IRunBehaviour
    {
        void IRunBehaviour.Run()
        {
            Console.WriteLine("I fell while running... :(");
        }
    }
}
