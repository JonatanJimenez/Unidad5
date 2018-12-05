using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E5_JimenezAhumadaJonatanAlberto
{
    class Ejercicio2
    {
        int[] arreglo;//arreglo 
        private int[] Guardar()//metodo 
        {
            Random random = new Random();// se crea un objeto de tipo Random         

            arreglo = new int[80];
            for (int i = 0; i < arreglo.Length; i++)
            {
                arreglo[i] = random.Next(0, 500);// se guarda en cada indice del arreglo un numero random 
                int contador = 0;

                while (contador < i)//mientras que el contador sea menor a i 
                {
                    if (arreglo[contador] == arreglo[i])// se el arreglo en contador es igual al arreglo en i 
                    {
                        arreglo[i] = random.Next(0, 500);// se le agrega otro numero random 
                        contador = 0;//contador se vuelve 0
                        continue;
                    }
                    contador++;// se incrementa el contador 
                }                
            }          
            return arreglo;// me devuelve el arreglo 
        }

        private void Ordenar(int[] arreglo)// se crea el metodo de tipo void llamado Ordenar, como su nombre indica es para ordenar los numeros de un arreglo 
        {
            int[] Arreglotemp = new int[arreglo.Length];// se crea un arreglo que se utilizara para meter los numeros del arreglo en este para ordenar los numeros 
            for (int i = 31; i > -1; i--)// se crea un for que empieza en 31 y si es mayor a -1 se sigue disminuyendo 
            {
                int var = 0;// se crea una variable inicializada en cero
                for (int j = 0; j < arreglo.Length; j++)// se crea otro for que va desde 0, hasta que sea menor al tamaño del arreglo
                {
                    bool move = (arreglo[j] << i) >= 0;// se crea una variable booleana llamada move al que se le da una condicion arreglo en el indice j 
                                                       // desplaza los bits a la izquierda y rellena con cero a la derecha respecto a i, es mayor o igual a cero
                    if (i == 0 ? !move : move)// se crea un if en el cual si la prueba de que i es igual a cero, se evalúa como verdadera, evalúe y devuelva !move; 
                                              //De lo contrario esto se evalua y se devuelve move.
                        arreglo[j - var] = arreglo[j];// si entra en el if el arreglo en el indice j - var se de asigna el valor del arreglo en j 
                    else//si no 
                        Arreglotemp[var++] = arreglo[j];// el Arreglo temporal (Arreglotemp) en el indice var se le asigna el valor de arreglo en j
                }
                Array.Copy(Arreglotemp, 0, arreglo, arreglo.Length - var, var);// se utiliza el metodo Array.Copy para copiar un arreglo en otro en los 
                                                                               // indices especificados 
            }
        }

        public void Imprimir()// metodo para imprimir los numeros ordenados 
        {
            Guardar();
            Ordenar(arreglo);
            Console.WriteLine("Numeros aleatorios ordenados sin repetir: \n");
            foreach (var item in arreglo)
            {
                Console.Write("{0} ", item);
            }
        }
    }
}
    
