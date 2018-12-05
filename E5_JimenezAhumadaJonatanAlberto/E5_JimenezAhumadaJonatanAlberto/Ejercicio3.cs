using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E5_JimenezAhumadaJonatanAlberto
{
    class Ejercicio3
    {
        int[] arreglo;
        private void Pedir()// metodo para imprimir los numeros 
        {
            int num = 0;
            Console.Write("Cuantos numeros desea ingresar: ");
            int resp = int.Parse(Console.ReadLine());

            arreglo = new int[resp];
            for (int i = 0; i < resp; i++)
            {
                Console.Write("\nIngrese un numero: ");
                num = int.Parse(Console.ReadLine());                
                arreglo[i] = num;// se guarda el numero en el arreglo 
            }
        }

        private void ShellSort()
        {
            Pedir();// se manda llamar al metodo 
            int aux1, aux2, aux3, mitad;
            mitad = arreglo.Length / 2;

            while (mitad > 0)// mientras mitad sea menor a cero 
            {
                for (aux1 = mitad; aux1 < arreglo.Length; aux1++)// desde la mitad de la cantidad de numeros hasta uno menos del tamaño arreglo
                {
                    aux2 = aux1 - mitad;// se iguala la aux2 a la aux1 - el numero de la mitad 
                    while (aux2 >= 0)// mientras la aux2 sea mayor o igual a 0 
                    {
                        aux3 = aux2 + mitad;// la aux3 se iguala a la aux2 mas el numero de la mitad 
                        if (arreglo[aux2] >= arreglo[aux3])// se hace una comparacion 
                        {
                            aux2 = -1;// se iguala la aux2 a -1 
                        }
                        else// si no 
                        {
                            int aux = arreglo[aux2];// la aux se iguala a lo que contenga el arreglo en la aux2 
                            arreglo[aux2] = arreglo[aux3];// se iguala lo del arreglo en la aux2 a lo que tiene el arreglo en la aux3
                            arreglo[aux3] = aux;// se iguala el lo que contenga el arreglo en la aux3 a la aux
                            aux2 -= mitad;// se le resta a aux2 la mitad y se guarda en aux2 el resultado 
                        }
                    }
                }
                mitad /= 2; // se divide entre 2 la mitad y se guarda en mitad 
            }                      
        }

        public void Imprimir()// metodo para imprimir 
        {
            ShellSort();
            Console.WriteLine("\nNumeros ordenados de forma descendente\n");
            foreach (var item in arreglo)
            {
                Console.Write("{0} ", item);
            }
        }
    }
}
