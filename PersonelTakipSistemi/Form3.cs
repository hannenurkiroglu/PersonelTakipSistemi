using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonelTakipSistemi
{
    public partial class Form3 : Form
    {
        String sicil_no;
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-KK831NE; Initial Catalog=PersonelDB; Integrated Security=true");

        public Form3(String sicil)
        {
            InitializeComponent();
            sicil_no = sicil;
            connection.Open();
            txt_pSicilNo.MaxLength = 15;
            txt_pAdi.MaxLength = 20;
            txt_pSoyadi.MaxLength = 20;


            //personel sicil no ile iliskili personel ve personelBolum tablosundan bilgilerini cekiyor.
            SqlCommand personel = new SqlCommand("SELECT personelAdi,personelSoyAdi,bolumAdi " +
                                                "FROM tb_personel " +
                                                "INNER JOIN tb_personelBolum ON tb_personel.personelSicilNo = tb_personelBolum.personelSicilNo " +
                                                "INNER JOIN tb_bolum ON tb_personelBolum.bolumNo = tb_bolum.bolumNo WHERE tb_personel.personelSicilNo ='" 
                                                + sicil + "'", connection);
            SqlDataReader personelOku = personel.ExecuteReader();
            personelOku.Read();

            label_tc.Text = sicil;
            label_ad.Text = personelOku["personelAdi"].ToString().ToUpper();
            label_soyad.Text = personelOku["personelSoyAdi"].ToString().ToUpper();
            label_bolum.Text = personelOku["bolumAdi"].ToString().ToUpper();
            connection.Close();
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            panel_profil.Visible = true;
            panel_gorev.Visible = false;
            panel_proje.Visible = false;
            panel_personelislem.Visible = false;
            panel_bolumler.Visible = false;
            panel_gorevler.Visible = false;
            panel_projeler.Visible = false;
            panel_personelBilgi.Visible = false;

        }

        private void exit2_Click(object sender, EventArgs e)
        {
            this.Close(); //Programın kapanması için.
        }
        
        private void btn_profil_Click(object sender, EventArgs e)
        {
            panel_profil.Visible = true;
            panel_gorev.Visible = false;
            panel_proje.Visible = false;
            panel_personelislem.Visible = false;
            panel_bolumler.Visible = false;
            panel_gorevler.Visible = false;
            panel_projeler.Visible = false;
            panel_personelBilgi.Visible = false;
        }

        private void btn_gorev_Click(object sender, EventArgs e)
        {
            panel_profil.Visible = false;
            panel_gorev.Visible = true;
            panel_proje.Visible = false;
            panel_personelislem.Visible = false;
            panel_bolumler.Visible = false;
            panel_gorevler.Visible = false;
            panel_projeler.Visible = false;
            panel_personelBilgi.Visible = false;

            //giris yapan kisinin sicil no sunu kullanarak personelGorev tablosundan bilgilerini cekiyor.
            SqlDataAdapter da = new SqlDataAdapter("SELECT tb_gorev.gorevAdi, tb_personelGorev.gorevBaslangicTarih,tb_personelGorev.gorevBitisTarih FROM tb_personelGorev INNER JOIN tb_gorev ON tb_personelGorev.gorevNo = tb_gorev.gorevNo WHERE tb_personelGorev.personelSicilNo = '" + sicil_no + "'", connection);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridViewGorev.DataSource = ds.Tables[0];
        }

        private void btn_proje_Click(object sender, EventArgs e)
        {
            panel_profil.Visible = false;
            panel_gorev.Visible = false;
            panel_proje.Visible = true;
            panel_personelislem.Visible = false;
            panel_bolumler.Visible = false;
            panel_gorevler.Visible = false;
            panel_projeler.Visible = false;
            panel_personelBilgi.Visible = false;

            //giris yapan kisinin sicil no sunu kullanarak personelin projelerini listeliyor
            SqlDataAdapter da = new SqlDataAdapter("SELECT tb_proje.projeAdi FROM tb_Proje INNER JOIN tb_personelProje ON tb_proje.projeNo = tb_personelProje.projeNo WHERE tb_personelProje.personelSicilNo = '" + sicil_no + "'", connection);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridViewProje.DataSource = ds.Tables[0];
        }

        private void btn_personel_Click(object sender, EventArgs e)
        {
            panel_profil.Visible = false;
            panel_gorev.Visible = false;
            panel_proje.Visible = false;
            panel_personelislem.Visible = true;
            panel_bolumler.Visible = false;
            panel_gorevler.Visible = false;
            panel_projeler.Visible = false;
            panel_personelBilgi.Visible = false;
            cinsToplam.Checked = false;

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM tb_personel", connection);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridViewPersoneller.DataSource = ds.Tables[0];
        }

        private void btn_bolumler_Click(object sender, EventArgs e)
        {
            panel_profil.Visible = false;
            panel_gorev.Visible = false;
            panel_proje.Visible = false;
            panel_personelislem.Visible = false;
            panel_bolumler.Visible = true;
            panel_gorevler.Visible = false;
            panel_projeler.Visible = false;
            panel_personelBilgi.Visible = false;

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM tb_bolum", connection);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridViewBolumler.DataSource = ds.Tables[0];
        }

        private void btn_gorevler_Click(object sender, EventArgs e)
        {
            panel_profil.Visible = false;
            panel_gorev.Visible = false;
            panel_proje.Visible = false;
            panel_personelislem.Visible = false;
            panel_bolumler.Visible = false;
            panel_gorevler.Visible = true;
            panel_projeler.Visible = false;
            panel_personelBilgi.Visible = false;

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM tb_gorev", connection);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridViewGorevler.DataSource = ds.Tables[0];
        }

        private void btn_projeler_Click(object sender, EventArgs e)
        {
            panel_profil.Visible = false;
            panel_gorev.Visible = false;
            panel_proje.Visible = false;
            panel_personelislem.Visible = false;
            panel_bolumler.Visible = false;
            panel_gorevler.Visible = false;
            panel_projeler.Visible = true;
            panel_personelBilgi.Visible = false;

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM tb_proje", connection);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridViewProjeler.DataSource = ds.Tables[0];
        }

        private void btn_personelbilgi_Click(object sender, EventArgs e)
        {
            panel_profil.Visible = false;
            panel_gorev.Visible = false;
            panel_proje.Visible = false;
            panel_personelislem.Visible = false;
            panel_bolumler.Visible = false;
            panel_gorevler.Visible = false;
            panel_projeler.Visible = false;
            panel_personelBilgi.Visible = true;
            cinsToplam.Checked = false;

            SqlDataAdapter da = new SqlDataAdapter("SELECT tb_personel.personelSicilNo, tb_personel.personelAdi, tb_personel.personelSoyAdi, tb_bolum.bolumAdi, tb_oda.odaKat, tb_personelOda.odaNo FROM tb_personel INNER JOIN tb_personelBolum ON tb_personel.personelSicilNo = tb_personelBolum.personelSicilNo INNER JOIN tb_bolum ON tb_personelBolum.bolumNo = tb_bolum.bolumNo INNER JOIN tb_personelOda ON tb_personel.personelSicilNo = tb_personelOda.personelSicilNo INNER JOIN tb_oda ON dbo.tb_bolum.bolumNo = tb_oda.bolumNo AND tb_personelOda.odaNo = tb_oda.odaNo", connection);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridViewPersonelBilgi.DataSource = ds.Tables[0];
        }

        private void btn_ekle1_Click(object sender, EventArgs e)
        {
            connection.Open();           
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            // txt_pSicilNo gibi değğişkenleri türkçe karakterlerden ayıklayarak ver+
            cmd.CommandText = "INSERT INTO tb_personel VALUES ('" + txt_pSicilNo.Text + "' , '" + txt_pAdi.Text + "' , '" + txt_pSoyadi.Text + "', '"+ txt_cinsiyet.Text+"')";
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Eklendi");
            btn_yenile_Click(sender, e);
        }

        private void btn_sil1_Click(object sender, EventArgs e)
        {

            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM tb_personel WHERE personelSicilNo = '" + txt_pSicilNo.Text + "'";
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Silindi");
            btn_yenile_Click(sender, e);
        }

        private void btn_guncelle1_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE tb_personel SET personelAdi = '" + txt_pAdi.Text + "' , personelSoyAdi ='" + txt_pSoyadi.Text + "' , personelCinsiyet ='" + txt_cinsiyet.Text + "' WHERE personelSicilNo = '" + txt_pSicilNo.Text + "'";
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Güncellendi");
            btn_yenile_Click(sender, e);
        }

        private void btn_yenile_Click(object sender, EventArgs e)
        {
            cinsToplam.Checked = false;
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM tb_personel";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridViewPersoneller.DataSource = dt;
            connection.Close();
        }

        private void btn_ara_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT tb_personel.personelSicilNo, tb_personel.personelAdi, tb_personel.personelSoyAdi, tb_bolum.bolumAdi, tb_oda.odaKat, tb_personelOda.odaNo FROM tb_personel INNER JOIN tb_personelBolum ON tb_personel.personelSicilNo = tb_personelBolum.personelSicilNo INNER JOIN tb_bolum ON tb_personelBolum.bolumNo = tb_bolum.bolumNo INNER JOIN tb_personelOda ON tb_personel.personelSicilNo = tb_personelOda.personelSicilNo INNER JOIN tb_oda ON dbo.tb_bolum.bolumNo = tb_oda.bolumNo AND tb_personelOda.odaNo = tb_oda.odaNo WHERE tb_personel.personelSicilNo = '" + txt_ara.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridViewPersonelBilgi.DataSource = dt;
            connection.Close();
            btn_yenile_Click(sender, e);
        }

        private void btn_sifredegis_Click(object sender, EventArgs e)
        {
            Dao.SifDeg(sicil_no, txt_yenisifre.Text);
            MessageBox.Show("Parolanız değiştirildi");
        }

        private void cinsToplam_CheckedChanged(object sender, EventArgs e)
        {
            //PERSONELLERİ CİNSİYETLERE GÖRE GRUPLAYIP COUNT HESAPLAMALI SORGUSU İLE HER GRUPTA KAÇ VARLIK OLDUĞUNUNU LİSTELER
            SqlDataAdapter cinsiyetToplam = new SqlDataAdapter("SELECT personelCinsiyet AS 'Cinsiyetler', COUNT(*) AS 'Toplam Personel' FROM tb_personel GROUP BY personelCinsiyet", connection);
            DataSet ds = new DataSet();
            cinsiyetToplam.Fill(ds);
            dataGridViewPersoneller.DataSource = ds.Tables[0];
        }
    }
}
