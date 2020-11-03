using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine_H2
{
    public enum Flavor
    {
        Umami,
        Sour,
        Sweet,
        Bitter,
        Cool,
        Salty,
        Hot
    }

    abstract class Ingredient
    {
        private string ingredientName;

        public string IngredientName
        {
            get { return ingredientName; }
            protected set { ingredientName = value; }
        }

        private Flavor flavor;

        public Flavor Flavor
        {
            get { return flavor; }
            protected set { flavor = value; }
        }

        protected Ingredient(Flavor flavor)
        {
            Flavor = flavor;
        }
        protected Ingredient(string ingredientName, Flavor flavor) : this(flavor)
        {
            IngredientName = ingredientName;
        }
    }
}
