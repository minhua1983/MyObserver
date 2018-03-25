using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyObserver.Core.ObserverDemo
{
    public class MyActionListener : IEat, ISleep
    {
        public void OnActionSourceEat(EatAction e)
        {
            Console.WriteLine("action source  is eating....");
        }

        public void OnActionSourceSleep(SleepAction e)
        {
            Console.WriteLine("action source is sleeping....");
        }
    }
}
