using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace CalculadoraPublic
{
    class No_c_como_llamarlo
    {
        public Operaciones Operacion = new Operaciones();

        public double n = 0;



        public string Resultado(char t)

        {

            int Tot = 0;



            char op = 's';
           




            while (op != 'n')

            {

                if (t == 's')

                {

                    Tot = Operacion.Suma(Tot, PedirVal());

                }

                else if (t == 'r')

                {

                    Tot = Operacion.Resta(Tot, PedirVal());

                }
                else if (t == 'm')

                {
                    Tot = Operacion.Multiplicacion(Tot, PedirVal());
                }
                else if (t == 'd')

                {
                    Tot = Operacion.Division(Tot, PedirVal());
                }
                else if (t == 'p')

                {

                    Tot = Operacion.potencia(Tot, PedirVal());
                }
                else if (t == 'q')
                {
                    Tot = Operacion.Raiz(Tot, PedirVal());
                }


                bool a = false;
                Console.WriteLine("¿Quiere entrar otro valor?");
                 Console.WriteLine("[Si]                 [No]");
              
                while (a == false)
                {
                 try
                 {
                        
                 op = char.Parse(Console.ReadLine());
                   a = true;
                  }
                 catch
                    {
                    Console.WriteLine("Ingrese valores alfabeticos");
                    op = char.Parse(Console.ReadLine());
                       
                    }
               
                     
                }
               
            }

           

            return ("El resultado de la operacion es: " + Tot);

        }



        private int PedirVal()
        {
            int Val = 0;
            bool Est = false;



            while (Est == false)

            {

                Console.Write("ingrese un Numero: ");

                try

                {

                    Val = int.Parse(Console.ReadLine());

                    Est = true;

                }

                catch

                {
                    Console.WriteLine("Caracter o operacion invalida, por favor intente de nuevo");
                }

            }
            return Val;

        }
    }
}
