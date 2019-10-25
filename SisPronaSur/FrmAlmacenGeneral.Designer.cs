namespace SisPronaSur
{
    partial class FrmAlmacenGeneral
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAlmacenGeneral));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnsalir = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.btnregistrar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtmerma = new System.Windows.Forms.TextBox();
            this.txtpolvillo = new System.Windows.Forms.TextBox();
            this.txtsegunda = new System.Windows.Forms.TextBox();
            this.txtprimera = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtsarandear = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnsalirconsulta = new System.Windows.Forms.Button();
            this.dgsarandeo = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomSucursal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Polvillos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mermas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgsarandeo)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(23, 60);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(643, 270);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnsalir);
            this.tabPage1.Controls.Add(this.btncancelar);
            this.tabPage1.Controls.Add(this.btnnuevo);
            this.tabPage1.Controls.Add(this.btnregistrar);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(635, 244);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sarandear Producto";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnsalir
            // 
            this.btnsalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnsalir.BackgroundImage")));
            this.btnsalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnsalir.Location = new System.Drawing.Point(569, 196);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(50, 41);
            this.btnsalir.TabIndex = 11;
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click_1);
            // 
            // btncancelar
            // 
            this.btncancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btncancelar.BackgroundImage")));
            this.btncancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btncancelar.Enabled = false;
            this.btncancelar.Location = new System.Drawing.Point(513, 197);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(50, 39);
            this.btncancelar.TabIndex = 15;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click_1);
            // 
            // btnnuevo
            // 
            this.btnnuevo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnnuevo.BackgroundImage")));
            this.btnnuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnnuevo.Location = new System.Drawing.Point(401, 197);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(50, 39);
            this.btnnuevo.TabIndex = 13;
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click_1);
            // 
            // btnregistrar
            // 
            this.btnregistrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnregistrar.BackgroundImage")));
            this.btnregistrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnregistrar.Enabled = false;
            this.btnregistrar.Location = new System.Drawing.Point(457, 197);
            this.btnregistrar.Name = "btnregistrar";
            this.btnregistrar.Size = new System.Drawing.Size(50, 39);
            this.btnregistrar.TabIndex = 14;
            this.btnregistrar.UseVisualStyleBackColor = true;
            this.btnregistrar.Click += new System.EventHandler(this.btnregistrar_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtmerma);
            this.groupBox2.Controls.Add(this.txtpolvillo);
            this.groupBox2.Controls.Add(this.txtsegunda);
            this.groupBox2.Controls.Add(this.txtprimera);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 91);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(610, 100);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // txtmerma
            // 
            this.txtmerma.BackColor = System.Drawing.Color.LightYellow;
            this.txtmerma.Enabled = false;
            this.txtmerma.Location = new System.Drawing.Point(523, 41);
            this.txtmerma.Name = "txtmerma";
            this.txtmerma.ReadOnly = true;
            this.txtmerma.Size = new System.Drawing.Size(81, 20);
            this.txtmerma.TabIndex = 7;
            this.txtmerma.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtpolvillo
            // 
            this.txtpolvillo.BackColor = System.Drawing.Color.LightYellow;
            this.txtpolvillo.Enabled = false;
            this.txtpolvillo.Location = new System.Drawing.Point(370, 41);
            this.txtpolvillo.Name = "txtpolvillo";
            this.txtpolvillo.Size = new System.Drawing.Size(100, 20);
            this.txtpolvillo.TabIndex = 6;
            this.txtpolvillo.Text = "0";
            this.txtpolvillo.TextChanged += new System.EventHandler(this.txtpolvillo_TextChanged);
            this.txtpolvillo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpolvillo_KeyPress);
            // 
            // txtsegunda
            // 
            this.txtsegunda.BackColor = System.Drawing.Color.LightYellow;
            this.txtsegunda.Enabled = false;
            this.txtsegunda.Location = new System.Drawing.Point(218, 41);
            this.txtsegunda.Name = "txtsegunda";
            this.txtsegunda.Size = new System.Drawing.Size(100, 20);
            this.txtsegunda.TabIndex = 5;
            this.txtsegunda.Text = "0";
            this.txtsegunda.TextChanged += new System.EventHandler(this.txtsegunda_TextChanged);
            this.txtsegunda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsegunda_KeyPress);
            // 
            // txtprimera
            // 
            this.txtprimera.BackColor = System.Drawing.Color.LightYellow;
            this.txtprimera.Enabled = false;
            this.txtprimera.Location = new System.Drawing.Point(59, 41);
            this.txtprimera.Name = "txtprimera";
            this.txtprimera.Size = new System.Drawing.Size(100, 20);
            this.txtprimera.TabIndex = 4;
            this.txtprimera.Text = "0";
            this.txtprimera.TextChanged += new System.EventHandler(this.txtprimera_TextChanged);
            this.txtprimera.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtprimera_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(477, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Merma";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(324, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Polvillo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(168, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Segunda";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Primera";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtsarandear);
            this.groupBox1.Location = new System.Drawing.Point(12, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(610, 68);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cantidad Sarandear";
            // 
            // txtsarandear
            // 
            this.txtsarandear.BackColor = System.Drawing.Color.LightYellow;
            this.txtsarandear.Enabled = false;
            this.txtsarandear.Location = new System.Drawing.Point(126, 27);
            this.txtsarandear.Name = "txtsarandear";
            this.txtsarandear.ReadOnly = true;
            this.txtsarandear.Size = new System.Drawing.Size(100, 20);
            this.txtsarandear.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnsalirconsulta);
            this.tabPage2.Controls.Add(this.dgsarandeo);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(635, 244);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consulta Sarandeo";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnsalirconsulta
            // 
            this.btnsalirconsulta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnsalirconsulta.BackgroundImage")));
            this.btnsalirconsulta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnsalirconsulta.Location = new System.Drawing.Point(579, 198);
            this.btnsalirconsulta.Name = "btnsalirconsulta";
            this.btnsalirconsulta.Size = new System.Drawing.Size(50, 41);
            this.btnsalirconsulta.TabIndex = 12;
            this.btnsalirconsulta.UseVisualStyleBackColor = true;
            this.btnsalirconsulta.Click += new System.EventHandler(this.btnsalirconsulta_Click);
            // 
            // dgsarandeo
            // 
            this.dgsarandeo.AllowUserToAddRows = false;
            this.dgsarandeo.AllowUserToDeleteRows = false;
            this.dgsarandeo.AllowUserToResizeColumns = false;
            this.dgsarandeo.AllowUserToResizeRows = false;
            this.dgsarandeo.BackgroundColor = System.Drawing.Color.White;
            this.dgsarandeo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgsarandeo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.nomSucursal,
            this.Fecha,
            this.Cantidad,
            this.Polvillos,
            this.Mermas,
            this.Usuario});
            this.dgsarandeo.Location = new System.Drawing.Point(6, 6);
            this.dgsarandeo.Name = "dgsarandeo";
            this.dgsarandeo.ReadOnly = true;
            this.dgsarandeo.RowHeadersVisible = false;
            this.dgsarandeo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgsarandeo.Size = new System.Drawing.Size(623, 186);
            this.dgsarandeo.TabIndex = 1;
            this.dgsarandeo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgsarandeo_CellContentClick);
            this.dgsarandeo.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgsarandeo_CellDoubleClick);
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "CodSarandeo";
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // nomSucursal
            // 
            this.nomSucursal.DataPropertyName = "CantSarandeo";
            this.nomSucursal.HeaderText = "Cant. Sarandeo";
            this.nomSucursal.Name = "nomSucursal";
            this.nomSucursal.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "SaPrimera";
            this.Fecha.HeaderText = "Primera";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.DataPropertyName = "SaSegunda";
            this.Cantidad.HeaderText = "Segunda";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // Polvillos
            // 
            this.Polvillos.DataPropertyName = "SaPolvillo";
            this.Polvillos.HeaderText = "Polvillo";
            this.Polvillos.Name = "Polvillos";
            this.Polvillos.ReadOnly = true;
            // 
            // Mermas
            // 
            this.Mermas.DataPropertyName = "SaMerma";
            this.Mermas.HeaderText = "Merma";
            this.Mermas.Name = "Mermas";
            this.Mermas.ReadOnly = true;
            // 
            // Usuario
            // 
            this.Usuario.DataPropertyName = "nomUsuarioPersonal";
            this.Usuario.HeaderText = "Usuario";
            this.Usuario.Name = "Usuario";
            this.Usuario.ReadOnly = true;
            // 
            // FrmAlmacenGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 351);
            this.Controls.Add(this.tabControl1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAlmacenGeneral";
            this.Text = "Sarandeo ";
            this.Load += new System.EventHandler(this.FrmAlmacenGeneral_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgsarandeo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtsarandear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtmerma;
        private System.Windows.Forms.TextBox txtpolvillo;
        private System.Windows.Forms.TextBox txtsegunda;
        private System.Windows.Forms.TextBox txtprimera;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.Button btnregistrar;
        private System.Windows.Forms.Button btnsalirconsulta;
        private System.Windows.Forms.DataGridView dgsarandeo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomSucursal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Polvillos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mermas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
    }
}