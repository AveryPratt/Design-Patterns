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
            Parallel.Invoke(
                () => InstantiateStudentSingleton(),
                () => InstantiateEmployeeSingleton()
            );
            Console.ReadLine();
        }

        private static void InstantiateStudentSingleton()
        {
            Singleton singleton = Singleton.Instance;
            singleton.PrintDetails("Student Message");
        }

        private static void InstantiateEmployeeSingleton()
        {
            Singleton singleton = Singleton.Instance;
            singleton.PrintDetails("Employee Message");
        }
    }
}
