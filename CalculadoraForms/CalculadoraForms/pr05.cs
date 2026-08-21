private void btnCalcular_Click(object sender, EventArgs e)
{
    try
    {
        if (!double.TryParse(txtA.Text, out double a) || !double.TryParse(txtB.Text, out double b))
        {
            lblResultado.Text = "Resultado: Entrada numérica inválida";
            return;
        }
        string? operacion = cmbOp.SelectedItem?.ToString();
        if (string.IsNullOrEmpty(operacion))
        {
            lblResultado.Text = "Resultado: Seleccione una operación";
            return;
        }
        if (operacion == "/" && b == 0)
        {
            lblResultado.Text = "Resultado: No se puede dividir entre cero";
            return;
        }
        double resultado = Calcular(a, operacion, b);
        lblResultado.Text = $"Resultado: {resultado}";
    }
    catch (Exception ex)
    {
        lblResultado.Text = $"Error: {ex.Message}";
    }
}
