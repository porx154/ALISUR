namespace SisPronaSur.Consulta
{
    partial class FrmConsultaAdelanto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbadelanto = new System.Windows.Forms.ComboBox();
            this.dgconadelanto = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechIniAdelanto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomUsuarioPersonal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estAdelanto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgconadelanto)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbadelanto);
            this.groupBox1.Location = new System.Drawing.Point(23, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(690, 63);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cbadelanto
            // 
            this.cbadelanto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbadelanto.FormattingEnabled = true;
            this.cbadelanto.Location = new System.Drawing.Point(17, 24);
            this.cbadelanto.Name = "cbadelanto";
            this.cbadelanto.Size = new System.Drawing.Size(169, 21);
            this.cbadelanto.TabIndex = 0;
            this.cbadelanto.SelectedIndexChanged += new System.EventHandler(this.cbadelanto_SelectedIndexChanged);
            // 
            // dgconadelanto
            // 
            this.dgconadelanto.AllowUserToAddRows = false;
            this.dgconadelanto.AllowUserToDeleteRows = false;
            this.dgconadelanto.AllowUserToResizeColumns = false;
            this.dgconadelanto.AllowUserToResizeRows = false;
            this.dgconadelanto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgconadelanto.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgconadelanto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgconadelanto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgconadelanto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.fechIniAdelanto,
            this.Fecha,
            this.monto,
            this.nomUsuarioPersonal,
            this.estAdelanto});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgconadelanto.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgconadelanto.GridColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgconadelanto.Location = new System.Drawing.Point(24, 132);
            this.dgconadelanto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgconadelanto.Name = "dgconadelanto";
            this.dgconadelanto.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgconadelanto.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgconadelanto.RowHeadersVisible = false;
            this.dgconadelanto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgconadelanto.Size = new System.Drawing.Size(689, 311);
            this.dgconadelanto.TabIndex = 105;
            this.dgconadelanto.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvprestamo_CellDoubleClick);
            this.dgconadelanto.DoubleClick += new System.EventHandler(this.dgvprestamo_DoubleClick);
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "codAdelanto";
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
            // fechIniAdelanto
            // 
            this.fechIniAdelanto.DataPropertyName = "fechIniAdelanto";
            this.fechIniAdelanto.HeaderText = "Fecha Inicio";
            this.fechIniAdelanto.Name = "fechIniAdelanto";
            this.fechIniAdelanto.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "fechFinAdelanto";
            this.Fecha.HeaderText = "Fecha Fin";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // monto
            // 
            this.monto.DataPropertyName = "montoAdelanto";
            this.monto.HeaderText = "M. Adelanto S./";
            this.monto.Name = "monto";
            this.monto.ReadOnly = true;
            // 
            // nomUsuarioPersonal
            // 
            this.nomUsuarioPersonal.DataPropertyName = "nomUsuarioPersonal";
            this.nomUsuarioPersonal.HeaderText = "USUARIO";
            this.nomUsuarioPersonal.Name = "nomUsuarioPersonal";
            this.nomUsuarioPersonal.ReadOnly = true;
            // 
            // estAdelanto
            // 
            this.estAdelanto.DataPropertyName = "Estado";
            this.estAdelanto.HeaderText = "ESTADO";
            this.estAdelanto.Name = "estAdelanto";
            this.estAdelanto.ReadOnly = true;
            // 
            // FrmConsultaAdelanto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 466);
            this.Controls.Add(this.dgconadelanto);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmConsultaAdelanto";
            this.Text = "Consulta Adelanto";
            this.Load += new System.EventHandler(this.FrmConsultaAdelanto_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgconadelanto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.DataGridView dgconadelanto;
        private System.Windows.Forms.ComboBox cbadelanto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechIniAdelanto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomUsuarioPersonal;
        private System.Windows.Forms.DataGridViewTextBoxColumn estAdelanto;
    }
}