namespace SisPronaSur.Consulta
{
    partial class FrmConSarandeo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConSarandeo));
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomSucursal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgalmacengeneral = new System.Windows.Forms.DataGridView();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtsinprocesar = new System.Windows.Forms.TextBox();
            this.txtcantsarandeo = new System.Windows.Forms.TextBox();
            this.txtcantactual = new System.Windows.Forms.TextBox();
            this.btnsalir = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnactualizar = new System.Windows.Forms.Button();
            this.btnversarandeo = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgalmacengeneral)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "FechAlmGeneral";
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // nomSucursal
            // 
            this.nomSucursal.DataPropertyName = "nomSucursal";
            this.nomSucursal.HeaderText = "Sucursal";
            this.nomSucursal.Name = "nomSucursal";
            this.nomSucursal.ReadOnly = true;
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "CodAlmGeneral";
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // dgalmacengeneral
            // 
            this.dgalmacengeneral.AllowUserToAddRows = false;
            this.dgalmacengeneral.AllowUserToDeleteRows = false;
            this.dgalmacengeneral.AllowUserToResizeColumns = false;
            this.dgalmacengeneral.AllowUserToResizeRows = false;
            this.dgalmacengeneral.BackgroundColor = System.Drawing.Color.White;
            this.dgalmacengeneral.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgalmacengeneral.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.nomSucursal,
            this.Fecha,
            this.Cantidad});
            this.dgalmacengeneral.Location = new System.Drawing.Point(6, 19);
            this.dgalmacengeneral.Name = "dgalmacengeneral";
            this.dgalmacengeneral.ReadOnly = true;
            this.dgalmacengeneral.RowHeadersVisible = false;
            this.dgalmacengeneral.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgalmacengeneral.Size = new System.Drawing.Size(394, 223);
            this.dgalmacengeneral.TabIndex = 0;
            // 
            // Cantidad
            // 
            this.Cantidad.DataPropertyName = "CantKilo";
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // txtsinprocesar
            // 
            this.txtsinprocesar.BackColor = System.Drawing.Color.LightYellow;
            this.txtsinprocesar.Enabled = false;
            this.txtsinprocesar.Location = new System.Drawing.Point(129, 48);
            this.txtsinprocesar.Name = "txtsinprocesar";
            this.txtsinprocesar.ReadOnly = true;
            this.txtsinprocesar.Size = new System.Drawing.Size(100, 20);
            this.txtsinprocesar.TabIndex = 6;
            // 
            // txtcantsarandeo
            // 
            this.txtcantsarandeo.BackColor = System.Drawing.Color.LightYellow;
            this.txtcantsarandeo.Enabled = false;
            this.txtcantsarandeo.Location = new System.Drawing.Point(129, 73);
            this.txtcantsarandeo.Name = "txtcantsarandeo";
            this.txtcantsarandeo.ReadOnly = true;
            this.txtcantsarandeo.Size = new System.Drawing.Size(100, 20);
            this.txtcantsarandeo.TabIndex = 4;
            // 
            // txtcantactual
            // 
            this.txtcantactual.BackColor = System.Drawing.Color.LightYellow;
            this.txtcantactual.Enabled = false;
            this.txtcantactual.Location = new System.Drawing.Point(129, 20);
            this.txtcantactual.Name = "txtcantactual";
            this.txtcantactual.ReadOnly = true;
            this.txtcantactual.Size = new System.Drawing.Size(100, 20);
            this.txtcantactual.TabIndex = 3;
            // 
            // btnsalir
            // 
            this.btnsalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnsalir.BackgroundImage")));
            this.btnsalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnsalir.Location = new System.Drawing.Point(167, 50);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(51, 31);
            this.btnsalir.TabIndex = 1;
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnactualizar);
            this.groupBox3.Controls.Add(this.btnversarandeo);
            this.groupBox3.Controls.Add(this.btnsalir);
            this.groupBox3.Location = new System.Drawing.Point(406, 112);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(245, 130);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // btnactualizar
            // 
            this.btnactualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnactualizar.Image")));
            this.btnactualizar.Location = new System.Drawing.Point(99, 50);
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.Size = new System.Drawing.Size(51, 31);
            this.btnactualizar.TabIndex = 3;
            this.btnactualizar.UseVisualStyleBackColor = true;
            this.btnactualizar.Click += new System.EventHandler(this.btnactualizar_Click);
            // 
            // btnversarandeo
            // 
            this.btnversarandeo.Image = ((System.Drawing.Image)(resources.GetObject("btnversarandeo.Image")));
            this.btnversarandeo.Location = new System.Drawing.Point(22, 50);
            this.btnversarandeo.Name = "btnversarandeo";
            this.btnversarandeo.Size = new System.Drawing.Size(51, 31);
            this.btnversarandeo.TabIndex = 2;
            this.btnversarandeo.UseVisualStyleBackColor = true;
            this.btnversarandeo.Click += new System.EventHandler(this.btnversarandeo_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.metroLabel3);
            this.groupBox2.Controls.Add(this.metroLabel2);
            this.groupBox2.Controls.Add(this.txtsinprocesar);
            this.groupBox2.Controls.Add(this.metroLabel1);
            this.groupBox2.Controls.Add(this.txtcantsarandeo);
            this.groupBox2.Controls.Add(this.txtcantactual);
            this.groupBox2.Location = new System.Drawing.Point(406, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(245, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.dgalmacengeneral);
            this.groupBox1.Location = new System.Drawing.Point(23, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(662, 254);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(10, 21);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(79, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Cant. Actual";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(10, 49);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(81, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Sin Procesar";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(10, 74);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(113, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Cant. Sarandeada";
            // 
            // FrmConSarandeo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 326);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmConSarandeo";
            this.Text = "Sarandeo ";
            this.Load += new System.EventHandler(this.FrmConSarandeo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgalmacengeneral)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider err;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtsinprocesar;
        private System.Windows.Forms.TextBox txtcantsarandeo;
        private System.Windows.Forms.TextBox txtcantactual;
        private System.Windows.Forms.DataGridView dgalmacengeneral;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomSucursal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.Button btnactualizar;
        private System.Windows.Forms.Button btnversarandeo;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}