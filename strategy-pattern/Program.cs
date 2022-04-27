using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyPattern.Classes;
using StrategyPattern.Classes.Behavioural.Run;
using StrategyPattern.Classes.Behavioural.Bark;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Dog> dogs = new List<Dog>();

            Dog ToyDog = new Dog("Snoopy", new NoRun(), new NoBark());
            Dog BigDog = new Dog("Rocky", new WildRun(), new WildBark());
            Dog CuteDog = new Dog("Sugar", new CuteRun(), new CuteBark());
           
            dogs.Add(BigDog);
            dogs.Add(CuteDog);
            dogs.Add(ToyDog);

            foreach (Dog dog in dogs)
            {
                Console.WriteLine("\n{0}\n-------------------", dog.Name);
                Console.WriteLine("\n- Hey there!");
                dog.Display();
                Console.WriteLine("\n- Bark please!");
                dog.Bark();
                Console.WriteLine("\n- Run Forrest!");
                dog.Run();
            }
                
        }
    }
}
