using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyPattern.Interfaces.Behavioral;

namespace StrategyPattern.Classes.Behavioural.Run
{
    class NoRun : IRunBehaviour
    {
        void IRunBehaviour.Run()
        {
            Console.WriteLine("I can't run, I'm just a toy silly!");
        }
    }
}
