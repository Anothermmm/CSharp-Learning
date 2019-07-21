using System;

namespace ConsoleApplication2
{
    class TestEvent
    {
        public delegate void MyEventHandler();//为事件定义委托
        public event MyEventHandler Click;//用event关键字声明
        public void Trigger()//定义引发事件时调用的方法
        {
            Click();
        }
        public void M1()
        {
            Console.WriteLine("Hello!");
        }
        public void M2()
        {
            Console.WriteLine("Hello again!");
        }
        public void M3()
        {
            Console.WriteLine("Good_bye!");
        }
        static void Main()
        {
            TestEvent myEvent = new TestEvent();
            myEvent.Click += new MyEventHandler(myEvent.M1);
            myEvent.Click += new MyEventHandler(myEvent.M2);
            myEvent.Click += new MyEventHandler(myEvent.M3);
            //引发事件
            myEvent.Trigger();
            myEvent.Click -= new MyEventHandler(myEvent.M2);
            Console.WriteLine("不再引发\"Hello again\"");
            //重新引发事件
            myEvent.Trigger();
            Console.WriteLine();
        }
    }
}