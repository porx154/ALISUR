namespace SisPronaSur.Consulta
{
    partial class FrmConProveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConProveedor));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.mtbtnsalir = new MetroFramework.Controls.MetroButton();
            this.mttxtbuscar = new MetroFramework.Controls.MetroTextBox();
            this.mtdgproveedor = new MetroFramework.Controls.MetroGrid();
            this.Cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ape = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ru = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mtdgproveedor)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mtbtnsalir);
            this.groupBox1.Controls.Add(this.mttxtbuscar);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Location = new System.Drawing.Point(26, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(607, 54);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(15, 20);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(47, 19);
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "Buscar";
            // 
            // mtbtnsalir
            // 
            this.mtbtnsalir.Location = new System.Drawing.Point(526, 19);
            this.mtbtnsalir.Name = "mtbtnsalir";
            this.mtbtnsalir.Size = new System.Drawing.Size(75, 23);
            this.mtbtnsalir.TabIndex = 6;
            this.mtbtnsalir.Text = "Salir";
            this.mtbtnsalir.UseSelectable = true;
            this.mtbtnsalir.Click += new System.EventHandler(this.mtbtnsalir_Click);
            // 
            // mttxtbuscar
            // 
            // 
            // 
            // 
            this.mttxtbuscar.CustomButton.Image = null;
            this.mttxtbuscar.CustomButton.Location = new System.Drawing.Point(193, 1);
            this.mttxtbuscar.CustomButton.Name = "";
            this.mttxtbuscar.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mttxtbuscar.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mttxtbuscar.CustomButton.TabIndex = 1;
            this.mttxtbuscar.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mttxtbuscar.CustomButton.UseSelectable = true;
            this.mttxtbuscar.CustomButton.Visible = false;
            this.mttxtbuscar.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.mttxtbuscar.Lines = new string[0];
            this.mttxtbuscar.Location = new System.Drawing.Point(79, 19);
            this.mttxtbuscar.MaxLength = 32767;
            this.mttxtbuscar.Name = "mttxtbuscar";
            this.mttxtbuscar.PasswordChar = '\0';
            this.mttxtbuscar.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mttxtbuscar.SelectedText = "";
            this.mttxtbuscar.SelectionLength = 0;
            this.mttxtbuscar.SelectionStart = 0;
            this.mttxtbuscar.ShortcutsEnabled = true;
            this.mttxtbuscar.Size = new System.Drawing.Size(215, 23);
            this.mttxtbuscar.TabIndex = 5;
            this.mttxtbuscar.UseSelectable = true;
            this.mttxtbuscar.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mttxtbuscar.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.mttxtbuscar.TextChanged += new System.EventHandler(this.mttxtbuscar_TextChanged);
            // 
            // mtdgproveedor
            // 
            this.mtdgproveedor.AllowUserToAddRows = false;
            this.mtdgproveedor.AllowUserToDeleteRows = false;
            this.mtdgproveedor.AllowUserToResizeColumns = false;
            this.mtdgproveedor.AllowUserToResizeRows = false;
            this.mtdgproveedor.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mtdgproveedor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtdgproveedor.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mtdgproveedor.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mtdgproveedor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.mtdgproveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mtdgproveedor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cod,
            this.Nom,
            this.Ape,
            this.Dn,
            this.Tel,
            this.Ru,
            this.Dir});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mtdgproveedor.DefaultCellStyle = dataGridViewCellStyle2;
            this.mtdgproveedor.EnableHeadersVisualStyles = false;
            this.mtdgproveedor.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mtdgproveedor.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mtdgproveedor.Location = new System.Drawing.Point(26, 113);
            this.mtdgproveedor.Name = "mtdgproveedor";
            this.mtdgproveedor.ReadOnly = true;
            this.mtdgproveedor.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mtdgproveedor.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.mtdgproveedor.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mtdgproveedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mtdgproveedor.Size = new System.Drawing.Size(607, 228);
            this.mtdgproveedor.Style = MetroFramework.MetroColorStyle.Green;
            this.mtdgproveedor.TabIndex = 6;
            this.mtdgproveedor.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtdgproveedor.DoubleClick += new System.EventHandler(this.mtdgproveedor_DoubleClick);
            // 
            // Cod
            // 
            this.Cod.DataPropertyName = "CodProveedor";
            this.Cod.HeaderText = "CODIGO";
            this.Cod.Name = "Cod";
            this.Cod.ReadOnly = true;
            // 
            // Nom
            // 
            this.Nom.DataPropertyName = "nomProveedor";
            this.Nom.HeaderText = "NOMBRE";
            this.Nom.Name = "Nom";
            this.Nom.ReadOnly = true;
            // 
            // Ape
            // 
            this.Ape.DataPropertyName = "apeProveedor";
            this.Ape.HeaderText = "APELLIDO";
            this.Ape.Name = "Ape";
            this.Ape.ReadOnly = true;
            // 
            // Dn
            // 
            this.Dn.DataPropertyName = "dniProveedor";
            this.Dn.HeaderText = "DNI";
            this.Dn.Name = "Dn";
            this.Dn.ReadOnly = true;
            // 
            // Tel
            // 
            this.Tel.DataPropertyName = "telProveedor";
            this.Tel.HeaderText = "TELEFONO";
            this.Tel.Name = "Tel";
            this.Tel.ReadOnly = true;
            // 
            // Ru
            // 
            this.Ru.DataPropertyName = "rucProveedor";
            this.Ru.HeaderText = "RUC";
            this.Ru.Name = "Ru";
            this.Ru.ReadOnly = true;
            // 
            // Dir
            // 
            this.Dir.DataPropertyName = "dirProveedor";
            this.Dir.HeaderText = "DIRECCION";
            this.Dir.Name = "Dir";
            this.Dir.ReadOnly = true;
            // 
            // FrmConProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 364);
            this.Controls.Add(this.mtdgproveedor);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmConProveedor";
            this.Text = "Consulta Proveedor";
            this.Load += new System.EventHandler(this.FrmConProveedor_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mtdgproveedor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton mtbtnsalir;
        private MetroFramework.Controls.MetroTextBox mttxtbuscar;
        private MetroFramework.Controls.MetroGrid mtdgproveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ape;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ru;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dir;
    }
}