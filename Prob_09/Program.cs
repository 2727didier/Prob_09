using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            Console.Write("Ingrese el primer número: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el segundo número: ");
            num2 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el tercer número: ");
            num3 = int.Parse(Console.ReadLine());
            if (num1 != num2 && num1 != num3 && num2 != num3)
            {
                int mayor = Math.Max(Math.Max(num1, num2), num3);
                Console.WriteLine("El mayor de los tres números es: " + mayor);
            }
            else
            {
                Console.WriteLine("Los números deben ser diferentes.");
            }
        }
    }
}
