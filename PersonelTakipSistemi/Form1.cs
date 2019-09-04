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
    public partial class Form1 : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-KK831NE; Initial Catalog=PersonelDB; Integrated Security=true");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.Select();
        }
        
        private void txt_pSicilNo_Click(object sender, EventArgs e)
        {
            txt_pSicilNo.Text = "";
        }

        private void txt_parola_Click(object sender, EventArgs e)
        {
            txt_parola.UseSystemPasswordChar = true;
            txt_parola.Text = "";
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {

            connection.Open();
            SqlCommand loginSP = new SqlCommand("SpLogin", connection);
            loginSP.CommandType = CommandType.StoredProcedure;
            loginSP.Parameters.AddWithValue("@personelSicilNo", txt_pSicilNo.Text);
            loginSP.Parameters.AddWithValue("@parola", txt_parola.Text);
            loginSP.Parameters.AddWithValue("@donusDegeri", SqlDbType.Int);
            loginSP.Parameters["@donusDegeri"].Direction = ParameterDirection.Output;

            loginSP.ExecuteNonQuery();
            string yetkiDegeri = loginSP.Parameters["@donusDegeri"].Value.ToString();
            connection.Close();

            if (yetkiDegeri == "0")
            {
                MessageBox.Show("Hatalı Giriş");
            }
            else if (yetkiDegeri == "1")
            {
                //Form2 düzenlenmedi. 'txt_SicilNo' alınacak.
                //Form2 form2 = new Form2(txt_pSicilNo.Text); 
                Form3 form3 = new Form3(txt_pSicilNo.Text);
                this.Hide();
                form3.ShowDialog();
                Application.Exit();
            }
            else
            {
                //Form3 düzenlenmedi. 'txt_SicilNo' alınacak.
                //Form3 form3 = new Form3(txt_pSicilNo.Text);
                Form2 form2 = new Form2(txt_pSicilNo.Text);
                this.Hide();
                form2.ShowDialog();
                Application.Exit();
            }
            /*
                Form2 frm = new Form2();
                frm.Show();
                this.Hide();
            */
        }

        private void txt_pSicilNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_parola_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
