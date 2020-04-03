using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.FactoryMethod
{
    class ProductB : IProduct
    {
        public void DoSomething()
        {
            Console.WriteLine("ProductB");
        }
    }
}
