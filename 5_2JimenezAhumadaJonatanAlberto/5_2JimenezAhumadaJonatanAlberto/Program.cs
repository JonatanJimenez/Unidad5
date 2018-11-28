using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_2JimenezAhumadaJonatanAlberto
{
    class Program
    {
        static void Main(string[] args)
        {
            Imprimir imprimir = new Imprimir();// Se crea un objeto de tipo Imprimir 

            imprimir.ImprimirListaNumeros();// llamamos al metodo llamado ImprimirListaNumeros que nos imprimira los numeros de forma ordenada 
            Console.ReadKey();//detiene la ejecucion hasta que se presione alguna tecla
        }
    }
}
