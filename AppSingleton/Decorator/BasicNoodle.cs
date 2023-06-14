using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSingleton.Decorator
{
    public class BasicNoodle : INoodle
    {
        public string GetIngredients()
        {
            return "Noodles";
        }

        public double GetPrice()
        {
            return 1.0;
        }
    }
}
