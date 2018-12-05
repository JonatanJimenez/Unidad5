using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E5_JimenezAhumadaJonatanAlberto
{
    class Imprimir
    {
        Ejercicio1 ejer1 = new Ejercicio1();//se crea un objeto de tipo Ejercicio1
        Ejercicio2 ejer2 = new Ejercicio2();//se crea un objeto de tipo Ejercicio2
        Ejercicio3 ejer3 = new Ejercicio3();//se crea un objeto de tipo Ejercicio3
        Ejercicio4 ejer4 = new Ejercicio4();//se crea un objeto de tipo Ejercicio4

        public void Ver()//metodo que imprime los ejercicios 
        {
            Console.WriteLine("Ejercicio 1 Examen Unidad 5\nJonatan Alberto Jimenez Ahumada\n");
            ejer1.Imprimir();
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Ejercicio 2 Examen Unidad 5\nJonatan Alberto Jimenez Ahumada\n");
            ejer2.Imprimir();
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Ejercicio 3 Examen Unidad 5\nJonatan Alberto Jimenez Ahumada\n");
            ejer3.Imprimir();
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Ejercicio 4 Examen Unidad 5\nJonatan Alberto Jimenez Ahumada\n");
            ejer4.Imprimir();
            Console.WriteLine();
            Console.ReadKey();
        }
        
    }
}
