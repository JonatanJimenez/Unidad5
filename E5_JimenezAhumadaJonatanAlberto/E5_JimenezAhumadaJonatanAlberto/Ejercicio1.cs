using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E5_JimenezAhumadaJonatanAlberto
{
    class Ejercicio1
    {
        int[] arreglo;//se crea un arreglo 
        private void Pedir()
        {
            int num = 0;
            Console.Write("Cuantos numeros desea ingresar: ");// pregunta cuantos numeros quiere ingresar el usuario
            int resp = int.Parse(Console.ReadLine());

            arreglo = new int[resp];//se crea un arreglo 
            for (int i = 0; i < resp; i++)
            {
                Console.Write("\nIngrese un numero: ");
                num = int.Parse(Console.ReadLine());
                while (num < 0 || num > 2)// si el numero no es 0 1 o 2 
                {
                    Console.Write("El numero debe ser de 0 a 2, ingrese otro numero: ");//pide que lo ingrese de nuevo 
                    num = int.Parse(Console.ReadLine());
                }                 
                arreglo[i] = num;// se guarda el numero en el arreglo 
            }
        }
        
        private void MetodoBurbuja()//Metodo llamado MetodoBurbuja donde se haran las operaciones para ordenar los numeros 
        {            
            Pedir();
            int varTemporal; //variable que se utilizara para guardar distintos variables 
            for (int contador1 = 0; contador1 < arreglo.Length; contador1++)//for que va desde 0 al tamano del arreglo -1 (0 a 9)
            {
                for (int contador2 = 0; contador2 < arreglo.Length - 1; contador2++)//for que va desde 0 hasta el tamano del arreglo -2 (0 a 8)
                {
                    if (arreglo[contador2] > arreglo[contador2 + 1])//if que compara si lo contenido en el arreglo en el indice contador2 
                                                                    //es mayor a lo contenido en el arregglo en el indice Contador2 + 1
                    {
                        varTemporal = arreglo[contador2 + 1];//se guarda en la varTemporal lo que este en el arreglo[contador2 + 1]
                        arreglo[contador2 + 1] = arreglo[contador2];//en el arreglo en el contador2 + 1 se guarda lo que esta en numeros[contador2] 
                        arreglo[contador2] = varTemporal;//se guarda en el arreglo[contador2] lo que esta en varTemporal 
                    }
                }
            }
        }

        public void Imprimir()//Metodo para imprimir los numeros del arreglo de forma ordenada 
        {
            MetodoBurbuja();//Se llama al metodo MetodoBurbuja
            Console.WriteLine("\nNumero ordenados: ");
            foreach (var item in arreglo)//foreach que nos ayuda a imprimir los numeros del arreglo
            {
                Console.Write("{0} ", item);//se imprime en consola los numeros 
            }            
        }
    }
}
