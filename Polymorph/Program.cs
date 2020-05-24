using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorph
{
    class Program
    {
        static void Main(string[] args)
        {

            foreach (var someFoo in GetData("foobar"))
            {
                // Display the name of the type
                Console.WriteLine(someFoo.GetType().Name);
                // Explanation: By casting with the 'as' operator
                // you will get an object if the type matches and
                // a null if it doesn't. 
                FooA fooA = someFoo as FooA;
                FooB fooB = someFoo as FooB;

                // vvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvv
                // On the other hand, you could also cast
                // like this but it will throw an exception 
                // if the cast fails. Sometimes you want that 
                // behavior but most times you don't.

                // FooA fooA = (FooA)someFoo; // if (someFoo is FooB) then exception is thrown.
            }

            // Pause
            Console.ReadKey();
        }
        private static List<IFoo> GetData(string key)
        {
            return new List<IFoo> { new FooA(), new FooB() };
        }
    }
    class FooA : IFoo { }
    class FooB : IFoo { }
    internal interface IFoo { }
}
