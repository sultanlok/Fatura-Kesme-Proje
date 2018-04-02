using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FATURA_PROJESİ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Musteri_Click_1(object sender, EventArgs e)
        {
           
            MusteriForm msF = new MusteriForm();
            msF.MdiParent = this;
            msF.Dock = DockStyle.Fill;
            msF.Show();
            
        }

        private void urun_Click_1(object sender, EventArgs e)
        {
            UrunForm uF = new UrunForm();
            uF.MdiParent = this;
            uF.Dock = DockStyle.Fill;
            uF.Show();
            
        }


        private void siparis_Click(object sender, EventArgs e)
        {
            SiparisForm sF = new SiparisForm();
            sF.MdiParent = this;
           sF.Dock = DockStyle.Fill;
            sF.Show();

        }

        private void fatura_Click(object sender, EventArgs e)
        {
            FaturaForm fF = new FaturaForm();
            fF.MdiParent = this;
            fF.Dock = DockStyle.Fill;
            fF.Show();
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FaturaForm fF = new FaturaForm();
            fF.MdiParent = this;
            fF.Dock = DockStyle.Fill;
            fF.Show();
        }

        


        
    }
}
