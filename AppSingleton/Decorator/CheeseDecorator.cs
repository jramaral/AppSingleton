using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSingleton.Decorator
{
    public class CheeseDecorator : NoodleDecorator
    {
        public CheeseDecorator(INoodle noodle) : base(noodle)
        {
        }

        public override double GetPrice()
        {
            return decoratedNoodle.GetPrice() + 0.5;
        }

        public override string GetIngredients()
        {
            return decoratedNoodle.GetIngredients() + ", with cheese and bacon";
        }
    }
}
