private static double Calcular(double a, string op, double b) => op switch
{
    "+" => a + b,
    "-" => a - b,
    "*" => a * b,
    "/" => a / b,
    _ => double.NaN
};

// En btnCalcular_Click, reemplazar el switch por:
double resultado = Calcular(a, operacion, b);
