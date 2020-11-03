using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine_H2
{
    class Water : Ingredient
    {
        public Water(Flavor flavor) : base(flavor)
        {
            IngredientName = "Water";
        }
    }
}
