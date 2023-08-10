namespace IndiceGrasaCorporal
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
            this.peso = new System.Windows.Forms.Label();
            this.altura = new System.Windows.Forms.Label();
            this.btnEvalIMC = new System.Windows.Forms.Button();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // peso
            // 
            this.peso.AutoSize = true;
            this.peso.Location = new System.Drawing.Point(98, 101);
            this.peso.Name = "peso";
            this.peso.Size = new System.Drawing.Size(35, 15);
            this.peso.TabIndex = 0;
            this.peso.Text = "Peso:";
            this.peso.Click += new System.EventHandler(this.label1_Click);
            // 
            // altura
            // 
            this.altura.AutoSize = true;
            this.altura.Location = new System.Drawing.Point(98, 143);
            this.altura.Name = "altura";
            this.altura.Size = new System.Drawing.Size(42, 15);
            this.altura.TabIndex = 1;
            this.altura.Text = "Altura:";
            this.altura.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnEvalIMC
            // 
            this.btnEvalIMC.Location = new System.Drawing.Point(189, 194);
            this.btnEvalIMC.Name = "btnEvalIMC";
            this.btnEvalIMC.Size = new System.Drawing.Size(75, 23);
            this.btnEvalIMC.TabIndex = 2;
            this.btnEvalIMC.Text = "Evaluar";
            this.btnEvalIMC.UseVisualStyleBackColor = true;
            this.btnEvalIMC.Click += new System.EventHandler(this.btnEvalIMC_Click_1);
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(163, 98);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(125, 23);
            this.txtPeso.TabIndex = 3;
            this.txtPeso.TextChanged += new System.EventHandler(this.txtPeso_TextChanged);
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(163, 140);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(125, 23);
            this.txtAltura.TabIndex = 4;
            this.txtAltura.TextChanged += new System.EventHandler(this.txtAltura_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 325);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.btnEvalIMC);
            this.Controls.Add(this.altura);
            this.Controls.Add(this.peso);
            this.Name = "Form1";
            this.Text = "Calcular Imc";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label peso;
        private Label altura;
        private Button btnEvalIMC;
        private TextBox txtPeso;
        private TextBox txtAltura;
    }
}