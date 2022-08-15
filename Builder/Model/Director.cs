using Builder.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#nullable disable

namespace Builder.Model
{
    internal class Director
    {
        private IBuilder builder;

        public IBuilder Builder { get => builder; set => builder = value; }

        public void BuildMinimalVariableProduct()
        {
            this.builder.BuildPartA();
        }

        public void BuildFullProduct()
        {
            this.builder.BuildPartA();
            this.builder.BuildPartB();
            this.builder.BuildPartC();
        }

    }
}
