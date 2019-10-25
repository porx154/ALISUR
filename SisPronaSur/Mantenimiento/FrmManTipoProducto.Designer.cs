namespace SisPronaSur.Mantenimiento
{
    partial class FrmManTipoProducto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmManTipoProducto));
            this.gboDatos = new System.Windows.Forms.GroupBox();
            this.cmbproducto = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtdestipro = new System.Windows.Forms.TextBox();
            this.txtcod = new System.Windows.Forms.TextBox();
            this.LblCodigo = new System.Windows.Forms.Label();
            this.LblArea = new System.Windows.Forms.Label();
            this.LblAbreviatura = new System.Windows.Forms.Label();
            this.gboLista = new System.Windows.Forms.GroupBox();
            this.dgvtipopro = new System.Windows.Forms.DataGridView();
            this.Id_Anno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion_Anno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.btneditar = new System.Windows.Forms.Button();
            this.btnregistrar = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.GBOpciones = new System.Windows.Forms.GroupBox();
            this.gboDatos.SuspendLayout();
            this.gboLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtipopro)).BeginInit();
            this.GBOpciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboDatos
            // 
            this.gboDatos.BackColor = System.Drawing.Color.Transparent;
            this.gboDatos.Controls.Add(this.cmbproducto);
            this.gboDatos.Controls.Add(this.label1);
            this.gboDatos.Controls.Add(this.txtdestipro);
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
            this.gboDatos.Size = new System.Drawing.Size(441, 64);
            this.gboDatos.TabIndex = 141;
            this.gboDatos.TabStop = false;
            this.gboDatos.Text = "Datos del Producto";
            // 
            // cmbproducto
            // 
            this.cmbproducto.FormattingEnabled = true;
            this.cmbproducto.Location = new System.Drawing.Point(84, 35);
            this.cmbproducto.Name = "cmbproducto";
            this.cmbproducto.Size = new System.Drawing.Size(121, 21);
            this.cmbproducto.TabIndex = 12;
            this.cmbproducto.SelectedIndexChanged += new System.EventHandler(this.cmbproducto_SelectedIndexChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(81, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Producto";
            // 
            // txtdestipro
            // 
            this.txtdestipro.BackColor = System.Drawing.Color.White;
            this.txtdestipro.Enabled = false;
            this.txtdestipro.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdestipro.Location = new System.Drawing.Point(215, 35);
            this.txtdestipro.Name = "txtdestipro";
            this.txtdestipro.Size = new System.Drawing.Size(209, 21);
            this.txtdestipro.TabIndex = 8;
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
            this.LblArea.Location = new System.Drawing.Point(212, 19);
            this.LblArea.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblArea.Name = "LblArea";
            this.LblArea.Size = new System.Drawing.Size(73, 13);
            this.LblArea.TabIndex = 2;
            this.LblArea.Text = "Tipo Producto";
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
            // gboLista
            // 
            this.gboLista.BackColor = System.Drawing.Color.Transparent;
            this.gboLista.Controls.Add(this.dgvtipopro);
            this.gboLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboLista.ForeColor = System.Drawing.Color.Black;
            this.gboLista.Location = new System.Drawing.Point(24, 137);
            this.gboLista.Name = "gboLista";
            this.gboLista.Size = new System.Drawing.Size(441, 218);
            this.gboLista.TabIndex = 142;
            this.gboLista.TabStop = false;
            this.gboLista.Text = " Listado de Tipos";
            // 
            // dgvtipopro
            // 
            this.dgvtipopro.AllowUserToAddRows = false;
            this.dgvtipopro.AllowUserToDeleteRows = false;
            this.dgvtipopro.AllowUserToResizeColumns = false;
            this.dgvtipopro.AllowUserToResizeRows = false;
            this.dgvtipopro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvtipopro.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvtipopro.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvtipopro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtipopro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Anno,
            this.Descripcion_Anno});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvtipopro.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvtipopro.GridColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgvtipopro.Location = new System.Drawing.Point(8, 19);
            this.dgvtipopro.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvtipopro.Name = "dgvtipopro";
            this.dgvtipopro.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvtipopro.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvtipopro.RowHeadersVisible = false;
            this.dgvtipopro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvtipopro.Size = new System.Drawing.Size(426, 193);
            this.dgvtipopro.TabIndex = 102;
            this.dgvtipopro.SelectionChanged += new System.EventHandler(this.dgvtipopro_SelectionChanged);
            // 
            // Id_Anno
            // 
            this.Id_Anno.DataPropertyName = "CodTipoProdcuto";
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
            this.Descripcion_Anno.DataPropertyName = "desTipoProducto";
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Descripcion_Anno.DefaultCellStyle = dataGridViewCellStyle3;
            this.Descripcion_Anno.HeaderText = "DESCRIPCIÓN";
            this.Descripcion_Anno.Name = "Descripcion_Anno";
            this.Descripcion_Anno.ReadOnly = true;
            // 
            // btncancelar
            // 
            this.btncancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btncancelar.BackgroundImage")));
            this.btncancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncancelar.Location = new System.Drawing.Point(6, 184);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(50, 39);
            this.btncancelar.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btncancelar, "Cancelar");
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnsalir.BackgroundImage")));
            this.btnsalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsalir.Location = new System.Drawing.Point(6, 242);
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
            this.btneditar.Location = new System.Drawing.Point(6, 69);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(50, 39);
            this.btneditar.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btneditar, "Editar");
            this.btneditar.UseVisualStyleBackColor = true;
            this.btneditar.Click += new System.EventHandler(this.btneditar_Click);
            // 
            // btnregistrar
            // 
            this.btnregistrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnregistrar.BackgroundImage")));
            this.btnregistrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnregistrar.Enabled = false;
            this.btnregistrar.Location = new System.Drawing.Point(6, 125);
            this.btnregistrar.Name = "btnregistrar";
            this.btnregistrar.Size = new System.Drawing.Size(50, 39);
            this.btnregistrar.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btnregistrar, "Registrar");
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
            this.toolTip1.SetToolTip(this.btnnuevo, "Nuevo");
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // GBOpciones
            // 
            this.GBOpciones.BackColor = System.Drawing.Color.Transparent;
            this.GBOpciones.Controls.Add(this.btncancelar);
            this.GBOpciones.Controls.Add(this.btnsalir);
            this.GBOpciones.Controls.Add(this.btneditar);
            this.GBOpciones.Controls.Add(this.btnregistrar);
            this.GBOpciones.Controls.Add(this.btnnuevo);
            this.GBOpciones.Location = new System.Drawing.Point(472, 63);
            this.GBOpciones.Name = "GBOpciones";
            this.GBOpciones.Size = new System.Drawing.Size(62, 288);
            this.GBOpciones.TabIndex = 143;
            this.GBOpciones.TabStop = false;
            // 
            // FrmManTipoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 369);
            this.Controls.Add(this.gboDatos);
            this.Controls.Add(this.gboLista);
            this.Controls.Add(this.GBOpciones);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmManTipoProducto";
            this.Text = "Mantenimiento Tipo Producto";
            this.Load += new System.EventHandler(this.FrmManTipoProducto_Load);
            this.gboDatos.ResumeLayout(false);
            this.gboDatos.PerformLayout();
            this.gboLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvtipopro)).EndInit();
            this.GBOpciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox gboDatos;
        internal System.Windows.Forms.TextBox txtdestipro;
        internal System.Windows.Forms.TextBox txtcod;
        internal System.Windows.Forms.Label LblCodigo;
        internal System.Windows.Forms.Label LblArea;
        internal System.Windows.Forms.Label LblAbreviatura;
        internal System.Windows.Forms.GroupBox gboLista;
        internal System.Windows.Forms.DataGridView dgvtipopro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Anno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion_Anno;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btnregistrar;
        private System.Windows.Forms.Button btnnuevo;
        internal System.Windows.Forms.GroupBox GBOpciones;
        private System.Windows.Forms.ComboBox cmbproducto;
        internal System.Windows.Forms.Label label1;
    }
}