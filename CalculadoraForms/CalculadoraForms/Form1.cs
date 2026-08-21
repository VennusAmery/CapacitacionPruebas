namespace CalculadoraForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cmbOp.Items.AddRange(new object[] { "+", "-", "*", "/" });
            cmbOp.SelectedIndex = 0;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
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

            double resultado = operacion switch
            {
                "+" => a + b,
                "-" => a - b,
                "*" => a * b,
                "/" => a / b,
                _ => double.NaN
            };

            lblResultado.Text = $"Resultado: {resultado}";
        }
    }
}