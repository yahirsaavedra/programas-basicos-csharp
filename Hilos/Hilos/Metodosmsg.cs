using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


/*
SAAVEDRA GALLARDO YAHIR ALEJANDRO, 21490577

OBSERVACIONES:
EN EL CODIGO, PODEMOS OBSERVAR QUE EL PRIMER HILO ESCRIBE LOS NUMEROS DEL 0 AL 9
CADA SEGUNDO Y EL SEGUNDO HILO LO HACE DE 2 EN 2 CADA 5 SEGUNDOS.

CUANDO EL PROGRAMA SE EJECUTA SIN LOS METODOS JOIN, LOS HILOS SE EJECUTAN AL MISMO
TIEMPO. A VECES SE EJECUTA PRIMERO EL HILO 1, A VECES EL HILO 2.
CUANDO SE LE APLICAN LOS METODOS JOIN, EL SEGUNDO HILO SE EJECUTARÁ DESPUÉS DE QUE
CONCLUYA SU EJECUCIÓN EL PRIMER HILO, ES DECIR, NO SE EJECUTAN AL MISMO TIEMPO.
*/

namespace HILOS_D0S
{
    class Metodosmsg
    {
        //CLASE CON DOS METODOS QUE MUESTRAN MENSAJES POR PANTALLA
        //EL OBJETIVO ES CREAR HILOS UNO PARA CADA UNO DE LOS METODOS
        //Y EJECUTARLOS DE FORMA PARALELA, DE FORMA QUE PODAMOS VER COMO 
        //RESULTADO COMO SE VAN INTERCALANDO LOS MENSAJES ESCRITOS POR CADA METODO

        public void Hilo1()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("[" + i + "]" + "EJECUTANDO H1");

                Thread.Sleep(1000);
            }
        }
        public void Hilo2()
        {
            for (int i = 0; i < 10; i = i + 2)
            {

                Console.WriteLine("[" + i + "]" + "EJECUTANDO H2");

                Thread.Sleep(5000);
            }

        }
    }
}

