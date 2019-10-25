namespace SisPronaSur
{
    partial class FrmCaja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCaja));
            this.btnsalir = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.btnregistrar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtnrooperacion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmontocaja = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgcaja = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomSucursal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbRetiro = new System.Windows.Forms.RadioButton();
            this.rdbIngreso = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbsucursal = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgcaja)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnsalir
            // 
            this.btnsalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnsalir.BackgroundImage")));
            this.btnsalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnsalir.Location = new System.Drawing.Point(454, 608);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(50, 42);
            this.btnsalir.TabIndex = 21;
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click_1);
            // 
            // btncancelar
            // 
            this.btncancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btncancelar.BackgroundImage")));
            this.btncancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btncancelar.Enabled = false;
            this.btncancelar.Location = new System.Drawing.Point(448, 184);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(50, 39);
            this.btncancelar.TabIndex = 24;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnnuevo
            // 
            this.btnnuevo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnnuevo.BackgroundImage")));
            this.btnnuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnnuevo.Location = new System.Drawing.Point(336, 184);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(50, 39);
            this.btnnuevo.TabIndex = 22;
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // btnregistrar
            // 
            this.btnregistrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnregistrar.BackgroundImage")));
            this.btnregistrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnregistrar.Enabled = false;
            this.btnregistrar.Location = new System.Drawing.Point(392, 184);
            this.btnregistrar.Name = "btnregistrar";
            this.btnregistrar.Size = new System.Drawing.Size(50, 39);
            this.btnregistrar.TabIndex = 23;
            this.btnregistrar.UseVisualStyleBackColor = true;
            this.btnregistrar.Click += new System.EventHandler(this.btnregistrar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtnrooperacion);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtmontocaja);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(23, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(481, 78);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar Monto";
            // 
            // txtnrooperacion
            // 
            this.txtnrooperacion.BackColor = System.Drawing.Color.LightYellow;
            this.txtnrooperacion.Enabled = false;
            this.txtnrooperacion.Location = new System.Drawing.Point(267, 31);
            this.txtnrooperacion.Name = "txtnrooperacion";
            this.txtnrooperacion.Size = new System.Drawing.Size(161, 20);
            this.txtnrooperacion.TabIndex = 4;
            this.txtnrooperacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnrooperacion_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(140, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "S/.";
            // 
            // txtmontocaja
            // 
            this.txtmontocaja.BackColor = System.Drawing.Color.LightYellow;
            this.txtmontocaja.Enabled = false;
            this.txtmontocaja.Location = new System.Drawing.Point(49, 31);
            this.txtmontocaja.Name = "txtmontocaja";
            this.txtmontocaja.Size = new System.Drawing.Size(85, 20);
            this.txtmontocaja.TabIndex = 2;
            this.txtmontocaja.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmontocaja_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nro. Operacion";
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
            // dgcaja
            // 
            this.dgcaja.AllowUserToAddRows = false;
            this.dgcaja.AllowUserToDeleteRows = false;
            this.dgcaja.AllowUserToResizeColumns = false;
            this.dgcaja.AllowUserToResizeRows = false;
            this.dgcaja.BackgroundColor = System.Drawing.Color.White;
            this.dgcaja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgcaja.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Fecha,
            this.nomSucursal,
            this.Nro,
            this.Cantidad,
            this.Usuario});
            this.dgcaja.Location = new System.Drawing.Point(9, 74);
            this.dgcaja.Name = "dgcaja";
            this.dgcaja.ReadOnly = true;
            this.dgcaja.RowHeadersVisible = false;
            this.dgcaja.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgcaja.Size = new System.Drawing.Size(463, 293);
            this.dgcaja.TabIndex = 26;
            this.dgcaja.DoubleClick += new System.EventHandler(this.dgcaja_DoubleClick);
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "CodCaja";
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "fechCaja";
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // nomSucursal
            // 
            this.nomSucursal.DataPropertyName = "montoCaja";
            this.nomSucursal.HeaderText = "Monto";
            this.nomSucursal.Name = "nomSucursal";
            this.nomSucursal.ReadOnly = true;
            // 
            // Nro
            // 
            this.Nro.DataPropertyName = "NroOperacion";
            this.Nro.HeaderText = "Nro. Operacion";
            this.Nro.Name = "Nro";
            this.Nro.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.DataPropertyName = "Operacion";
            this.Cantidad.HeaderText = "Tipo Operacion";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // Usuario
            // 
            this.Usuario.DataPropertyName = "nomPersonal";
            this.Usuario.HeaderText = "Usuario";
            this.Usuario.Name = "Usuario";
            this.Usuario.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbRetiro);
            this.groupBox2.Controls.Add(this.rdbIngreso);
            this.groupBox2.Location = new System.Drawing.Point(9, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(180, 49);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            // 
            // rdbRetiro
            // 
            this.rdbRetiro.AutoSize = true;
            this.rdbRetiro.Location = new System.Drawing.Point(100, 19);
            this.rdbRetiro.Name = "rdbRetiro";
            this.rdbRetiro.Size = new System.Drawing.Size(58, 17);
            this.rdbRetiro.TabIndex = 1;
            this.rdbRetiro.TabStop = true;
            this.rdbRetiro.Text = "Retiros";
            this.rdbRetiro.UseVisualStyleBackColor = true;
            this.rdbRetiro.CheckedChanged += new System.EventHandler(this.rdbRetiro_CheckedChanged);
            // 
            // rdbIngreso
            // 
            this.rdbIngreso.AutoSize = true;
            this.rdbIngreso.Location = new System.Drawing.Point(17, 19);
            this.rdbIngreso.Name = "rdbIngreso";
            this.rdbIngreso.Size = new System.Drawing.Size(65, 17);
            this.rdbIngreso.TabIndex = 0;
            this.rdbIngreso.TabStop = true;
            this.rdbIngreso.Text = "Ingresos";
            this.rdbIngreso.UseVisualStyleBackColor = true;
            this.rdbIngreso.CheckedChanged += new System.EventHandler(this.rdbIngreso_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgcaja);
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Location = new System.Drawing.Point(26, 229);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(478, 373);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Lista Operaciones";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Sucursal";
            // 
            // cmbsucursal
            // 
            this.cmbsucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbsucursal.FormattingEnabled = true;
            this.cmbsucursal.Location = new System.Drawing.Point(83, 70);
            this.cmbsucursal.Name = "cmbsucursal";
            this.cmbsucursal.Size = new System.Drawing.Size(121, 21);
            this.cmbsucursal.TabIndex = 29;
            this.cmbsucursal.SelectedIndexChanged += new System.EventHandler(this.cmbsucursal_SelectedIndexChanged);
            // 
            // FrmCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 685);
            this.Controls.Add(this.cmbsucursal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.btnregistrar);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCaja";
            this.Text = "Caja";
            this.Load += new System.EventHandler(this.FrmCaja_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgcaja)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.Button btnregistrar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtnrooperacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtmontocaja;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgcaja;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbRetiro;
        private System.Windows.Forms.RadioButton rdbIngreso;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbsucursal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomSucursal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
    }
}