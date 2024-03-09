using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P1_Programacion1_SerieIII_B
{
    internal class Program
    {
        
        static void Main(string[] args)

        {
            try
            {
                Console.WriteLine("Bienbenido");
                Console.WriteLine("Ingresa tu correo");

                string nombreUsuario = Console.ReadLine();

                string Correo = ("mium.edu.gt");



                Console.WriteLine($"\nHola {nombreUsuario}, Tu correo es {nombreUsuario:F2} {Correo:F2}");



            }
            finally 
            {
                Console.WriteLine("Gracias por registrarte");
            
            
            
            
            }
         

        }
    }
}
