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
    public partial class gecmis : Form
    {
        public gecmis()
        {
            InitializeComponent();
        }

        private void gecmis_Load(object sender, EventArgs e)
        {
            label1.Text =Convert.ToString("Müşteri ="+ MusteriForm.ad+MusteriForm.soyad);
            for (int i = 0; i <MusteriForm.eleman.Count; i++)
            {
                int a =MusteriForm.eleman.ElementAt(i);
                geclist.Items.Add(a);
            }
            
        }
    }
}
