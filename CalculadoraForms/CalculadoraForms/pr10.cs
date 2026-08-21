// Agregar ListBox lstHistorial en Designer

private void btnCalcular_Click(object sender, EventArgs e)
{
    // ... cálculo existente ...
    double resultado = Calcular(a, operacion, b);
    lblResultado.Text = $"Resultado: {resultado}";
    lstHistorial.Items.Add($"{a} {operacion} {b} = {resultado}");
}
