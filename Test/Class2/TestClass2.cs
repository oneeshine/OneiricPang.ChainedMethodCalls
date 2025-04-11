using OneiricPang.ChainedMethodCalls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Test.Class2
{
    [ChainedMethodCallObject]
    public partial class TestClass2
    {

        [ChainedMethodCallObject]
        public partial class TestClass2Sub
        {

        }

    }
}

namespace Test.Class3
{

    namespace Class4
    {
        [ChainedMethodCallObject]
        public partial class TestClass3
        {
            /// <summary>
            /// 可写原点
            /// </summary>
            public Point? WriteOnlyPoint { set { } }
            /// <summary>
            /// 只读原点
            /// </summary>
            public Point? ReadOnlyPoint { get; }

            /// <summary>
            /// 读写原点
            /// </summary>
            private Point? ReadWritePoint { get; set; }


        }

    }
}
