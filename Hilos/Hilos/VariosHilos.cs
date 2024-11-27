using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hilos
{
    internal class VariosHilos
    {
        public void HiloPrimario()
        {
            DateTime inicio = DateTime.Now;
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine("[" + i + "]" + " - Hilo primario");
                
                Thread.Sleep(1000);
            }
            DateTime fin = DateTime.Now;
            TimeSpan tiempo = (fin - inicio);
            Console.WriteLine("Hilo primario - Ejecución: " + tiempo.TotalMilliseconds + " ms");
        }
        public void HiloSecundario()
        {
            DateTime inicio = DateTime.Now;
            for (int i = 0; i <= 5; i = i + 2)
            {
                Console.WriteLine("[" + i + "]" + " - Hilo secundario");

                Thread.Sleep(1000);
            }
            DateTime fin = DateTime.Now;
            TimeSpan tiempo = (fin - inicio);
            Console.WriteLine("Hilo secundario - Ejecución: " + tiempo.TotalMilliseconds + " ms");

        }

        public void HiloTerciario()
        {
            DateTime inicio = DateTime.Now;
            for (int i = 0; i <= 5; i = i + 3)
            {
                Console.WriteLine("[" + i + "]" + " - Hilo terciario");

                Thread.Sleep(1000);
            }
            DateTime fin = DateTime.Now;
            TimeSpan tiempo = (fin - inicio);
            Console.WriteLine("Hilo terciario - Ejecución: " + tiempo.TotalMilliseconds + " ms");
        }
    }
}
