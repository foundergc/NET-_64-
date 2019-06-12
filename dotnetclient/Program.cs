using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnetclient
{
    class Program
    {
        static void Main(string[] args)
        {
            int result=0;
            var svc = new SPF_PROXYLib.PROXY (); /* 新建COM对象*/
            string xml ="D:\\Test.xml";    /* 文件的绝对路径*/
            result = svc.FUN(xml, 1, 1); /* 参数1：XML文件路径；参数2：是否生成EXCEL报告，1=生成，0=不生成；参数3：是否生成PDF报告，1=生成，0=不生成*/
            Console.WriteLine("Running " + (result == 0 ? "运行完成,没有错误!" : "运行完成,发现错误,错误内容请查看Log文件"));/* 返回值=0无异常，其他=有异常*/
            Console.ReadKey();
        }
    }

}