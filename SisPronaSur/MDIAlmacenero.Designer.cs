namespace SisPronaSur
{
    partial class MDIAlmacenero
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDIAlmacenero));
            this.tmrmenu = new System.Windows.Forms.Timer(this.components);
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsshora = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssfecha = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssnomusuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.ToolStrip1.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmrmenu
            // 
            this.tmrmenu.Enabled = true;
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(61, 59);
            this.toolStripButton4.Text = "Sarandear";
            this.toolStripButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // ToolStripButton5
            // 
            this.ToolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButton5.Image")));
            this.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButton5.Name = "ToolStripButton5";
            this.ToolStripButton5.Size = new System.Drawing.Size(61, 59);
            this.ToolStripButton5.Text = "Salir";
            this.ToolStripButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ToolStripButton5.Click += new System.EventHandler(this.ToolStripButton5_Click);
            // 
            // ToolStripButton2
            // 
            this.ToolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButton2.Image")));
            this.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButton2.Name = "ToolStripButton2";
            this.ToolStripButton2.Size = new System.Drawing.Size(61, 59);
            this.ToolStripButton2.Text = "Almacen";
            this.ToolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ToolStripButton2.Click += new System.EventHandler(this.ToolStripButton2_Click);
            // 
            // ToolStrip1
            // 
            this.ToolStrip1.BackColor = System.Drawing.Color.Gainsboro;
            this.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.ToolStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripButton2,
            this.toolStripButton4,
            this.ToolStripButton5});
            this.ToolStrip1.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.ToolStrip1.Size = new System.Drawing.Size(64, 431);
            this.ToolStrip1.TabIndex = 6;
            this.ToolStrip1.Text = "ToolStrip1";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(49, 17);
            this.toolStripStatusLabel4.Text = "tsscaja";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(38, 17);
            this.toolStripStatusLabel3.Text = "Caja:";
            // 
            // tsshora
            // 
            this.tsshora.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsshora.Name = "tsshora";
            this.tsshora.Size = new System.Drawing.Size(140, 17);
            this.tsshora.Text = "toolStripStatusLabel3";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(42, 17);
            this.toolStripStatusLabel2.Text = "Hora:";
            // 
            // tssfecha
            // 
            this.tssfecha.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tssfecha.Name = "tssfecha";
            this.tssfecha.Size = new System.Drawing.Size(140, 17);
            this.tssfecha.Text = "toolStripStatusLabel2";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(47, 17);
            this.toolStripStatusLabel1.Text = "Fecha:";
            // 
            // tssnomusuario
            // 
            this.tssnomusuario.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tssnomusuario.Name = "tssnomusuario";
            this.tssnomusuario.Size = new System.Drawing.Size(140, 17);
            this.tssnomusuario.Text = "toolStripStatusLabel1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(59, 17);
            this.toolStripStatusLabel.Text = "Usuario:";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel,
            this.tssnomusuario,
            this.toolStripStatusLabel1,
            this.tssfecha,
            this.toolStripStatusLabel2,
            this.tsshora,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4});
            this.statusStrip.Location = new System.Drawing.Point(0, 431);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(799, 22);
            this.statusStrip.TabIndex = 5;
            this.statusStrip.Text = "StatusStrip";
            // 
            // MDIAlmacenero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(799, 453);
            this.Controls.Add(this.ToolStrip1);
            this.Controls.Add(this.statusStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "MDIAlmacenero";
            this.Text = "Almacenero";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MDIAlmacenero_Load);
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Timer tmrmenu;
        internal System.Windows.Forms.ToolStripButton toolStripButton4;
        internal System.Windows.Forms.ToolStripButton ToolStripButton5;
        internal System.Windows.Forms.ToolStripButton ToolStripButton2;
        internal System.Windows.Forms.ToolStrip ToolStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel tsshora;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel tssfecha;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tssnomusuario;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.StatusStrip statusStrip;
    }
}



