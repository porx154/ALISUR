namespace SisPronaSur.Mantenimiento
{
    partial class FrmManProducto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmManProducto));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtpreproducto = new System.Windows.Forms.TextBox();
            this.txtdespro = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcodproducto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gboLista = new System.Windows.Forms.GroupBox();
            this.dgvproducto = new System.Windows.Forms.DataGridView();
            this.Id_Anno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion_Anno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.btnregistrar = new System.Windows.Forms.Button();
            this.btneditar = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.GBOpciones = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.gboLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproducto)).BeginInit();
            this.GBOpciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtpreproducto);
            this.groupBox1.Controls.Add(this.txtdespro);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtcodproducto);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(23, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(447, 101);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Producto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(292, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "S/.";
            // 
            // txtpreproducto
            // 
            this.txtpreproducto.Enabled = false;
            this.txtpreproducto.Location = new System.Drawing.Point(320, 45);
            this.txtpreproducto.Name = "txtpreproducto";
            this.txtpreproducto.Size = new System.Drawing.Size(72, 20);
            this.txtpreproducto.TabIndex = 17;
            this.txtpreproducto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtpreproducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpreproducto_KeyPress);
            // 
            // txtdespro
            // 
            this.txtdespro.BackColor = System.Drawing.Color.White;
            this.txtdespro.Enabled = false;
            this.txtdespro.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdespro.Location = new System.Drawing.Point(100, 45);
            this.txtdespro.Name = "txtdespro";
            this.txtdespro.Size = new System.Drawing.Size(176, 21);
            this.txtdespro.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(292, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Precio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Descripcion";
            // 
            // txtcodproducto
            // 
            this.txtcodproducto.BackColor = System.Drawing.Color.White;
            this.txtcodproducto.Enabled = false;
            this.txtcodproducto.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodproducto.ForeColor = System.Drawing.Color.Black;
            this.txtcodproducto.Location = new System.Drawing.Point(18, 45);
            this.txtcodproducto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtcodproducto.Name = "txtcodproducto";
            this.txtcodproducto.ReadOnly = true;
            this.txtcodproducto.Size = new System.Drawing.Size(62, 21);
            this.txtcodproducto.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // gboLista
            // 
            this.gboLista.BackColor = System.Drawing.Color.Transparent;
            this.gboLista.Controls.Add(this.dgvproducto);
            this.gboLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboLista.ForeColor = System.Drawing.Color.Black;
            this.gboLista.Location = new System.Drawing.Point(23, 161);
            this.gboLista.Name = "gboLista";
            this.gboLista.Size = new System.Drawing.Size(447, 218);
            this.gboLista.TabIndex = 145;
            this.gboLista.TabStop = false;
            this.gboLista.Text = " Listado de Producto";
            // 
            // dgvproducto
            // 
            this.dgvproducto.AllowUserToAddRows = false;
            this.dgvproducto.AllowUserToDeleteRows = false;
            this.dgvproducto.AllowUserToResizeColumns = false;
            this.dgvproducto.AllowUserToResizeRows = false;
            this.dgvproducto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvproducto.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvproducto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvproducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvproducto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Anno,
            this.Descripcion_Anno,
            this.preProducto});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvproducto.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvproducto.GridColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgvproducto.Location = new System.Drawing.Point(8, 19);
            this.dgvproducto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvproducto.Name = "dgvproducto";
            this.dgvproducto.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvproducto.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvproducto.RowHeadersVisible = false;
            this.dgvproducto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvproducto.Size = new System.Drawing.Size(432, 193);
            this.dgvproducto.TabIndex = 102;
            this.dgvproducto.SelectionChanged += new System.EventHandler(this.dgvproducto_SelectionChanged);
            // 
            // Id_Anno
            // 
            this.Id_Anno.DataPropertyName = "CodProducto";
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
            this.Descripcion_Anno.DataPropertyName = "nomProducto";
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Descripcion_Anno.DefaultCellStyle = dataGridViewCellStyle3;
            this.Descripcion_Anno.HeaderText = "DESCRIPCIÓN";
            this.Descripcion_Anno.Name = "Descripcion_Anno";
            this.Descripcion_Anno.ReadOnly = true;
            // 
            // preProducto
            // 
            this.preProducto.DataPropertyName = "preProducto";
            this.preProducto.HeaderText = "PRECIO";
            this.preProducto.Name = "preProducto";
            this.preProducto.ReadOnly = true;
            // 
            // btnnuevo
            // 
            this.btnnuevo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnnuevo.BackgroundImage")));
            this.btnnuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnnuevo.Location = new System.Drawing.Point(6, 17);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(50, 39);
            this.btnnuevo.TabIndex = 0;
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // btnregistrar
            // 
            this.btnregistrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnregistrar.BackgroundImage")));
            this.btnregistrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnregistrar.Enabled = false;
            this.btnregistrar.Location = new System.Drawing.Point(6, 149);
            this.btnregistrar.Name = "btnregistrar";
            this.btnregistrar.Size = new System.Drawing.Size(50, 39);
            this.btnregistrar.TabIndex = 1;
            this.btnregistrar.UseVisualStyleBackColor = true;
            this.btnregistrar.Click += new System.EventHandler(this.btnregistrar_Click);
            // 
            // btneditar
            // 
            this.btneditar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btneditar.BackgroundImage")));
            this.btneditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btneditar.Location = new System.Drawing.Point(6, 86);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(50, 39);
            this.btneditar.TabIndex = 2;
            this.btneditar.UseVisualStyleBackColor = true;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnsalir.BackgroundImage")));
            this.btnsalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsalir.Location = new System.Drawing.Point(6, 278);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(50, 41);
            this.btnsalir.TabIndex = 3;
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btncancelar.BackgroundImage")));
            this.btncancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncancelar.Location = new System.Drawing.Point(6, 216);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(50, 39);
            this.btncancelar.TabIndex = 4;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // GBOpciones
            // 
            this.GBOpciones.BackColor = System.Drawing.Color.Transparent;
            this.GBOpciones.Controls.Add(this.btncancelar);
            this.GBOpciones.Controls.Add(this.btnsalir);
            this.GBOpciones.Controls.Add(this.btneditar);
            this.GBOpciones.Controls.Add(this.btnregistrar);
            this.GBOpciones.Controls.Add(this.btnnuevo);
            this.GBOpciones.Location = new System.Drawing.Point(476, 54);
            this.GBOpciones.Name = "GBOpciones";
            this.GBOpciones.Size = new System.Drawing.Size(62, 325);
            this.GBOpciones.TabIndex = 144;
            this.GBOpciones.TabStop = false;
            // 
            // FrmManProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 400);
            this.Controls.Add(this.gboLista);
            this.Controls.Add(this.GBOpciones);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmManProducto";
            this.Text = "Mantenimiento Producto";
            this.Load += new System.EventHandler(this.FrmManProducto_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gboLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvproducto)).EndInit();
            this.GBOpciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.TextBox txtcodproducto;
        private System.Windows.Forms.Label label3;
        internal System.Windows.Forms.TextBox txtdespro;
        internal System.Windows.Forms.GroupBox gboLista;
        internal System.Windows.Forms.DataGridView dgvproducto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtpreproducto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Anno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion_Anno;
        private System.Windows.Forms.DataGridViewTextBoxColumn preProducto;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.Button btnregistrar;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btncancelar;
        internal System.Windows.Forms.GroupBox GBOpciones;
    }
}