namespace SisPronaSur.Mantenimiento
{
    partial class FrmManPersonal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmManPersonal));
            this.dgvpersonal = new System.Windows.Forms.DataGridView();
            this.Id_Anno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion_Anno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.APELLIDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIRECCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TELEFONO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CORREO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.USUARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CONTRASEÑA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PUESTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SUCURSAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GBOpciones = new System.Windows.Forms.GroupBox();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.btnregistrar = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Cargo = new System.Windows.Forms.Label();
            this.cmbcargoper = new System.Windows.Forms.ComboBox();
            this.cmbsucursal = new System.Windows.Forms.ComboBox();
            this.txtnomper = new System.Windows.Forms.TextBox();
            this.txtapeper = new System.Windows.Forms.TextBox();
            this.txtdirper = new System.Windows.Forms.TextBox();
            this.txttelper = new System.Windows.Forms.TextBox();
            this.txtdniper = new System.Windows.Forms.TextBox();
            this.txtemailper = new System.Windows.Forms.TextBox();
            this.txtnomusuarioper = new System.Windows.Forms.TextBox();
            this.txtpassper = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvpersonal)).BeginInit();
            this.GBOpciones.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvpersonal
            // 
            this.dgvpersonal.AllowUserToAddRows = false;
            this.dgvpersonal.AllowUserToDeleteRows = false;
            this.dgvpersonal.AllowUserToResizeColumns = false;
            this.dgvpersonal.AllowUserToResizeRows = false;
            this.dgvpersonal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvpersonal.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvpersonal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvpersonal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvpersonal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Anno,
            this.Descripcion_Anno,
            this.APELLIDO,
            this.DIRECCION,
            this.TELEFONO,
            this.DNI,
            this.CORREO,
            this.USUARIO,
            this.CONTRASEÑA,
            this.PUESTO,
            this.SUCURSAL});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvpersonal.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvpersonal.GridColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgvpersonal.Location = new System.Drawing.Point(7, 60);
            this.dgvpersonal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvpersonal.Name = "dgvpersonal";
            this.dgvpersonal.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvpersonal.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvpersonal.RowHeadersVisible = false;
            this.dgvpersonal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvpersonal.Size = new System.Drawing.Size(730, 228);
            this.dgvpersonal.TabIndex = 103;
            this.dgvpersonal.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvpersonal_CellContentClick);
            this.dgvpersonal.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvpersonal_CellDoubleClick);
            this.dgvpersonal.SelectionChanged += new System.EventHandler(this.dgvpersonal_SelectionChanged);
            // 
            // Id_Anno
            // 
            this.Id_Anno.DataPropertyName = "CodPersonal";
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
            this.Descripcion_Anno.DataPropertyName = "nomPersonal";
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Descripcion_Anno.DefaultCellStyle = dataGridViewCellStyle3;
            this.Descripcion_Anno.HeaderText = "NOMBRE";
            this.Descripcion_Anno.Name = "Descripcion_Anno";
            this.Descripcion_Anno.ReadOnly = true;
            // 
            // APELLIDO
            // 
            this.APELLIDO.DataPropertyName = "apePersonal";
            this.APELLIDO.HeaderText = "APELLIDO";
            this.APELLIDO.Name = "APELLIDO";
            this.APELLIDO.ReadOnly = true;
            // 
            // DIRECCION
            // 
            this.DIRECCION.DataPropertyName = "dirPersonal";
            this.DIRECCION.HeaderText = "DIRECCION";
            this.DIRECCION.Name = "DIRECCION";
            this.DIRECCION.ReadOnly = true;
            // 
            // TELEFONO
            // 
            this.TELEFONO.DataPropertyName = "telPersonal";
            this.TELEFONO.HeaderText = "TELEFONO";
            this.TELEFONO.Name = "TELEFONO";
            this.TELEFONO.ReadOnly = true;
            // 
            // DNI
            // 
            this.DNI.DataPropertyName = "dniPersonal";
            this.DNI.HeaderText = "DNI";
            this.DNI.Name = "DNI";
            this.DNI.ReadOnly = true;
            // 
            // CORREO
            // 
            this.CORREO.DataPropertyName = "emailPersonal";
            this.CORREO.HeaderText = "CORREO";
            this.CORREO.Name = "CORREO";
            this.CORREO.ReadOnly = true;
            // 
            // USUARIO
            // 
            this.USUARIO.DataPropertyName = "nomUsuarioPersonal";
            this.USUARIO.HeaderText = "USUARIO";
            this.USUARIO.Name = "USUARIO";
            this.USUARIO.ReadOnly = true;
            // 
            // CONTRASEÑA
            // 
            this.CONTRASEÑA.DataPropertyName = "passPersonal";
            this.CONTRASEÑA.HeaderText = "CONTRASEÑA";
            this.CONTRASEÑA.Name = "CONTRASEÑA";
            this.CONTRASEÑA.ReadOnly = true;
            // 
            // PUESTO
            // 
            this.PUESTO.DataPropertyName = "desCargo";
            this.PUESTO.HeaderText = "PUESTO";
            this.PUESTO.Name = "PUESTO";
            this.PUESTO.ReadOnly = true;
            // 
            // SUCURSAL
            // 
            this.SUCURSAL.DataPropertyName = "nomSucursal";
            this.SUCURSAL.HeaderText = "SUCURSAL";
            this.SUCURSAL.Name = "SUCURSAL";
            this.SUCURSAL.ReadOnly = true;
            // 
            // GBOpciones
            // 
            this.GBOpciones.BackColor = System.Drawing.Color.Transparent;
            this.GBOpciones.Controls.Add(this.btncancelar);
            this.GBOpciones.Controls.Add(this.btnsalir);
            this.GBOpciones.Controls.Add(this.btnregistrar);
            this.GBOpciones.Controls.Add(this.btnnuevo);
            this.GBOpciones.Location = new System.Drawing.Point(411, 129);
            this.GBOpciones.Name = "GBOpciones";
            this.GBOpciones.Size = new System.Drawing.Size(283, 141);
            this.GBOpciones.TabIndex = 145;
            this.GBOpciones.TabStop = false;
            // 
            // btncancelar
            // 
            this.btncancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btncancelar.BackgroundImage")));
            this.btncancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncancelar.Enabled = false;
            this.btncancelar.Location = new System.Drawing.Point(150, 48);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(50, 39);
            this.btncancelar.TabIndex = 4;
            this.btncancelar.UseVisualStyleBackColor = true;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnsalir.BackgroundImage")));
            this.btnsalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnsalir.Location = new System.Drawing.Point(206, 48);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(50, 39);
            this.btnsalir.TabIndex = 3;
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btnregistrar
            // 
            this.btnregistrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnregistrar.BackgroundImage")));
            this.btnregistrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnregistrar.Enabled = false;
            this.btnregistrar.Location = new System.Drawing.Point(94, 48);
            this.btnregistrar.Name = "btnregistrar";
            this.btnregistrar.Size = new System.Drawing.Size(50, 39);
            this.btnregistrar.TabIndex = 1;
            this.btnregistrar.UseVisualStyleBackColor = true;
            this.btnregistrar.Click += new System.EventHandler(this.btnregistrar_Click);
            // 
            // btnnuevo
            // 
            this.btnnuevo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnnuevo.BackgroundImage")));
            this.btnnuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnnuevo.Location = new System.Drawing.Point(36, 48);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(50, 39);
            this.btnnuevo.TabIndex = 0;
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 146;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 147;
            this.label2.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 148;
            this.label3.Text = "Direccion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 149;
            this.label4.Text = "Telefono";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(205, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 150;
            this.label5.Text = "Dni";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 151;
            this.label6.Text = "Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 152;
            this.label7.Text = "Contraseña";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 13);
            this.label8.TabIndex = 153;
            this.label8.Text = "Nombre Usuario";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(205, 206);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 154;
            this.label9.Text = "Sucursal";
            // 
            // Cargo
            // 
            this.Cargo.AutoSize = true;
            this.Cargo.Location = new System.Drawing.Point(6, 206);
            this.Cargo.Name = "Cargo";
            this.Cargo.Size = new System.Drawing.Size(35, 13);
            this.Cargo.TabIndex = 155;
            this.Cargo.Text = "Cargo";
            // 
            // cmbcargoper
            // 
            this.cmbcargoper.FormattingEnabled = true;
            this.cmbcargoper.Location = new System.Drawing.Point(63, 203);
            this.cmbcargoper.Name = "cmbcargoper";
            this.cmbcargoper.Size = new System.Drawing.Size(121, 21);
            this.cmbcargoper.TabIndex = 156;
            // 
            // cmbsucursal
            // 
            this.cmbsucursal.FormattingEnabled = true;
            this.cmbsucursal.Location = new System.Drawing.Point(259, 203);
            this.cmbsucursal.Name = "cmbsucursal";
            this.cmbsucursal.Size = new System.Drawing.Size(121, 21);
            this.cmbsucursal.TabIndex = 157;
            // 
            // txtnomper
            // 
            this.txtnomper.Location = new System.Drawing.Point(64, 26);
            this.txtnomper.Name = "txtnomper";
            this.txtnomper.Size = new System.Drawing.Size(178, 20);
            this.txtnomper.TabIndex = 158;
            this.txtnomper.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnomper_KeyPress);
            // 
            // txtapeper
            // 
            this.txtapeper.Location = new System.Drawing.Point(64, 66);
            this.txtapeper.Name = "txtapeper";
            this.txtapeper.Size = new System.Drawing.Size(178, 20);
            this.txtapeper.TabIndex = 159;
            this.txtapeper.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtapeper_KeyPress);
            // 
            // txtdirper
            // 
            this.txtdirper.Location = new System.Drawing.Point(64, 102);
            this.txtdirper.Name = "txtdirper";
            this.txtdirper.Size = new System.Drawing.Size(260, 20);
            this.txtdirper.TabIndex = 160;
            // 
            // txttelper
            // 
            this.txttelper.Location = new System.Drawing.Point(64, 137);
            this.txttelper.Name = "txttelper";
            this.txttelper.Size = new System.Drawing.Size(90, 20);
            this.txttelper.TabIndex = 161;
            this.txttelper.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttelper_KeyPress);
            this.txttelper.Validating += new System.ComponentModel.CancelEventHandler(this.txttelper_Validating);
            // 
            // txtdniper
            // 
            this.txtdniper.Location = new System.Drawing.Point(234, 137);
            this.txtdniper.Name = "txtdniper";
            this.txtdniper.Size = new System.Drawing.Size(90, 20);
            this.txtdniper.TabIndex = 162;
            this.txtdniper.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdniper_KeyPress);
            this.txtdniper.Validating += new System.ComponentModel.CancelEventHandler(this.txtdniper_Validating);
            // 
            // txtemailper
            // 
            this.txtemailper.Location = new System.Drawing.Point(64, 173);
            this.txtemailper.Name = "txtemailper";
            this.txtemailper.Size = new System.Drawing.Size(178, 20);
            this.txtemailper.TabIndex = 163;
            this.txtemailper.Validating += new System.ComponentModel.CancelEventHandler(this.txtemailper_Validating);
            // 
            // txtnomusuarioper
            // 
            this.txtnomusuarioper.Location = new System.Drawing.Point(105, 29);
            this.txtnomusuarioper.Name = "txtnomusuarioper";
            this.txtnomusuarioper.Size = new System.Drawing.Size(164, 20);
            this.txtnomusuarioper.TabIndex = 164;
            // 
            // txtpassper
            // 
            this.txtpassper.Location = new System.Drawing.Point(105, 65);
            this.txtpassper.Name = "txtpassper";
            this.txtpassper.PasswordChar = '•';
            this.txtpassper.Size = new System.Drawing.Size(164, 20);
            this.txtpassper.TabIndex = 165;
            this.txtpassper.Validating += new System.ComponentModel.CancelEventHandler(this.txtpassper_Validating);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbsucursal);
            this.groupBox1.Controls.Add(this.cmbcargoper);
            this.groupBox1.Controls.Add(this.txtemailper);
            this.groupBox1.Controls.Add(this.Cargo);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtdniper);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txttelper);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtdirper);
            this.groupBox1.Controls.Add(this.txtapeper);
            this.groupBox1.Controls.Add(this.txtnomper);
            this.groupBox1.Location = new System.Drawing.Point(15, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(390, 247);
            this.groupBox1.TabIndex = 166;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Personal";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtpassper);
            this.groupBox2.Controls.Add(this.txtnomusuarioper);
            this.groupBox2.Location = new System.Drawing.Point(411, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(292, 100);
            this.groupBox2.TabIndex = 167;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Usuario";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(24, 63);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(752, 320);
            this.tabControl1.TabIndex = 168;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.GBOpciones);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(744, 294);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Personal";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtbuscar);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.dgvpersonal);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(744, 294);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consulta";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(52, 19);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(228, 20);
            this.txtbuscar.TabIndex = 105;
            this.txtbuscar.TextChanged += new System.EventHandler(this.txtbuscar_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 104;
            this.label10.Text = "Buscar";
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // FrmManPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 408);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmManPersonal";
            this.Text = "Mantenimiento Personal";
            this.Load += new System.EventHandler(this.FrmManPersonal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvpersonal)).EndInit();
            this.GBOpciones.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.DataGridView dgvpersonal;
        internal System.Windows.Forms.GroupBox GBOpciones;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btnregistrar;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label Cargo;
        private System.Windows.Forms.ComboBox cmbcargoper;
        private System.Windows.Forms.ComboBox cmbsucursal;
        private System.Windows.Forms.TextBox txtnomper;
        private System.Windows.Forms.TextBox txtapeper;
        private System.Windows.Forms.TextBox txtdirper;
        private System.Windows.Forms.TextBox txttelper;
        private System.Windows.Forms.TextBox txtdniper;
        private System.Windows.Forms.TextBox txtemailper;
        private System.Windows.Forms.TextBox txtnomusuarioper;
        private System.Windows.Forms.TextBox txtpassper;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ErrorProvider err;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Anno;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion_Anno;
        private System.Windows.Forms.DataGridViewTextBoxColumn APELLIDO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIRECCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn TELEFONO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn CORREO;
        private System.Windows.Forms.DataGridViewTextBoxColumn USUARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CONTRASEÑA;
        private System.Windows.Forms.DataGridViewTextBoxColumn PUESTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn SUCURSAL;
    }
}