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
        /// <summary>
        /// Brews the desired amount of coffee
        /// </summary>
        /// <param name="cupsToMake"></param>
        /// <returns>Returns a string with the end result</returns>
        string BrewCoffee(int cupsToMake);
        /// <summary>
        /// Adds <paramref name="coffeeIngredientAmount"/> units of coffeeingredient
        /// </summary>
        /// <param name="coffeeIngredientAmount"></param>
        /// <returns>Returns a string of the end result</returns>
        string AddCoffeeIngredient(float coffeeIngredientAmount);
    }
}
