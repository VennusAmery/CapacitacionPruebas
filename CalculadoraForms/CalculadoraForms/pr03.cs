// En constructor Form1(), después de cmbOp.SelectedIndex = 0;
txtB.KeyDown += (s, e) =>
{
    if (e.KeyCode == Keys.Enter)
        btnCalcular_Click(s, e);
};
