using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyPattern.Interfaces;
using StrategyPattern.Interfaces.Behavioral;

namespace StrategyPattern.Classes
{
    class Dog : IDog
    {
        string _name;
        IRunBehaviour _run;
        IBarkBehaviour _bark;

        public Dog(string dogName, IRunBehaviour runBehaviour, IBarkBehaviour barkBehaviour)
        {
            this._name = dogName;
            this._run = runBehaviour;
            this._bark = barkBehaviour;
        }
        public string Name { get => _name; set => _name = value; }

        public void Bark()
        {
            this._bark.Bark();
        }

        public void Run()
        {
            this._run.Run();
        }

        public void Display()
        {
            Console.WriteLine("Hi! I'm {0} :=)", Name);
        }

       
    }
}
