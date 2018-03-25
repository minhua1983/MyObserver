using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyObserver.Core.ObserverDemo
{
    public class MyActionSource
    {
        public List<IEat> _eatActionListenerList = new List<IEat>();
        public List<ISleep> _sleepActionListenerList = new List<ISleep>();

        public List<IEat> EatActionListenerList
        {
            get { return _eatActionListenerList; }
        }

        public List<ISleep> SleepActionListenerList
        {
            get { return _sleepActionListenerList; }
        }

        public MyActionSource()
        {

        }

        public void Eat()
        {
            EatAction e = new EatAction();
            _eatActionListenerList.ForEach(eatActionListener => eatActionListener.OnActionSourceEat(e));
        }

        public void Sleep()
        {
            SleepAction e = new SleepAction();
            _sleepActionListenerList.ForEach(sleepActionListener => sleepActionListener.OnActionSourceSleep(e));
        }
    }
}
