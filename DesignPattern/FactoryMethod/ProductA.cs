using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.FactoryMethod
{
    class ProductA : IProduct
    {
        public void DoSomething()
        {
            Console.WriteLine("ProductB");
        }
    }
}
