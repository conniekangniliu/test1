using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    
    class demo
    {
        delegate void testdelegate(string s); //method 1 定义委托
        static void consolestr(string s )
        {
            Console.WriteLine(s);
        }
        static void Main(string[] args)
        {
            testdelegate idelegate = new testdelegate(consolestr); //method1 实例化委托
            idelegate("1 instance delegate");//方法一 调用委托




            testdelegate adelegate = delegate (string s) { Console.WriteLine(s); }; //method2 匿名委托





            adelegate("2 anonymous delegate");


            //method 3 lambda expression
            testdelegate ldelegate = (s) => { Console.WriteLine(s); };
            ldelegate("3 lambda delegate");
            




        }
    }
}
