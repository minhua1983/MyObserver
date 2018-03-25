using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyObserver.Core.ObserverDemo
{
    public interface IEat
    {
        void OnActionSourceEat(EatAction e);
    }
}
