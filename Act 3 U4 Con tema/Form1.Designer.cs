namespace Act_3_U4_Con_tema
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
            this.btnProcesarArchivo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnProcesarArchivo
            // 
            this.btnProcesarArchivo.Location = new System.Drawing.Point(124, 109);
            this.btnProcesarArchivo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnProcesarArchivo.Name = "btnProcesarArchivo";
            this.btnProcesarArchivo.Size = new System.Drawing.Size(224, 103);
            this.btnProcesarArchivo.TabIndex = 0;
            this.btnProcesarArchivo.Text = "Procesar Archivo";
            this.btnProcesarArchivo.UseVisualStyleBackColor = true;
            this.btnProcesarArchivo.Click += new System.EventHandler(this.btnProcesarArchivo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 334);
            this.Controls.Add(this.btnProcesarArchivo);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProcesarArchivo;
    }
}

