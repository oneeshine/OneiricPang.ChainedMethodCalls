// See https://aka.ms/new-console-template for more information
using Test.Class;

namespace Test;
partial class Program
{
    static void Main(string[] args)
    {

       TestClass.Instance.SetPoint(new(4,5)).GetPoint(out var point).SetPoint(new(8, 9)).CallAlert()._();
            
    }

}
