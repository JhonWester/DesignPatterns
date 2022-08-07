using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Products
{
    public class ProductA1: IAbstractProductA
    {

        public string UseFulFunctionA()
        {
            return "The result of the product A1.";
        }
    }
}
