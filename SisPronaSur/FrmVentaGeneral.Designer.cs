namespace SisPronaSur
{
    partial class FrmVentaGeneral
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVentaGeneral));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtdnioruc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtphventa = new System.Windows.Forms.TextBox();
            this.txtvalunitarioventa = new System.Windows.Forms.TextBox();
            this.txtpesototal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbtipoproducto = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbmoneda = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.btnregistrar = new System.Windows.Forms.Button();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtdnioruc);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(23, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 76);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busqueda";
            // 
            // txtdnioruc
            // 
            this.txtdnioruc.Location = new System.Drawing.Point(74, 32);
            this.txtdnioruc.Name = "txtdnioruc";
            this.txtdnioruc.Size = new System.Drawing.Size(174, 20);
            this.txtdnioruc.TabIndex = 2;
            this.txtdnioruc.TextChanged += new System.EventHandler(this.txtdnioruc_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ruc/DNI";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtdireccion);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtnombre);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(23, 145);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(350, 122);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Empresa/Cliente";
            // 
            // txtdireccion
            // 
            this.txtdireccion.BackColor = System.Drawing.Color.LightYellow;
            this.txtdireccion.Enabled = false;
            this.txtdireccion.Location = new System.Drawing.Point(74, 68);
            this.txtdireccion.Multiline = true;
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.ReadOnly = true;
            this.txtdireccion.Size = new System.Drawing.Size(258, 48);
            this.txtdireccion.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Direccion";
            // 
            // txtnombre
            // 
            this.txtnombre.BackColor = System.Drawing.Color.LightYellow;
            this.txtnombre.Enabled = false;
            this.txtnombre.Location = new System.Drawing.Point(74, 33);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.ReadOnly = true;
            this.txtnombre.Size = new System.Drawing.Size(147, 20);
            this.txtnombre.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtphventa);
            this.groupBox3.Controls.Add(this.txtvalunitarioventa);
            this.groupBox3.Controls.Add(this.txtpesototal);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.cmbtipoproducto);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.cmbmoneda);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(23, 273);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(277, 207);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Venta";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(181, 174);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(15, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "%";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(181, 140);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "$";
            // 
            // txtphventa
            // 
            this.txtphventa.BackColor = System.Drawing.Color.LightYellow;
            this.txtphventa.Enabled = false;
            this.txtphventa.Location = new System.Drawing.Point(100, 171);
            this.txtphventa.Name = "txtphventa";
            this.txtphventa.Size = new System.Drawing.Size(75, 20);
            this.txtphventa.TabIndex = 9;
            this.txtphventa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtphventa_KeyPress);
            // 
            // txtvalunitarioventa
            // 
            this.txtvalunitarioventa.BackColor = System.Drawing.Color.LightYellow;
            this.txtvalunitarioventa.Enabled = false;
            this.txtvalunitarioventa.Location = new System.Drawing.Point(100, 137);
            this.txtvalunitarioventa.Name = "txtvalunitarioventa";
            this.txtvalunitarioventa.Size = new System.Drawing.Size(75, 20);
            this.txtvalunitarioventa.TabIndex = 8;
            this.txtvalunitarioventa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtvalunitarioventa_KeyPress);
            // 
            // txtpesototal
            // 
            this.txtpesototal.BackColor = System.Drawing.Color.LightYellow;
            this.txtpesototal.Enabled = false;
            this.txtpesototal.Location = new System.Drawing.Point(100, 103);
            this.txtpesototal.Name = "txtpesototal";
            this.txtpesototal.Size = new System.Drawing.Size(75, 20);
            this.txtpesototal.TabIndex = 7;
            this.txtpesototal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpesototal_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 174);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "PH";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Valor Unitario";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Peso Total";
            // 
            // cmbtipoproducto
            // 
            this.cmbtipoproducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbtipoproducto.FormattingEnabled = true;
            this.cmbtipoproducto.Location = new System.Drawing.Point(100, 67);
            this.cmbtipoproducto.Name = "cmbtipoproducto";
            this.cmbtipoproducto.Size = new System.Drawing.Size(121, 21);
            this.cmbtipoproducto.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Tipo Producto";
            // 
            // cmbmoneda
            // 
            this.cmbmoneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbmoneda.FormattingEnabled = true;
            this.cmbmoneda.Location = new System.Drawing.Point(100, 29);
            this.cmbmoneda.Name = "cmbmoneda";
            this.cmbmoneda.Size = new System.Drawing.Size(121, 21);
            this.cmbmoneda.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tipo Moneda";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btncancelar);
            this.groupBox4.Controls.Add(this.btnnuevo);
            this.groupBox4.Controls.Add(this.btnsalir);
            this.groupBox4.Controls.Add(this.btnregistrar);
            this.groupBox4.Location = new System.Drawing.Point(306, 273);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(66, 207);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            // 
            // btncancelar
            // 
            this.btncancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btncancelar.BackgroundImage")));
            this.btncancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btncancelar.Enabled = false;
            this.btncancelar.Location = new System.Drawing.Point(10, 110);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(50, 39);
            this.btncancelar.TabIndex = 8;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnnuevo
            // 
            this.btnnuevo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnnuevo.BackgroundImage")));
            this.btnnuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnnuevo.Location = new System.Drawing.Point(10, 15);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(50, 39);
            this.btnnuevo.TabIndex = 5;
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnsalir.BackgroundImage")));
            this.btnsalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnsalir.Location = new System.Drawing.Point(10, 155);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(50, 41);
            this.btnsalir.TabIndex = 7;
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btnregistrar
            // 
            this.btnregistrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnregistrar.BackgroundImage")));
            this.btnregistrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnregistrar.Enabled = false;
            this.btnregistrar.Location = new System.Drawing.Point(10, 61);
            this.btnregistrar.Name = "btnregistrar";
            this.btnregistrar.Size = new System.Drawing.Size(50, 39);
            this.btnregistrar.TabIndex = 6;
            this.btnregistrar.UseVisualStyleBackColor = true;
            this.btnregistrar.Click += new System.EventHandler(this.btnregistrar_Click);
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // FrmVentaGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 503);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmVentaGeneral";
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.FrmVentaGeneral_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtdnioruc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmbtipoproducto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbmoneda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtphventa;
        private System.Windows.Forms.TextBox txtvalunitarioventa;
        private System.Windows.Forms.TextBox txtpesototal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btnregistrar;
        private System.Windows.Forms.ErrorProvider err;
    }
}