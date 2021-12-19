using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buscar_el_mayor
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num;
            int TomaNumero = 0;
            int NumeroMaximo = 0;
            for(int i = 1; i <= 10; i++)
            {
                Console.Write("Ingrese un Número por favor: ");
                Num = int.Parse(Console.ReadLine());
                if(TomaNumero == 0)
                {
                    TomaNumero = 1;
                    NumeroMaximo = Num;
                }
                else
                {
                    if(Num >= NumeroMaximo)
                    {
                        NumeroMaximo = Num;
                    }
                }
            }
            Console.WriteLine("El Número maximo ingresado es: {0} ", NumeroMaximo);
            Console.Read();
        }
    }
}
