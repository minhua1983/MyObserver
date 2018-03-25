using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyObserver.Core.EventDemo;
using MyObserver.Core.ObserverDemo;
using MyObserver.Core.PipelineDemo;

namespace MyObserver.Core
{
    class Program
    {
        static void Main(string[] args)
        {
            //*MyComponent作为被观察者，即事件源(事件源持有事件)，MyMonitor作为观察者。.net中的事件不太容易理解，如果看不明白的话，可以看第二个例子，那个例子是基于java中观察者模式的原型而用c#实现的观察者模式。
            MyComponent component = new MyComponent();
            MyMonitor monitor = new MyMonitor();
            component.MonitorList.Add(monitor);
            component.Init();
            component.Load();
            //*/

            //*这是个基于java的观察者模式，它比较标准，也容易理解。EatAction和SleepAction就是事件，MyActionSource就是事件源（即被观察者），MyActionListener就是观察者。这种写法就是每个事件都要一个单独的监听者列表。而第一个和第三个例子都是指定同一种监听者，至于若干个事件中监听哪个几个或哪一个都使用同一列表，使用上有一定局限性。建议使用这种，每个事件都有一个单独的监听者列表，这种写法比较麻烦，但是相对比较灵活。
            MyActionSource actionSource = new MyActionSource();
            MyActionListener eatActionListener = new MyActionListener();
            MyActionListener sleepActionListener = new MyActionListener();
            actionSource.EatActionListenerList.Add(eatActionListener);
            actionSource.SleepActionListenerList.Add(sleepActionListener);
            actionSource.Eat();
            actionSource.Sleep();
            //*/


            //*这是一个简单pipeline模型，它模拟asp.net的请求管道处理模型。平时我们不用写下面行代码是因为asp.net底层机制通过我们的web.config中的httpmodules节点会帮我们自动注册到每个HttpApplication中去。平时我们只需自定义HttpModule即可，确实帮我们简化了很多步骤。

            //通过事件实现观察者模式，这里的MyHttpApplication即被观察者，也叫事件源。
            MyHttpApplication httpApplication = new MyHttpApplication();
            //实例化观察者MyHttpModule的实例
            MyHttpModule httpModule = new MyHttpModule();
            //注册MyHttpModule实例到事件源
            httpApplication.HttpModuleList.Add(httpModule);
            //模拟初始化HttpApplication
            httpApplication.Init();
            //模拟http上下文
            object httpContext = new object();
            //执行模拟的管道模型
            httpApplication.ProcessRequest(httpContext);
            //*/

            Console.ReadLine();
        }
    }
}
