using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase1;

namespace ClasePrincipal
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 obj = new Class1();
            Class2 obj2 = new Class2();
            obj.semaforo("verde");
            obj2.semaforo("amarillo", "rojo");

            Console.ReadKey(); 
        }
    }
}
