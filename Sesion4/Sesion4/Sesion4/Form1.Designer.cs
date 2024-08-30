namespace Sesion4
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnAumentar = new System.Windows.Forms.Button();
            this.BtnDisminuir = new System.Windows.Forms.Button();
            this.NudPorcentaje = new System.Windows.Forms.NumericUpDown();
            this.ProgressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.NudPorcentaje)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnAumentar
            // 
            this.BtnAumentar.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAumentar.Location = new System.Drawing.Point(399, 178);
            this.BtnAumentar.Name = "BtnAumentar";
            this.BtnAumentar.Size = new System.Drawing.Size(32, 32);
            this.BtnAumentar.TabIndex = 0;
            this.BtnAumentar.Text = "+";
            this.BtnAumentar.UseVisualStyleBackColor = true;
            this.BtnAumentar.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnDisminuir
            // 
            this.BtnDisminuir.Font = new System.Drawing.Font("MS Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDisminuir.Location = new System.Drawing.Point(580, 178);
            this.BtnDisminuir.Name = "BtnDisminuir";
            this.BtnDisminuir.Size = new System.Drawing.Size(28, 32);
            this.BtnDisminuir.TabIndex = 1;
            this.BtnDisminuir.Text = "-";
            this.BtnDisminuir.UseVisualStyleBackColor = true;
            this.BtnDisminuir.Click += new System.EventHandler(this.BtnDisminuir_Click);
            // 
            // NudPorcentaje
            // 
            this.NudPorcentaje.Location = new System.Drawing.Point(705, 189);
            this.NudPorcentaje.Name = "NudPorcentaje";
            this.NudPorcentaje.Size = new System.Drawing.Size(120, 18);
            this.NudPorcentaje.TabIndex = 2;
            this.NudPorcentaje.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // ProgressBar1
            // 
            this.ProgressBar1.Location = new System.Drawing.Point(448, 277);
            this.ProgressBar1.Name = "ProgressBar1";
            this.ProgressBar1.Size = new System.Drawing.Size(100, 23);
            this.ProgressBar1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 11F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(939, 386);
            this.Controls.Add(this.ProgressBar1);
            this.Controls.Add(this.NudPorcentaje);
            this.Controls.Add(this.BtnDisminuir);
            this.Controls.Add(this.BtnAumentar);
            this.Font = new System.Drawing.Font("MS Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Red;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Opacity = 0.75D;
            this.ShowIcon = false;
            this.Text = "Ejemplo1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NudPorcentaje)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnAumentar;
        private System.Windows.Forms.Button BtnDisminuir;
        private System.Windows.Forms.NumericUpDown NudPorcentaje;
        private System.Windows.Forms.ProgressBar ProgressBar1;
    }
}

