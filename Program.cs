using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio33
{
    class Program
    {
        static void Main(string[] args)
        {
            // 33. Solicite el ingreso de una fecha al usuario y determine cuántos días restan para el fin de años próximo ás cercano

            bool flag = false;
            string ingreso;
            DateTime fechaCorrecta;

            Console.WriteLine("Ingrese una fecha");
            ingreso = Console.ReadLine();
            do
            {
                if (!DateTime.TryParse(ingreso, out fechaCorrecta))
                {
                    Console.WriteLine("Usted no ha ingresado una fecha");
                }
                else if (fechaCorrecta > DateTime.Now)
                {
                    Console.WriteLine("La fecha no puede ser superior a hoy");
                }
                else 
                {
                    flag = true;
                }
            } while(flag==false);
            DateDiff();
            Console.WriteLine($"La fecha ingresada fue: {fechaCorrecta}");
            Console.WriteLine($"Faltan {} para fin de año");
        }
    }
}
