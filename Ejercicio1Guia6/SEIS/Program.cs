using System;

namespace SEIS
{
    //------------------UNICAES------------------
    //---Facultad de Ingenería y Arquitectura---
    //--INGENIERÍA EN DESARROLLO DE SOFTWARE--
    //-Última fecha de modificación: 11.09.19
    //-------Luis Adrián Alfonzo Morán-------
    class Program
    {
        //Función para crear Tabla
        static string CrearTabla(int numPor)
        {
            //Base de función CrearTabla
            int numero1 = 0;
            int numero2 = numPor;
            int final;
            string resultadoFinal = "";
            //Proceso de multiplicar normal en FOR
            for (int inicio = 1; inicio <= 10; inicio++)
            {
                numero1 = +numero1 + 1;
                final = numero1 * numero2;
                Console.WriteLine("({0})  ({1}) =    {2}", numero2, numero1, final);
            }
            return resultadoFinal;
        }
        //Función para pintar Tabla
        static string PintarTabla(int numeroEspecial, int mostrarColor)
        {
            //Base de función PintarTabla
            string tablaFinal = "";
            int numeroo1 = 0;
            int numeroo2 = numeroEspecial;
            int final;
            //Proceso de pintar en IF
            if (mostrarColor == 1)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
            }
            //Proceso de multiplicar lo pintado en FOR
            for (int tabla = 1; tabla <= 10; tabla++)
            {
                numeroo1 = +numeroo1 + 1;
                final = numeroo1 * numeroo2;
                Console.WriteLine("({0})  ({1}) = {2}", numeroo2, numeroo1, final);
            }
            return tablaFinal;
        }
        static void Main(string[] args)
        {
            //Consulta
            Console.WriteLine("¿Con qué tabla de multiplicar trabajaremos? ");
            int numeroMultiplicar = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("COLORES");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("[1]                    Amarillo");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("[Cualquier otra tecla] para el color por defecto: ");
            //Proceso de muestra en IF
            if (int.TryParse(Console.ReadLine(), out int opcionColor))
            {
                Console.Clear();
                Console.WriteLine(PintarTabla(numeroMultiplicar, opcionColor));
                Console.ReadKey();
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            else
            {
                Console.Clear();
                Console.WriteLine(CrearTabla(numeroMultiplicar));
                Console.ReadKey();
            }
        }
    }
}
