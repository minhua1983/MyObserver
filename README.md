# 自动编译
这是一个用于自动编译的demo

## 项目环境
* .net framework 4.5.2

## 所需额外加载nuget包
* Microsoft.CodeAnalysis 
* Microsoft.VisualStudio.TextTemplating

## 项目结构
* AutoComplier.Core，winform主程序，核心程序，读取T4模版文件内容（基于AutoComplier.UICore获取数据库中表结构）并执行（生成对应的cs类文件），最后结合MSBuild来自动编译AutoComplier.UI项目（即通过本项目程序来编译，而非在VS中执行编译）
* AutoComplier.XCore，控制台主程序（用于最基本的核心功能测试，在本解决方案中实际被AutoComplier.Core项目所替换，所以目前用不着）
* AutoComplier.UI，需要生成的网站
* AutoComplier.UICore 帮助类库，用于放映数据库中表结构的项目，

## MSBuild官方文档
[MSBuild官方文档](https://msdn.microsoft.com/zh-cn/library/0k6kkbsd.aspx)
MSBuild是对.net程序做持续集成的核心工具，对持续集成感兴趣的话，可以看一下MSBuild（编译工具）和Jenkins（持续集成工具）。

## 项目灵感
这种自动编译的demo，可以用于数据库中新建了某些表，而对这些表又需要生成一些实体类，基本的数据访问操作类，基本的业务逻辑，基本的访问接口时，可以通过这个程序来生成，并自动发布网站。
