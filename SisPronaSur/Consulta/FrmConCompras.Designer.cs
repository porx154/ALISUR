namespace SisPronaSur.Consulta
{
    partial class FrmConCompras
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConCompras));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mtdtfecha = new MetroFramework.Controls.MetroDateTime();
            this.mtcmbsucursal = new MetroFramework.Controls.MetroComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.mtdgcompra = new MetroFramework.Controls.MetroGrid();
            this.mtdgdetcompra = new MetroFramework.Controls.MetroGrid();
            this.Cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ru = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.mttxttotcompra = new MetroFramework.Controls.MetroTextBox();
            this.mtbtnbuscar = new MetroFramework.Controls.MetroTile();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mtdgcompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mtdgdetcompra)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(6, 21);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(43, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Fecha";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(278, 21);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(56, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Sucursal";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mtbtnbuscar);
            this.groupBox1.Controls.Add(this.mtdtfecha);
            this.groupBox1.Controls.Add(this.mtcmbsucursal);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Location = new System.Drawing.Point(23, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(646, 54);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // mtdtfecha
            // 
            this.mtdtfecha.Location = new System.Drawing.Point(55, 15);
            this.mtdtfecha.MinimumSize = new System.Drawing.Size(0, 29);
            this.mtdtfecha.Name = "mtdtfecha";
            this.mtdtfecha.Size = new System.Drawing.Size(200, 29);
            this.mtdtfecha.TabIndex = 3;
            // 
            // mtcmbsucursal
            // 
            this.mtcmbsucursal.FormattingEnabled = true;
            this.mtcmbsucursal.ItemHeight = 23;
            this.mtcmbsucursal.Location = new System.Drawing.Point(340, 15);
            this.mtcmbsucursal.Name = "mtcmbsucursal";
            this.mtcmbsucursal.Size = new System.Drawing.Size(163, 29);
            this.mtcmbsucursal.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtcmbsucursal.TabIndex = 2;
            this.mtcmbsucursal.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtcmbsucursal.UseSelectable = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.mtdgcompra);
            this.groupBox2.Location = new System.Drawing.Point(23, 141);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(646, 200);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.mtdgdetcompra);
            this.groupBox3.Location = new System.Drawing.Point(23, 358);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(646, 217);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            // 
            // mtdgcompra
            // 
            this.mtdgcompra.AllowUserToAddRows = false;
            this.mtdgcompra.AllowUserToDeleteRows = false;
            this.mtdgcompra.AllowUserToResizeColumns = false;
            this.mtdgcompra.AllowUserToResizeRows = false;
            this.mtdgcompra.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mtdgcompra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtdgcompra.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mtdgcompra.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mtdgcompra.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.mtdgcompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mtdgcompra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cod,
            this.Nom,
            this.Ru,
            this.Tipo});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mtdgcompra.DefaultCellStyle = dataGridViewCellStyle2;
            this.mtdgcompra.EnableHeadersVisualStyles = false;
            this.mtdgcompra.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mtdgcompra.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mtdgcompra.Location = new System.Drawing.Point(6, 19);
            this.mtdgcompra.Name = "mtdgcompra";
            this.mtdgcompra.ReadOnly = true;
            this.mtdgcompra.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mtdgcompra.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.mtdgcompra.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mtdgcompra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mtdgcompra.Size = new System.Drawing.Size(634, 175);
            this.mtdgcompra.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtdgcompra.TabIndex = 6;
            this.mtdgcompra.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mtdgcompra_CellDoubleClick);
            // 
            // mtdgdetcompra
            // 
            this.mtdgdetcompra.AllowUserToAddRows = false;
            this.mtdgdetcompra.AllowUserToDeleteRows = false;
            this.mtdgdetcompra.AllowUserToResizeColumns = false;
            this.mtdgdetcompra.AllowUserToResizeRows = false;
            this.mtdgdetcompra.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mtdgdetcompra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtdgdetcompra.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mtdgdetcompra.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mtdgdetcompra.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.mtdgdetcompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mtdgdetcompra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mtdgdetcompra.DefaultCellStyle = dataGridViewCellStyle5;
            this.mtdgdetcompra.EnableHeadersVisualStyles = false;
            this.mtdgdetcompra.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mtdgdetcompra.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mtdgdetcompra.Location = new System.Drawing.Point(6, 19);
            this.mtdgdetcompra.Name = "mtdgdetcompra";
            this.mtdgdetcompra.ReadOnly = true;
            this.mtdgdetcompra.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mtdgdetcompra.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.mtdgdetcompra.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mtdgdetcompra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mtdgdetcompra.Size = new System.Drawing.Size(634, 192);
            this.mtdgdetcompra.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtdgdetcompra.TabIndex = 7;
            // 
            // Cod
            // 
            this.Cod.DataPropertyName = "CodCompra";
            this.Cod.HeaderText = "Codigo";
            this.Cod.Name = "Cod";
            this.Cod.ReadOnly = true;
            // 
            // Nom
            // 
            this.Nom.DataPropertyName = "FechaCompra";
            this.Nom.HeaderText = "Fecha";
            this.Nom.Name = "Nom";
            this.Nom.ReadOnly = true;
            // 
            // Ru
            // 
            this.Ru.DataPropertyName = "nomProveedor";
            this.Ru.HeaderText = "Nombre Proveedor";
            this.Ru.Name = "Ru";
            this.Ru.ReadOnly = true;
            // 
            // Tipo
            // 
            this.Tipo.DataPropertyName = "nomUsuarioPersonal";
            this.Tipo.HeaderText = "Usuario";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "pesoDetCompra";
            this.dataGridViewTextBoxColumn1.HeaderText = "Peso";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "descripcion";
            this.dataGridViewTextBoxColumn2.HeaderText = "Descripcion";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "preDetCompra";
            this.dataGridViewTextBoxColumn3.HeaderText = "Precio Unitario";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(504, 598);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(55, 19);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "Total S/.";
            // 
            // mttxttotcompra
            // 
            // 
            // 
            // 
            this.mttxttotcompra.CustomButton.Image = null;
            this.mttxttotcompra.CustomButton.Location = new System.Drawing.Point(76, 1);
            this.mttxttotcompra.CustomButton.Name = "";
            this.mttxttotcompra.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mttxttotcompra.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mttxttotcompra.CustomButton.TabIndex = 1;
            this.mttxttotcompra.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mttxttotcompra.CustomButton.UseSelectable = true;
            this.mttxttotcompra.CustomButton.Visible = false;
            this.mttxttotcompra.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.mttxttotcompra.Lines = new string[0];
            this.mttxttotcompra.Location = new System.Drawing.Point(565, 596);
            this.mttxttotcompra.MaxLength = 32767;
            this.mttxttotcompra.Name = "mttxttotcompra";
            this.mttxttotcompra.PasswordChar = '\0';
            this.mttxttotcompra.ReadOnly = true;
            this.mttxttotcompra.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mttxttotcompra.SelectedText = "";
            this.mttxttotcompra.SelectionLength = 0;
            this.mttxttotcompra.SelectionStart = 0;
            this.mttxttotcompra.ShortcutsEnabled = true;
            this.mttxttotcompra.Size = new System.Drawing.Size(98, 23);
            this.mttxttotcompra.TabIndex = 6;
            this.mttxttotcompra.UseSelectable = true;
            this.mttxttotcompra.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mttxttotcompra.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtbtnbuscar
            // 
            this.mtbtnbuscar.ActiveControl = null;
            this.mtbtnbuscar.Location = new System.Drawing.Point(529, 15);
            this.mtbtnbuscar.Name = "mtbtnbuscar";
            this.mtbtnbuscar.Size = new System.Drawing.Size(49, 29);
            this.mtbtnbuscar.TabIndex = 4;
            this.mtbtnbuscar.TileImage = ((System.Drawing.Image)(resources.GetObject("mtbtnbuscar.TileImage")));
            this.mtbtnbuscar.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtbtnbuscar.UseSelectable = true;
            this.mtbtnbuscar.UseTileImage = true;
            this.mtbtnbuscar.Click += new System.EventHandler(this.mtbtnbuscar_Click);
            // 
            // FrmConCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 648);
            this.Controls.Add(this.mttxttotcompra);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmConCompras";
            this.Text = "Consulta Compras";
            this.Load += new System.EventHandler(this.FrmConVentas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mtdgcompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mtdgdetcompra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroComboBox mtcmbsucursal;
        private MetroFramework.Controls.MetroDateTime mtdtfecha;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private MetroFramework.Controls.MetroGrid mtdgcompra;
        private MetroFramework.Controls.MetroGrid mtdgdetcompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ru;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox mttxttotcompra;
        private MetroFramework.Controls.MetroTile mtbtnbuscar;
    }
}