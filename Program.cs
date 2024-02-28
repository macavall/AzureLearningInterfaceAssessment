using System;
using System.Threading.Tasks;
using InterfaceDLL;

namespace InterfaceAssessmentConsole
{
    public class Program
    {
        static void Main(string[] args)
        {
            var myClass = new MyClass();

            Console.WriteLine("Writing out the results from the Interface Methods!");
            Console.WriteLine("MyInterfaceMethod1 returns: " + myClass.MyInterfaceMethod1());
            Console.WriteLine("MyInterfaceMethod2 returns: " + myClass.MyInterfaceMethod2());
            Console.WriteLine("MyInterfaceMethod3 returns: " + myClass.MyInterfaceMethod3());

        }

        public class MyClass : IMyInterface
        {
            public string MyInterfaceMethod1()
            {
                
            }

            public int MyInterfaceMethod2()
            {
                
            }

            public Task MyInterfaceMethod3()
            {
                
            }
        }
    }
}
