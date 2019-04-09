namespace Abstract_Interface
{
    using System;
    class ConcreteClass2 : AbstractClass
    {
        public ConcreteClass2(string name) : base(name)
        {
        }

        public override void Print2()
        {
            Console.WriteLine($"ConcreteClass2.Print2 <{Name}> override abstract method");
        }
        public override void Print3()
        {
            Console.WriteLine($"ConcreteClass2.Print3 <{Name}> override virtual method");
        }
    }
}
