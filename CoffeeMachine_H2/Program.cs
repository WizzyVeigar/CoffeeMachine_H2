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
            CoffeeMachine coffee = new CoffeeMachine("PhillipsHueRGBLaserPointer365.X", 50,100);
            Console.WriteLine(coffee.ChangePower());
            Console.WriteLine(coffee.AddWater(60));
            Console.WriteLine(coffee.AddCoffeeIngredient(50));
            Console.WriteLine(coffee.BrewCoffee(5));
            Console.ReadKey();
        }
    }
}
