// See https://aka.ms/new-console-template for more information
using Test.Class;

namespace Test;
partial class Program
{
    static void Main(string[] args)
    {

        TestClass.Instance.SetPoint(new(4, 5)).GetPoint(out var point).SetPoint(new(8, 9)).CallAlert()._();

        TestClass testClass = new();
        testClass.SetPoint(new(5, 6)).GetPoint(out point).CallAlert().CallReturnPoint(out var result,1).SetPoint(new(7, 50))._();
    }

}
