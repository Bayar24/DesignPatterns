using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Strategy
{
    class Context
    {
        private readonly ICompositor compositor;
        public Context(ICompositor compositor)
        {
            this.compositor = compositor;
        }
        public void DoSomething()
        {
            compositor.DoSomething();
        }
    }
}
