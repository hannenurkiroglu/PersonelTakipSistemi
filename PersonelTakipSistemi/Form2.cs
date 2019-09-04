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
    public partial class Form2 : Form
    {
        String sicil_no;
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-KK831NE; Initial Catalog=PersonelDB; Integrated Security=true");

        public Form2(String sicil)
        {
            InitializeComponent();
            sicil_no = sicil;
            connection.Open();

            SqlCommand isim = new SqlCommand("select personelAdi,personelSoyAdi from tb_personel where personelSicilNo ='" + sicil + "'", connection);
            SqlDataReader isimoku = isim.ExecuteReader();
            isimoku.Read();

            hosgeldin.Text = "Merhaba\n" + isimoku["personelAdi"].ToString().ToUpper() + " " + isimoku["personelSoyAdi"].ToString().ToUpper();
            connection.Close();
            connection.Open();


            SqlCommand personel = new SqlCommand("SELECT personelAdi,personelSoyAdi,bolumAdi " +
                                                "FROM tb_personel " +
                                                "INNER JOIN tb_personelBolum ON tb_personel.personelSicilNo = tb_personelBolum.personelSicilNo " +
                                                "INNER JOIN tb_bolum ON tb_personelBolum.bolumNo = tb_bolum.bolumNo WHERE tb_personel.personelSicilNo ='"
                                                + sicil  + "'", connection);
            SqlDataReader personelOku = personel.ExecuteReader();
            personelOku.Read();

            label_tc.Text = sicil;
            label_ad.Text = personelOku["personelAdi"].ToString().ToUpper();
            label_soyad.Text = personelOku["personelSoyAdi"].ToString().ToUpper();
            label_bolum.Text = personelOku["bolumAdi"].ToString().ToUpper();
            connection.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            panel_profil.Visible = true;
            panel_gorev.Visible = false;
            panel_proje.Visible = false;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close(); //Programın kapanması için.
        }

        private void btn_profil_Click(object sender, EventArgs e)
        {
            panel_profil.Visible = true;
            panel_gorev.Visible = false;
            panel_proje.Visible = false;
        }

        private void btn_gorevler_Click(object sender, EventArgs e)
        {
            panel_profil.Visible = false;
            panel_gorev.Visible = true;
            panel_proje.Visible = false;

            SqlDataAdapter da = new SqlDataAdapter("SELECT tb_gorev.gorevAdi, tb_personelGorev.gorevBaslangicTarih,tb_personelGorev.gorevBitisTarih FROM tb_personelGorev INNER JOIN tb_gorev ON tb_personelGorev.gorevNo = tb_gorev.gorevNo WHERE tb_personelGorev.personelSicilNo = '" + sicil_no + "'", connection);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridViewGorev.DataSource = ds.Tables[0];
        }

        private void btn_projeler_Click(object sender, EventArgs e)
        {
            panel_profil.Visible = false;
            panel_gorev.Visible = false;
            panel_proje.Visible = true;

            SqlDataAdapter da = new SqlDataAdapter("SELECT tb_proje.projeAdi FROM tb_Proje INNER JOIN tb_personelProje ON tb_proje.projeNo = tb_personelProje.projeNo WHERE tb_personelProje.personelSicilNo = '" + sicil_no + "'", connection);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridViewProje.DataSource = ds.Tables[0];
        }

        private void btn_sifredegis_Click(object sender, EventArgs e)
        {
            Dao.SifDeg(sicil_no, txt_yenisifre.Text);
            MessageBox.Show("Parolanız değiştirildi");
        }

        private void btn_pGrup_Click(object sender, EventArgs e)
        {
            panel_profil.Visible = false;
            panel_gorev.Visible = false;
            panel_proje.Visible = true;

            SqlDataAdapter da = new SqlDataAdapter("SELECT personelSicilNo AS 'Aynı Projedeki Üyelerin Sicil Numaraları' FROM tb_personelProje as a inner join tb_proje as b on b.projeNo = a.projeNo where a.projeNo = (select projeNo from tb_personelProje where personelSicilNo ='" + sicil_no + "')", connection);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridViewProje.DataSource = ds.Tables[0];
        }
    }
}
