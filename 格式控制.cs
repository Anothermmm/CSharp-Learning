//格式化输出
using System;


namespace ConsoleApplication2
{
    public class Program
    {
        static void Main()
        {
            int i = 10,j = 1234;
            double m = 433.1222200;
            Console.WriteLine("{0:C}  {1:F4}", i, m);//金额输出、小数保留4位
            Console.WriteLine("{0:00000}", i);//0占位符自动补0
            Console.WriteLine("{0:0000.##########}",m);//#占位符自动去0
            Console.Write(string.Format("{0,30}", ' '));//字符串格式化
            Console.WriteLine(string.Format("{0,-20}", "kkkk"));//字符串格式化
            Console.WriteLine(string.Format("格式：d6,数{0},输出结果:{0:d6}", i));
            Console.WriteLine(string.Format("i:{0,-7},j:{1,7}",i,j));//左右补空，正是左补，负是右补
            DateTime da = new DateTime(2009, 12, 12, 23, 33, 34);//datatime的一种构造函数形式
            Console.WriteLine(string.Format("{0:yyyy年MM月dd日 HH:mm:ss dddd,MMMM}", da));//具体见书
        }
    }
}
