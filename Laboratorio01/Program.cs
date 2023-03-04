using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejemplo");
            Console.WriteLine("Hello, World!");
            Console.ReadKey();

            int n1, n2;
            int suma, resta, multiplicacion, DIV, MOD;
            double n3, n4, division;
            Console.WriteLine("\n" + "Ejercicio 1: Operaciones Aritméticas");
            Console.Write("Ingrese un número: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese otro número: ");
            n2 = Convert.ToInt32(Console.ReadLine());
            suma = n1 + n2;
            Console.WriteLine("\n" + n1 + " + " + n2 + " = " + suma);
            resta = n1 - n2;
            Console.WriteLine(n1 + " - " + n2 + " = " + resta);
            multiplicacion = n1 * n2;
            Console.WriteLine(n1 + " * " + n2 + " = " + multiplicacion);
            n3 = Convert.ToDouble(n1);
            n4 = Convert.ToDouble(n2);
            if (n4 == 0)
            {
                Console.WriteLine(n1 + " / " + n2 + " = " + "Error: No se puede dividir entre cero");
            }
            else
            {
                division = n3 / n4;
                Console.WriteLine(n1 + " / " + n2 + " = " + division);
            }
            if (n2 == 0)
            {
                Console.WriteLine(n1 + " DIV " + n2 + " = " + "Error: No es posible realizar el DIV");
                Console.WriteLine(n1 + " MOD " + n2 + " = " + "Error: No es posible realizar el MOD");
            }
            else
            {
                DIV = n1 / n2;
                Console.WriteLine(n1 + " DIV " + n2 + " = " + DIV);
                MOD = n1 % n2;
                Console.WriteLine(n1 + " MOD " + n2 + " = " + MOD);
            }
            Console.ReadKey();

            Console.WriteLine("\n\n" + "Ejercicio 2: Operaciones Booleanas");
            if (n1 > n2)
            {
                Console.WriteLine("\n" + n1 + " > " + n2 + " (" + n1 + " mayor que " + n2 + ")");
            }
            if (n1 < n2)
            {
                Console.WriteLine("\n" + n1 + " < " + n2 + " (" + n1 + " menor que " + n2 + ")");
            }
            if (n1 == n2)
            {
                Console.WriteLine("\n" + n1 + " == " + n2 + " (" + n1 + " es igual que " + n2 + ")");
            }
            Console.ReadKey();

            int a, b, c, resultado1, resultado2;
            double x, y, z, resultado3, resultado4;
            Console.WriteLine("\n\n" + "Ejercicio 3: Jerarquía de Operaciones");
            Console.Write("Ingrese un número al valor a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese un número al valor b: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese un número al valor c: ");
            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("a = " + a + ", b = " + b + ", c = " + c);

            resultado1 = (a * b) + c;
            Console.WriteLine("\n" + a + " * " + b + " + " + c + " = " + resultado1);
            resultado2 = a * (b + c);
            Console.WriteLine(a + " * (" + b + " + " + c + ") = " + resultado2);
            x = Convert.ToDouble(a);
            y = Convert.ToDouble(b);
            z = Convert.ToDouble(c);
            if ((y * z) == 0)
            {
                Console.WriteLine(a + " / (" + b + " * " + c + ") = " + "Error: No se puede dividir entre cero");
            }
            else
            {
                resultado3 = x / (y * z);
                Console.WriteLine(a + " / (" + b + " * " + c + ") = " + resultado3);
            }
            if (z == 0)
            {
                Console.WriteLine("(3(" + a + ") + 2(" + b + ")) / (" + c + "^2) = " + "Error: No se puede dividir entre cero");
            }
            else
            {
                resultado4 = ((3 * x) + (2 * y)) / (Math.Pow(z, 2));
                Console.WriteLine("(3(" + a + ") + 2(" + b + ")) / (" + c + "^2) = " + resultado4);
            }
            Console.ReadKey();

            double x1, x2;
            Console.WriteLine("\n\n" + "Ejercicio 4: Expresión Cuadrática");
            Console.WriteLine("a = " + a + ", b = " + b + ", c = " + c);

            if (x == 0 || ((Math.Pow(y, 2)) - (4 * x * z)) < 0)
            {
                Console.WriteLine("\n" + "(-(" + y + ") ± (√" + y + "^2 - 4(" + x + ")(" + z + "))) / (2(" + x + ")) = " + "Error: Verificar si a != 0 y b^2 − 4ac >= 0 ");
            }
            else
            {
                x1 = (-(y) + (Math.Sqrt((Math.Pow(y, 2)) - (4 * x * z)))) / (2 * x);
                Console.WriteLine("\n" + "(-(" + y + ") + (√" + y + "^2 - 4(" + x + ")(" + z + "))) / (2(" + x + ")) = " + x1);
                x2 = (-(y) - (Math.Sqrt((Math.Pow(y, 2)) - (4 * x * z)))) / (2 * x);
                Console.WriteLine("(-(" + y + ") - (√" + y + "^2 - 4(" + x + ")(" + z + "))) / (2(" + x + ")) = " + x2);

            }
            Console.ReadKey();
        }
    }
}
