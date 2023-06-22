using ArsivOtomasyonu.DOMAIN;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArsivOtomasyonu.DAL
{
    class evrakDAO
    {
        public void evrakKaydet(evrak gevrak)
        {
            (new MySqlCommand("insert into evrak (evrakID,evrakAdi,evrakTuru,evrakYili) values (" + gevrak.EvrakID + ",'" + gevrak.EvrakAdi + "','" + gevrak.EvrakTuru + "','" + gevrak.EvrakYili + "')", (new dbBaglanti()).baglantiGetir())).ExecuteNonQuery();
        }

        internal void evraklariSil(int gevrakID)
        {
            (new MySqlCommand("delete from evrak where evrakID=" + gevrakID, (new dbBaglanti()).baglantiGetir())
                ).ExecuteNonQuery();
        }

        internal ArrayList evraklariGetir()
        {
            ArrayList okunanEvraklar = new ArrayList();
            //MySqlCommand komutum=new MySqlCommand("select * from bolum", (new dbBaglanti()).baglantiGetir())
            MySqlDataReader okunan = (new MySqlCommand("select * from evrak", (new dbBaglanti()).baglantiGetir())).ExecuteReader();
            while (okunan.Read())
            {
                okunanEvraklar.Add(new evrak(Convert.ToInt32(okunan[0]),okunan[1].ToString(), okunan[2].ToString(), okunan[3].ToString()));
            }
            return okunanEvraklar;
        }

       
    }
}

