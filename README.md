# 观察者模式
这是一个观察者模式的demo

## 项目环境
* .net framework 4.5.2

## 相关说明
* MyObserver.Core\EventDemo 一个基于.net事件的MyComponent/MyMonitor之间的demo。
* MyObserver.Core\ObserverDemo 一个基于java事件监听者的demo，最好能理解这个demo，因为.net的事件隐藏了是如何循环通知监听者列表的，因此不好理解.net下的事件，如果能看懂这个demo，那么就可以明白.net事件中哪些部分被隐藏了。
* MyObserver.Core\PipelineDemo 一个基于.net事件的MyHttpApplication/MyHttpModule之间的demo，它和第一个demo很像，但是这个demo基本反映了管道处理的逻辑，最好也能看懂它，它有助于帮你理解asp.net的管道是如何处理请求的。
