private void btnCalcular_Click(object sender, EventArgs e)
{
    if (!double.TryParse(txtA.Text, out double a) || !double.TryParse(txtB.Text, out double b))
    {
        lblResultado.ForeColor = Color.Red;
        lblResultado.Text = "Resultado: Entrada numérica inválida";
        return;
    }
    string? operacion = cmbOp.SelectedItem?.ToString();
    if (string.IsNullOrEmpty(operacion))
    {
        lblResultado.ForeColor = Color.Red;
        lblResultado.Text = "Resultado: Seleccione una operación";
        return;
    }
    if (operacion == "/" && b == 0)
    {
        lblResultado.ForeColor = Color.Red;
        lblResultado.Text = "Resultado: No se puede dividir entre cero";
        return;
    }
    double resultado = Calcular(a, operacion, b);
    lblResultado.ForeColor = Color.Green;
    lblResultado.Text = $"Resultado: {resultado:F2}";
}

private static double Calcular(double a, string op, double b) => op switch
{
    "+" => a + b,
    "-" => a - b,
    "*" => a * b,
    "/" => a / b,
    _ => double.NaN
};
