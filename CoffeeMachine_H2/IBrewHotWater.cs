using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine_H2
{
    interface IBrewHotWater
    {
        float WaterAmountCurrent { get; }
        float WaterAmountMax { get; }
        /// <summary>
        /// Adds <paramref name="amountToAdd"/> of units to <see cref="WaterAmountCurrent"/>
        /// </summary>
        /// <param name="amountToAdd"></param>
        /// <returns>Returns a string of the end result</returns>
        string AddWater(float amountToAdd);
    }
}
