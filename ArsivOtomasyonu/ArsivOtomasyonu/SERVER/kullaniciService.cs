using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArsivOtomasyonu.DOMAIN;
using ArsivOtomasyonu.DAL;
using System.Collections;

namespace ArsivOtomasyonu.SERVER
{
    class kullaniciService
    {
        internal void kullaniciKaydet(string kullaniciID,string gkullaniciAdi, string gkullaniciSoyadi, string gkullaniciSifre, string gkullaniciEmaill, string gkullaniciTelNo)
        {
            (new KullaniciDAO()).kullaniciKaydet(new kullanici(Convert.ToInt32(kullaniciID), gkullaniciSifre,gkullaniciAdi, gkullaniciSoyadi, gkullaniciTelNo, gkullaniciEmaill));
        }

        internal ArrayList kullanicilariOku()
        {
            return (new KullaniciDAO()).kullanicilariGetir();
        }

        internal void kullanicilariSil(int kullaniciID)
        {
            (new KullaniciDAO()).kullanicilariSil(kullaniciID);
        }

      
    }
    
}
