namespace Abstract_Interface
{
    using System;
    class ConcreteClass1 : AbstractClass
    {
        public ConcreteClass1(string name) : base(name)
        {
        }

        public override void Print2()
        {
            Console.WriteLine($"ConcreteClass1.Print2 <{Name}> override abstract method");
        }
    }
}
