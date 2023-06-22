using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using ArsivOtomasyonu.DOMAIN;
using System.Security.Cryptography;


namespace ArsivOtomasyonu.DAL
{   class DepartmanDAO
    {
        public void departmanKaydet(departman gdepartman)
        {
            (new MySqlCommand("insert into departman (departmanAdi,departmanID) values ('" + gdepartman.DepartmanAdi + "'," + gdepartman.DepartmanID + ")", (new dbBaglanti()).baglantiGetir())).ExecuteNonQuery();
        }

        internal void departmaniSil(int gId)
        {
            (new MySqlCommand("delete from departman where departmanID=" + gId, (new dbBaglanti()).baglantiGetir())
                ).ExecuteNonQuery();
        }

        internal ArrayList departmanlariGetir()
        {
            ArrayList okunanDepartmanlar = new ArrayList();
            //MySqlCommand komutum=new MySqlCommand("select * from bolum", (new dbBaglanti()).baglantiGetir())
            MySqlDataReader okunan = (new MySqlCommand("select * from departman", (new dbBaglanti()).baglantiGetir())).ExecuteReader();
            while (okunan.Read())
            {
                okunanDepartmanlar.Add(new departman(okunan[1].ToString(), Convert.ToInt32(okunan[0])));
            }
            return okunanDepartmanlar;
        }
    }

}
