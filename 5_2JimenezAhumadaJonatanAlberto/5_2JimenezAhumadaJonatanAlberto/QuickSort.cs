using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_2JimenezAhumadaJonatanAlberto
{
    class QuickSort
    {
        public void UsarQuickSort(double[] arreglo, int numInicial, int numFinal)//Se crea un metodo llamado UsarQuickSort donde se le envian 
                                                                                 //de parametros un arreglo, un numero inicial y otro final 
        {
            int var1 = numInicial;// se le asigna el valor a var1 del entero que contenga numInicial
            int var2 = numFinal;// se le asigna el valor a var1 del entero que contenga numInicial
            double pivote = arreglo[(numInicial + numFinal) / 2]; // se crea una variable llamado pivote al que se le da el valor del numero que este en el centro del arreglo
                                                                 
            do // se crea un do-while 
            {
                while (arreglo[var1] < pivote) { var1++; }// mientras que el numero que esta en el arreglo con indice var1 sea menor al pivote, se aumenta var1
                while (arreglo[var2] > pivote) { var2--; }// mientras que el numero que esta en el arreglo con indice var2 sea mayor al pivote, se disminuye var2

                if (var1 <= var2)// si var1 es menor a var2 
                {
                    double varAuxiliar = arreglo[var1];// se crea una variable auxiliar a la que se le da de valor lo que esta en el arreglo con indice var1 
                    arreglo[var1] = varAuxiliar;//lo que esta en el arreglo con var1 se le da el valor de la variable auxiliar
                    arreglo[var1] = arreglo[var2];//lo que esta en el arreglo con indice var1 se le da el valor de lo que esta en el arreglo de indice var2
                    arreglo[var2] = varAuxiliar;// se le da el valor a lo que esta en el arreglo de indice var2 lo que esta en la variable auxiliar
                    var1++;//incrementa var1
                    var2--;//disminuye var2
                }

            } while (var1 <= var2) ;// mientras que la var1 sea menor o igual a var2 se ejecutara lo que esta dentro del do-while 

            if (var1 < numFinal) { UsarQuickSort(arreglo, var1, numFinal); } // si var1 es menor a numFinal se manda llamar al metodo usarQuickSort
                                                                             //al que le damos de parametros el arreglo, var1 y numFinal      
            if (var2 > numInicial) { UsarQuickSort(arreglo, numInicial, var2); } // si var2 es mayor a numInicial se manda llamar al metodo usarQuickSort
                                                                                 //al que le damos de parametros el arreglo, numInicial y var2                                                                        
        }
    }
}
