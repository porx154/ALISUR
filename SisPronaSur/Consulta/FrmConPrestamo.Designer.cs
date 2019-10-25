namespace SisPronaSur.Consulta
{
    partial class FrmConPrestamo
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
            this.dgvprestamo = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbprestamo = new System.Windows.Forms.ComboBox();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechDev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Interes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Operacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvprestamo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvprestamo
            // 
            this.dgvprestamo.AllowUserToAddRows = false;
            this.dgvprestamo.AllowUserToDeleteRows = false;
            this.dgvprestamo.AllowUserToResizeColumns = false;
            this.dgvprestamo.AllowUserToResizeRows = false;
            this.dgvprestamo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvprestamo.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvprestamo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvprestamo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvprestamo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.FechInicio,
            this.fechDev,
            this.Monto,
            this.Interes,
            this.Usuario,
            this.Operacion});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvprestamo.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvprestamo.GridColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgvprestamo.Location = new System.Drawing.Point(13, 170);
            this.dgvprestamo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvprestamo.Name = "dgvprestamo";
            this.dgvprestamo.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvprestamo.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvprestamo.RowHeadersVisible = false;
            this.dgvprestamo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvprestamo.Size = new System.Drawing.Size(661, 263);
            this.dgvprestamo.TabIndex = 104;
            this.dgvprestamo.DoubleClick += new System.EventHandler(this.dgvprestamo_DoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbprestamo);
            this.groupBox1.Location = new System.Drawing.Point(13, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(661, 72);
            this.groupBox1.TabIndex = 105;
            this.groupBox1.TabStop = false;
            // 
            // cmbprestamo
            // 
            this.cmbprestamo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbprestamo.FormattingEnabled = true;
            this.cmbprestamo.Location = new System.Drawing.Point(6, 28);
            this.cmbprestamo.Name = "cmbprestamo";
            this.cmbprestamo.Size = new System.Drawing.Size(150, 21);
            this.cmbprestamo.TabIndex = 0;
            this.cmbprestamo.SelectedIndexChanged += new System.EventHandler(this.cmbprestamo_SelectedIndexChanged);
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "codPrestamo";
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre y Apellido";
            this.Nombre.HeaderText = "Nombre y Apellido";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // FechInicio
            // 
            this.FechInicio.DataPropertyName = "fechInicio";
            this.FechInicio.HeaderText = "Fecha Prestamo";
            this.FechInicio.Name = "FechInicio";
            this.FechInicio.ReadOnly = true;
            // 
            // fechDev
            // 
            this.fechDev.DataPropertyName = "fechDevolucion";
            this.fechDev.HeaderText = "Fecha Devolucion";
            this.fechDev.Name = "fechDev";
            this.fechDev.ReadOnly = true;
            this.fechDev.Visible = false;
            // 
            // Monto
            // 
            this.Monto.DataPropertyName = "montoPrestamo";
            this.Monto.HeaderText = "Monto Prestamo";
            this.Monto.Name = "Monto";
            this.Monto.ReadOnly = true;
            // 
            // Interes
            // 
            this.Interes.DataPropertyName = "interesPrestamo";
            this.Interes.HeaderText = "Interes Prestamo";
            this.Interes.Name = "Interes";
            this.Interes.ReadOnly = true;
            // 
            // Usuario
            // 
            this.Usuario.DataPropertyName = "nomUsuarioPersonal";
            this.Usuario.HeaderText = "Usuario";
            this.Usuario.Name = "Usuario";
            this.Usuario.ReadOnly = true;
            // 
            // Operacion
            // 
            this.Operacion.DataPropertyName = "Estado";
            this.Operacion.HeaderText = "Estado Prestamo";
            this.Operacion.Name = "Operacion";
            this.Operacion.ReadOnly = true;
            // 
            // FrmConPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 445);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvprestamo);
            this.Name = "FrmConPrestamo";
            this.Text = "Consulta Prestamo";
            this.Load += new System.EventHandler(this.FrmConPrestamo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvprestamo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.DataGridView dgvprestamo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbprestamo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechDev;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Interes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Operacion;
    }
}