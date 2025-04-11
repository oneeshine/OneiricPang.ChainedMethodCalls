using OneiricPang.ChainedMethodCalls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Class
{
    /// <summary>
    /// 测试类
    /// </summary>
    [ChainedMethodCallObject]
    public partial class TestClass
    {
        private static TestClass? instance = null;
        public static TestClass Instance
        {
            get
            {
                return instance ??= new();
            }
        }
        /// <summary>
        /// 原点
        /// </summary>
        public Point? Point { get; set; }


        public Point? Point2 { get; set; }


        private Task<string> TestTask()
        {
            return Task.Factory.StartNew(() => { return "1"; });

        }


        public void Alert()
        {

            Console.WriteLine($"Alert");
        }

        /// <summary> 注释
        /// 多行
        /// </summary>
        /// <param name="r1">r1</param>
        /// <param name="r2">r2</param>
        public void Alert(string r1, string r2)
        {

            Console.WriteLine($"Alert");
        }

        public void Alert<T1,T4>(T1 r1, T4 r2)
        {

            Console.WriteLine($"Alert");
        }
        public void Alert<T>(int index, out T? other, string dd = "1")
        {
            other = default;
            switch (index)
            {
                case 0:
                    Console.WriteLine($"Point：{Point?.ToString()}");
                    break;
                case 1:
                    Console.WriteLine($"Point2：{Point2?.ToString()}");
                    break;
                default:
                    Console.WriteLine($"null");
                    break;
            }

        }


        /// <summary>
        /// 测试
        /// </summary>
        /// <param name="index"></param>
        /// <param name="ss"></param>
        /// <returns></returns>
        public (Point?,int) ReturnPoint(int index, params string[] ss)
        {
            switch (index)
            {
                case 0:
                    return (Point,index);
                case 1:
                    return (Point2, index);
                default:
                    return (null,index);
            }

        }     
    }
}
