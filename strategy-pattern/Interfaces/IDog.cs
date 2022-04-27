
using StrategyPattern.Interfaces.Behavioral;

namespace StrategyPattern.Interfaces
{
    interface IDog
    {
        string Name { get; set; }
        void Display();
        void Run();
        void Bark();

    }
}
