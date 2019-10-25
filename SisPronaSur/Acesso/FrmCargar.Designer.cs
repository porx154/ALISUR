namespace SisPronaSur.Acesso
{
    partial class FrmCargar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCargar));
            this.tmpcarga = new System.Windows.Forms.Timer(this.components);
            this.lblcargar = new System.Windows.Forms.Label();
            this.pgrcargar = new System.Windows.Forms.ProgressBar();
            this.bcprogreso = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.SuspendLayout();
            // 
            // tmpcarga
            // 
            this.tmpcarga.Enabled = true;
            this.tmpcarga.Interval = 10;
            this.tmpcarga.Tick += new System.EventHandler(this.tmpcarga_Tick);
            // 
            // lblcargar
            // 
            this.lblcargar.AutoSize = true;
            this.lblcargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcargar.ForeColor = System.Drawing.Color.Black;
            this.lblcargar.Location = new System.Drawing.Point(12, 84);
            this.lblcargar.Name = "lblcargar";
            this.lblcargar.Size = new System.Drawing.Size(56, 13);
            this.lblcargar.TabIndex = 5;
            this.lblcargar.Text = "lblcargar";
            this.lblcargar.Visible = false;
            // 
            // pgrcargar
            // 
            this.pgrcargar.Location = new System.Drawing.Point(12, 42);
            this.pgrcargar.Name = "pgrcargar";
            this.pgrcargar.Size = new System.Drawing.Size(84, 33);
            this.pgrcargar.TabIndex = 4;
            this.pgrcargar.Visible = false;
            // 
            // bcprogreso
            // 
            this.bcprogreso.animated = false;
            this.bcprogreso.animationIterval = 5;
            this.bcprogreso.animationSpeed = 100;
            this.bcprogreso.BackColor = System.Drawing.Color.White;
            this.bcprogreso.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bcprogreso.BackgroundImage")));
            this.bcprogreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.bcprogreso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(239)))));
            this.bcprogreso.LabelVisible = true;
            this.bcprogreso.LineProgressThickness = 8;
            this.bcprogreso.LineThickness = 5;
            this.bcprogreso.Location = new System.Drawing.Point(10, 9);
            this.bcprogreso.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.bcprogreso.MaxValue = 100;
            this.bcprogreso.Name = "bcprogreso";
            this.bcprogreso.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.bcprogreso.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(239)))));
            this.bcprogreso.Size = new System.Drawing.Size(132, 132);
            this.bcprogreso.TabIndex = 6;
            this.bcprogreso.Value = 0;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 30;
            this.bunifuElipse1.TargetControl = this;
            // 
            // FrmCargar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(155, 150);
            this.ControlBox = false;
            this.Controls.Add(this.bcprogreso);
            this.Controls.Add(this.lblcargar);
            this.Controls.Add(this.pgrcargar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCargar";
            this.Opacity = 0.8D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iniciando...";
            this.Load += new System.EventHandler(this.FrmCargar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmpcarga;
        private System.Windows.Forms.Label lblcargar;
        private System.Windows.Forms.ProgressBar pgrcargar;
        private Bunifu.Framework.UI.BunifuCircleProgressbar bcprogreso;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
    }
}