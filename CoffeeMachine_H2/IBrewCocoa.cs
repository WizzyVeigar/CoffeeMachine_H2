using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine_H2
{
    interface IBrewCocoa : IBrewHotWater
    {
        float CocoaPowderAmountMax { get; }
        float CocoaPowderAmountCurrent { get; }
        /// <summary>
        /// Brews the amount of cocoa you want
        /// </summary>
        /// <param name="cupsToMake"></param>
        /// <returns>Returns a string with the end result</returns>
        string BrewCocoa(int cupsToMake);
        /// <summary>
        /// tries to add the <paramref name="amountToAdd"/> to the <see cref="CocoaPowderAmountCurrent"/>
        /// </summary>
        /// <param name="amountToAdd"></param>
        /// <returns>Returns a string with the end result</returns>
        string AddCocoaPowder(float amountToAdd);
    }
}
