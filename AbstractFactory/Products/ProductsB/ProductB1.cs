using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Products
{
    class ProductB1 : IAbstractProductB
    {
        public string AnotherUsefulFunctionB(IAbstractProductA collaborator)
        {
            var result = collaborator.UseFulFunctionA();

            return $"The result of the B1 collaborating with the ({result})";
        }
        public string UseFulFunctionB()
        {
            return "The result of the product B1.";
        }
    }
}
