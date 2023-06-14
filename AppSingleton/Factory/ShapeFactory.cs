using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSingleton.Factory
{
    public class ShapeFactory
    {
        public static IShape? GetShape(string shapeType) 
        {
            if (shapeType == "Circle") return new Circle();

            if (shapeType == "Square") { return new Square(); }

            return null;
        }
    }
}
