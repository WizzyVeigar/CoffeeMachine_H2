using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine_H2
{
    interface IBrewCoffee : IBrewHotWater
    {
        float BeanAmountMax { get; }
        float BeanAmountCurrent { get; }

        string BrewCoffee(int cupsToMake);
        string AddCoffeeIngredient(float coffeeIngredient);
    }
}
