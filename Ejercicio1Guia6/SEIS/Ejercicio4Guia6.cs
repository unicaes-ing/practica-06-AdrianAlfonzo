using System;

namespace SEIS
{
    //------------------UNICAES------------------
    //---Facultad de Ingenería y Arquitectura---
    //--INGENIERÍA EN DESARROLLO DE SOFTWARE--
    //-Última fecha de modificación: 18.09.19
    //-------Luis Adrián Alfonzo Morán-------
    class Ejercicio4Guia6
    {
        static void Main(string[] args)
        {
            //Base
            decimal numeroEntrada;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("¿Qué número decimal convertirá?");
            if (decimal.TryParse(Console.ReadLine(), out numeroEntrada))
            {
                Console.WriteLine(Binary(numeroEntrada));
                Console.ReadKey();
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine();
                Console.WriteLine("NO PERMITIDO");
                Console.ResetColor();
                Console.ReadKey();
            }
        }
        public static string Binary(decimal numberEntrada)
        {
            string resultFinal = "Representación binaria: ";
            for (int start = 0; start <= numberEntrada; start++)
            {
                numberEntrada /= 2;
                if (numberEntrada % 2 == 0)
                {
                    resultFinal += "0";
                }
                else
                { 
                    resultFinal += "1";
                }
            }
            return resultFinal;
        }
    }
}
