using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArsivOtomasyonu.DAL
{
    class dbBaglanti
    {
        public MySqlConnection baglantiGetir()
        {
            MySqlConnection baglanti = new MySqlConnection("Server=172.21.54.3; Database=Grup16-2023; Uid=Grup16-2023; Pwd=NyP:974.cc");
            baglanti.Open();
            return baglanti;
        }
    }
}
