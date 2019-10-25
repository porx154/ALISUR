namespace SisPronaSur
{
    partial class FrmAlmGenConfirm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAlmGenConfirm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtcodconfirmacion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnregistrar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgalmacengeneral = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomSucursal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnsalir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgalmacengeneral)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtcodconfirmacion);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnregistrar);
            this.groupBox1.Location = new System.Drawing.Point(23, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(422, 94);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txtcodconfirmacion
            // 
            this.txtcodconfirmacion.BackColor = System.Drawing.Color.LightYellow;
            this.txtcodconfirmacion.Location = new System.Drawing.Point(140, 39);
            this.txtcodconfirmacion.Name = "txtcodconfirmacion";
            this.txtcodconfirmacion.Size = new System.Drawing.Size(174, 20);
            this.txtcodconfirmacion.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Codigo de Confirmacion";
            // 
            // btnregistrar
            // 
            this.btnregistrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnregistrar.Image = ((System.Drawing.Image)(resources.GetObject("btnregistrar.Image")));
            this.btnregistrar.Location = new System.Drawing.Point(332, 39);
            this.btnregistrar.Name = "btnregistrar";
            this.btnregistrar.Size = new System.Drawing.Size(51, 24);
            this.btnregistrar.TabIndex = 0;
            this.btnregistrar.UseVisualStyleBackColor = true;
            this.btnregistrar.Click += new System.EventHandler(this.btnregistrar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgalmacengeneral);
            this.groupBox2.Location = new System.Drawing.Point(23, 163);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(422, 334);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
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
            this.dgalmacengeneral.Size = new System.Drawing.Size(406, 309);
            this.dgalmacengeneral.TabIndex = 5;
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
            // btnsalir
            // 
            this.btnsalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnsalir.BackgroundImage")));
            this.btnsalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsalir.Location = new System.Drawing.Point(395, 503);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(50, 41);
            this.btnsalir.TabIndex = 4;
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // FrmAlmGenConfirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 556);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAlmGenConfirm";
            this.Text = "Registrar Confirmacion";
            this.Load += new System.EventHandler(this.FrmAlmGenConfirm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgalmacengeneral)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.DataGridView dgalmacengeneral;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomSucursal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.TextBox txtcodconfirmacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnregistrar;
    }
}