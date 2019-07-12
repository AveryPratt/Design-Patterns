using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public sealed class Singleton
    {
        private static int _counter;

        private static readonly Lazy<Singleton> _instance = new Lazy<Singleton>(()=>new Singleton());
        public static Singleton Instance
        {
            get
            {
                return _instance.Value;
            }
        }

        private Singleton()
        {
            _counter++;
            Console.WriteLine("Counter value: " + _counter);
        }

        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}
