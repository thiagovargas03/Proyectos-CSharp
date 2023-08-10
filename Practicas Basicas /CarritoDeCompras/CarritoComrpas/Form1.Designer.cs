namespace CarritoComrpas
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
            this.listProductos = new System.Windows.Forms.ListBox();
            this.cmbProductos = new System.Windows.Forms.ComboBox();
            this.agrProd = new System.Windows.Forms.Button();
            this.txtPromo = new System.Windows.Forms.TextBox();
            this.calcPrecio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listProductos
            // 
            this.listProductos.FormattingEnabled = true;
            this.listProductos.ItemHeight = 15;
            this.listProductos.Location = new System.Drawing.Point(42, 28);
            this.listProductos.Name = "listProductos";
            this.listProductos.Size = new System.Drawing.Size(170, 229);
            this.listProductos.TabIndex = 0;
            this.listProductos.SelectedIndexChanged += new System.EventHandler(this.listProductos_SelectedIndexChanged);
            // 
            // cmbProductos
            // 
            this.cmbProductos.FormattingEnabled = true;
            this.cmbProductos.Location = new System.Drawing.Point(259, 28);
            this.cmbProductos.Name = "cmbProductos";
            this.cmbProductos.Size = new System.Drawing.Size(218, 23);
            this.cmbProductos.TabIndex = 1;
            // 
            // agrProd
            // 
            this.agrProd.Location = new System.Drawing.Point(259, 112);
            this.agrProd.Name = "agrProd";
            this.agrProd.Size = new System.Drawing.Size(75, 23);
            this.agrProd.TabIndex = 2;
            this.agrProd.Text = "Agregar";
            this.agrProd.UseVisualStyleBackColor = true;
            this.agrProd.Click += new System.EventHandler(this.agrProd_Click);
            // 
            // txtPromo
            // 
            this.txtPromo.Location = new System.Drawing.Point(259, 67);
            this.txtPromo.Name = "txtPromo";
            this.txtPromo.Size = new System.Drawing.Size(218, 23);
            this.txtPromo.TabIndex = 3;
            // 
            // calcPrecio
            // 
            this.calcPrecio.Location = new System.Drawing.Point(402, 112);
            this.calcPrecio.Name = "calcPrecio";
            this.calcPrecio.Size = new System.Drawing.Size(75, 23);
            this.calcPrecio.TabIndex = 4;
            this.calcPrecio.Text = "Calcular";
            this.calcPrecio.UseVisualStyleBackColor = true;
            this.calcPrecio.Click += new System.EventHandler(this.calcPrecio_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 386);
            this.Controls.Add(this.calcPrecio);
            this.Controls.Add(this.txtPromo);
            this.Controls.Add(this.agrProd);
            this.Controls.Add(this.cmbProductos);
            this.Controls.Add(this.listProductos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox listProductos;
        private ComboBox cmbProductos;
        private Button agrProd;
        private TextBox txtPromo;
        private Button calcPrecio;
    }
}