using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSingleton.Decorator
{
    public class WhiteSauce : NoodleDecorator
    {
        public WhiteSauce(INoodle noodle) : base(noodle)
        {
        }

        public override string GetIngredients()
        {
            return decoratedNoodle.GetIngredients() + ", with bacon and white sauce";
        }

        public override double GetPrice()
        {
            return decoratedNoodle.GetPrice() + 0.2;
        }
    }
}
