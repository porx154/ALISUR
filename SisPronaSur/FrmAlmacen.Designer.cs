namespace SisPronaSur
{
    partial class FrmAlmacen
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAlmacen));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvalmacen = new System.Windows.Forms.DataGridView();
            this.Id_Anno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion_Anno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTALPESO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estOpTienda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Operacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtsucalm = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtretalm = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txttotalmacen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnsalir = new System.Windows.Forms.Button();
            this.btnretirar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvalmacen)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvalmacen);
            this.groupBox1.Controls.Add(this.txtsucalm);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(23, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(546, 260);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Almacen";
            // 
            // dgvalmacen
            // 
            this.dgvalmacen.AllowUserToAddRows = false;
            this.dgvalmacen.AllowUserToDeleteRows = false;
            this.dgvalmacen.AllowUserToResizeColumns = false;
            this.dgvalmacen.AllowUserToResizeRows = false;
            this.dgvalmacen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvalmacen.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvalmacen.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvalmacen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvalmacen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Anno,
            this.Descripcion_Anno,
            this.preProducto,
            this.TOTALPESO,
            this.estOpTienda,
            this.CodProducto,
            this.Operacion});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvalmacen.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvalmacen.GridColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgvalmacen.Location = new System.Drawing.Point(23, 71);
            this.dgvalmacen.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvalmacen.Name = "dgvalmacen";
            this.dgvalmacen.ReadOnly = true;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvalmacen.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvalmacen.RowHeadersVisible = false;
            this.dgvalmacen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvalmacen.Size = new System.Drawing.Size(516, 166);
            this.dgvalmacen.TabIndex = 103;
            // 
            // Id_Anno
            // 
            this.Id_Anno.DataPropertyName = "CodAlmacen";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.Format = "0#####";
            this.Id_Anno.DefaultCellStyle = dataGridViewCellStyle7;
            this.Id_Anno.HeaderText = "CÓDIGO";
            this.Id_Anno.Name = "Id_Anno";
            this.Id_Anno.ReadOnly = true;
            this.Id_Anno.Width = 60;
            // 
            // Descripcion_Anno
            // 
            this.Descripcion_Anno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Descripcion_Anno.DataPropertyName = "nomProducto";
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Descripcion_Anno.DefaultCellStyle = dataGridViewCellStyle8;
            this.Descripcion_Anno.HeaderText = "PRODUCTO";
            this.Descripcion_Anno.Name = "Descripcion_Anno";
            this.Descripcion_Anno.ReadOnly = true;
            // 
            // preProducto
            // 
            this.preProducto.DataPropertyName = "Peso";
            this.preProducto.HeaderText = "PESO";
            this.preProducto.Name = "preProducto";
            this.preProducto.ReadOnly = true;
            // 
            // TOTALPESO
            // 
            this.TOTALPESO.DataPropertyName = "Total Peso";
            this.TOTALPESO.HeaderText = "TOTAL PESO";
            this.TOTALPESO.Name = "TOTALPESO";
            this.TOTALPESO.ReadOnly = true;
            // 
            // estOpTienda
            // 
            this.estOpTienda.DataPropertyName = "estOpTienda";
            this.estOpTienda.HeaderText = "estOpTienda";
            this.estOpTienda.Name = "estOpTienda";
            this.estOpTienda.ReadOnly = true;
            this.estOpTienda.Visible = false;
            // 
            // CodProducto
            // 
            this.CodProducto.DataPropertyName = "CodProducto";
            this.CodProducto.HeaderText = "CodProducto";
            this.CodProducto.Name = "CodProducto";
            this.CodProducto.ReadOnly = true;
            this.CodProducto.Visible = false;
            // 
            // Operacion
            // 
            this.Operacion.DataPropertyName = "Operacion";
            this.Operacion.HeaderText = "OPERACION";
            this.Operacion.Name = "Operacion";
            this.Operacion.ReadOnly = true;
            // 
            // txtsucalm
            // 
            this.txtsucalm.BackColor = System.Drawing.Color.White;
            this.txtsucalm.Enabled = false;
            this.txtsucalm.Location = new System.Drawing.Point(74, 28);
            this.txtsucalm.Name = "txtsucalm";
            this.txtsucalm.ReadOnly = true;
            this.txtsucalm.Size = new System.Drawing.Size(167, 20);
            this.txtsucalm.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sucursal";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtretalm);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txttotalmacen);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(575, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(239, 133);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Retirar";
            // 
            // txtretalm
            // 
            this.txtretalm.BackColor = System.Drawing.Color.White;
            this.txtretalm.Location = new System.Drawing.Point(83, 86);
            this.txtretalm.Name = "txtretalm";
            this.txtretalm.Size = new System.Drawing.Size(64, 20);
            this.txtretalm.TabIndex = 3;
            this.txtretalm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtretalm_KeyPress);
            this.txtretalm.Validating += new System.ComponentModel.CancelEventHandler(this.txtretalm_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Retirar";
            // 
            // txttotalmacen
            // 
            this.txttotalmacen.BackColor = System.Drawing.Color.White;
            this.txttotalmacen.Enabled = false;
            this.txttotalmacen.Location = new System.Drawing.Point(83, 28);
            this.txttotalmacen.Name = "txttotalmacen";
            this.txttotalmacen.ReadOnly = true;
            this.txttotalmacen.Size = new System.Drawing.Size(64, 20);
            this.txttotalmacen.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Total Peso";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnsalir);
            this.groupBox3.Controls.Add(this.btnretirar);
            this.groupBox3.Location = new System.Drawing.Point(575, 202);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(239, 121);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // btnsalir
            // 
            this.btnsalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnsalir.BackgroundImage")));
            this.btnsalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnsalir.Location = new System.Drawing.Point(129, 40);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(46, 37);
            this.btnsalir.TabIndex = 1;
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btnretirar
            // 
            this.btnretirar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnretirar.BackgroundImage")));
            this.btnretirar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnretirar.Location = new System.Drawing.Point(55, 40);
            this.btnretirar.Name = "btnretirar";
            this.btnretirar.Size = new System.Drawing.Size(46, 37);
            this.btnretirar.TabIndex = 0;
            this.btnretirar.UseVisualStyleBackColor = true;
            this.btnretirar.Click += new System.EventHandler(this.btnretirar_Click);
            // 
            // FrmAlmacen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 343);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAlmacen";
            this.Text = "Almacen Tienda";
            this.Load += new System.EventHandler(this.FrmAlmacen_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvalmacen)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtsucalm;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.DataGridView dgvalmacen;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txttotalmacen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtretalm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btnretirar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Anno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion_Anno;
        private System.Windows.Forms.DataGridViewTextBoxColumn preProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTALPESO;
        private System.Windows.Forms.DataGridViewTextBoxColumn estOpTienda;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Operacion;
    }
}