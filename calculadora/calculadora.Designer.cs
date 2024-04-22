namespace calculadora
{
    partial class calculadora
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
            txtNumero1 = new TextBox();
            btnSumar = new Button();
            txtNumero2 = new TextBox();
            lblNumero1 = new Label();
            lblNumero2 = new Label();
            lblResultado = new Label();
            btnRestar = new Button();
            btnMultiplicar = new Button();
            btnDividir = new Button();
            SuspendLayout();
            // 
            // txtNumero1
            // 
            txtNumero1.Location = new Point(12, 33);
            txtNumero1.Name = "txtNumero1";
            txtNumero1.Size = new Size(355, 23);
            txtNumero1.TabIndex = 0;
            // 
            // btnSumar
            // 
            btnSumar.Location = new Point(12, 227);
            btnSumar.Name = "btnSumar";
            btnSumar.Size = new Size(81, 37);
            btnSumar.TabIndex = 1;
            btnSumar.Text = "Sumar";
            btnSumar.UseVisualStyleBackColor = true;
            btnSumar.Click += btnSumar_Click;
            // 
            // txtNumero2
            // 
            txtNumero2.Location = new Point(12, 106);
            txtNumero2.Name = "txtNumero2";
            txtNumero2.Size = new Size(355, 23);
            txtNumero2.TabIndex = 2;
            // 
            // lblNumero1
            // 
            lblNumero1.AutoSize = true;
            lblNumero1.Location = new Point(12, 15);
            lblNumero1.Name = "lblNumero1";
            lblNumero1.Size = new Size(60, 15);
            lblNumero1.TabIndex = 3;
            lblNumero1.Text = "Número 1";
            // 
            // lblNumero2
            // 
            lblNumero2.AutoSize = true;
            lblNumero2.Location = new Point(12, 88);
            lblNumero2.Name = "lblNumero2";
            lblNumero2.Size = new Size(60, 15);
            lblNumero2.TabIndex = 4;
            lblNumero2.Text = "Número 2";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(12, 149);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(65, 15);
            lblResultado.TabIndex = 5;
            lblResultado.Text = "Resultado: ";
            lblResultado.Click += lblResultado_Click;
            // 
            // btnRestar
            // 
            btnRestar.Location = new Point(99, 227);
            btnRestar.Name = "btnRestar";
            btnRestar.Size = new Size(81, 37);
            btnRestar.TabIndex = 6;
            btnRestar.Text = "Restar";
            btnRestar.UseVisualStyleBackColor = true;
            btnRestar.Click += btnRestar_Click;
            // 
            // btnMultiplicar
            // 
            btnMultiplicar.Location = new Point(12, 270);
            btnMultiplicar.Name = "btnMultiplicar";
            btnMultiplicar.Size = new Size(81, 37);
            btnMultiplicar.TabIndex = 7;
            btnMultiplicar.Text = "Multiplicar";
            btnMultiplicar.UseVisualStyleBackColor = true;
            btnMultiplicar.Click += btnMultiplicar_Click;
            // 
            // btnDividir
            // 
            btnDividir.Location = new Point(99, 270);
            btnDividir.Name = "btnDividir";
            btnDividir.Size = new Size(81, 37);
            btnDividir.TabIndex = 8;
            btnDividir.Text = "Dividir";
            btnDividir.UseVisualStyleBackColor = true;
            btnDividir.Click += btnDividir_Click;
            // 
            // calculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(379, 344);
            Controls.Add(btnDividir);
            Controls.Add(btnMultiplicar);
            Controls.Add(btnRestar);
            Controls.Add(lblResultado);
            Controls.Add(lblNumero2);
            Controls.Add(lblNumero1);
            Controls.Add(txtNumero2);
            Controls.Add(btnSumar);
            Controls.Add(txtNumero1);
            Name = "calculadora";
            Text = "Calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNumero1;
        private Button btnSumar;
        private TextBox txtNumero2;
        private Label lblNumero1;
        private Label lblNumero2;
        private Label lblResultado;
        private Button btnRestar;
        private Button btnMultiplicar;
        private Button btnDividir;
    }
}