这很容易使用

```csharp
///为类增加ChainedMethodCallObject属性
[ChainedMethodCallObject]
public partial class TestClass
{      
    public Point? Point { get; set; }
                       
    public void Alert(string r1, string r2)
    {
    Console.WriteLine($"Alert");
    }
       
    public (Point?,int) ReturnPoint(ref int index, params string[] ss)
    {            
        return (Point,index); 
    }     
}
```

```csharp
///现在你可以使用它
TestClass testClass = new();
testClass.SetPoint(new(5, 6)).GetPoint(out point).CallAlert().CallReturnPoint(out var result,1).SetPoint(new(7, 50))._();
```