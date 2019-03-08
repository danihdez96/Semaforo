using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase1
{
    public class Class2
    {
        String estado2, estado3;

        public void semaforo(String estado2, String estado3)
        {
            
            Console.WriteLine("Carlos el semaforo esta en " + estado2 + " debes tener precaución y dismuir la velocidad");
            Console.WriteLine("Maria el semaforo esta en " + estado2 + " debes tener precaución y dismuir la velocidad");
            Console.WriteLine("Luis el semaforo esta en " + estado2 + " debes tener precaución y dismuir la velocidad");
            Console.WriteLine("Fernando el semaforo esta en " + estado2 + " debes tener precaución y dismuir la velocidad");

           
            Console.WriteLine("Carlos el semaforo esta en " + estado3 + " debes detenerte");
            Console.WriteLine("Maria el semaforo esta en " + estado3 + " debes detenerte");
            Console.WriteLine("Luis el semaforo esta en " + estado3 + " debes detenerte");
            Console.WriteLine("Fernando el semaforo esta en " + estado3 + " debes detenerte");
        }

    }
}
