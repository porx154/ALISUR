namespace SisPronaSur.Consulta
{
    partial class FrmConGasto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConGasto));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtfinal = new System.Windows.Forms.DateTimePicker();
            this.dtinicial = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnfiltrar = new System.Windows.Forms.Button();
            this.cmbmes = new System.Windows.Forms.ComboBox();
            this.txtgastotot = new System.Windows.Forms.TextBox();
            this.dgvcargo = new System.Windows.Forms.DataGridView();
            this.Id_Anno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion_Anno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MONTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.USUARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcargo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtfinal);
            this.groupBox1.Controls.Add(this.dtinicial);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.btnfiltrar);
            this.groupBox1.Controls.Add(this.cmbmes);
            this.groupBox1.Location = new System.Drawing.Point(23, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(691, 97);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // dtfinal
            // 
            this.dtfinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtfinal.Location = new System.Drawing.Point(256, 24);
            this.dtfinal.Name = "dtfinal";
            this.dtfinal.Size = new System.Drawing.Size(97, 20);
            this.dtfinal.TabIndex = 108;
            this.dtfinal.Visible = false;
            this.dtfinal.ValueChanged += new System.EventHandler(this.dtfinal_ValueChanged);
            // 
            // dtinicial
            // 
            this.dtinicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtinicial.Location = new System.Drawing.Point(71, 23);
            this.dtinicial.Name = "dtinicial";
            this.dtinicial.Size = new System.Drawing.Size(97, 20);
            this.dtinicial.TabIndex = 107;
            this.dtinicial.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(201, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 106;
            this.label3.Text = "Final";
            this.label3.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 105;
            this.label2.Text = "Inicial";
            this.label2.Visible = false;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(105, 74);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(89, 17);
            this.checkBox2.TabIndex = 3;
            this.checkBox2.Text = "Entre Fechas";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(19, 74);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(65, 17);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Por Mes";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnfiltrar
            // 
            this.btnfiltrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnfiltrar.BackgroundImage")));
            this.btnfiltrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnfiltrar.Location = new System.Drawing.Point(244, 47);
            this.btnfiltrar.Name = "btnfiltrar";
            this.btnfiltrar.Size = new System.Drawing.Size(49, 21);
            this.btnfiltrar.TabIndex = 1;
            this.btnfiltrar.UseVisualStyleBackColor = true;
            this.btnfiltrar.Visible = false;
            this.btnfiltrar.Click += new System.EventHandler(this.btnfiltrar_Click);
            // 
            // cmbmes
            // 
            this.cmbmes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbmes.FormattingEnabled = true;
            this.cmbmes.Location = new System.Drawing.Point(19, 47);
            this.cmbmes.Name = "cmbmes";
            this.cmbmes.Size = new System.Drawing.Size(219, 21);
            this.cmbmes.TabIndex = 0;
            this.cmbmes.Visible = false;
            // 
            // txtgastotot
            // 
            this.txtgastotot.Location = new System.Drawing.Point(614, 395);
            this.txtgastotot.Name = "txtgastotot";
            this.txtgastotot.Size = new System.Drawing.Size(100, 20);
            this.txtgastotot.TabIndex = 2;
            // 
            // dgvcargo
            // 
            this.dgvcargo.AllowUserToAddRows = false;
            this.dgvcargo.AllowUserToDeleteRows = false;
            this.dgvcargo.AllowUserToResizeColumns = false;
            this.dgvcargo.AllowUserToResizeRows = false;
            this.dgvcargo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvcargo.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvcargo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvcargo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcargo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Anno,
            this.Descripcion_Anno,
            this.MONTO,
            this.DESCRIPCION,
            this.FECHA,
            this.USUARIO});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvcargo.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvcargo.GridColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgvcargo.Location = new System.Drawing.Point(24, 166);
            this.dgvcargo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvcargo.Name = "dgvcargo";
            this.dgvcargo.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvcargo.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvcargo.RowHeadersVisible = false;
            this.dgvcargo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvcargo.Size = new System.Drawing.Size(690, 209);
            this.dgvcargo.TabIndex = 103;
            this.dgvcargo.DoubleClick += new System.EventHandler(this.dgvcargo_DoubleClick);
            // 
            // Id_Anno
            // 
            this.Id_Anno.DataPropertyName = "codGastoGeneral";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Format = "0#####";
            this.Id_Anno.DefaultCellStyle = dataGridViewCellStyle2;
            this.Id_Anno.HeaderText = "CÓDIGO";
            this.Id_Anno.Name = "Id_Anno";
            this.Id_Anno.ReadOnly = true;
            this.Id_Anno.Width = 60;
            // 
            // Descripcion_Anno
            // 
            this.Descripcion_Anno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Descripcion_Anno.DataPropertyName = "desTipoGasto";
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Descripcion_Anno.DefaultCellStyle = dataGridViewCellStyle3;
            this.Descripcion_Anno.HeaderText = "TIPO GASTO";
            this.Descripcion_Anno.Name = "Descripcion_Anno";
            this.Descripcion_Anno.ReadOnly = true;
            // 
            // MONTO
            // 
            this.MONTO.DataPropertyName = "montoGasto";
            this.MONTO.HeaderText = "MONTO";
            this.MONTO.Name = "MONTO";
            this.MONTO.ReadOnly = true;
            // 
            // DESCRIPCION
            // 
            this.DESCRIPCION.DataPropertyName = "desGasto";
            this.DESCRIPCION.HeaderText = "DESCRIPCION";
            this.DESCRIPCION.Name = "DESCRIPCION";
            this.DESCRIPCION.ReadOnly = true;
            // 
            // FECHA
            // 
            this.FECHA.DataPropertyName = "Fecha";
            this.FECHA.HeaderText = "FECHA";
            this.FECHA.Name = "FECHA";
            this.FECHA.ReadOnly = true;
            // 
            // USUARIO
            // 
            this.USUARIO.DataPropertyName = "nomUsuarioPersonal";
            this.USUARIO.HeaderText = "USUARIO";
            this.USUARIO.Name = "USUARIO";
            this.USUARIO.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(559, 398);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 104;
            this.label1.Text = "Total S./";
            // 
            // FrmConGasto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 455);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvcargo);
            this.Controls.Add(this.txtgastotot);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmConGasto";
            this.Text = "Consulta Gasto";
            this.Load += new System.EventHandler(this.FrmConGasto_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcargo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtgastotot;
        private System.Windows.Forms.Button btnfiltrar;
        private System.Windows.Forms.ComboBox cmbmes;
        internal System.Windows.Forms.DataGridView dgvcargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Anno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion_Anno;
        private System.Windows.Forms.DataGridViewTextBoxColumn MONTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA;
        private System.Windows.Forms.DataGridViewTextBoxColumn USUARIO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.DateTimePicker dtfinal;
        private System.Windows.Forms.DateTimePicker dtinicial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}