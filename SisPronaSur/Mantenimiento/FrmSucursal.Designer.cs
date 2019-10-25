namespace SisPronaSur.Mantenimiento
{
    partial class FrmSucursal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSucursal));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtdirsucursal = new System.Windows.Forms.TextBox();
            this.txtrucsucursal = new System.Windows.Forms.TextBox();
            this.txttelsucursal = new System.Windows.Forms.TextBox();
            this.txtnomsucursal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgsucursal = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomSucursal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.btnregistrar = new System.Windows.Forms.Button();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgsucursal)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtdirsucursal);
            this.groupBox1.Controls.Add(this.txtrucsucursal);
            this.groupBox1.Controls.Add(this.txttelsucursal);
            this.groupBox1.Controls.Add(this.txtnomsucursal);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(23, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(476, 123);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sucursal";
            // 
            // txtdirsucursal
            // 
            this.txtdirsucursal.BackColor = System.Drawing.Color.LightYellow;
            this.txtdirsucursal.Enabled = false;
            this.txtdirsucursal.Location = new System.Drawing.Point(114, 89);
            this.txtdirsucursal.Name = "txtdirsucursal";
            this.txtdirsucursal.Size = new System.Drawing.Size(344, 20);
            this.txtdirsucursal.TabIndex = 7;
            this.txtdirsucursal.Validating += new System.ComponentModel.CancelEventHandler(this.txtdirsucursal_Validating);
            // 
            // txtrucsucursal
            // 
            this.txtrucsucursal.BackColor = System.Drawing.Color.LightYellow;
            this.txtrucsucursal.Enabled = false;
            this.txtrucsucursal.Location = new System.Drawing.Point(362, 27);
            this.txtrucsucursal.Name = "txtrucsucursal";
            this.txtrucsucursal.Size = new System.Drawing.Size(96, 20);
            this.txtrucsucursal.TabIndex = 6;
            this.txtrucsucursal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtrucsucursal_KeyPress);
            this.txtrucsucursal.Validating += new System.ComponentModel.CancelEventHandler(this.txtrucsucursal_Validating);
            // 
            // txttelsucursal
            // 
            this.txttelsucursal.BackColor = System.Drawing.Color.LightYellow;
            this.txttelsucursal.Enabled = false;
            this.txttelsucursal.Location = new System.Drawing.Point(114, 57);
            this.txttelsucursal.Name = "txttelsucursal";
            this.txttelsucursal.Size = new System.Drawing.Size(103, 20);
            this.txttelsucursal.TabIndex = 5;
            this.txttelsucursal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttelsucursal_KeyPress);
            this.txttelsucursal.Validating += new System.ComponentModel.CancelEventHandler(this.txttelsucursal_Validating);
            // 
            // txtnomsucursal
            // 
            this.txtnomsucursal.BackColor = System.Drawing.Color.LightYellow;
            this.txtnomsucursal.Enabled = false;
            this.txtnomsucursal.Location = new System.Drawing.Point(114, 27);
            this.txtnomsucursal.Name = "txtnomsucursal";
            this.txtnomsucursal.Size = new System.Drawing.Size(160, 20);
            this.txtnomsucursal.TabIndex = 4;
            this.txtnomsucursal.Validating += new System.ComponentModel.CancelEventHandler(this.txtnomsucursal_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Direccion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(306, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nro. Ruc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Telefono";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Sucursal";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgsucursal);
            this.groupBox2.Location = new System.Drawing.Point(23, 192);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(476, 256);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lista Sucursal";
            // 
            // dgsucursal
            // 
            this.dgsucursal.AllowUserToAddRows = false;
            this.dgsucursal.AllowUserToDeleteRows = false;
            this.dgsucursal.AllowUserToResizeColumns = false;
            this.dgsucursal.AllowUserToResizeRows = false;
            this.dgsucursal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgsucursal.BackgroundColor = System.Drawing.Color.White;
            this.dgsucursal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgsucursal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Fecha,
            this.nomSucursal,
            this.Nro,
            this.Cantidad});
            this.dgsucursal.Location = new System.Drawing.Point(6, 25);
            this.dgsucursal.Name = "dgsucursal";
            this.dgsucursal.ReadOnly = true;
            this.dgsucursal.RowHeadersVisible = false;
            this.dgsucursal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgsucursal.Size = new System.Drawing.Size(464, 225);
            this.dgsucursal.TabIndex = 27;
            this.dgsucursal.DoubleClick += new System.EventHandler(this.dgsucursal_DoubleClick);
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "CodSucursal";
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "nomSucursal";
            this.Fecha.HeaderText = "Nombre";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // nomSucursal
            // 
            this.nomSucursal.DataPropertyName = "dirSucursal";
            this.nomSucursal.HeaderText = "Direccion";
            this.nomSucursal.Name = "nomSucursal";
            this.nomSucursal.ReadOnly = true;
            // 
            // Nro
            // 
            this.Nro.DataPropertyName = "rucSucursal";
            this.Nro.HeaderText = "Nro. Ruc";
            this.Nro.Name = "Nro";
            this.Nro.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.DataPropertyName = "telSucursal";
            this.Cantidad.HeaderText = "Telefono";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btncancelar);
            this.groupBox3.Controls.Add(this.btnsalir);
            this.groupBox3.Controls.Add(this.btnnuevo);
            this.groupBox3.Controls.Add(this.btnregistrar);
            this.groupBox3.Location = new System.Drawing.Point(505, 63);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(62, 385);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // btncancelar
            // 
            this.btncancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btncancelar.BackgroundImage")));
            this.btncancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncancelar.Location = new System.Drawing.Point(6, 226);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(50, 39);
            this.btncancelar.TabIndex = 32;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnsalir.BackgroundImage")));
            this.btnsalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsalir.Location = new System.Drawing.Point(6, 322);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(50, 41);
            this.btnsalir.TabIndex = 31;
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btnnuevo
            // 
            this.btnnuevo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnnuevo.BackgroundImage")));
            this.btnnuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnnuevo.Location = new System.Drawing.Point(6, 20);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(50, 39);
            this.btnnuevo.TabIndex = 28;
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // btnregistrar
            // 
            this.btnregistrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnregistrar.BackgroundImage")));
            this.btnregistrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnregistrar.Enabled = false;
            this.btnregistrar.Location = new System.Drawing.Point(6, 129);
            this.btnregistrar.Name = "btnregistrar";
            this.btnregistrar.Size = new System.Drawing.Size(50, 39);
            this.btnregistrar.TabIndex = 29;
            this.btnregistrar.UseVisualStyleBackColor = true;
            this.btnregistrar.Click += new System.EventHandler(this.btnregistrar_Click);
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // FrmSucursal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 462);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmSucursal";
            this.Text = "Sucursal";
            this.Load += new System.EventHandler(this.FrmSucursal_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgsucursal)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtdirsucursal;
        private System.Windows.Forms.TextBox txtrucsucursal;
        private System.Windows.Forms.TextBox txttelsucursal;
        private System.Windows.Forms.TextBox txtnomsucursal;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgsucursal;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.Button btnregistrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomSucursal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.ErrorProvider err;
    }
}