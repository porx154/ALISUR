namespace SisPronaSur
{
    partial class Impresion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnInicializar = new System.Windows.Forms.Button();
            this.btnVistaPrevia = new System.Windows.Forms.Button();
            this.btnPDF = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(352, 22);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 71);
            this.btnLimpiar.TabIndex = 9;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnInicializar
            // 
            this.btnInicializar.Location = new System.Drawing.Point(28, 22);
            this.btnInicializar.Name = "btnInicializar";
            this.btnInicializar.Size = new System.Drawing.Size(75, 71);
            this.btnInicializar.TabIndex = 8;
            this.btnInicializar.Text = "Inicializar";
            this.btnInicializar.UseVisualStyleBackColor = true;
            this.btnInicializar.Click += new System.EventHandler(this.btnInicializar_Click);
            // 
            // btnVistaPrevia
            // 
            this.btnVistaPrevia.Location = new System.Drawing.Point(271, 22);
            this.btnVistaPrevia.Name = "btnVistaPrevia";
            this.btnVistaPrevia.Size = new System.Drawing.Size(75, 71);
            this.btnVistaPrevia.TabIndex = 7;
            this.btnVistaPrevia.Text = "Vista previa";
            this.btnVistaPrevia.UseVisualStyleBackColor = true;
            this.btnVistaPrevia.Click += new System.EventHandler(this.btnVistaPrevia_Click);
            // 
            // btnPDF
            // 
            this.btnPDF.Location = new System.Drawing.Point(190, 22);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(75, 71);
            this.btnPDF.TabIndex = 6;
            this.btnPDF.Text = "PDF";
            this.btnPDF.UseVisualStyleBackColor = true;
            this.btnPDF.Click += new System.EventHandler(this.btnPDF_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(109, 22);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 71);
            this.btnImprimir.TabIndex = 5;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // Impresion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 118);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnInicializar);
            this.Controls.Add(this.btnVistaPrevia);
            this.Controls.Add(this.btnPDF);
            this.Controls.Add(this.btnImprimir);
            this.Name = "Impresion";
            this.Text = "Impresion";
            this.Load += new System.EventHandler(this.Impresion_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnInicializar;
        private System.Windows.Forms.Button btnVistaPrevia;
        private System.Windows.Forms.Button btnPDF;
        private System.Windows.Forms.Button btnImprimir;
    }
}