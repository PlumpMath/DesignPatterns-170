﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Patterns.FactoryMethod.Abstract;
using Patterns.FactoryMethod.Products;

namespace Patterns.FactoryMethod.Products
{
    public class CarFactoryF : AbsCarFactory
    {
        public CarFactoryF(string factoryName)
        {
            this.FactoryName = factoryName;
        }

        public override Products.Car BuildCar()
        {
            return new CarF();
        }
    }
}
