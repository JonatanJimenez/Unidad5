using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_3JimenezAhumadaJonatanAlberto
{
    class Imprimir
    {
        public void Mostrar()//Se crea el metodo Mostrar donde se crean los arreglos con los numeros y se imprimen de manera ordenada
        {
            int[] arreglo1 = new int[] { 3, 6, 9, 5, 1, 4, 7, 2, 1, 3 };// se crea un arreglo con distintos numeros 
            int[] arreglo2 = new int[] { 8, 3, 9, 3, 11, 7, 1, 27, 12 };// se crea un arreglo con distintos numeros 
            int[] arreglo3 = new int[] { 10, 40, 36, 5, 24, 2, 5, 8 };// se crea un arreglo con distintos numeros 
            int[] arreglo4 = new int[] { 55, 42, 0, -3, 0, -1, 2, 4, 7 };// se crea un arreglo con distintos numeros 
            int[] arreglo5 = new int[] { 25, 108, 1024, 12, 351, 251, 39 };// se crea un arreglo con distintos numeros 

            ImprimirArreglo(arreglo1);// se manda a llamar al metodo ImprimirArreglo donde se imprmimen los numeros desordenados y ordenados
            ImprimirArreglo(arreglo2);// se manda a llamar al metodo ImprimirArreglo donde se imprmimen los numeros desordenados y ordenados
            ImprimirArreglo(arreglo3);// se manda a llamar al metodo ImprimirArreglo donde se imprmimen los numeros desordenados y ordenados
            ImprimirArreglo(arreglo4);// se manda a llamar al metodo ImprimirArreglo donde se imprmimen los numeros desordenados y ordenados
            ImprimirArreglo(arreglo5);// se manda a llamar al metodo ImprimirArreglo donde se imprmimen los numeros desordenados y ordenados
        }

        private void ImprimirArreglo(int[] arreglo)// se crea el metodo ImprimirArreglo al que se le manda de parametro el arreglo de numeros que se desea 
        {                                          // ordenar 
            RadixSort radix = new RadixSort();// se crea un objeto de tipo RadixSort para poder llamar al metodo que contiene esa clase 

            Console.WriteLine("Arreglo sin ordenar: ");// se imprime en consola lo que esta entre comillas 
            foreach (var item in arreglo)// por cada numero en el arreglo
            {
                Console.Write("{0} ",item);// se imprime el numero 
            }
           
            radix.Ordenar(arreglo);// se manda a llamar al metodo ordenar el cual ordena los numeros del arreglo
            Console.WriteLine("\nArreglo Ordenado: ");// se imprime en consola lo que esta entre comillas 

            foreach (var item in arreglo)//  por cada numero en el arreglo
            {
                Console.Write("{0} ",item);// se imprime el numero 
            }
            Console.WriteLine("\n");// Salto de linea 
        }
    }
}
