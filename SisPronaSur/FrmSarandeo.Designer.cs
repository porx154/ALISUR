namespace SisPronaSur
{
    partial class FrmSarandeoAlmacen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSarandeoAlmacen));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnsalir = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtsarandear = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtsinprocesar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtcantsarandeo = new System.Windows.Forms.TextBox();
            this.txtcantactual = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgalmacengeneral = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomSucursal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgalmacengeneral)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnsalir);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.dgalmacengeneral);
            this.groupBox1.Location = new System.Drawing.Point(23, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(662, 254);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sarandeo";
            // 
            // btnsalir
            // 
            this.btnsalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnsalir.BackgroundImage")));
            this.btnsalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnsalir.Location = new System.Drawing.Point(600, 211);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(51, 31);
            this.btnsalir.TabIndex = 1;
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.txtsarandear);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(406, 112);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(245, 93);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(143, 60);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Procesar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtsarandear
            // 
            this.txtsarandear.BackColor = System.Drawing.Color.LightYellow;
            this.txtsarandear.Location = new System.Drawing.Point(118, 23);
            this.txtsarandear.Name = "txtsarandear";
            this.txtsarandear.Size = new System.Drawing.Size(100, 20);
            this.txtsarandear.TabIndex = 1;
            this.txtsarandear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsarandear_KeyPress);
            this.txtsarandear.Validating += new System.ComponentModel.CancelEventHandler(this.txtsarandear_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Cant. Sarandeo";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtsinprocesar);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtcantsarandeo);
            this.groupBox2.Controls.Add(this.txtcantactual);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(406, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(245, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // txtsinprocesar
            // 
            this.txtsinprocesar.BackColor = System.Drawing.Color.LightYellow;
            this.txtsinprocesar.Enabled = false;
            this.txtsinprocesar.Location = new System.Drawing.Point(118, 47);
            this.txtsinprocesar.Name = "txtsinprocesar";
            this.txtsinprocesar.ReadOnly = true;
            this.txtsinprocesar.Size = new System.Drawing.Size(100, 20);
            this.txtsinprocesar.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Sin Procesar";
            // 
            // txtcantsarandeo
            // 
            this.txtcantsarandeo.BackColor = System.Drawing.Color.LightYellow;
            this.txtcantsarandeo.Enabled = false;
            this.txtcantsarandeo.Location = new System.Drawing.Point(118, 72);
            this.txtcantsarandeo.Name = "txtcantsarandeo";
            this.txtcantsarandeo.ReadOnly = true;
            this.txtcantsarandeo.Size = new System.Drawing.Size(100, 20);
            this.txtcantsarandeo.TabIndex = 4;
            // 
            // txtcantactual
            // 
            this.txtcantactual.BackColor = System.Drawing.Color.LightYellow;
            this.txtcantactual.Enabled = false;
            this.txtcantactual.Location = new System.Drawing.Point(118, 19);
            this.txtcantactual.Name = "txtcantactual";
            this.txtcantactual.ReadOnly = true;
            this.txtcantactual.Size = new System.Drawing.Size(100, 20);
            this.txtcantactual.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cant. Actual";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cant. Sarandeada";
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
            // Codigo
            // 
            this.Codigo.DataPropertyName = "CodAlmGeneral";
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // nomSucursal
            // 
            this.nomSucursal.DataPropertyName = "nomSucursal";
            this.nomSucursal.HeaderText = "Sucursal";
            this.nomSucursal.Name = "nomSucursal";
            this.nomSucursal.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "FechAlmGeneral";
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.DataPropertyName = "CantKilo";
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // FrmSarandeoAlmacen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 336);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmSarandeoAlmacen";
            this.Text = "Sarandeo Almacen";
            this.Load += new System.EventHandler(this.FrmSarandeo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgalmacengeneral)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgalmacengeneral;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtcantactual;
        private System.Windows.Forms.TextBox txtcantsarandeo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtsarandear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomSucursal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.ErrorProvider err;
        private System.Windows.Forms.TextBox txtsinprocesar;
        private System.Windows.Forms.Label label4;
    }
}