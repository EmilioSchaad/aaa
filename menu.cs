using System;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraPublic
{
    class menu 
    {
        private int num = 0;



        public int Menu()

        {
            Console.WriteLine("Opciones de operaciones");
            Console.WriteLine("_______________________");
            Console.WriteLine("1.Suma");
            Console.WriteLine("2.Resta");
            Console.WriteLine("3.Multiplicacion");
            Console.WriteLine("4.Division");
            Console.WriteLine("5.Potencia");
            Console.WriteLine("6.Raiz");
            Console.WriteLine("7.Salir");
            Console.Write("Usted elegio la opcion: ");
            try
            {
                num = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Por favor, intente de nuevo");
            }
            
            Console.Clear();
            return num;
        
        }
    }
}
