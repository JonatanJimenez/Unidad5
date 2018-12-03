using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_3JimenezAhumadaJonatanAlberto
{
    class Program
    {        
        static void Main(string[] args)
        {
            Imprimir imprimir = new Imprimir();// se crea un objeto de tipo Imprimir 

            imprimir.Mostrar();// se manda a llamar el metodo que contiene los arreglos y los ordena llamado Mostrar contenido en la clase Imprimir
            Console.ReadKey();// se detiene la ejecucion del programa                        
        }                   
    }
}
