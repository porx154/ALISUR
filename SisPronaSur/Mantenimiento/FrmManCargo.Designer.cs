namespace SisPronaSur.Mantenimiento
{
    partial class FrmManCargo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmManCargo));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnnuevo = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.btneditar = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnregistrar = new System.Windows.Forms.Button();
            this.dgvcargo = new System.Windows.Forms.DataGridView();
            this.Id_Anno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion_Anno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gboLista = new System.Windows.Forms.GroupBox();
            this.txtdes = new System.Windows.Forms.TextBox();
            this.txtcod = new System.Windows.Forms.TextBox();
            this.LblCodigo = new System.Windows.Forms.Label();
            this.LblArea = new System.Windows.Forms.Label();
            this.LblAbreviatura = new System.Windows.Forms.Label();
            this.GBOpciones = new System.Windows.Forms.GroupBox();
            this.gboDatos = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcargo)).BeginInit();
            this.gboLista.SuspendLayout();
            this.GBOpciones.SuspendLayout();
            this.gboDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnnuevo
            // 
            this.btnnuevo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnnuevo.BackgroundImage")));
            this.btnnuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnnuevo.Location = new System.Drawing.Point(6, 17);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(50, 39);
            this.btnnuevo.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btnnuevo, "Nuevo");
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnsalir.BackgroundImage")));
            this.btnsalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsalir.Location = new System.Drawing.Point(6, 241);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(50, 41);
            this.btnsalir.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnsalir, "Salir");
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
            this.toolTip1.SetToolTip(this.btneditar, "Editar");
            this.btneditar.UseVisualStyleBackColor = true;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btncancelar.BackgroundImage")));
            this.btncancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncancelar.Location = new System.Drawing.Point(6, 189);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(50, 39);
            this.btncancelar.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btncancelar, "Cancelar");
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
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
            this.toolTip1.SetToolTip(this.btnregistrar, "Registrar");
            this.btnregistrar.UseVisualStyleBackColor = true;
            this.btnregistrar.Click += new System.EventHandler(this.btnregistrar_Click);
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
            this.Descripcion_Anno});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvcargo.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvcargo.GridColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgvcargo.Location = new System.Drawing.Point(8, 19);
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
            this.dgvcargo.Size = new System.Drawing.Size(277, 193);
            this.dgvcargo.TabIndex = 102;
            this.dgvcargo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvcargo_CellContentClick);
            this.dgvcargo.SelectionChanged += new System.EventHandler(this.dgvcargo_SelectionChanged);
            // 
            // Id_Anno
            // 
            this.Id_Anno.DataPropertyName = "CodCargo";
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
            this.Descripcion_Anno.DataPropertyName = "desCargo";
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Descripcion_Anno.DefaultCellStyle = dataGridViewCellStyle3;
            this.Descripcion_Anno.HeaderText = "DESCRIPCIÓN";
            this.Descripcion_Anno.Name = "Descripcion_Anno";
            this.Descripcion_Anno.ReadOnly = true;
            // 
            // gboLista
            // 
            this.gboLista.BackColor = System.Drawing.Color.Transparent;
            this.gboLista.Controls.Add(this.dgvcargo);
            this.gboLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboLista.ForeColor = System.Drawing.Color.Black;
            this.gboLista.Location = new System.Drawing.Point(24, 133);
            this.gboLista.Name = "gboLista";
            this.gboLista.Size = new System.Drawing.Size(292, 218);
            this.gboLista.TabIndex = 139;
            this.gboLista.TabStop = false;
            this.gboLista.Text = " Listado de Cargos";
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
            this.LblArea.Size = new System.Drawing.Size(36, 13);
            this.LblArea.TabIndex = 2;
            this.LblArea.Text = "Cargo";
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
            // GBOpciones
            // 
            this.GBOpciones.BackColor = System.Drawing.Color.Transparent;
            this.GBOpciones.Controls.Add(this.btncancelar);
            this.GBOpciones.Controls.Add(this.btnsalir);
            this.GBOpciones.Controls.Add(this.btneditar);
            this.GBOpciones.Controls.Add(this.btnregistrar);
            this.GBOpciones.Controls.Add(this.btnnuevo);
            this.GBOpciones.Location = new System.Drawing.Point(322, 63);
            this.GBOpciones.Name = "GBOpciones";
            this.GBOpciones.Size = new System.Drawing.Size(62, 288);
            this.GBOpciones.TabIndex = 140;
            this.GBOpciones.TabStop = false;
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
            this.gboDatos.Location = new System.Drawing.Point(24, 63);
            this.gboDatos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gboDatos.Name = "gboDatos";
            this.gboDatos.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gboDatos.Size = new System.Drawing.Size(292, 64);
            this.gboDatos.TabIndex = 138;
            this.gboDatos.TabStop = false;
            this.gboDatos.Text = "Datos de la Marca";
            // 
            // FrmManCargo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 361);
            this.Controls.Add(this.gboLista);
            this.Controls.Add(this.GBOpciones);
            this.Controls.Add(this.gboDatos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmManCargo";
            this.Text = "Mantenimiento Cargo";
            this.Load += new System.EventHandler(this.FrmManCargo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcargo)).EndInit();
            this.gboLista.ResumeLayout(false);
            this.GBOpciones.ResumeLayout(false);
            this.gboDatos.ResumeLayout(false);
            this.gboDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnregistrar;
        internal System.Windows.Forms.DataGridView dgvcargo;
        internal System.Windows.Forms.GroupBox gboLista;
        internal System.Windows.Forms.TextBox txtdes;
        internal System.Windows.Forms.TextBox txtcod;
        internal System.Windows.Forms.Label LblCodigo;
        internal System.Windows.Forms.Label LblArea;
        internal System.Windows.Forms.Label LblAbreviatura;
        internal System.Windows.Forms.GroupBox GBOpciones;
        internal System.Windows.Forms.GroupBox gboDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Anno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion_Anno;
    }
}