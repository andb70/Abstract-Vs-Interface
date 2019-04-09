using System;

namespace Abstract_Interface
{
    class Program
    {
        /// <summary>
        /// This program demonstrate the differences between the use of abstract, virtual and
        /// non-virtual modifier for the interface methods implemented by an abstract class and,
        /// consequently, the different behavior it causes in the inherited classes
        /// <para>
        /// https://docs.microsoft.com/it-it/dotnet/csharp/language-reference/keywords/abstract
        /// </para>
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            IInterface concrete1i = new ConcreteClass1("I1");
            AbstractClass concrete1a = new ConcreteClass1("A1");
            ConcreteClass1 concrete1c = new ConcreteClass1("C1");

            IInterface concrete2i = new ConcreteClass2("I2");
            AbstractClass concrete2a = new ConcreteClass2("A2");
            ConcreteClass2 concrete2c = new ConcreteClass2("C2");

            Console.WriteLine("\nprint concrete1i");
            concrete1i.Print1();
            concrete1i.Print2();
            concrete1i.Print3();

            Console.WriteLine("\nprint concrete1a");
            concrete1a.Print1();
            concrete1a.Print2();
            concrete1a.Print3();

            Console.WriteLine("\nprint concrete1c");
            concrete1c.Print1();
            concrete1c.Print2();
            concrete1c.Print3();

            Console.WriteLine("\nprint concrete2i");
            concrete2i.Print1();
            concrete2i.Print2();
            concrete2i.Print3();

            Console.WriteLine("\nprint concrete2a");
            concrete2a.Print1();
            concrete2a.Print2();
            concrete2a.Print3();

            Console.WriteLine("\nprint concrete2c");
            concrete2c.Print1();
            concrete2c.Print2();
            concrete2c.Print3();


            Console.ReadLine();
        }
    }
}
