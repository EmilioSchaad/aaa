using System;


namespace CalculadoraPublic
{
    class Program
    {
        
        static No_c_como_llamarlo Operacion = new No_c_como_llamarlo();
        
        static menu menu = new menu();
        static void Main(string[] args)
        {
            int Opcion = 0;

            while (Opcion != 7)

            {
                Opcion = menu.Menu();

                if (Opcion == 1)

                {
                    Console.WriteLine(Operacion.Resultado('s'));
                }

                else if (Opcion == 2)

                {
                    Console.WriteLine(Operacion.Resultado('r'));
                }

                else if (Opcion == 3)

                {
                    Console.WriteLine(Operacion.Resultado('m'));
                }

                else if (Opcion == 4)

                {
                    Console.WriteLine(Operacion.Resultado('d'));

                }

                else if (Opcion == 5)
                {
                    Console.WriteLine(Operacion.Resultado('p'));
                }
                else if (Opcion == 6)
                {
                    Console.WriteLine(Operacion.Resultado('q'));
                }
            }





            Console.ReadKey();
        }
    }
}
