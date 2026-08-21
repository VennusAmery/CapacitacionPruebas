namespace CalculadoraForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCalcular = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            lblResultado = new Label();
            txtA = new TextBox();
            txtB = new TextBox();
            cmbOp = new ComboBox();
            SuspendLayout();
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(187, 194);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(94, 29);
            btnCalcular.TabIndex = 0;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(88, 25);
            label1.Name = "label1";
            label1.Size = new Size(228, 50);
            label1.TabIndex = 1;
            label1.Text = "Calculadora";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 90);
            label2.Name = "label2";
            label2.Size = new Size(88, 20);
            label2.TabIndex = 2;
            label2.Text = "1er Numero";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 127);
            label3.Name = "label3";
            label3.Size = new Size(47, 20);
            label3.TabIndex = 3;
            label3.Text = "Signo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(46, 164);
            label4.Name = "label4";
            label4.Size = new Size(93, 20);
            label4.TabIndex = 4;
            label4.Text = "2do Numero";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(46, 242);
            label5.Name = "label5";
            label5.Size = new Size(75, 20);
            label5.TabIndex = 5;
            label5.Text = "Resultado";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(232, 242);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(26, 20);
            lblResultado.TabIndex = 6;
            lblResultado.Text = "lbl";
            // 
            // txtA
            // 
            txtA.Location = new Point(165, 90);
            txtA.Name = "txtA";
            txtA.Size = new Size(151, 27);
            txtA.TabIndex = 7;
            // 
            // txtB
            // 
            txtB.Location = new Point(167, 161);
            txtB.Name = "txtB";
            txtB.Size = new Size(149, 27);
            txtB.TabIndex = 8;
            // 
            // cmbOp
            // 
            cmbOp.FormattingEnabled = true;
            cmbOp.Location = new Point(165, 127);
            cmbOp.Name = "cmbOp";
            cmbOp.Size = new Size(151, 28);
            cmbOp.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(380, 343);
            Controls.Add(cmbOp);
            Controls.Add(txtB);
            Controls.Add(txtA);
            Controls.Add(lblResultado);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCalcular);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalcular;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label lblResultado;
        private TextBox txtA;
        private TextBox txtB;
        private ComboBox cmbOp;
    }
}
