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
    public partial class UrunForm : Form
    {
        public UrunForm()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=SAMSUNGPC;Initial Catalog=faturaIslemleri;Integrated Security=true;");
        public void verilerigoster()
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }

            SqlCommand kmt = new SqlCommand("select * from Urun", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(kmt);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();


        }
        private void UrunForm_Load(object sender, EventArgs e)
        {
            verilerigoster();
        }

        private void button1_Click(object sender, EventArgs e)
        {/////ürün ekle
            baglanti.Open();
          
            SqlCommand cmd = new SqlCommand("insert into Urun (Kodu,UrunAdı,Acıklama,Fiyatı,Proje_Dahil)values(@Kodu,@UrunAdı,@Acıklama,@Fiyatı,@Proje_Dahil)", baglanti);
            cmd.Parameters.AddWithValue("@Kodu", dataGridView1.CurrentRow.Cells[0].Value.ToString());
            cmd.Parameters.AddWithValue("@UrunAdı", dataGridView1.CurrentRow.Cells[1].Value.ToString());
            cmd.Parameters.AddWithValue("@Acıklama", dataGridView1.CurrentRow.Cells[2].Value.ToString());
            cmd.Parameters.AddWithValue("@Fiyatı", dataGridView1.CurrentRow.Cells[3].Value.ToString());
            cmd.Parameters.AddWithValue("@Proje_Dahil", dataGridView1.CurrentRow.Cells[4].Value.ToString());
            cmd.ExecuteNonQuery();
            MessageBox.Show("Urun Eklendi");
            verilerigoster();
            baglanti.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {////ürün sil
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("Delete  from Urun where Kodu=@Kodu",baglanti);
            cmd.Parameters.AddWithValue("@Kodu", dataGridView1.CurrentRow.Cells[0].Value.ToString());
            cmd.ExecuteNonQuery();
            MessageBox.Show("Silme İşlemi Başarılı", "Silindi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            verilerigoster();
            baglanti.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {//////ÜRÜN Güncelle
            baglanti.Open();
            SqlCommand komut = new SqlCommand("UPDATE Urun set UrunAdı=@UrunAdı,Acıklama=@Acıklama,Fiyatı=@Fiyatı,Proje_Dahil=@Proje_Dahil  where Kodu=@Kodu", baglanti);
            komut.Parameters.AddWithValue("@Kodu", dataGridView1.CurrentRow.Cells[0].Value);
            komut.Parameters.AddWithValue("@UrunAdı", dataGridView1.CurrentRow.Cells[1].Value.ToString());
            komut.Parameters.AddWithValue("@Acıklama", dataGridView1.CurrentRow.Cells[2].Value.ToString());
            komut.Parameters.AddWithValue("@Fiyatı", dataGridView1.CurrentRow.Cells[3].Value.ToString());
            komut.Parameters.AddWithValue("@Proje_Dahil", dataGridView1.CurrentRow.Cells[4].Value.ToString());
            
            komut.ExecuteNonQuery();
            MessageBox.Show("Güncellendi");
            verilerigoster();
            baglanti.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
