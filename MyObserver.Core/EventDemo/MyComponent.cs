using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyObserver.Core.EventDemo
{
    public class MyComponent
    {
        public event EventHandler PreLoad;
        public event EventHandler PostLoad;
        public List<MyMonitor> _monitorList = new List<MyMonitor>();

        public List<MyMonitor> MonitorList
        {
            get { return _monitorList; }
        }

        public void Init()
        {
            _monitorList.ForEach(monitor => monitor.Init(this));
        }

        public void Load()
        {
            OnPreLoad();
            Console.WriteLine("Load...");
            OnPostLoad();
        }

        protected void OnPreLoad()
        {
            if (PreLoad != null)
            {
                PreLoad(this, new EventArgs());
            }
        }

        protected void OnPostLoad()
        {
            if (PostLoad != null)
            {
                PostLoad(this, new EventArgs());
            }
        }
    }
}
