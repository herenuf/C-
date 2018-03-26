using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入你的语文成绩");
            double Chinese = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("请输入你的数学成绩");
            double math = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("你的总分是{0}分,你的平均分是{1}分", math + Chinese,(math + Chinese) / 2);
            Console.ReadKey();
        }
    }
}
