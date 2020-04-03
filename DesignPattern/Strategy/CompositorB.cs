using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Strategy
{
    class CompositorB : ICompositor
    {
        public void DoSomething()
        {
            Console.WriteLine("Do Something B");
        }
    }
}
