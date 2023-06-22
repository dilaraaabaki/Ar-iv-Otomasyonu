using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArsivOtomasyonu.DOMAIN;
using MySql.Data.MySqlClient;

namespace ArsivOtomasyonu.DAL
{
    class KullaniciDAO
    {
        public void kullaniciKaydet(kullanici gKullanici)
        {
            (new MySqlCommand("insert into kullanici (kullaniciID,kullaniciAdi, kullaniciSoyadi, kullaniciSifre,kullaniciEmail,kullaniciTelNo) values ('" + gKullanici.KullaniciAdi + "','" + gKullanici.KullaniciSoyadi + "','" + gKullanici.KullaniciSifre + "','" + gKullanici.KullaniciEmail + "','" + gKullanici.KullaniciTelNo + "')", (new dbBaglanti()).baglantiGetir())).ExecuteNonQuery();
        }

        internal ArrayList kullanicilariGetir()
        {
            ArrayList okunanKullanicilar = new ArrayList();
            //MySqlCommand komutum=new MySqlCommand("select * from bolum", (new dbBaglanti()).baglantiGetir())
            MySqlDataReader okunan = (new MySqlCommand("select * from kullanici", (new dbBaglanti()).baglantiGetir())).ExecuteReader();
            while (okunan.Read())
            {
                okunanKullanicilar.Add(new kullanici(Convert.ToInt32(okunan[0]),okunan[1].ToString(), okunan[2].ToString(), okunan[3].ToString(), okunan[4].ToString(),okunan[5].ToString()));
            }
            return okunanKullanicilar;
        }

        internal void kullanicilariSil(int gkullaniciID)
        {
            (new MySqlCommand("delete from kullanici where kullaniciID=" + gkullaniciID, (new dbBaglanti()).baglantiGetir())
                ).ExecuteNonQuery();
        }
    }
}
