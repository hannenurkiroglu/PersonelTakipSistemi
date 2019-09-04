using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelTakipSistemi
{
    class Dao
    {
        public static SqlConnection GetConnection()
        {
            string str = "Data Source=DESKTOP-9NS46DK; Initial Catalog=PersonelDB; Integrated Security=true";

            SqlConnection con = new SqlConnection(str);
            con.Open();
            return con;

        }
        public static string TarihHesap(string sicil_no)
        {
            SqlCommand oku =
            new SqlCommand("SELECT DATEDIFF(day, (select gorevBaslangicTarih from tb_personelGorev where personelSicilNo = '" + sicil_no + "' ), (select gorevBitisTarih from tb_personelGorev where personelSicilNo = '" + sicil_no + "' )) AS a", GetConnection());
            SqlDataReader tarih = oku.ExecuteReader();
            tarih.Read();
            
            return tarih["a"].ToString();

        }

        public static void SifDeg(string sicil_no, string parola)
        {
            //SqlCommand oku = new SqlCommand("SELECT parola FROM tb_personelParola where (personelSicilNo= '" + sicil_no + "&& parola = '" + eskiparola + ")'", GetConnection());
            //if(parola)
            SqlCommand oku = new SqlCommand("update tb_personelParola set parola= '" + parola + "' where personelSicilNo= '" + sicil_no + "'", GetConnection());
            oku.ExecuteNonQuery();

        }
    }
}
