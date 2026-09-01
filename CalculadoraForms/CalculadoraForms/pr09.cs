// Campos privados en Form1
private string _lastA = "", _lastB = "", _lastOp = "";

// En btnLimpiar_Click, antes de limpiar:
_lastA = txtA.Text;
_lastB = txtB.Text;
_lastOp = cmbOp.Text;

// En Form1(), después de InitializeComponent();
this.KeyPreview = true;
this.KeyDown += (s, e) =>
{
    if (e.Control && e.KeyCode == Keys.Z)
    {
        txtA.Text = _lastA;
        txtB.Text = _lastB;
        cmbOp.Text = _lastOp;
    }
};
