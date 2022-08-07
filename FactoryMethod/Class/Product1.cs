using FactoryMethod.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Class
{
    class Product1 : IProduct
    {
        public string someOperation()
        {
            return "Result operation of product 1";
        }
    }
}
