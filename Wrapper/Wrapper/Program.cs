using System;
using System.IO;

namespace Wrapper
{
    class Program
    {
        static void Main(string[] args)
        {
            Wrapper wrapper = new Wrapper();
            wrapper.LoadFromFile("Info");
            wrapper.Print();

            Console.ReadKey();  
        }
    }
}
