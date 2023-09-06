using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Ejercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la categoria del Hotel: ");
            Console.WriteLine("3: Tres estrellas");
            Console.WriteLine("5: Cinco estrellas");
            int estrellas = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la cantidad de dias que desee hospedarse: ");
            int dias = int.Parse(Console.ReadLine());

            float costo = 0f;

            if (estrellas == 3) 
            {
                if (dias >= 1 && dias <= 5)
                {
                    costo = 100 * dias + 7 * dias;
                }
                else if (dias >= 6 && dias <= 10) 
                {
                    costo = 85 * dias + 7 * dias;
                }
                else 
                {
                    costo = 70 * dias + 7 * dias;
                }
                Console.WriteLine("El pago por su estadia es de:" + costo);
            }
            else if (estrellas == 5) 
            {
                if (dias >= 1 && dias <= 5)
                {
                    costo = 300 * dias + 7 * dias;
                }
                else if (dias >= 6 && dias <= 10)
                {
                    costo = 270 * dias + 7 * dias;
                }
                else
                {
                    costo = 250 * dias + 7 * dias;
                }
                Console.WriteLine("El pago por su estadia es de:" + costo);
            }
            Console.ReadKey();
        }
    }
}
