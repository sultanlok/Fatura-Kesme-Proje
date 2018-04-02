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
namespace FATURA_PROJESİ
{
    public partial class MusteriForm : Form
    {
        public MusteriForm()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=SAMSUNGPC;Initial Catalog=faturaIslemleri;Integrated Security=true;");
       public static List<int> eleman = new List<int>();
        public static int ID;
        public static string ad;
        public static string soyad;
        
        public void liste()
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
            SqlCommand toplam = new SqlCommand("Select Kodu from siparis where M_id='" + ID + "'", baglanti);
            SqlDataReader dReader = toplam.ExecuteReader();
            while (dReader.Read())
            {
                eleman.Add(int.Parse("" + dReader.GetValue(0)));
                // toplam.add (int.Parse("" + dReader.GetValue(0)));
                
                MessageBox.Show(dReader.GetValue(0).ToString());


            }
            baglanti.Close();
        }
       
       
        public void verilerigoster()
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }

            SqlCommand kmt = new SqlCommand("select * from Musteri", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(kmt);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();


        }

        private void MusteriForm_Load(object sender, EventArgs e)
        {
            verilerigoster();
        }

        private void button1_Click(object sender, EventArgs e)
        {///ekleee
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Musteri(TC,Adı,Soyadı,Unvanı,Telefon,VergiDairesi,VergiNo,e_posta,Adres)values(@TC,@Adı,@Soyadı,@Unvanı,@Telefon,@VergiDairesi,@VergiNo,@e_posta,@Adres)", baglanti);
            komut.Parameters.AddWithValue("@TC", dataGridView1.CurrentRow.Cells[1].Value);
            komut.Parameters.AddWithValue("@Adı", dataGridView1.CurrentRow.Cells[2].Value.ToString());
            komut.Parameters.AddWithValue("@Soyadı", dataGridView1.CurrentRow.Cells[3].Value.ToString());
            komut.Parameters.AddWithValue("@Unvanı", dataGridView1.CurrentRow.Cells[4].Value.ToString());
            komut.Parameters.AddWithValue("@Telefon", dataGridView1.CurrentRow.Cells[5].Value.ToString());
            komut.Parameters.AddWithValue("@VergiDairesi", dataGridView1.CurrentRow.Cells[6].Value.ToString());
            komut.Parameters.AddWithValue("@VergiNo", dataGridView1.CurrentRow.Cells[7].Value.ToString());
            komut.Parameters.AddWithValue("@e_posta", dataGridView1.CurrentRow.Cells[8].Value.ToString());
            komut.Parameters.AddWithValue("@Adres", dataGridView1.CurrentRow.Cells[9].Value.ToString());
            komut.ExecuteNonQuery();
            MessageBox.Show("Müşteri Kaydedildi.");
          
            verilerigoster();
            baglanti.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {////Düzenle
            baglanti.Open();
            SqlCommand komut = new SqlCommand("UPDATE Musteri set TC=@TC,Adı=@Adı,Soyadı=@Soyadı,Unvanı=@Unvanı,Telefon=@Telefon,VergiDairesi=@VergiDairesi,VergiNo=@VergiNo,e_posta=@e_posta,Adres=@Adres where M_id=@M_id", baglanti);
            komut.Parameters.AddWithValue("@M_id", dataGridView1.CurrentRow.Cells[0].Value);
            komut.Parameters.AddWithValue("@TC", dataGridView1.CurrentRow.Cells[1].Value.ToString());
            komut.Parameters.AddWithValue("@Adı", dataGridView1.CurrentRow.Cells[2].Value.ToString());
            komut.Parameters.AddWithValue("@Soyadı", dataGridView1.CurrentRow.Cells[3].Value.ToString());
            komut.Parameters.AddWithValue("@Unvanı", dataGridView1.CurrentRow.Cells[4].Value.ToString());
            komut.Parameters.AddWithValue("@Telefon", dataGridView1.CurrentRow.Cells[5].Value.ToString());
            komut.Parameters.AddWithValue("@VergiDairesi", dataGridView1.CurrentRow.Cells[6].Value.ToString());
            komut.Parameters.AddWithValue("@VergiNo", dataGridView1.CurrentRow.Cells[7].Value.ToString());
            komut.Parameters.AddWithValue("@e_posta", dataGridView1.CurrentRow.Cells[8].Value.ToString());
            komut.Parameters.AddWithValue("@Adres", dataGridView1.CurrentRow.Cells[9].Value.ToString());
            komut.ExecuteNonQuery();
            MessageBox.Show("Güncellendi");
            verilerigoster();
            baglanti.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {//////sillll
            baglanti.Open();
            SqlCommand kmt = new SqlCommand("DELETE FROM Musteri WHERE M_id=@M_id", baglanti);
            kmt.Parameters.AddWithValue("@M_id", dataGridView1.CurrentRow.Cells[0].Value.ToString());
            kmt.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Silme İşlemi Başarılı", "Silindi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            verilerigoster();
        }

        private void button4_Click(object sender, EventArgs e)
        {///müşteri geçmişi
            gecmis gec = new gecmis(); 
            liste();           
            gec.Show();
           

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           ID = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value);
           ad = Convert.ToString(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value);
           soyad = Convert.ToString(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[3].Value);
        }

        
    }
}
