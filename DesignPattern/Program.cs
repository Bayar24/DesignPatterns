using DesignPattern.Strategy;
using DesignPattern.FactoryMethod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            #region [ Factory Method ]
            ICreator creator = new Creator();
            IProduct product = creator.FactoryMethod(1);
            product.DoSomething();
            product = creator.FactoryMethod(2);
            product.DoSomething();
            #endregion

            #region [ Factory Method ]
            Context context = new Context(new CompositorA());
            context.DoSomething();
            context = new Context(new CompositorB());
            context.DoSomething();
            context = new Context(new CompositorC());
            context.DoSomething();
            #endregion
        }
    }
}
