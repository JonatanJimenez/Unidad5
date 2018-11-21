using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_1JimenezAhumadaJonatanAlberto
{
    class Burbuja//Clase Burbuja
    {
        int varTemporal;//variable que se utilizara para guardar distintos variables 
        int[] numeros = new int[] { 10, 6, 7, 8, 5, 2, 1, 3, 4, 9 };//Arreglo que contiene numeros de forma desordenada 

        private void MetodoBurbuja()//Metodo llamado MetodoBurbuja donde se haran las operaciones para ordenar los numeros 
        {
            for (int contador1 = 0; contador1 < numeros.Length; contador1++)//for que va desde 0 al tamano del arreglo -1 (0 a 9)
            {
                for (int contador2 = 0; contador2 < numeros.Length -1; contador2++)//for que va desde 0 hasta el tamano del arreglo -2 (0 a 8)
                {
                    if (numeros[contador2] > numeros[contador2 + 1])//if que compara si lo contenido en el arreglo en el indice contador2 
                                                                    //es mayor a lo contenido en el arregglo en el indice Contador2 + 1
                    {
                        varTemporal = numeros[contador2 + 1];//se guarda en la varTemporal lo que este en el arreglo[contador2 + 1]
                        numeros[contador2 + 1] = numeros[contador2];//en el arreglo en el contador2 + 1 se guarda lo que esta en numeros[contador2] 
                        numeros[contador2] = varTemporal;//se guarda en el arreglo[contador2] lo que esta en varTemporal 
                    }
                }
            }
        }

        public void ImpNumerosOrdenados()//Metodo para imprimir los numeros del arreglo de forma ordenada 
        {
            MetodoBurbuja();//Se llama al metodo MetodoBurbuja
            foreach (var item in numeros)//foreach que nos ayuda a imprimir los numeros del arreglo
            {
                Console.Write("{0} ", item);//se imprime en consola los numeros 
            }
            Console.WriteLine();// salto de renglon 
        }
    }
}
