using System;

namespace SEIS
{
    //------------------UNICAES------------------
    //---Facultad de Ingenería y Arquitectura---
    //--INGENIERÍA EN DESARROLLO DE SOFTWARE--
    //-Última fecha de modificación: 18.09.19
    //-------Luis Adrián Alfonzo Morán-------
    class Ejercicio3Guia6
    {
        static void Main(string[] args)
        {
            //Base
            int numberExpon;
            int numberBase;
            //Consulta
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("¿Cuál será el número base?");
            //
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            numberBase = Convert.ToInt32(Console.ReadLine());
            //
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("¿Cuál será el exponente? ( {0}^ )", numberBase);
            //
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            numberExpon = Convert.ToInt32(Console.ReadLine());
            //
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(Resultado(numberBase, numberExpon));
            //
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.ReadKey();
        }
        //Función para mostrar el resultado de la elevación
        public static string Resultado(int numeroBase, int numeroExponente)
        {
            //Base
            string equal;
            double equalFinal;
            //Mostrar
            equalFinal = Math.Pow(numeroBase, numeroBase);
            Console.WriteLine();
            Console.Write("El resultado de la elevación {0}^{1}", numeroBase, numeroExponente);
            equal = " es: " + equalFinal;
            return equal;
        }
    }
}
