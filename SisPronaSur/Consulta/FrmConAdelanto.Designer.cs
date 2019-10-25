namespace SisPronaSur.Consulta
{
    partial class FrmConAdelanto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConAdelanto));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtnomape = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpinicio = new System.Windows.Forms.DateTimePicker();
            this.txtdni = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnsalir = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dtpfechdevolucion = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmontosoles = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtnomape);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(23, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(504, 134);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // txtnomape
            // 
            this.txtnomape.Enabled = false;
            this.txtnomape.Location = new System.Drawing.Point(124, 96);
            this.txtnomape.Name = "txtnomape";
            this.txtnomape.Size = new System.Drawing.Size(285, 20);
            this.txtnomape.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre y Apellido";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtpinicio);
            this.groupBox2.Controls.Add(this.txtdni);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(6, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(492, 57);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // dtpinicio
            // 
            this.dtpinicio.Enabled = false;
            this.dtpinicio.Location = new System.Drawing.Point(286, 23);
            this.dtpinicio.Name = "dtpinicio";
            this.dtpinicio.Size = new System.Drawing.Size(200, 20);
            this.dtpinicio.TabIndex = 2;
            // 
            // txtdni
            // 
            this.txtdni.Enabled = false;
            this.txtdni.Location = new System.Drawing.Point(52, 23);
            this.txtdni.Name = "txtdni";
            this.txtdni.Size = new System.Drawing.Size(161, 20);
            this.txtdni.TabIndex = 1;
            this.txtdni.TextChanged += new System.EventHandler(this.txtdni_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "DNI";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Location = new System.Drawing.Point(23, 203);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(504, 159);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Adelanto";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnsalir);
            this.groupBox5.Controls.Add(this.btncancelar);
            this.groupBox5.Controls.Add(this.btnguardar);
            this.groupBox5.Controls.Add(this.btnnuevo);
            this.groupBox5.Location = new System.Drawing.Point(371, 19);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(127, 134);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            // 
            // btnsalir
            // 
            this.btnsalir.Image = ((System.Drawing.Image)(resources.GetObject("btnsalir.Image")));
            this.btnsalir.Location = new System.Drawing.Point(25, 102);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 27);
            this.btnsalir.TabIndex = 7;
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.button3_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Enabled = false;
            this.btncancelar.Image = ((System.Drawing.Image)(resources.GetObject("btncancelar.Image")));
            this.btncancelar.Location = new System.Drawing.Point(25, 71);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(75, 26);
            this.btncancelar.TabIndex = 6;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.Enabled = false;
            this.btnguardar.Image = ((System.Drawing.Image)(resources.GetObject("btnguardar.Image")));
            this.btnguardar.Location = new System.Drawing.Point(25, 41);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(75, 26);
            this.btnguardar.TabIndex = 5;
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btnnuevo
            // 
            this.btnnuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnnuevo.Image")));
            this.btnnuevo.Location = new System.Drawing.Point(25, 12);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(75, 26);
            this.btnnuevo.TabIndex = 4;
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dtpfechdevolucion);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.txtmontosoles);
            this.groupBox4.Location = new System.Drawing.Point(6, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(359, 134);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            // 
            // dtpfechdevolucion
            // 
            this.dtpfechdevolucion.Enabled = false;
            this.dtpfechdevolucion.Location = new System.Drawing.Point(142, 25);
            this.dtpfechdevolucion.Name = "dtpfechdevolucion";
            this.dtpfechdevolucion.Size = new System.Drawing.Size(200, 20);
            this.dtpfechdevolucion.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Fecha Devolucion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Monto .S/";
            // 
            // txtmontosoles
            // 
            this.txtmontosoles.Enabled = false;
            this.txtmontosoles.Location = new System.Drawing.Point(142, 86);
            this.txtmontosoles.Name = "txtmontosoles";
            this.txtmontosoles.Size = new System.Drawing.Size(89, 20);
            this.txtmontosoles.TabIndex = 2;
            this.txtmontosoles.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmontosoles_KeyPress);
            // 
            // FrmConAdelanto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 385);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmConAdelanto";
            this.Text = "Adelanto";
            this.Load += new System.EventHandler(this.FrmConAdelanto_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtdni;
        private System.Windows.Forms.TextBox txtnomape;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtmontosoles;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DateTimePicker dtpinicio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpfechdevolucion;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btnnuevo;
    }
}