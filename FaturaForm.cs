using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using CrystalDecisions.Windows.Forms;
using CrystalDecisions.ReportSource;

namespace FATURA_PROJESİ
{
    public partial class FaturaForm : Form
    {
        public FaturaForm()
        {
            InitializeComponent();
        }
        public static string muss;
        private void button1_Click(object sender, EventArgs e)
        {///ürün ekleme
            if (textBox1.Text == "")
            {
                MessageBox.Show("Lütfen Ürün kodunu giriniz.!");
            }

            else
            {
                arama();
            }
            textBox1.Text = "";
        }

        private void FaturaForm_Load(object sender, EventArgs e)
        {
         dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void button2_Click(object sender, EventArgs e)
        {//rapor tuşu
            muss = textBox2.Text;
            Yazdır yz = new Yazdır();
            yz.Show();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=SAMSUNGPC;Initial Catalog=faturaIslemleri;Integrated Security=true;");
        DataTable dt = new DataTable();

        public void arama()
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("Select * From Urun where Kodu= '" + textBox1.Text + "'", baglanti);
            SqlDataAdapter adtr = new SqlDataAdapter(cmd);
            if (adtr.Fill(dt) != 0)
            {
                dataGridView1.DataSource = dt;
            }
            else { MessageBox.Show("Ürün Kodu Hatalı.!!"); }
            baglanti.Close();

           
        }

     public static   string ad, soy, un, adres,VD;
 public static  int  Vno;
  
  
        private void button3_Click(object sender, EventArgs e)
        {/* müşteriyi id si ile bilgilerine ulaşma*/

        /* int ele =Convert.ToInt32( textBox2.Text);
          baglanti.Open();
          SqlCommand cmd = new SqlCommand("Select * From Musteri where M_id= '" + ele + "'", baglanti);
          SqlDataReader rdr = cmd.ExecuteReader();
          while (rdr.Read()) {
              Yazdır yz = new Yazdır();
              ad=(rdr["Adı"].ToString());
              soy=(rdr["Soyadı"].ToString());
             un =(rdr["Unvanı"].ToString());
              VD=(rdr["VergiDairesi"].ToString());
             Vno=Convert.ToInt32(rdr["VergiNo"].ToString());
             adres = (rdr["Adres"].ToString());
          }

          Yazdır frm = new Yazdır();
           
            frm.Show();
            
            
           
          //  frm.crGoster.ReportSource = (@"C:\Users\Mustafa\Documents\Visual Studio 2008\Projects\CrystalReport\CrystalReport\rapor.rpt");
 
          baglanti.Close();*/
        }
    }
}
