using System;

namespace ConsoleApplication2
{
    public delegate string MyDelegate(string name);//声明一个委托类型,像一个没有方法体的方法
    public class Program
    {
        public static string FunctionA(string name)//定义被委托调用的方法，参数类型、个数、顺序都必须和delegate相同
        {
            return "A say Hello to" + name;
        }
        public static string FunctionB(string name)
        {
            return "B say Hello to" + name;
        }
        //定义delegate类型的处理函数，并在此函数中通过delegate类型调用步骤定义的方法
        public static void MethodA(MyDelegate Me)
        {
            Console.WriteLine(Me("张三"));
        }
        public static void Main()
        {
            //创建实例，传入准备调用的方法名
            MyDelegate a = new MyDelegate(FunctionA);
            MyDelegate b = new MyDelegate(FunctionB);
            MethodA(a);
            MethodA(b);
            Console.WriteLine();
        }
    }
}