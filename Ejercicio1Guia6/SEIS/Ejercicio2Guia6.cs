using System;

namespace SEIS
{
    //------------------UNICAES------------------
    //---Facultad de Ingenería y Arquitectura---
    //--INGENIERÍA EN DESARROLLO DE SOFTWARE--
    //-Última fecha de modificación: 18.09.19
    //-------Luis Adrián Alfonzo Morán-------
    class Ejercicio2Guia6
    {
        static void Main(string[] args)
        {
            //Base
            decimal widthDibujo;
            decimal heightDibujo;
            string characterDibujo;
            int coordinateY;
            int coordinateX;
            int countLineas;
            //Consulta
            Console.Write("¿De cuánto será el ANCHO del dibujo a realizar?");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write(" (El valor puede ser decimal o entero): ");
            Console.ForegroundColor = ConsoleColor.Gray;
            widthDibujo = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine();
            Console.Write("¿De cuánto será el ALTO del dibujo a realizar?");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write(" (El valor puede ser decimal o entero): ");
            Console.ForegroundColor = ConsoleColor.Gray;
            heightDibujo = Convert.ToDecimal(Console.ReadLine());
            Console.Clear();
            Console.Write("¿Con qué caracter será creado el dibujo?");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write(" ( '*' Es el caracter por defecto): ");
            Console.ForegroundColor = ConsoleColor.Gray;
            characterDibujo = Console.ReadLine();
            Console.WriteLine();
            Console.Write("¿Cuáles son las coordenadas para X? ");
            coordinateX = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.Write("¿Cuáles son las coordenadas para Y? ");
            coordinateY = Convert.ToInt32(Console.ReadLine());
            //Mostrar
            Console.Clear();
            //Proceso de dibujo si X y Y son por defecto en IF
            if (coordinateX == 0 && coordinateY == 0)
            {
                //Proceso de dibujo si el CARACTER es por defecto en IF
                if (characterDibujo == "")
                {
                    Console.WriteLine("----------Voilà----------");
                    Console.WriteLine();
                    for (countLineas = 1; countLineas <= heightDibujo; countLineas++)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine(Dibujar(widthDibujo));
                    }
                    Console.ReadKey();
                }
                //Proceso de dibujo si el CARACTER es seleccionado en IF-ELSE
                else
                {
                    Console.WriteLine("----------Voilà----------");
                    Console.WriteLine();
                    for (countLineas = 1; countLineas <= heightDibujo; countLineas++)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine(Draw(widthDibujo, characterDibujo));
                    }
                    Console.ReadKey();
                }
            }
            //Proceso de dibujo si X y Y es seleccionado en IF
            if (coordinateX > 0 && coordinateY > 0)
            {
                //Proceso de dibujo si el CARACTER es por defecto en IF
                if (characterDibujo == "")
                {
                    Console.WriteLine("----------Voilà----------");
                    for (countLineas = 1; countLineas <= heightDibujo; countLineas++)
                    {
                        Console.Clear();
                        Console.SetCursorPosition(coordinateX, coordinateY);
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine(Dibujar(widthDibujo));
                    }
                    Console.ReadKey();
                }
                //Proceso de dibujo si el CARACTER es seleccionado en IF-ELSE
                else
                {
                    Console.WriteLine("----------Voilà----------");
                    for (countLineas = 1; countLineas <= heightDibujo; countLineas++)
                    {
                        Console.Clear();
                        Console.SetCursorPosition(coordinateX, coordinateY);
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine(Draw(widthDibujo, characterDibujo));
                    }
                    Console.ReadKey();
                }
            }
        }
        //Función dibujar con valores
        public static string Draw(decimal forma, string getForma)
        {
            string ancho = getForma;
            for (int i = 1; i <= forma; i++)
            {
                ancho += getForma;
            }
            return ancho;
        }
        //Función dibujar por defecto
        public static string Dibujar(decimal figura)
        {
            string ancho = "";
            for (int i = 1; i <= figura; i++)
            {
                ancho += "*";
            }
            return ancho;
        }
    }
}
