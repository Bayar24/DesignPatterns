using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.FactoryMethod
{
    class Creator : ICreator
    {
        public IProduct FactoryMethod(int type)
        {
            if (type == 1)
            {
                return new ProductA();
            }
            else
            {
                return new ProductB();
            }
        }
    }
}