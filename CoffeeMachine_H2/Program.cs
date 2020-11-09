using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine_H2
{
    class Program
    {
        static void Main(string[] args)
        {
            AllInOneMachine aioMachine = new AllInOneMachine("PhillipsHueRGBLaserPointer365.X Version 2.1 PRO", 150,200, 150);
            Console.WriteLine(aioMachine.ChangePower());
            Console.WriteLine(aioMachine.AddWater(200));
            Console.WriteLine(aioMachine.AddCoffeeIngredient(100));
            Console.WriteLine(aioMachine.AddCocoaPowder(50));
            
            Console.WriteLine(aioMachine.BrewCoffee(5));
            Console.WriteLine(aioMachine.BrewTea(5));
            Console.WriteLine(aioMachine.BrewCocoa());
            Console.WriteLine(aioMachine.ToString());
            Console.ReadKey();
        }
    }
}
