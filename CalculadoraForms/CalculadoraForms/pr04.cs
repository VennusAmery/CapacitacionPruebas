// Agregar en Form1(), y crear estos handlers
txtA.KeyPress += ValidarNumero_KeyPress;
txtB.KeyPress += ValidarNumero_KeyPress;

private void ValidarNumero_KeyPress(object? sender, KeyPressEventArgs e)
{
    if (char.IsControl(e.KeyChar)) return;
    if (char.IsDigit(e.KeyChar)) return;
    if (e.KeyChar == '.' && sender is TextBox tb && !tb.Text.Contains('.')) return;
    if (e.KeyChar == '-' && sender is TextBox tb2 && tb2.SelectionStart == 0) return;
    e.Handled = true;
}
