using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.FactoryMethod
{
    interface ICreator
    {
        IProduct FactoryMethod(int type);
    }
}
