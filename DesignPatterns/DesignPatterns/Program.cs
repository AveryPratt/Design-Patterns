using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton singleton1 = Singleton.Instance;
            singleton1.PrintDetails("Message 1");
            Singleton singleton2 = Singleton.Instance;
            singleton1.PrintDetails("Message 2");
            Console.ReadLine();
        }
    }
}
