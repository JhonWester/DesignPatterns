using AbstractFactory.Interfaces;
using AbstractFactory.Products;
using AbstractFactory.Products.ProductsA;
using AbstractFactory.Products.ProductsB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.ConcreteFactories
{
    internal class ConcreteFactory2 : IAbstractFactory
    {
        public IAbstractProductA CreateProductA()
        {
            return new ProductA2();
        }

        public IAbstractProductB CreateProductB()
        {
            return new ProductB2();
        }
    }
}
