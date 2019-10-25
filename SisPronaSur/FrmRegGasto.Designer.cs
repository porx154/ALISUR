namespace SisPronaSur
{
    partial class FrmRegGasto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRegGasto));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtdesgasto = new System.Windows.Forms.TextBox();
            this.cmbgasto = new System.Windows.Forms.ComboBox();
            this.txtmontogasto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnsalir = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Monto";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtdesgasto);
            this.groupBox1.Controls.Add(this.cmbgasto);
            this.groupBox1.Controls.Add(this.txtmontogasto);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(23, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(443, 218);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // txtdesgasto
            // 
            this.txtdesgasto.Enabled = false;
            this.txtdesgasto.Location = new System.Drawing.Point(107, 109);
            this.txtdesgasto.Multiline = true;
            this.txtdesgasto.Name = "txtdesgasto";
            this.txtdesgasto.Size = new System.Drawing.Size(287, 103);
            this.txtdesgasto.TabIndex = 5;
            // 
            // cmbgasto
            // 
            this.cmbgasto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbgasto.FormattingEnabled = true;
            this.cmbgasto.Location = new System.Drawing.Point(107, 72);
            this.cmbgasto.Name = "cmbgasto";
            this.cmbgasto.Size = new System.Drawing.Size(287, 21);
            this.cmbgasto.TabIndex = 4;
            // 
            // txtmontogasto
            // 
            this.txtmontogasto.Enabled = false;
            this.txtmontogasto.Location = new System.Drawing.Point(107, 27);
            this.txtmontogasto.Name = "txtmontogasto";
            this.txtmontogasto.Size = new System.Drawing.Size(113, 20);
            this.txtmontogasto.TabIndex = 3;
            this.txtmontogasto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmontogasto_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descripción";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo de Gasto";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnsalir);
            this.groupBox2.Controls.Add(this.btncancelar);
            this.groupBox2.Controls.Add(this.btnguardar);
            this.groupBox2.Controls.Add(this.btnnuevo);
            this.groupBox2.Location = new System.Drawing.Point(472, 60);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(89, 218);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // btnsalir
            // 
            this.btnsalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnsalir.BackgroundImage")));
            this.btnsalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnsalir.Location = new System.Drawing.Point(12, 164);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(65, 38);
            this.btnsalir.TabIndex = 3;
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btncancelar.BackgroundImage")));
            this.btncancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btncancelar.Location = new System.Drawing.Point(12, 120);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(65, 38);
            this.btncancelar.TabIndex = 2;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnguardar.BackgroundImage")));
            this.btnguardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnguardar.Location = new System.Drawing.Point(12, 72);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(65, 38);
            this.btnguardar.TabIndex = 1;
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btnnuevo
            // 
            this.btnnuevo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnnuevo.BackgroundImage")));
            this.btnnuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnnuevo.Location = new System.Drawing.Point(12, 27);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(65, 38);
            this.btnnuevo.TabIndex = 0;
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // FrmRegGasto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 301);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmRegGasto";
            this.Text = "Gasto";
            this.Load += new System.EventHandler(this.FrmRegGasto_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtdesgasto;
        private System.Windows.Forms.ComboBox cmbgasto;
        private System.Windows.Forms.TextBox txtmontogasto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btnnuevo;
    }
}