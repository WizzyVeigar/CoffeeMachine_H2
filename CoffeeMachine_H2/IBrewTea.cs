using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine_H2
{
    interface IBrewTea : IBrewHotWater
    {
        /// <summary>
        /// Brews the desired amount of tea
        /// </summary>
        /// <param name="cupsToMake"></param>
        /// <returns>Returns a string with the end result</returns>
        string BrewTea(int cupsToMake);
    }
}
