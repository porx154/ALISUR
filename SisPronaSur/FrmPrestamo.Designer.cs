namespace SisPronaSur
{
    partial class FrmPrestamo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrestamo));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtinicio = new System.Windows.Forms.DateTimePicker();
            this.txtdni = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtnombape = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnsalir = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.dtfin = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtmonto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtinteres = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtdias = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtinicio);
            this.groupBox1.Controls.Add(this.txtdni);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(29, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(664, 163);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // dtinicio
            // 
            this.dtinicio.Enabled = false;
            this.dtinicio.Location = new System.Drawing.Point(457, 36);
            this.dtinicio.Name = "dtinicio";
            this.dtinicio.Size = new System.Drawing.Size(201, 20);
            this.dtinicio.TabIndex = 3;
            // 
            // txtdni
            // 
            this.txtdni.Enabled = false;
            this.txtdni.Location = new System.Drawing.Point(73, 36);
            this.txtdni.Name = "txtdni";
            this.txtdni.Size = new System.Drawing.Size(136, 20);
            this.txtdni.TabIndex = 2;
            this.txtdni.TextChanged += new System.EventHandler(this.txtdni_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtnombape);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(9, 74);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(649, 83);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // txtnombape
            // 
            this.txtnombape.Enabled = false;
            this.txtnombape.Location = new System.Drawing.Point(121, 31);
            this.txtnombape.Name = "txtnombape";
            this.txtnombape.Size = new System.Drawing.Size(328, 20);
            this.txtnombape.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre y Apellido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "DNI";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox6);
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Location = new System.Drawing.Point(29, 232);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(664, 200);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Prestamo";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnsalir);
            this.groupBox4.Controls.Add(this.btnnuevo);
            this.groupBox4.Controls.Add(this.btnguardar);
            this.groupBox4.Controls.Add(this.btncancelar);
            this.groupBox4.Location = new System.Drawing.Point(9, 126);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(645, 68);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            // 
            // btnsalir
            // 
            this.btnsalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnsalir.BackgroundImage")));
            this.btnsalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnsalir.Location = new System.Drawing.Point(436, 19);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(65, 38);
            this.btnsalir.TabIndex = 7;
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btnnuevo
            // 
            this.btnnuevo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnnuevo.BackgroundImage")));
            this.btnnuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnnuevo.Location = new System.Drawing.Point(83, 19);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(65, 38);
            this.btnnuevo.TabIndex = 4;
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // btnguardar
            // 
            this.btnguardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnguardar.BackgroundImage")));
            this.btnguardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnguardar.Location = new System.Drawing.Point(202, 19);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(65, 38);
            this.btnguardar.TabIndex = 5;
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btncancelar.BackgroundImage")));
            this.btncancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btncancelar.Location = new System.Drawing.Point(322, 19);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(65, 38);
            this.btncancelar.TabIndex = 6;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // dtfin
            // 
            this.dtfin.Enabled = false;
            this.dtfin.Location = new System.Drawing.Point(146, 22);
            this.dtfin.Name = "dtfin";
            this.dtfin.Size = new System.Drawing.Size(201, 20);
            this.dtfin.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Fecha de devolución";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtmonto
            // 
            this.txtmonto.Enabled = false;
            this.txtmonto.Location = new System.Drawing.Point(66, 24);
            this.txtmonto.Name = "txtmonto";
            this.txtmonto.Size = new System.Drawing.Size(102, 20);
            this.txtmonto.TabIndex = 7;
            this.txtmonto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmonto_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Monto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Interes";
            // 
            // txtinteres
            // 
            this.txtinteres.Enabled = false;
            this.txtinteres.Location = new System.Drawing.Point(68, 63);
            this.txtinteres.Name = "txtinteres";
            this.txtinteres.Size = new System.Drawing.Size(49, 20);
            this.txtinteres.TabIndex = 14;
            this.txtinteres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtinteres_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Dias";
            // 
            // txtdias
            // 
            this.txtdias.Enabled = false;
            this.txtdias.Location = new System.Drawing.Point(67, 58);
            this.txtdias.Name = "txtdias";
            this.txtdias.Size = new System.Drawing.Size(53, 20);
            this.txtdias.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(123, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "%";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.txtmonto);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.txtinteres);
            this.groupBox5.Location = new System.Drawing.Point(411, 19);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(243, 101);
            this.groupBox5.TabIndex = 18;
            this.groupBox5.TabStop = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.dtfin);
            this.groupBox6.Controls.Add(this.txtdias);
            this.groupBox6.Controls.Add(this.label4);
            this.groupBox6.Enabled = false;
            this.groupBox6.Location = new System.Drawing.Point(9, 19);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(396, 101);
            this.groupBox6.TabIndex = 19;
            this.groupBox6.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(174, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 16);
            this.label8.TabIndex = 18;
            this.label8.Text = "$";
            // 
            // FrmPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 453);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmPrestamo";
            this.Text = "Prestamo";
            this.Load += new System.EventHandler(this.FrmPrestamo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtinicio;
        private System.Windows.Forms.TextBox txtdni;
        private System.Windows.Forms.TextBox txtnombape;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtmonto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtfin;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.TextBox txtinteres;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtdias;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label8;
    }
}