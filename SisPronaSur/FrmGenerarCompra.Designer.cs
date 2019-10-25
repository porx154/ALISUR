namespace SisPronaSur
{
    partial class FrmGenerarCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGenerarCompra));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtseriecomp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnumcomp = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtrucproven = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtnomapepro = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtdniprovent = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txttotpro = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvdetallecompra = new System.Windows.Forms.DataGridView();
            this.CODPROD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CANT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODTIPO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SUBTOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.printDialogCompra = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocumentCompra = new System.Drawing.Printing.PrintDocument();
            this.lblimp = new System.Windows.Forms.Label();
            this.lbltopimp = new System.Windows.Forms.Label();
            this.lblprintnombre = new System.Windows.Forms.Label();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.btnGuardarCompra = new System.Windows.Forms.Button();
            this.lblprintdni = new System.Windows.Forms.Label();
            this.lblfechacompra = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblestado = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdetallecompra)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.txtseriecomp);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.txtnumcomp);
            this.groupBox4.Location = new System.Drawing.Point(23, 63);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(620, 44);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
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
            this.txtnumcomp.Location = new System.Drawing.Point(177, 13);
            this.txtnumcomp.Name = "txtnumcomp";
            this.txtnumcomp.ReadOnly = true;
            this.txtnumcomp.Size = new System.Drawing.Size(147, 20);
            this.txtnumcomp.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtrucproven);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtnomapepro);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtdniprovent);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(23, 121);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(625, 118);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Proveedor";
            // 
            // txtrucproven
            // 
            this.txtrucproven.BackColor = System.Drawing.Color.White;
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
            this.txtdniprovent.BackColor = System.Drawing.Color.White;
            this.txtdniprovent.Location = new System.Drawing.Point(53, 25);
            this.txtdniprovent.Name = "txtdniprovent";
            this.txtdniprovent.ReadOnly = true;
            this.txtdniprovent.Size = new System.Drawing.Size(122, 20);
            this.txtdniprovent.TabIndex = 6;
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
            this.groupBox3.Controls.Add(this.lblestado);
            this.groupBox3.Controls.Add(this.dgvdetallecompra);
            this.groupBox3.Controls.Add(this.txttotpro);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Location = new System.Drawing.Point(25, 245);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(625, 171);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Detalle Compra";
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
            this.CODPROD,
            this.CANT,
            this.DESCRIPCION,
            this.CODTIPO,
            this.Column1,
            this.SUBTOTAL});
            this.dgvdetallecompra.Location = new System.Drawing.Point(6, 19);
            this.dgvdetallecompra.Name = "dgvdetallecompra";
            this.dgvdetallecompra.ReadOnly = true;
            this.dgvdetallecompra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvdetallecompra.Size = new System.Drawing.Size(612, 109);
            this.dgvdetallecompra.TabIndex = 21;
            // 
            // CODPROD
            // 
            this.CODPROD.DataPropertyName = "Codigo";
            this.CODPROD.HeaderText = "COD.PRODUCTO";
            this.CODPROD.Name = "CODPROD";
            this.CODPROD.ReadOnly = true;
            // 
            // CANT
            // 
            this.CANT.DataPropertyName = "Peso";
            this.CANT.HeaderText = "PESO";
            this.CANT.Name = "CANT";
            this.CANT.ReadOnly = true;
            // 
            // DESCRIPCION
            // 
            this.DESCRIPCION.DataPropertyName = "Descripcion";
            this.DESCRIPCION.HeaderText = "DESCRIPCION";
            this.DESCRIPCION.Name = "DESCRIPCION";
            this.DESCRIPCION.ReadOnly = true;
            this.DESCRIPCION.Width = 265;
            // 
            // CODTIPO
            // 
            this.CODTIPO.DataPropertyName = "CodTipo";
            this.CODTIPO.HeaderText = "COD.TIPO";
            this.CODTIPO.Name = "CODTIPO";
            this.CODTIPO.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "PrecioUnitario";
            this.Column1.HeaderText = "P. UNITARIO";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // SUBTOTAL
            // 
            this.SUBTOTAL.HeaderText = "SUBTOTAL";
            this.SUBTOTAL.Name = "SUBTOTAL";
            this.SUBTOTAL.ReadOnly = true;
            // 
            // printDialogCompra
            // 
            this.printDialogCompra.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printDialogCompra.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printDialogCompra.ClientSize = new System.Drawing.Size(400, 300);
            this.printDialogCompra.Enabled = true;
            this.printDialogCompra.Icon = ((System.Drawing.Icon)(resources.GetObject("printDialogCompra.Icon")));
            this.printDialogCompra.Name = "printDialogCompra";
            this.printDialogCompra.Visible = false;
            // 
            // printDocumentCompra
            // 
            this.printDocumentCompra.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocumentCompra_PrintPage);
            // 
            // lblimp
            // 
            this.lblimp.AutoSize = true;
            this.lblimp.Location = new System.Drawing.Point(197, 439);
            this.lblimp.Name = "lblimp";
            this.lblimp.Size = new System.Drawing.Size(9, 390);
            this.lblimp.TabIndex = 21;
            this.lblimp.Text = "|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n" +
    "|\r\n|\r\n|\r\n";
            this.lblimp.Visible = false;
            // 
            // lbltopimp
            // 
            this.lbltopimp.AutoSize = true;
            this.lbltopimp.Location = new System.Drawing.Point(53, 425);
            this.lbltopimp.Name = "lbltopimp";
            this.lbltopimp.Size = new System.Drawing.Size(283, 13);
            this.lbltopimp.TabIndex = 22;
            this.lbltopimp.Text = "—  — — — — — — — — — — —  — — —  — — — — — — — — — — — — — — —";
            this.lbltopimp.Visible = false;
            // 
            // lblprintnombre
            // 
            this.lblprintnombre.AutoSize = true;
            this.lblprintnombre.Location = new System.Drawing.Point(384, 441);
            this.lblprintnombre.Name = "lblprintnombre";
            this.lblprintnombre.Size = new System.Drawing.Size(172, 13);
            this.lblprintnombre.TabIndex = 23;
            this.lblprintnombre.Text = ".......................................................";
            this.lblprintnombre.Visible = false;
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnImprimir.BackgroundImage")));
            this.btnImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnImprimir.Location = new System.Drawing.Point(333, 441);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(45, 39);
            this.btnImprimir.TabIndex = 19;
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnsalir.BackgroundImage")));
            this.btnsalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnsalir.Location = new System.Drawing.Point(598, 439);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(45, 39);
            this.btnsalir.TabIndex = 15;
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btnGuardarCompra
            // 
            this.btnGuardarCompra.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuardarCompra.BackgroundImage")));
            this.btnGuardarCompra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnGuardarCompra.Location = new System.Drawing.Point(253, 441);
            this.btnGuardarCompra.Name = "btnGuardarCompra";
            this.btnGuardarCompra.Size = new System.Drawing.Size(45, 39);
            this.btnGuardarCompra.TabIndex = 18;
            this.btnGuardarCompra.UseVisualStyleBackColor = true;
            this.btnGuardarCompra.Click += new System.EventHandler(this.btnGuardarCompra_Click);
            // 
            // lblprintdni
            // 
            this.lblprintdni.AutoSize = true;
            this.lblprintdni.Location = new System.Drawing.Point(384, 465);
            this.lblprintdni.Name = "lblprintdni";
            this.lblprintdni.Size = new System.Drawing.Size(94, 13);
            this.lblprintdni.TabIndex = 24;
            this.lblprintdni.Text = ".............................";
            this.lblprintdni.Visible = false;
            // 
            // lblfechacompra
            // 
            this.lblfechacompra.AutoSize = true;
            this.lblfechacompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfechacompra.Location = new System.Drawing.Point(384, 79);
            this.lblfechacompra.Name = "lblfechacompra";
            this.lblfechacompra.Size = new System.Drawing.Size(0, 16);
            this.lblfechacompra.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "ESTADO DE LA COMPRA:";
            // 
            // lblestado
            // 
            this.lblestado.AutoSize = true;
            this.lblestado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblestado.Location = new System.Drawing.Point(175, 143);
            this.lblestado.Name = "lblestado";
            this.lblestado.Size = new System.Drawing.Size(0, 13);
            this.lblestado.TabIndex = 27;
            // 
            // FrmGenerarCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 509);
            this.Controls.Add(this.lblfechacompra);
            this.Controls.Add(this.lblprintdni);
            this.Controls.Add(this.lblprintnombre);
            this.Controls.Add(this.lbltopimp);
            this.Controls.Add(this.lblimp);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnGuardarCompra);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmGenerarCompra";
            this.Text = "Generar Compra";
            this.Load += new System.EventHandler(this.FrmGenerarCompra_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdetallecompra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtseriecomp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnumcomp;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btnGuardarCompra;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtrucproven;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtnomapepro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtdniprovent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txttotpro;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvdetallecompra;
        private System.Windows.Forms.PrintPreviewDialog printDialogCompra;
        private System.Drawing.Printing.PrintDocument printDocumentCompra;
        private System.Windows.Forms.Label lblimp;
        private System.Windows.Forms.Label lbltopimp;
        private System.Windows.Forms.Label lblprintnombre;
        private System.Windows.Forms.Label lblprintdni;
        private System.Windows.Forms.Label lblfechacompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODPROD;
        private System.Windows.Forms.DataGridViewTextBoxColumn CANT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODTIPO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SUBTOTAL;
        private System.Windows.Forms.Label lblestado;
        private System.Windows.Forms.Label label6;
    }
}