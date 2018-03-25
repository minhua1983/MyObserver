using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyObserver.Core.PipelineDemo
{
    public class MyHttpModule
    {
        public void Init(MyHttpApplication httpApplication)
        {
            httpApplication.BeginRequest += HttpApplication_BeginRequest;
            httpApplication.EndRequest += HttpApplication_EndRequest;
        }

        private void HttpApplication_BeginRequest(object sender, EventArgs e)
        {
            Console.WriteLine("HttpApplication_BeginRequest...");
        }

        private void HttpApplication_EndRequest(object sender, EventArgs e)
        {
            Console.WriteLine("HttpApplication_EndRequest...");
        }
    }
}
