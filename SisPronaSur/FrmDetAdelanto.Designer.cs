namespace SisPronaSur
{
    partial class FrmDetAdelanto
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
            this.gpdatosadelanto = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnomape = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtfechinicio = new System.Windows.Forms.TextBox();
            this.txtfechfin = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtmontoinicial = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgprestamo = new System.Windows.Forms.DataGridView();
            this.cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montopre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechpre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montintere = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRODUCTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPOPRODUCTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtsaldo = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbproducto = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbtipoproducto = new System.Windows.Forms.ComboBox();
            this.gpdatosadelanto.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgprestamo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpdatosadelanto
            // 
            this.gpdatosadelanto.Controls.Add(this.groupBox3);
            this.gpdatosadelanto.Controls.Add(this.groupBox2);
            this.gpdatosadelanto.Location = new System.Drawing.Point(23, 63);
            this.gpdatosadelanto.Name = "gpdatosadelanto";
            this.gpdatosadelanto.Size = new System.Drawing.Size(579, 148);
            this.gpdatosadelanto.TabIndex = 0;
            this.gpdatosadelanto.TabStop = false;
            this.gpdatosadelanto.Text = "Datos Adelanto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre y Apellido";
            // 
            // txtnomape
            // 
            this.txtnomape.Enabled = false;
            this.txtnomape.Location = new System.Drawing.Point(119, 22);
            this.txtnomape.Name = "txtnomape";
            this.txtnomape.Size = new System.Drawing.Size(242, 20);
            this.txtnomape.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha Inicio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fecha Fin";
            // 
            // txtfechinicio
            // 
            this.txtfechinicio.Enabled = false;
            this.txtfechinicio.Location = new System.Drawing.Point(119, 61);
            this.txtfechinicio.Name = "txtfechinicio";
            this.txtfechinicio.Size = new System.Drawing.Size(145, 20);
            this.txtfechinicio.TabIndex = 4;
            // 
            // txtfechfin
            // 
            this.txtfechfin.Enabled = false;
            this.txtfechfin.Location = new System.Drawing.Point(119, 96);
            this.txtfechfin.Name = "txtfechfin";
            this.txtfechfin.Size = new System.Drawing.Size(145, 20);
            this.txtfechfin.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtfechfin);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtfechinicio);
            this.groupBox2.Controls.Add(this.txtnomape);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(6, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(379, 129);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtsaldo);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtmontoinicial);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(391, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(182, 129);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Monto Inicial";
            // 
            // txtmontoinicial
            // 
            this.txtmontoinicial.Enabled = false;
            this.txtmontoinicial.Location = new System.Drawing.Point(83, 22);
            this.txtmontoinicial.Name = "txtmontoinicial";
            this.txtmontoinicial.Size = new System.Drawing.Size(90, 20);
            this.txtmontoinicial.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Saldo";
            // 
            // dgprestamo
            // 
            this.dgprestamo.AllowUserToAddRows = false;
            this.dgprestamo.AllowUserToDeleteRows = false;
            this.dgprestamo.AllowUserToResizeColumns = false;
            this.dgprestamo.AllowUserToResizeRows = false;
            this.dgprestamo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgprestamo.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgprestamo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgprestamo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgprestamo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cod,
            this.montopre,
            this.fechpre,
            this.montintere,
            this.SAL,
            this.PRODUCTO,
            this.TIPOPRODUCTO});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgprestamo.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgprestamo.GridColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgprestamo.Location = new System.Drawing.Point(23, 333);
            this.dgprestamo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgprestamo.Name = "dgprestamo";
            this.dgprestamo.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgprestamo.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgprestamo.RowHeadersVisible = false;
            this.dgprestamo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgprestamo.Size = new System.Drawing.Size(579, 201);
            this.dgprestamo.TabIndex = 104;
            // 
            // cod
            // 
            this.cod.DataPropertyName = "codDetPrestamo";
            this.cod.HeaderText = "CODIGO";
            this.cod.Name = "cod";
            this.cod.ReadOnly = true;
            // 
            // montopre
            // 
            this.montopre.DataPropertyName = "montDetPrestamo";
            this.montopre.HeaderText = "MONTO";
            this.montopre.Name = "montopre";
            this.montopre.ReadOnly = true;
            // 
            // fechpre
            // 
            this.fechpre.DataPropertyName = "fechDetPrestamo";
            this.fechpre.HeaderText = "FECHA";
            this.fechpre.Name = "fechpre";
            this.fechpre.ReadOnly = true;
            // 
            // montintere
            // 
            this.montintere.DataPropertyName = "montDetInteres";
            this.montintere.HeaderText = "CANT. PRODUCTO";
            this.montintere.Name = "montintere";
            this.montintere.ReadOnly = true;
            // 
            // SAL
            // 
            this.SAL.DataPropertyName = "SaldoDetPrestamo";
            this.SAL.HeaderText = "SALDO";
            this.SAL.Name = "SAL";
            this.SAL.ReadOnly = true;
            // 
            // PRODUCTO
            // 
            this.PRODUCTO.HeaderText = "PRODUCTO";
            this.PRODUCTO.Name = "PRODUCTO";
            this.PRODUCTO.ReadOnly = true;
            // 
            // TIPOPRODUCTO
            // 
            this.TIPOPRODUCTO.HeaderText = "TIPO PRODUCTO";
            this.TIPOPRODUCTO.Name = "TIPOPRODUCTO";
            this.TIPOPRODUCTO.ReadOnly = true;
            // 
            // txtsaldo
            // 
            this.txtsaldo.Enabled = false;
            this.txtsaldo.Location = new System.Drawing.Point(83, 92);
            this.txtsaldo.Name = "txtsaldo";
            this.txtsaldo.Size = new System.Drawing.Size(90, 20);
            this.txtsaldo.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbtipoproducto);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cmbproducto);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(23, 217);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(579, 110);
            this.groupBox1.TabIndex = 105;
            this.groupBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Producto";
            // 
            // cmbproducto
            // 
            this.cmbproducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbproducto.FormattingEnabled = true;
            this.cmbproducto.Location = new System.Drawing.Point(106, 27);
            this.cmbproducto.Name = "cmbproducto";
            this.cmbproducto.Size = new System.Drawing.Size(121, 21);
            this.cmbproducto.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Tipo Producto";
            // 
            // cmbtipoproducto
            // 
            this.cmbtipoproducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbtipoproducto.FormattingEnabled = true;
            this.cmbtipoproducto.Location = new System.Drawing.Point(106, 73);
            this.cmbtipoproducto.Name = "cmbtipoproducto";
            this.cmbtipoproducto.Size = new System.Drawing.Size(121, 21);
            this.cmbtipoproducto.TabIndex = 3;
            // 
            // FrmDetAdelanto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 557);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgprestamo);
            this.Controls.Add(this.gpdatosadelanto);
            this.Name = "FrmDetAdelanto";
            this.Text = "Detalle Adelanto";
            this.Load += new System.EventHandler(this.FrmDetAdelanto_Load);
            this.gpdatosadelanto.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgprestamo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpdatosadelanto;
        private System.Windows.Forms.TextBox txtnomape;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtfechfin;
        private System.Windows.Forms.TextBox txtfechinicio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtmontoinicial;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        internal System.Windows.Forms.DataGridView dgprestamo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn montopre;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechpre;
        private System.Windows.Forms.DataGridViewTextBoxColumn montintere;
        private System.Windows.Forms.DataGridViewTextBoxColumn SAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRODUCTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPOPRODUCTO;
        private System.Windows.Forms.TextBox txtsaldo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbproducto;
        private System.Windows.Forms.ComboBox cmbtipoproducto;
        private System.Windows.Forms.Label label7;
    }
}