using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Products.ProductsB
{
    internal class ProductB2 : IAbstractProductB
    {
        public string AnotherUsefulFunctionB(IAbstractProductA collaborator)
        {
            var result = collaborator.UseFulFunctionA();

            return $"The result of the B2 collaborating with the ({result})";
        }

        public string UseFulFunctionB()
        {
            return "The result of the product B2.";
        }
    }
}
