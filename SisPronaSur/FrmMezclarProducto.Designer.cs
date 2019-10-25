namespace SisPronaSur
{
    partial class FrmMezclarProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMezclarProducto));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbprobase = new System.Windows.Forms.ComboBox();
            this.cmbtipoprobase = new System.Windows.Forms.ComboBox();
            this.txtcantprobase = new System.Windows.Forms.TextBox();
            this.txtcantproania = new System.Windows.Forms.TextBox();
            this.cmbtipoproania = new System.Windows.Forms.ComboBox();
            this.cmbproania = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.btnmezclar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnsalir = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txttotalmezcla = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtcantprobase);
            this.groupBox1.Controls.Add(this.cmbtipoprobase);
            this.groupBox1.Controls.Add(this.cmbprobase);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(23, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(516, 98);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Producto Base";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtcantproania);
            this.groupBox2.Controls.Add(this.cmbtipoproania);
            this.groupBox2.Controls.Add(this.cmbproania);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(23, 167);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(516, 97);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Producto Añadir";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo Producto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(382, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cantidad";
            // 
            // cmbprobase
            // 
            this.cmbprobase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbprobase.FormattingEnabled = true;
            this.cmbprobase.Location = new System.Drawing.Point(26, 59);
            this.cmbprobase.Name = "cmbprobase";
            this.cmbprobase.Size = new System.Drawing.Size(123, 21);
            this.cmbprobase.TabIndex = 4;
            this.cmbprobase.SelectedIndexChanged += new System.EventHandler(this.cmbprobase_SelectedIndexChanged);
            // 
            // cmbtipoprobase
            // 
            this.cmbtipoprobase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbtipoprobase.FormattingEnabled = true;
            this.cmbtipoprobase.Location = new System.Drawing.Point(205, 59);
            this.cmbtipoprobase.Name = "cmbtipoprobase";
            this.cmbtipoprobase.Size = new System.Drawing.Size(123, 21);
            this.cmbtipoprobase.TabIndex = 5;
            // 
            // txtcantprobase
            // 
            this.txtcantprobase.Enabled = false;
            this.txtcantprobase.Location = new System.Drawing.Point(385, 60);
            this.txtcantprobase.Name = "txtcantprobase";
            this.txtcantprobase.Size = new System.Drawing.Size(92, 20);
            this.txtcantprobase.TabIndex = 6;
            // 
            // txtcantproania
            // 
            this.txtcantproania.Enabled = false;
            this.txtcantproania.Location = new System.Drawing.Point(385, 57);
            this.txtcantproania.Name = "txtcantproania";
            this.txtcantproania.Size = new System.Drawing.Size(92, 20);
            this.txtcantproania.TabIndex = 12;
            // 
            // cmbtipoproania
            // 
            this.cmbtipoproania.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbtipoproania.FormattingEnabled = true;
            this.cmbtipoproania.Location = new System.Drawing.Point(205, 56);
            this.cmbtipoproania.Name = "cmbtipoproania";
            this.cmbtipoproania.Size = new System.Drawing.Size(123, 21);
            this.cmbtipoproania.TabIndex = 11;
            // 
            // cmbproania
            // 
            this.cmbproania.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbproania.FormattingEnabled = true;
            this.cmbproania.Location = new System.Drawing.Point(26, 56);
            this.cmbproania.Name = "cmbproania";
            this.cmbproania.Size = new System.Drawing.Size(123, 21);
            this.cmbproania.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(382, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Cantidad Añadir";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(202, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tipo Producto Añadir";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Producto Añadir";
            // 
            // btnnuevo
            // 
            this.btnnuevo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnnuevo.BackgroundImage")));
            this.btnnuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnnuevo.Location = new System.Drawing.Point(9, 20);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(41, 33);
            this.btnnuevo.TabIndex = 2;
            this.btnnuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnnuevo.UseVisualStyleBackColor = true;
            // 
            // btnmezclar
            // 
            this.btnmezclar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnmezclar.BackgroundImage")));
            this.btnmezclar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnmezclar.Location = new System.Drawing.Point(9, 89);
            this.btnmezclar.Name = "btnmezclar";
            this.btnmezclar.Size = new System.Drawing.Size(41, 33);
            this.btnmezclar.TabIndex = 3;
            this.btnmezclar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnmezclar.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnsalir);
            this.groupBox3.Controls.Add(this.btnnuevo);
            this.groupBox3.Controls.Add(this.btnmezclar);
            this.groupBox3.Location = new System.Drawing.Point(545, 63);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(61, 201);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            // 
            // btnsalir
            // 
            this.btnsalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnsalir.BackgroundImage")));
            this.btnsalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnsalir.Location = new System.Drawing.Point(9, 153);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(41, 33);
            this.btnsalir.TabIndex = 4;
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(462, 277);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "TOTAL";
            // 
            // txttotalmezcla
            // 
            this.txttotalmezcla.Enabled = false;
            this.txttotalmezcla.Location = new System.Drawing.Point(510, 274);
            this.txttotalmezcla.Name = "txttotalmezcla";
            this.txttotalmezcla.Size = new System.Drawing.Size(97, 20);
            this.txttotalmezcla.TabIndex = 6;
            // 
            // FrmMezclarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 319);
            this.Controls.Add(this.txttotalmezcla);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmMezclarProducto";
            this.Text = "Mezclar Producto";
            this.Load += new System.EventHandler(this.FrmMezclarProducto_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcantprobase;
        private System.Windows.Forms.ComboBox cmbtipoprobase;
        private System.Windows.Forms.ComboBox cmbprobase;
        private System.Windows.Forms.TextBox txtcantproania;
        private System.Windows.Forms.ComboBox cmbtipoproania;
        private System.Windows.Forms.ComboBox cmbproania;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.Button btnmezclar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txttotalmezcla;
    }
}