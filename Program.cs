using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingScope
{
    class Program
    {
        private static string k = ""; //it's called private field - it's private, but it's
                                      //available to all members of the class
        static void Main(string[] args)
        {
            //a variable - inside a block of code - it is "alive" for
            //the life of that codeblock and any of the interior codeblocks

            string j = " ";

            for (int i = 0; i < 10; i++)
            {
                j = i.ToString();
                k = i.ToString();
                Console.WriteLine(i);

                if (i==9)
                {
                    string l = i.ToString();
                }
                //Console.WriteLine(l); //won't work since l is declared in a seperate
                //codeblock above

            }
            //Console.WriteLine(i); // i doesn't exist outside a codeblock
            Console.WriteLine("Outside of the for: " + j);
            Console.WriteLine("Outside of the for: " + k);

            HelperMethod();

            Car myCar = new Car();
            myCar.DoSomething();

            Console.ReadLine();
        }
        static void HelperMethod()
        {
            Console.WriteLine("Value of k from the HelperMethod(): " + k);
        }
    }
    class Car
    {
        public void DoSomething()
        {
            Console.WriteLine(helperMethod());
        }
        private string helperMethod() //impossible to access directly from other classes
                                      //it's an example of encapsulation
        {
            return "Hello world!";
        }
    }
}