namespace FATURA_PROJESİ
{
    partial class Yazdır
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
            this.crGoster = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.CrystalReport11 = new FATURA_PROJESİ.CrystalReport1();
            this.SuspendLayout();
            // 
            // crGoster
            // 
            this.crGoster.ActiveViewIndex = 0;
            this.crGoster.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crGoster.Cursor = System.Windows.Forms.Cursors.Default;
            this.crGoster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crGoster.Location = new System.Drawing.Point(0, 0);
            this.crGoster.Name = "crGoster";
            this.crGoster.ReportSource = this.CrystalReport11;
            this.crGoster.Size = new System.Drawing.Size(1041, 674);
            this.crGoster.TabIndex = 0;
            this.crGoster.Load += new System.EventHandler(this.crGoster_Load);
            // 
            // Yazdır
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 674);
            this.Controls.Add(this.crGoster);
            this.Name = "Yazdır";
            this.Text = "Yazdır";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crGoster;
        private CrystalReport1 CrystalReport11;
     
       

    }
}