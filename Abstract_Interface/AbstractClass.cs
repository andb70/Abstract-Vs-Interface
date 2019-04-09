namespace Abstract_Interface
{
    using System;
    abstract class AbstractClass : IInterface
    {
        public AbstractClass(string name)
        {
            Name = name;
        }

        public string Name { get; private set; }

        public void Print1()
        {
            Console.WriteLine($"AbstractClass .Print1 <{Name}> non-virtual method");
        }

        abstract public void Print2();

        virtual public void Print3()
        {
            Console.WriteLine($"AbstractClass .Print3 <{Name}> virtual method");
        }
    }
}
