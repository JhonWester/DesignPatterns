using FactoryMethod.Abstract;
using FactoryMethod.Concept;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Class
{
    class CreatorConcrete2 : Creator
    {
        public override IProduct FactoryMethod()
        {
            return new Product2();
        }
    }
}
