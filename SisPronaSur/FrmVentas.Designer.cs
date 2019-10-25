namespace SisPronaSur
{
    partial class FrmVentas
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVentas));
            this.label1 = new System.Windows.Forms.Label();
            this.txtseriecomp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnumcomp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnNuevoProveedor = new System.Windows.Forms.Button();
            this.txtrucproven = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtnomapepro = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtdniprovent = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbtippro = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnquitar = new System.Windows.Forms.Button();
            this.btnagregar = new System.Windows.Forms.Button();
            this.txtpeso = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtpredetprod = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtpreproducto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbproductoventa = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvdetallecompra = new System.Windows.Forms.DataGridView();
            this.CODPRODUCTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CANT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODTIPO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnsalir = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txttotpro = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbestado = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdetallecompra)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Serie";
            // 
            // txtseriecomp
            // 
            this.txtseriecomp.BackColor = System.Drawing.Color.White;
            this.txtseriecomp.Enabled = false;
            this.txtseriecomp.Location = new System.Drawing.Point(43, 13);
            this.txtseriecomp.Name = "txtseriecomp";
            this.txtseriecomp.ReadOnly = true;
            this.txtseriecomp.Size = new System.Drawing.Size(68, 20);
            this.txtseriecomp.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Numero";
            // 
            // txtnumcomp
            // 
            this.txtnumcomp.BackColor = System.Drawing.Color.White;
            this.txtnumcomp.Enabled = false;
            this.txtnumcomp.Location = new System.Drawing.Point(177, 13);
            this.txtnumcomp.Name = "txtnumcomp";
            this.txtnumcomp.ReadOnly = true;
            this.txtnumcomp.Size = new System.Drawing.Size(147, 20);
            this.txtnumcomp.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "DNI";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnNuevoProveedor);
            this.groupBox1.Controls.Add(this.txtrucproven);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtnomapepro);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtdniprovent);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(23, 121);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(625, 118);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Proveedor";
            // 
            // btnNuevoProveedor
            // 
            this.btnNuevoProveedor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNuevoProveedor.BackgroundImage")));
            this.btnNuevoProveedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNuevoProveedor.Location = new System.Drawing.Point(181, 23);
            this.btnNuevoProveedor.Name = "btnNuevoProveedor";
            this.btnNuevoProveedor.Size = new System.Drawing.Size(26, 22);
            this.btnNuevoProveedor.TabIndex = 11;
            this.btnNuevoProveedor.UseVisualStyleBackColor = true;
            this.btnNuevoProveedor.Click += new System.EventHandler(this.btnNuevoProveedor_Click);
            // 
            // txtrucproven
            // 
            this.txtrucproven.BackColor = System.Drawing.Color.White;
            this.txtrucproven.Enabled = false;
            this.txtrucproven.Location = new System.Drawing.Point(438, 62);
            this.txtrucproven.Name = "txtrucproven";
            this.txtrucproven.ReadOnly = true;
            this.txtrucproven.Size = new System.Drawing.Size(143, 20);
            this.txtrucproven.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(402, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "RUC";
            // 
            // txtnomapepro
            // 
            this.txtnomapepro.BackColor = System.Drawing.Color.White;
            this.txtnomapepro.Enabled = false;
            this.txtnomapepro.Location = new System.Drawing.Point(129, 62);
            this.txtnomapepro.Name = "txtnomapepro";
            this.txtnomapepro.ReadOnly = true;
            this.txtnomapepro.Size = new System.Drawing.Size(255, 20);
            this.txtnomapepro.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nombres y Apellidos";
            // 
            // txtdniprovent
            // 
            this.txtdniprovent.Location = new System.Drawing.Point(53, 25);
            this.txtdniprovent.Name = "txtdniprovent";
            this.txtdniprovent.Size = new System.Drawing.Size(122, 20);
            this.txtdniprovent.TabIndex = 6;
            this.txtdniprovent.TextChanged += new System.EventHandler(this.txtdniprovent_TextChanged);
            this.txtdniprovent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdniprovent_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbtippro);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.btnquitar);
            this.groupBox2.Controls.Add(this.btnagregar);
            this.groupBox2.Controls.Add(this.txtpeso);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtpredetprod);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtpreproducto);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cmbproductoventa);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(23, 245);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(625, 108);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Compra";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // cmbtippro
            // 
            this.cmbtippro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbtippro.FormattingEnabled = true;
            this.cmbtippro.Location = new System.Drawing.Point(249, 28);
            this.cmbtippro.Name = "cmbtippro";
            this.cmbtippro.Size = new System.Drawing.Size(121, 21);
            this.cmbtippro.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(215, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Tipo";
            // 
            // btnquitar
            // 
            this.btnquitar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnquitar.BackgroundImage")));
            this.btnquitar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnquitar.Location = new System.Drawing.Point(573, 67);
            this.btnquitar.Name = "btnquitar";
            this.btnquitar.Size = new System.Drawing.Size(46, 33);
            this.btnquitar.TabIndex = 16;
            this.btnquitar.UseVisualStyleBackColor = true;
            this.btnquitar.Click += new System.EventHandler(this.btnquitar_Click);
            // 
            // btnagregar
            // 
            this.btnagregar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnagregar.BackgroundImage")));
            this.btnagregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnagregar.Location = new System.Drawing.Point(573, 28);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(46, 33);
            this.btnagregar.TabIndex = 15;
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtpeso
            // 
            this.txtpeso.Location = new System.Drawing.Point(218, 70);
            this.txtpeso.Name = "txtpeso";
            this.txtpeso.Size = new System.Drawing.Size(68, 20);
            this.txtpeso.TabIndex = 14;
            this.txtpeso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpeso_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(175, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Peso";
            // 
            // txtpredetprod
            // 
            this.txtpredetprod.Location = new System.Drawing.Point(86, 70);
            this.txtpredetprod.Name = "txtpredetprod";
            this.txtpredetprod.Size = new System.Drawing.Size(68, 20);
            this.txtpredetprod.TabIndex = 12;
            this.txtpredetprod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpredetprod_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Precio";
            // 
            // txtpreproducto
            // 
            this.txtpreproducto.BackColor = System.Drawing.Color.White;
            this.txtpreproducto.Enabled = false;
            this.txtpreproducto.Location = new System.Drawing.Point(479, 28);
            this.txtpreproducto.Name = "txtpreproducto";
            this.txtpreproducto.ReadOnly = true;
            this.txtpreproducto.Size = new System.Drawing.Size(68, 20);
            this.txtpreproducto.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(376, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Precio del Producto";
            // 
            // cmbproductoventa
            // 
            this.cmbproductoventa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbproductoventa.FormattingEnabled = true;
            this.cmbproductoventa.Location = new System.Drawing.Point(86, 28);
            this.cmbproductoventa.Name = "cmbproductoventa";
            this.cmbproductoventa.Size = new System.Drawing.Size(121, 21);
            this.cmbproductoventa.TabIndex = 1;
            this.cmbproductoventa.SelectedIndexChanged += new System.EventHandler(this.cmbproductoventa_SelectedIndexChanged_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Producto";
            // 
            // dgvdetallecompra
            // 
            this.dgvdetallecompra.AllowUserToAddRows = false;
            this.dgvdetallecompra.AllowUserToDeleteRows = false;
            this.dgvdetallecompra.AllowUserToResizeColumns = false;
            this.dgvdetallecompra.AllowUserToResizeRows = false;
            this.dgvdetallecompra.BackgroundColor = System.Drawing.Color.White;
            this.dgvdetallecompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdetallecompra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CODPRODUCTO,
            this.CANT,
            this.DESCRIPCION,
            this.CODTIPO,
            this.Column1});
            this.dgvdetallecompra.Location = new System.Drawing.Point(6, 19);
            this.dgvdetallecompra.Name = "dgvdetallecompra";
            this.dgvdetallecompra.ReadOnly = true;
            this.dgvdetallecompra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvdetallecompra.Size = new System.Drawing.Size(612, 109);
            this.dgvdetallecompra.TabIndex = 7;
            this.dgvdetallecompra.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdetallecompra_CellContentClick);
            this.dgvdetallecompra.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdetallecompra_CellDoubleClick);
            this.dgvdetallecompra.SelectionChanged += new System.EventHandler(this.dgvdetallecompra_SelectionChanged);
            this.dgvdetallecompra.Click += new System.EventHandler(this.dgvdetallecompra_Click);
            // 
            // CODPRODUCTO
            // 
            this.CODPRODUCTO.HeaderText = "COD. PRODUCTO";
            this.CODPRODUCTO.Name = "CODPRODUCTO";
            this.CODPRODUCTO.ReadOnly = true;
            // 
            // CANT
            // 
            this.CANT.HeaderText = "PESO";
            this.CANT.Name = "CANT";
            this.CANT.ReadOnly = true;
            // 
            // DESCRIPCION
            // 
            this.DESCRIPCION.HeaderText = "DESCRIPCION";
            this.DESCRIPCION.Name = "DESCRIPCION";
            this.DESCRIPCION.ReadOnly = true;
            this.DESCRIPCION.Width = 265;
            // 
            // CODTIPO
            // 
            this.CODTIPO.DataPropertyName = "COD.TIPO";
            this.CODTIPO.HeaderText = "COD.TIPO";
            this.CODTIPO.Name = "CODTIPO";
            this.CODTIPO.ReadOnly = true;
            this.CODTIPO.Visible = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "P. UNITARIO";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // btnsalir
            // 
            this.btnsalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnsalir.BackgroundImage")));
            this.btnsalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnsalir.Location = new System.Drawing.Point(597, 534);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(45, 39);
            this.btnsalir.TabIndex = 8;
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(468, 143);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Total";
            // 
            // txttotpro
            // 
            this.txttotpro.BackColor = System.Drawing.Color.White;
            this.txttotpro.Location = new System.Drawing.Point(505, 140);
            this.txttotpro.Name = "txttotpro";
            this.txttotpro.ReadOnly = true;
            this.txttotpro.Size = new System.Drawing.Size(76, 20);
            this.txttotpro.TabIndex = 20;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txttotpro);
            this.groupBox3.Controls.Add(this.dgvdetallecompra);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Location = new System.Drawing.Point(23, 359);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(625, 171);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Detalle Compra";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cmbestado);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.txtseriecomp);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.txtnumcomp);
            this.groupBox4.Location = new System.Drawing.Point(23, 63);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(625, 44);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGenerar.BackgroundImage")));
            this.btnGenerar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGenerar.Location = new System.Drawing.Point(252, 536);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(45, 39);
            this.btnGenerar.TabIndex = 11;
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancelar.BackgroundImage")));
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelar.Location = new System.Drawing.Point(348, 536);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(45, 39);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(356, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(105, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "Estado de la Compra";
            // 
            // cmbestado
            // 
            this.cmbestado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbestado.FormattingEnabled = true;
            this.cmbestado.Location = new System.Drawing.Point(467, 13);
            this.cmbestado.Name = "cmbestado";
            this.cmbestado.Size = new System.Drawing.Size(151, 21);
            this.cmbestado.TabIndex = 20;
            // 
            // FrmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 606);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmVentas";
            this.Text = "Compras";
            this.Load += new System.EventHandler(this.FrmVentas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdetallecompra)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtseriecomp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnumcomp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtdniprovent;
        private System.Windows.Forms.TextBox txtrucproven;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtnomapepro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbproductoventa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtpeso;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtpredetprod;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtpreproducto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvdetallecompra;
        private System.Windows.Forms.Button btnquitar;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.ComboBox cmbtippro;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txttotpro;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnNuevoProveedor;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODPRODUCTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CANT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODTIPO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.ComboBox cmbestado;
        private System.Windows.Forms.Label label12;
    }
}

