//类的初步测试
using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApplication1
{
    class CSerialPort
    {
        private string Name;
        public int Speed;//如果Speed是private,就不能直接访问了
        public int speed
        {
            get { return Speed; } //可读。计算或返回字段值,如果Speed是private就可以通过调用speed访问
            set { Speed = value; } //可修改。 value是给出的值。
        }

        private int BufferLength;
        public int a
        {
            get
            {
                Console.WriteLine("串口名称：{0}",Name);
                Console.WriteLine("速度：{0}", Speed);
                Console.Write("BufferLength:");
                return BufferLength;
            }
        }

        private static int ComCounts = 0;//静态变量只能抽象访问
        public static int GetCom()//静态函数只能抽象访问
        {
            return ComCounts;
        }

        public CSerialPort(string name = "com1", int speed = 9600, int bufferLength = 500)
        {
            this.Name = name;
            this.Speed = speed;
            this.BufferLength = bufferLength;
            ComCounts++;
        }

        public CSerialPort(CSerialPort a)
        {
            this.Name = a.Name;
            this.Speed = a.Speed;
            this.BufferLength = a.BufferLength;
            ComCounts++;
        }

        public static CSerialPort operator++(CSerialPort a)//只能是值传递，不能传ref和out
        {
            a.Speed++;
            return a;
        }

        //重载运算符必须使用public static修饰，比较运算符必须成对重载
        public static CSerialPort operator+(CSerialPort lhs, CSerialPort rhs)
        {
            return new CSerialPort(lhs.Name + "+++" + rhs.Name, lhs.Speed + rhs.Speed, lhs.BufferLength + rhs.BufferLength);
        }



        ~CSerialPort()
        {
            ComCounts--;
            Console.WriteLine("析构CSerialPort.");
        }

    }

    class Program
    {
        static void Main()
        {
            CSerialPort portA;//这声明了一个CSerialPort类，但是没有赋值
            //Console.WriteLine(portA.speed); 错误，因为portA未赋值
            Console.WriteLine("用静态成员函数访问静态成员变量：{0}",CSerialPort.GetCom());//为0，即初始化的值
            Console.WriteLine("以上A-----------------------------------");
            
            CSerialPort portB=new CSerialPort("com5",4800,1024);
            Console.WriteLine("直接访问Speed:{0}",portB.Speed);
            Console.WriteLine("利用speed访问Speed:{0}",portB.speed);
            Console.WriteLine("以上B-----------------------------------");
            
            CSerialPort portC = new CSerialPort(portB);
            Console.WriteLine("访问静态成员变量：{0}",CSerialPort.GetCom());
            ++portC;
            portC++;//虽然只重载了一个++，但前后++都能使用
            Console.WriteLine(portC.a);
            Console.WriteLine("以上C-----------------------------------");
            
            CSerialPort portD = new CSerialPort(portB + portC);//在重载加法运算的时候又多构造了一次，这一行构造了两次
            Console.WriteLine(portD.a);
            Console.WriteLine("以上D-----------------------------------");
            Console.ReadLine();
        }//在此处才会析构，且析构四次（因为一共构造了四次）
    }
}