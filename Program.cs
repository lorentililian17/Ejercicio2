using System.Collections.Generic;
using System.Linq;
using System.Text;


public class ProyectoPrograma
{
    static void Main(string[] args)
    {

        byte edad;
        Console.WriteLine("ingrese su edad");
        edad = Convert.ToByte(Console.ReadLine());
        Console.WriteLine("usted no aparenta " + edad + " años ");
        Console.WriteLine();

        byte num1, num2;
        ushort mult;
        Console.WriteLine("ingrese un número de dos cifras");
        num1 = Convert.ToByte(Console.ReadLine());
        Console.WriteLine("ingrese un número de dos cifras");
        num2 = Convert.ToByte(Console.ReadLine());
        mult = (ushort)(num1 * num2);
        Console.WriteLine("resultado de la multiplicacion: " + mult);
        Console.WriteLine();

        long n1, n2, rest, sum, prod;
        Console.WriteLine("Ingrese el primer número entero largo: ");
        n1 = Convert.ToInt64(Console.ReadLine());
        Console.WriteLine("Ingrese el segundo número entero largo: ");
        n2 = Convert.ToInt64(Console.ReadLine());
        sum = n1 + n2;
        Console.WriteLine("El resultado de la suma es: " + sum);
        Console.ReadLine();

        rest = n1 - n2;
        Console.WriteLine("El resultado de la resta es: " + rest);
        Console.ReadLine();

        prod = n1 / n2;
        Console.WriteLine("El resultado de el producto: " + prod);
        Console.ReadLine();

    }

}