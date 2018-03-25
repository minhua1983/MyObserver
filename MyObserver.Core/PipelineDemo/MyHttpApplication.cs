using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyObserver.Core.PipelineDemo
{
    /// <summary>
    /// HttpApplication实例是由HttpApplicationFactory.GetApplicationInstance方法提供的，这里为了简化demo，就没定义HttpApplicationFactory和HttpContext的模拟类型，不过他们是asp.net请求的核心类。本模拟类型的只支持处理其2个事件BeginRequest和EndRequest，为了简化程序另外17个事件就不在这个demo中模拟了。
    /// </summary>
    public class MyHttpApplication
    {
        public event EventHandler BeginRequest;
        public event EventHandler EndRequest;
        public List<MyHttpModule> _httpModuleList = new List<MyHttpModule>();

        public List<MyHttpModule> HttpModuleList
        {
            get { return _httpModuleList; }
        }

        public void Init()
        {
            _httpModuleList.ForEach(httpModule => httpModule.Init(this));
        }

        public void ProcessRequest(object httpContext)
        {
            //尝试触发BeginRequest事件
            OnBeginRequest();
            //模拟处理的真正的逻辑
            Console.WriteLine("ProcessRequest...");
            //尝试触发EndRequest事件
            OnEndRequest();
        }

        protected void OnBeginRequest()
        {
            //默认写法
            //if (BeginRequest != null) BeginRequest(this, new EventArgs());
            //新写法
            BeginRequest?.Invoke(this, new EventArgs());
        }

        protected void OnEndRequest()
        {
            //默认写法
            //if (EndRequest != null) EndRequest(this, new EventArgs());
            //新写法
            EndRequest?.Invoke(this, new EventArgs());
        }
    }
}
