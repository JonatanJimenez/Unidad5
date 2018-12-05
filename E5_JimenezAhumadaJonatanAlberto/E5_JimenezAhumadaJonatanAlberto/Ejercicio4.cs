using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E5_JimenezAhumadaJonatanAlberto
{
    class Ejercicio4
    {
        List<int> ListaNum;// se crea una lista de enteros llamada ListaNum
        private void Pedir()
        {
            
            string oracion = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Fusce varius, augue vitae tincidunt viverra, sem felis bibendum nisl, id cursus diam leo sit amet urna. Duis ac massa est.";
            List<char> ListaLetras = new List<char>();// se crea una lista para guardar cada letra de la oracion 
           
            foreach (char letra in oracion)// por cada caracter en la oracion 
            {
                ListaLetras.Add(letra);// se guarda cada letra en la lista ListaLetras
            }

            ListaNum = new List<int>();// se crea una lista de enteros 
            for (int i = 0; i < ListaLetras.Count; i++)//de 0 hasta un numero menos de la lista ListaLetras 
            {
                switch (ListaLetras[i])// se crea un switch 
                {
                    case 'a':// si la letra es a 
                        ListaNum.Add(1);// se agrega el numero a la lista ListaNum 
                        break;
                    case 'b':// si la letra es b 
                        ListaNum.Add(2);// se agrega el numero a la lista ListaNum 
                        break;
                    case 'c':// si la letra es c 
                        ListaNum.Add(3);// se agrega el numero a la lista ListaNum 
                        break;
                    case 'd':// si la letra es d
                        ListaNum.Add(4);// se agrega el numero a la lista ListaNum 
                        break;
                    case 'e':// si la letra es e
                        ListaNum.Add(5);// se agrega el numero a la lista ListaNum 
                        break;
                    case 'f':// si la letra es f
                        ListaNum.Add(6);// se agrega el numero a la lista ListaNum 
                        break;
                    case 'g':// si la letra es g
                        ListaNum.Add(7);// se agrega el numero a la lista ListaNum 
                        break;
                    case 'h':// si la letra es h 
                        ListaNum.Add(8);// se agrega el numero a la lista ListaNum 
                        break;
                    case 'i':// si la letra es i 
                        ListaNum.Add(9);// se agrega el numero a la lista ListaNum 
                        break;
                    case 'j':// si la letra es j 
                        ListaNum.Add(10);// se agrega el numero a la lista ListaNum 
                        break;
                    case 'k':// si la letra es k 
                        ListaNum.Add(11);// se agrega el numero a la lista ListaNum 
                        break;
                    case 'l':// si la letra es l
                        ListaNum.Add(12);// se agrega el numero a la lista ListaNum 
                        break;
                    case 'm':// si la letra es m 
                        ListaNum.Add(13);// se agrega el numero a la lista ListaNum 
                        break;
                    case 'n':// si la letra es n 
                        ListaNum.Add(14);// se agrega el numero a la lista ListaNum 
                        break;
                    case 'o':// si la letra es o 
                        ListaNum.Add(15);// se agrega el numero a la lista ListaNum 
                        break;
                    case 'p':// si la letra es p
                        ListaNum.Add(16);// se agrega el numero a la lista ListaNum 
                        break;
                    case 'q':// si la letra es q 
                        ListaNum.Add(17);// se agrega el numero a la lista ListaNum 
                        break;
                    case 'r':// si la letra es r 
                        ListaNum.Add(18);// se agrega el numero a la lista ListaNum 
                        break;
                    case 's':// si la letra es s
                        ListaNum.Add(19);// se agrega el numero a la lista ListaNum 
                        break;
                    case 't':// si la letra es t
                        ListaNum.Add(20);// se agrega el numero a la lista ListaNum 
                        break;
                    case 'u':// si la letra es u 
                        ListaNum.Add(21);// se agrega el numero a la lista ListaNum 
                        break;
                    case 'v':// si la letra es v 
                        ListaNum.Add(22);// se agrega el numero a la lista ListaNum 
                        break;
                    case 'w':// si la letra es w
                        ListaNum.Add(23);// se agrega el numero a la lista ListaNum 
                        break;
                    case 'x':// si la letra es x
                        ListaNum.Add(24);// se agrega el numero a la lista ListaNum 
                        break;
                    case 'y':// si la letra es y 
                        ListaNum.Add(25);// se agrega el numero a la lista ListaNum 
                        break;
                    case 'z':// si la letra es z
                        ListaNum.Add(26);// se agrega el numero a la lista ListaNum 
                        break;                                            
                    default:
                        break;
                }
            }            
        }

        private void UsarQuickSort(List<int> arreglo, int numInicial, int numFinal)//Se crea un metodo llamado UsarQuickSort donde se le envian 
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
                    int varAuxiliar = arreglo[var1];// se crea una variable auxiliar a la que se le da de valor lo que esta en el arreglo con indice var1 
                    arreglo[var1] = varAuxiliar;//lo que esta en el arreglo con var1 se le da el valor de la variable auxiliar
                    arreglo[var1] = arreglo[var2];//lo que esta en el arreglo con indice var1 se le da el valor de lo que esta en el arreglo de indice var2
                    arreglo[var2] = varAuxiliar;// se le da el valor a lo que esta en el arreglo de indice var2 lo que esta en la variable auxiliar
                    var1++;//incrementa var1
                    var2--;//disminuye var2
                }

            } while (var1 <= var2);// mientras que la var1 sea menor o igual a var2 se ejecutara lo que esta dentro del do-while 

            if (var1 < numFinal) { UsarQuickSort(arreglo, var1, numFinal); } // si var1 es menor a numFinal se manda llamar al metodo usarQuickSort
                                                                             //al que le damos de parametros el arreglo, var1 y numFinal      
            if (var2 > numInicial) { UsarQuickSort(arreglo, numInicial, var2); } // si var2 es mayor a numInicial se manda llamar al metodo usarQuickSort                                                                                 //al que le damos de parametros el arreglo, numInicial y var2                                                                        
        }

        public void Imprimir()// metodo para imprimir 
        {
            Pedir();
            UsarQuickSort(ListaNum, 0, ListaNum.Count - 1);// se llama al metodo de la clase QuickSort llamado UsarQuickSort al que le damos de parametros 
                                                         // el nombre del arreglo, un 0 como numero inicial y como numero final el tamaño del arreglo -1

            string palabra = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            Console.WriteLine("Numeros de la oracion ordenados\n");
            foreach (var item in ListaNum)// se crea un foreach para que imprima los numeros ordenados del arreglo 
            {
                Console.Write("{0} ", item);// se escribe en consola el numero y un espacio
            }

            Console.WriteLine();
            Console.WriteLine("Letras de la oracion ordenados\n");
            foreach (var item in ListaNum)// se crea un foreach para que imprima los numeros ordenados del arreglo 
            {
                Console.Write("{0} ", palabra[item -1]);// se escribe en consola el numero y un espacio
            }
        }
    }
}
