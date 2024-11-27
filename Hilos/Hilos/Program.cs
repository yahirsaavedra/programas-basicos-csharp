
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Hilos;

// OBSERVACIONES DENTRO DEL CODIGO DE METODOSMSG.CS

namespace HILOS_D0S
{
    class Program
    {
        static void Main(string[] args)
        {
            //Metodosmsg ms = new Metodosmsg();

            VariosHilos ms = new VariosHilos();

            /* Thread th1 = new Thread(ms.Hilo1);
             Thread th2 = new Thread(ms.Hilo2);*/

            Thread hiloPrimario = new Thread(ms.HiloPrimario);
            Thread hiloSecundario = new Thread(ms.HiloSecundario);
            Thread hiloTerciario = new Thread(ms.HiloTerciario);

            /*th1.Start();

            th1.Join();

            th2.Start();

            th2.Join();*/

            hiloPrimario.Start();
            hiloPrimario.Join();
            hiloSecundario.Start();
            hiloSecundario.Join();
            hiloTerciario.Start();
            hiloTerciario.Join();

            Console.ReadKey();

            //EL METODO JOIN PERMITE A UN HILO QUEDARSE A LA ESPERA QUE TERMINE UN SEGUNDO HILO        
        }

    }
}

