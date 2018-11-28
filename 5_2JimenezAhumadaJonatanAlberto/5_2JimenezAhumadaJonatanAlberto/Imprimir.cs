using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_2JimenezAhumadaJonatanAlberto
{
    class Imprimir
    {
        private void ImprimirArreglo(double[] arreglo)// se crea el metodo llamado ImprimirArreglo al que le mandamos como parametro un arreglo de tipo double
        {
            QuickSort quickSort = new QuickSort();// se crea un objeto de tipo QuickSort 
            Console.WriteLine("Numeros desordenados: ");//escribimos en consola lo que esta entre comillas
            foreach (var item in arreglo)// se crea un foreach para que imprima los numeros desordenados del arreglo 
            {
                Console.Write("{0} ", item);// se escribe en consola el numero y un espacio
            }

            Console.WriteLine("\nNumeros ordenados de menor a mayor: ");// se escribe en consola lo que esta entre comillas 
            quickSort.UsarQuickSort(arreglo, 0, arreglo.Length - 1);// se llama al metodo de la clase QuickSort llamado UsarQuickSort al que le damos de parametros 
                                                                    // el nombre del arreglo, un 0 como numero inicial y como numero final el tamaño del arreglo -1
            
            foreach (var item in arreglo)// se crea un foreach para que imprima los numeros ordenados del arreglo 
            {
                Console.Write("{0} ", item);// se escribe en consola el numero y un espacio
            }
            Console.WriteLine();//Salto de linea 
        }

        public void ImprimirListaNumeros()//se crea el metodo llamado ImprimirListaNumeros que nos servira para imprimir todos los arreglos de numeros
                                          // que tengamos 
        {
            double[] arreglo1 = new double[] { 11, 2, 3, 14, 18, 45, -3, -1, 6, 9 };// se crea el arreglo1 con ciertos numeros desordenados 
            double[] arreglo2 = new double[] { 1, 3, 5, 7, 8, 3, 9, .7071, 16.5664, 12, 0, 10 };// se crea el arreglo2 con ciertos numeros desordenados 
            double[] arreglo3 = new double[] { 3, 7, 15, 4 / 3, 155, 100, 15, Math.Sqrt(3), 5, 2, 3, 2 };// se crea el arreglo3 con ciertos numeros desordenados 
            double[] arreglo4 = new double[] { 8, 19, 7, 3, 15, 23, 34, 27, 89, 101 };// se crea el arreglo4 con ciertos numeros desordenados 

            ImprimirArreglo(arreglo1);//se llama al metodo ImprimirArreglo al que le damos de parametro el arreglo1 
            Console.WriteLine();//Salto de renglon 
            ImprimirArreglo(arreglo2);//se llama al metodo ImprimirArreglo al que le damos de parametro el arreglo2 
            Console.WriteLine();//Salto de renglon
            ImprimirArreglo(arreglo3);//se llama al metodo ImprimirArreglo al que le damos de parametro el arreglo3 
            Console.WriteLine();//Salto de renglon
            ImprimirArreglo(arreglo4);//se llama al metodo ImprimirArreglo al que le damos de parametro el arreglo4 
            Console.WriteLine();//Salto de renglon
        }

    }
}
