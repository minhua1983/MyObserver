using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyObserver.Core.EventDemo
{
    public class MyMonitor
    {
        public void Init(MyComponent component)
        {
            component.PreLoad += Component_PreLoad;
            component.PostLoad += Component_PostLoad;
        }

        private void Component_PreLoad(object sender, EventArgs e)
        {
            Console.WriteLine("Component_PreLoad...");
        }

        private void Component_PostLoad(object sender, EventArgs e)
        {
            Console.WriteLine("Component_PostLoad...");
        }
    }
}
