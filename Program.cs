using System;
using FacadePattern;

namespace FacadePatter
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // Console.WriteLine("Hello World!");

           Facade facade=new Facade();

           facade.doSomething();
           Console.WriteLine();
        }
    }
}
