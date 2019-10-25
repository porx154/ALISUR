namespace SisPronaSur.Consulta
{
    partial class FrmBusVentaGeneral
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBusVentaGeneral));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpfechaventa = new System.Windows.Forms.DateTimePicker();
            this.chkopcion = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.mtdgventa = new MetroFramework.Controls.MetroGrid();
            this.Cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ru = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.peso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ph = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mtbtnsalir = new MetroFramework.Controls.MetroButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mtdgventa)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpfechaventa);
            this.groupBox1.Controls.Add(this.chkopcion);
            this.groupBox1.Location = new System.Drawing.Point(23, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(637, 75);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // dtpfechaventa
            // 
            this.dtpfechaventa.Enabled = false;
            this.dtpfechaventa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpfechaventa.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpfechaventa.Location = new System.Drawing.Point(38, 25);
            this.dtpfechaventa.Name = "dtpfechaventa";
            this.dtpfechaventa.Size = new System.Drawing.Size(122, 24);
            this.dtpfechaventa.TabIndex = 1;
            this.dtpfechaventa.ValueChanged += new System.EventHandler(this.dtpfechaventa_ValueChanged);
            // 
            // chkopcion
            // 
            this.chkopcion.AutoSize = true;
            this.chkopcion.Location = new System.Drawing.Point(17, 31);
            this.chkopcion.Name = "chkopcion";
            this.chkopcion.Size = new System.Drawing.Size(15, 14);
            this.chkopcion.TabIndex = 0;
            this.chkopcion.UseVisualStyleBackColor = true;
            this.chkopcion.CheckedChanged += new System.EventHandler(this.chkopcion_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.mtdgventa);
            this.groupBox2.Location = new System.Drawing.Point(23, 144);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(643, 254);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // mtdgventa
            // 
            this.mtdgventa.AllowUserToAddRows = false;
            this.mtdgventa.AllowUserToDeleteRows = false;
            this.mtdgventa.AllowUserToResizeColumns = false;
            this.mtdgventa.AllowUserToResizeRows = false;
            this.mtdgventa.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mtdgventa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtdgventa.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mtdgventa.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mtdgventa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.mtdgventa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mtdgventa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cod,
            this.Nom,
            this.Ru,
            this.Tipo,
            this.TipoP,
            this.peso,
            this.precio,
            this.ph,
            this.Usuario});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mtdgventa.DefaultCellStyle = dataGridViewCellStyle2;
            this.mtdgventa.EnableHeadersVisualStyles = false;
            this.mtdgventa.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mtdgventa.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mtdgventa.Location = new System.Drawing.Point(6, 19);
            this.mtdgventa.Name = "mtdgventa";
            this.mtdgventa.ReadOnly = true;
            this.mtdgventa.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mtdgventa.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.mtdgventa.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mtdgventa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mtdgventa.Size = new System.Drawing.Size(631, 222);
            this.mtdgventa.Style = MetroFramework.MetroColorStyle.Green;
            this.mtdgventa.TabIndex = 5;
            this.mtdgventa.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mtdgventa_CellDoubleClick);
            // 
            // Cod
            // 
            this.Cod.DataPropertyName = "CodVenta";
            this.Cod.HeaderText = "Codigo";
            this.Cod.Name = "Cod";
            this.Cod.ReadOnly = true;
            // 
            // Nom
            // 
            this.Nom.DataPropertyName = "nombCliente";
            this.Nom.HeaderText = "Nombre";
            this.Nom.Name = "Nom";
            this.Nom.ReadOnly = true;
            // 
            // Ru
            // 
            this.Ru.DataPropertyName = "rucCliente";
            this.Ru.HeaderText = "Ruc/DNI";
            this.Ru.Name = "Ru";
            this.Ru.ReadOnly = true;
            // 
            // Tipo
            // 
            this.Tipo.DataPropertyName = "Tipo Moneda";
            this.Tipo.HeaderText = "Tipo Moneda";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            // 
            // TipoP
            // 
            this.TipoP.DataPropertyName = "desTipoProducto";
            this.TipoP.HeaderText = "Tipo Producto";
            this.TipoP.Name = "TipoP";
            this.TipoP.ReadOnly = true;
            // 
            // peso
            // 
            this.peso.DataPropertyName = "pesoTotal";
            this.peso.HeaderText = "Peso";
            this.peso.Name = "peso";
            this.peso.ReadOnly = true;
            // 
            // precio
            // 
            this.precio.DataPropertyName = "preUnitario";
            this.precio.HeaderText = "P. Unitario";
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            // 
            // ph
            // 
            this.ph.DataPropertyName = "phVenta";
            this.ph.HeaderText = "Ph Venta";
            this.ph.Name = "ph";
            this.ph.ReadOnly = true;
            // 
            // Usuario
            // 
            this.Usuario.DataPropertyName = "nomPersonal";
            this.Usuario.HeaderText = "Usuario";
            this.Usuario.Name = "Usuario";
            this.Usuario.ReadOnly = true;
            // 
            // mtbtnsalir
            // 
            this.mtbtnsalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mtbtnsalir.BackgroundImage")));
            this.mtbtnsalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.mtbtnsalir.Location = new System.Drawing.Point(616, 404);
            this.mtbtnsalir.Name = "mtbtnsalir";
            this.mtbtnsalir.Size = new System.Drawing.Size(44, 41);
            this.mtbtnsalir.Style = MetroFramework.MetroColorStyle.Green;
            this.mtbtnsalir.TabIndex = 5;
            this.mtbtnsalir.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbtnsalir.UseSelectable = true;
            this.mtbtnsalir.Click += new System.EventHandler(this.mtbtnsalir_Click);
            // 
            // FrmBusVentaGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 478);
            this.Controls.Add(this.mtbtnsalir);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmBusVentaGeneral";
            this.Text = "Busqueda Ventas";
            this.Load += new System.EventHandler(this.FrmBusVentaGeneral_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mtdgventa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtpfechaventa;
        private System.Windows.Forms.CheckBox chkopcion;
        private MetroFramework.Controls.MetroGrid mtdgventa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ru;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoP;
        private System.Windows.Forms.DataGridViewTextBoxColumn peso;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ph;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private MetroFramework.Controls.MetroButton mtbtnsalir;
    }
}