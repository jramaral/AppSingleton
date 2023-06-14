﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppSingleton.Factory
{
    public class Square : IShape
    {
        public void Draw()
        {
            Console.WriteLine("I'm in the Draw method of class Square");
        }
    }
}
