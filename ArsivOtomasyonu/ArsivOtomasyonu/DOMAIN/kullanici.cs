using ArsivOtomasyonu.DAL;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArsivOtomasyonu.DOMAIN
{
    public class kullanici
    {
        public kullanici(int gkullaniciID, string gkullaniciSifre, string gkullaniciAdi, string gkullaniciSoyadi, string gkullaniciTelNo,string gkullaniciEmail) 
        {
            this.kullaniciID = gkullaniciID;
            this.kullaniciAdi = gkullaniciAdi;
            this.kullaniciSoyadi = gkullaniciSoyadi;
            this.kullaniciSifre = gkullaniciSifre;
            this.kullaniciEmail = gkullaniciEmail;
            this.kullaniciTelNo = gkullaniciTelNo;
        }

        int kullaniciID;
        string kullaniciAdi;
        string kullaniciSoyadi;
        string kullaniciSifre;
        string kullaniciEmail;
        string kullaniciTelNo;

        public string KullaniciSifre { get => kullaniciSifre; set => kullaniciSifre = value; }
        public string KullaniciAdi { get => kullaniciAdi; set => kullaniciAdi = value; }
        public string KullaniciSoyadi { get => kullaniciSoyadi; set => kullaniciSoyadi = value; }
        public string KullaniciTelNo { get => kullaniciTelNo; set => kullaniciTelNo = value; }
        public string KullaniciEmail { get => kullaniciEmail; set => kullaniciEmail = value; }
        public int KullaniciID { get => kullaniciID; set => kullaniciID = value; }
    }


}
