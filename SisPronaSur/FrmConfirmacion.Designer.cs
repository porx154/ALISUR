namespace SisPronaSur
{
    partial class FrmConfirmacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConfirmacion));
            this.printDialogCodigo = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocumentCodigo = new System.Drawing.Printing.PrintDocument();
            this.lblmargen = new System.Windows.Forms.Label();
            this.mtbtnimprimir = new MetroFramework.Controls.MetroTile();
            this.mtbtnsalir = new MetroFramework.Controls.MetroTile();
            this.mttxtcondigo = new MetroFramework.Controls.MetroTextBox();
            this.mttxtmonto = new MetroFramework.Controls.MetroTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // printDialogCodigo
            // 
            this.printDialogCodigo.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printDialogCodigo.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printDialogCodigo.ClientSize = new System.Drawing.Size(400, 300);
            this.printDialogCodigo.Enabled = true;
            this.printDialogCodigo.Icon = ((System.Drawing.Icon)(resources.GetObject("printDialogCodigo.Icon")));
            this.printDialogCodigo.Name = "printDialogCodigo";
            this.printDialogCodigo.Visible = false;
            // 
            // printDocumentCodigo
            // 
            this.printDocumentCodigo.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocumentCodigo_PrintPage);
            // 
            // lblmargen
            // 
            this.lblmargen.AutoSize = true;
            this.lblmargen.Location = new System.Drawing.Point(39, 206);
            this.lblmargen.Name = "lblmargen";
            this.lblmargen.Size = new System.Drawing.Size(243, 13);
            this.lblmargen.TabIndex = 1;
            this.lblmargen.Text = "***********************************************************";
            this.lblmargen.Visible = false;
            // 
            // mtbtnimprimir
            // 
            this.mtbtnimprimir.BackColor = System.Drawing.Color.White;
            this.mtbtnimprimir.Location = new System.Drawing.Point(278, 30);
            this.mtbtnimprimir.Name = "mtbtnimprimir";
            this.mtbtnimprimir.Size = new System.Drawing.Size(51, 36);
            this.mtbtnimprimir.Style = MetroFramework.MetroColorStyle.Yellow;
            this.mtbtnimprimir.TabIndex = 2;
            this.mtbtnimprimir.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbtnimprimir.TileImage = ((System.Drawing.Image)(resources.GetObject("mtbtnimprimir.TileImage")));
            this.mtbtnimprimir.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtbtnimprimir.UseTileImage = true;
            this.mtbtnimprimir.Click += new System.EventHandler(this.mtbtnimprimir_Click);
            // 
            // mtbtnsalir
            // 
            this.mtbtnsalir.BackColor = System.Drawing.Color.White;
            this.mtbtnsalir.Location = new System.Drawing.Point(278, 75);
            this.mtbtnsalir.Name = "mtbtnsalir";
            this.mtbtnsalir.Size = new System.Drawing.Size(51, 36);
            this.mtbtnsalir.Style = MetroFramework.MetroColorStyle.Teal;
            this.mtbtnsalir.TabIndex = 4;
            this.mtbtnsalir.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbtnsalir.TileImage = ((System.Drawing.Image)(resources.GetObject("mtbtnsalir.TileImage")));
            this.mtbtnsalir.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtbtnsalir.UseTileImage = true;
            this.mtbtnsalir.Click += new System.EventHandler(this.mtbtnsalir_Click);
            // 
            // mttxtcondigo
            // 
            this.mttxtcondigo.Enabled = false;
            this.mttxtcondigo.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.mttxtcondigo.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.mttxtcondigo.Location = new System.Drawing.Point(90, 31);
            this.mttxtcondigo.Name = "mttxtcondigo";
            this.mttxtcondigo.Size = new System.Drawing.Size(164, 29);
            this.mttxtcondigo.TabIndex = 5;
            // 
            // mttxtmonto
            // 
            this.mttxtmonto.Enabled = false;
            this.mttxtmonto.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.mttxtmonto.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.mttxtmonto.Location = new System.Drawing.Point(90, 75);
            this.mttxtmonto.Name = "mttxtmonto";
            this.mttxtmonto.Size = new System.Drawing.Size(114, 29);
            this.mttxtmonto.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.metroLabel3);
            this.groupBox2.Controls.Add(this.mtbtnsalir);
            this.groupBox2.Controls.Add(this.mttxtmonto);
            this.groupBox2.Controls.Add(this.mtbtnimprimir);
            this.groupBox2.Controls.Add(this.metroLabel4);
            this.groupBox2.Controls.Add(this.mttxtcondigo);
            this.groupBox2.Location = new System.Drawing.Point(23, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(343, 122);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(18, 75);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(48, 19);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "Monto";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(18, 31);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(53, 19);
            this.metroLabel4.TabIndex = 7;
            this.metroLabel4.Text = "Codigo";
            // 
            // FrmConfirmacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 256);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblmargen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmConfirmacion";
            this.Text = "Codigo de Confirmacion";
            this.Load += new System.EventHandler(this.FrmConfirmacion_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PrintPreviewDialog printDialogCodigo;
        private System.Drawing.Printing.PrintDocument printDocumentCodigo;
        private System.Windows.Forms.Label lblmargen;
        private MetroFramework.Controls.MetroTile mtbtnimprimir;
        private MetroFramework.Controls.MetroTile mtbtnsalir;
        private MetroFramework.Controls.MetroTextBox mttxtcondigo;
        private MetroFramework.Controls.MetroTextBox mttxtmonto;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
    }
}