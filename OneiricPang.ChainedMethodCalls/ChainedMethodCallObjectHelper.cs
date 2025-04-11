using System;

namespace OneiricPang.ChainedMethodCalls
{
    public class ChainedMethodCallObjectHelper
    {
        public const string ChainedMethodCallObjectAttribute = $$"""
using System;

namespace OneiricPang.ChainedMethodCalls
{
    /// <summary>
    /// 自动生成链式属性和方法
    /// </summary>
    [AttributeUsage(AttributeTargets.Class , AllowMultiple = false, Inherited = false)]
    public class ChainedMethodCallObjectAttribute : Attribute
    {
        public ChainedMethodCallObjectAttribute(string getPropPrefix ="Get", string setPropPrefix = "Set", string callMethodPrefix ="Call",string cutOffMethod = "_")
        {
            SetPropPrefix = setPropPrefix;
            GetPropPrefix = getPropPrefix;
            CallMethodPrefix = callMethodPrefix;
            CutOffMethod = cutOffMethod;
        }

        public string SetPropPrefix { get; set; }
        public string GetPropPrefix { get; set; }
        public string CallMethodPrefix { get; set; }
        public string CutOffMethod { get; set; }
    }   
}

""";

    }
}
