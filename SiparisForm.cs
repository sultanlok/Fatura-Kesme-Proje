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
    public partial class SiparisForm : Form
    {
        public SiparisForm()
        {
            InitializeComponent();
        } SqlConnection baglanti = new SqlConnection("Data Source=SAMSUNGPC;Initial Catalog=faturaIslemleri;Integrated Security=true;");
        public void verilerigoster()
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }

            SqlCommand kmt = new SqlCommand("select * from siparis", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(kmt);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();


        }

        private void SiparisForm_Load(object sender, EventArgs e)
        {
            verilerigoster();
        }

        private void button1_Click(object sender, EventArgs e)
        {/////////Siparişi kaydet
             baglanti.Open();
            SqlCommand cmd = new SqlCommand("insert into siparis (M_id,Kodu)values(@M_id,@Kodu)", baglanti);
            //cmd.Parameters.AddWithValue("@no",dataGridView1.CurrentRow.Cells[0].Value);
            cmd.Parameters.AddWithValue("@M_id", dataGridView1.CurrentRow.Cells[1].Value.ToString());
            cmd.Parameters.AddWithValue("@Kodu", dataGridView1.CurrentRow.Cells[2].Value.ToString());           
            cmd.ExecuteNonQuery();
            MessageBox.Show("Sipariş Kaydedildi..");
            verilerigoster();
            baglanti.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("Delete  from siparis where no=@no", baglanti);
            cmd.Parameters.AddWithValue("@no", dataGridView1.CurrentRow.Cells[0].Value.ToString());
            cmd.ExecuteNonQuery();
            MessageBox.Show("İptal İşlemi Başarılı", "Silindi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            verilerigoster();
            baglanti.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {/// düzenleeee
            baglanti.Open();
            SqlCommand komut = new SqlCommand("UPDATE siparis set M_id=@M_id,Kodu=@Kodu  where no=@no", baglanti);
            komut.Parameters.AddWithValue("@no", dataGridView1.CurrentRow.Cells[0].Value);
            komut.Parameters.AddWithValue("@M_id", dataGridView1.CurrentRow.Cells[1].Value.ToString());
            komut.Parameters.AddWithValue("@Kodu", dataGridView1.CurrentRow.Cells[2].Value.ToString());     

            komut.ExecuteNonQuery();
            MessageBox.Show("Sİpariş bilgileri düzenlendi.");
            verilerigoster();
            baglanti.Close();
        }
    }
}
