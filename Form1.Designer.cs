namespace FATURA_PROJESİ
{
    partial class Form1
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
            this.fatura = new System.Windows.Forms.Button();
            this.siparis = new System.Windows.Forms.Button();
            this.urun = new System.Windows.Forms.Button();
            this.Musteri = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fatura
            // 
            this.fatura.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.fatura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.fatura.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.fatura.Location = new System.Drawing.Point(620, 1);
            this.fatura.Name = "fatura";
            this.fatura.Size = new System.Drawing.Size(201, 44);
            this.fatura.TabIndex = 7;
            this.fatura.Text = "FATURA";
            this.fatura.UseVisualStyleBackColor = false;
            this.fatura.Click += new System.EventHandler(this.fatura_Click);
            // 
            // siparis
            // 
            this.siparis.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.siparis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.siparis.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.siparis.Location = new System.Drawing.Point(413, 0);
            this.siparis.Name = "siparis";
            this.siparis.Size = new System.Drawing.Size(210, 44);
            this.siparis.TabIndex = 6;
            this.siparis.Text = "SİPARİS BİLGİLERİ";
            this.siparis.UseVisualStyleBackColor = false;
            this.siparis.Click += new System.EventHandler(this.siparis_Click);
            // 
            // urun
            // 
            this.urun.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.urun.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.urun.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.urun.Location = new System.Drawing.Point(215, 0);
            this.urun.Name = "urun";
            this.urun.Size = new System.Drawing.Size(201, 44);
            this.urun.TabIndex = 5;
            this.urun.Text = "ÜRÜN BİLGİLERİ";
            this.urun.UseVisualStyleBackColor = false;
            this.urun.Click += new System.EventHandler(this.urun_Click_1);
            // 
            // Musteri
            // 
            this.Musteri.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Musteri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Musteri.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Musteri.Location = new System.Drawing.Point(-4, 0);
            this.Musteri.Name = "Musteri";
            this.Musteri.Size = new System.Drawing.Size(224, 44);
            this.Musteri.TabIndex = 4;
            this.Musteri.Text = "MÜŞTERİ BİLGİLERİ";
            this.Musteri.UseVisualStyleBackColor = false;
            this.Musteri.Click += new System.EventHandler(this.Musteri_Click_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Musteri);
            this.panel1.Controls.Add(this.fatura);
            this.panel1.Controls.Add(this.urun);
            this.panel1.Controls.Add(this.siparis);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1190, 45);
            this.panel1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(1190, 695);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button fatura;
        private System.Windows.Forms.Button siparis;
        private System.Windows.Forms.Button urun;
        private System.Windows.Forms.Button Musteri;
        private System.Windows.Forms.Panel panel1;

    }
}

