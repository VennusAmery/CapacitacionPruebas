using System;

class Calculadora
{
    static void Main()
    {
        Console.Write("Primer número: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Operador (+ - * /): ");
        string op = Console.ReadLine();

        Console.Write("Segundo número: ");
        double b = double.Parse(Console.ReadLine());

        double resultado = op switch
        {
            "+" => a + b,
            "-" => a - b,
            "*" => a * b,
            "/" => b != 0 ? a / b : double.NaN,
            _ => double.NaN
        };

        Console.WriteLine($"Resultado: {resultado}");
    }
}