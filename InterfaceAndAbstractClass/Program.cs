internal abstract class AbstractClass
{
    public AbstractClass()
    {
        ProtectedField = "pf";
    }

    protected string ProtectedField;
    public string MyProperty { get; set;}
    protected abstract void FooClass();
}

internal interface Interface1
{
    public string MyInterfaceProperty { get; set; }
    //string Field; - error
    public void Foo()
    {
        System.Console.WriteLine("Foo");
    }
}

internal interface Interface2
{
    public static void StaticFoo()
    {
        System.Console.WriteLine("Static foo");
    }

    public void FooInterface2();
}