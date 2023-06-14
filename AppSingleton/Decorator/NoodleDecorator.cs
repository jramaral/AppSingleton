using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSingleton.Decorator
{
    public abstract class NoodleDecorator : INoodle
    {
        protected INoodle decoratedNoodle;

        public NoodleDecorator(INoodle noodle)
        {
            decoratedNoodle = noodle;
        }
        public virtual string GetIngredients()
        {
            return decoratedNoodle.GetIngredients();
        }

        public virtual double GetPrice()
        {
            return decoratedNoodle.GetPrice();
        }
    }
}
