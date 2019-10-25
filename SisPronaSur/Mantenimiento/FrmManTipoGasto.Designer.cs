namespace SisPronaSur.Mantenimiento
{
    partial class FrmManTipoGasto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmManTipoGasto));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gboLista = new System.Windows.Forms.GroupBox();
            this.dggasto = new System.Windows.Forms.DataGridView();
            this.GBOpciones = new System.Windows.Forms.GroupBox();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.btneditar = new System.Windows.Forms.Button();
            this.btnregistrar = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.gboDatos = new System.Windows.Forms.GroupBox();
            this.txtdes = new System.Windows.Forms.TextBox();
            this.txtcod = new System.Windows.Forms.TextBox();
            this.LblCodigo = new System.Windows.Forms.Label();
            this.LblArea = new System.Windows.Forms.Label();
            this.LblAbreviatura = new System.Windows.Forms.Label();
            this.Id_Anno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion_Anno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gboLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dggasto)).BeginInit();
            this.GBOpciones.SuspendLayout();
            this.gboDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboLista
            // 
            this.gboLista.BackColor = System.Drawing.Color.Transparent;
            this.gboLista.Controls.Add(this.dggasto);
            this.gboLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboLista.ForeColor = System.Drawing.Color.Black;
            this.gboLista.Location = new System.Drawing.Point(8, 133);
            this.gboLista.Name = "gboLista";
            this.gboLista.Size = new System.Drawing.Size(292, 218);
            this.gboLista.TabIndex = 142;
            this.gboLista.TabStop = false;
            this.gboLista.Text = "Tipo de Gastos";
            // 
            // dggasto
            // 
            this.dggasto.AllowUserToAddRows = false;
            this.dggasto.AllowUserToDeleteRows = false;
            this.dggasto.AllowUserToResizeColumns = false;
            this.dggasto.AllowUserToResizeRows = false;
            this.dggasto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dggasto.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dggasto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dggasto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dggasto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Anno,
            this.Descripcion_Anno});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dggasto.DefaultCellStyle = dataGridViewCellStyle4;
            this.dggasto.GridColor = System.Drawing.SystemColors.InactiveCaption;
            this.dggasto.Location = new System.Drawing.Point(8, 19);
            this.dggasto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dggasto.Name = "dggasto";
            this.dggasto.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dggasto.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dggasto.RowHeadersVisible = false;
            this.dggasto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dggasto.Size = new System.Drawing.Size(277, 193);
            this.dggasto.TabIndex = 102;
            this.dggasto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dggasto_CellContentClick);
            this.dggasto.SelectionChanged += new System.EventHandler(this.dggasto_SelectionChanged);
            // 
            // GBOpciones
            // 
            this.GBOpciones.BackColor = System.Drawing.Color.Transparent;
            this.GBOpciones.Controls.Add(this.btncancelar);
            this.GBOpciones.Controls.Add(this.btnsalir);
            this.GBOpciones.Controls.Add(this.btneditar);
            this.GBOpciones.Controls.Add(this.btnregistrar);
            this.GBOpciones.Controls.Add(this.btnnuevo);
            this.GBOpciones.Location = new System.Drawing.Point(306, 63);
            this.GBOpciones.Name = "GBOpciones";
            this.GBOpciones.Size = new System.Drawing.Size(62, 288);
            this.GBOpciones.TabIndex = 143;
            this.GBOpciones.TabStop = false;
            // 
            // btncancelar
            // 
            this.btncancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btncancelar.BackgroundImage")));
            this.btncancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncancelar.Location = new System.Drawing.Point(6, 189);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(50, 39);
            this.btncancelar.TabIndex = 4;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnsalir.BackgroundImage")));
            this.btnsalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsalir.Location = new System.Drawing.Point(6, 241);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(50, 41);
            this.btnsalir.TabIndex = 3;
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btneditar
            // 
            this.btneditar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btneditar.BackgroundImage")));
            this.btneditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btneditar.Location = new System.Drawing.Point(6, 74);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(50, 39);
            this.btneditar.TabIndex = 2;
            this.btneditar.UseVisualStyleBackColor = true;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // btnregistrar
            // 
            this.btnregistrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnregistrar.BackgroundImage")));
            this.btnregistrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnregistrar.Enabled = false;
            this.btnregistrar.Location = new System.Drawing.Point(6, 132);
            this.btnregistrar.Name = "btnregistrar";
            this.btnregistrar.Size = new System.Drawing.Size(50, 39);
            this.btnregistrar.TabIndex = 1;
            this.btnregistrar.UseVisualStyleBackColor = true;
            this.btnregistrar.Click += new System.EventHandler(this.btnregistrar_Click);
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
            // gboDatos
            // 
            this.gboDatos.BackColor = System.Drawing.Color.Transparent;
            this.gboDatos.Controls.Add(this.txtdes);
            this.gboDatos.Controls.Add(this.txtcod);
            this.gboDatos.Controls.Add(this.LblCodigo);
            this.gboDatos.Controls.Add(this.LblArea);
            this.gboDatos.Controls.Add(this.LblAbreviatura);
            this.gboDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboDatos.ForeColor = System.Drawing.Color.Black;
            this.gboDatos.Location = new System.Drawing.Point(8, 63);
            this.gboDatos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gboDatos.Name = "gboDatos";
            this.gboDatos.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gboDatos.Size = new System.Drawing.Size(292, 64);
            this.gboDatos.TabIndex = 141;
            this.gboDatos.TabStop = false;
            this.gboDatos.Text = "Datos del Gasto";
            // 
            // txtdes
            // 
            this.txtdes.BackColor = System.Drawing.Color.White;
            this.txtdes.Enabled = false;
            this.txtdes.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdes.Location = new System.Drawing.Point(76, 35);
            this.txtdes.Name = "txtdes";
            this.txtdes.Size = new System.Drawing.Size(209, 21);
            this.txtdes.TabIndex = 8;
            // 
            // txtcod
            // 
            this.txtcod.BackColor = System.Drawing.Color.White;
            this.txtcod.Enabled = false;
            this.txtcod.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcod.ForeColor = System.Drawing.Color.Black;
            this.txtcod.Location = new System.Drawing.Point(8, 35);
            this.txtcod.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtcod.Name = "txtcod";
            this.txtcod.ReadOnly = true;
            this.txtcod.Size = new System.Drawing.Size(62, 21);
            this.txtcod.TabIndex = 7;
            // 
            // LblCodigo
            // 
            this.LblCodigo.AutoSize = true;
            this.LblCodigo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCodigo.ForeColor = System.Drawing.Color.Black;
            this.LblCodigo.Location = new System.Drawing.Point(6, 19);
            this.LblCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblCodigo.Name = "LblCodigo";
            this.LblCodigo.Size = new System.Drawing.Size(43, 13);
            this.LblCodigo.TabIndex = 6;
            this.LblCodigo.Text = "Código ";
            // 
            // LblArea
            // 
            this.LblArea.AutoSize = true;
            this.LblArea.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblArea.ForeColor = System.Drawing.Color.Black;
            this.LblArea.Location = new System.Drawing.Point(73, 19);
            this.LblArea.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblArea.Name = "LblArea";
            this.LblArea.Size = new System.Drawing.Size(35, 13);
            this.LblArea.TabIndex = 2;
            this.LblArea.Text = "Gasto";
            // 
            // LblAbreviatura
            // 
            this.LblAbreviatura.AutoSize = true;
            this.LblAbreviatura.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAbreviatura.ForeColor = System.Drawing.Color.Navy;
            this.LblAbreviatura.Location = new System.Drawing.Point(8, 69);
            this.LblAbreviatura.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblAbreviatura.Name = "LblAbreviatura";
            this.LblAbreviatura.Size = new System.Drawing.Size(75, 13);
            this.LblAbreviatura.TabIndex = 1;
            this.LblAbreviatura.Text = "Abreviatura";
            // 
            // Id_Anno
            // 
            this.Id_Anno.DataPropertyName = "codTipoGasto";
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
            this.Descripcion_Anno.HeaderText = "DESCRIPCIÓN";
            this.Descripcion_Anno.Name = "Descripcion_Anno";
            this.Descripcion_Anno.ReadOnly = true;
            // 
            // FrmManTipoGasto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 368);
            this.Controls.Add(this.gboLista);
            this.Controls.Add(this.GBOpciones);
            this.Controls.Add(this.gboDatos);
            this.Name = "FrmManTipoGasto";
            this.Text = "Tipo Gasto";
            this.Load += new System.EventHandler(this.FrmManTipoGasto_Load);
            this.gboLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dggasto)).EndInit();
            this.GBOpciones.ResumeLayout(false);
            this.gboDatos.ResumeLayout(false);
            this.gboDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox gboLista;
        internal System.Windows.Forms.DataGridView dggasto;
        internal System.Windows.Forms.GroupBox GBOpciones;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btnregistrar;
        private System.Windows.Forms.Button btnnuevo;
        internal System.Windows.Forms.GroupBox gboDatos;
        internal System.Windows.Forms.TextBox txtdes;
        internal System.Windows.Forms.TextBox txtcod;
        internal System.Windows.Forms.Label LblCodigo;
        internal System.Windows.Forms.Label LblArea;
        internal System.Windows.Forms.Label LblAbreviatura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Anno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion_Anno;
    }
}