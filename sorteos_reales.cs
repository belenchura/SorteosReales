using System;
using System.Collections;
using System.Collections.Generic;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre_participante;
            List <string> ListaParticipantes = new List <string>();

            Console.WriteLine("******************************************************************************************");
            Console.WriteLine("***************************** BIENVENIDOS A SORTEOS REALES ! *****************************");
            Console.WriteLine("******************************************************************************************");
            Console.WriteLine("");
            
            // guarda los nombres ingresados en lista
            Console.WriteLine("Ingresar nombre de participantes. Para terminar y mostrar los resultados ingrese 0: ");
            nombre_participante = Console.ReadLine();

            while(nombre_participante !=  "0")
            {
               if( ("".Equals(nombre_participante)) || nombre_participante == " ")
            {
                Console.WriteLine("*** No ingresaste ningun nombre. Vuelve a intentar ***"); 
            }
                else
            {
                 ListaParticipantes.Add(nombre_participante);
            }   
                Console.WriteLine(" ");
                Console.WriteLine("Ingresar nombre de participantes. Para terminar y mostrar los resultados ingrese 0: ");
                nombre_participante = Console.ReadLine() ;    
            }

            // muestra el resultado de lista de participantes
            Console.WriteLine(" ");
            Console.WriteLine("***************************** PARTICIPANTES *****************************");

            if(ListaParticipantes.Count != 0)
            {  
                foreach(string item in ListaParticipantes)
                {      
                    Console.WriteLine(item);
                }
            }
            else
            {
                 Console.WriteLine("No se ingreso ningun nombre.");
            }

            Console.WriteLine(" ");
            Console.WriteLine("***************************** GANADOR/A !!! *****************************");
            
            // genera e imprime numero aleatorio, etableciendole un maximo
            Random r = new Random();
            int cantidad_participantes = ListaParticipantes.Count ;
            int indice_aleatorio = r.Next(cantidad_participantes);

            // imprime indice_aleatorio en ListaParticipanteS
            Console.WriteLine (ListaParticipantes[indice_aleatorio]);
            

            Console.WriteLine(" ");
            Console.WriteLine("Presione cualquier tecla para salir...");
            Console.ReadKey();

        }
    }

}