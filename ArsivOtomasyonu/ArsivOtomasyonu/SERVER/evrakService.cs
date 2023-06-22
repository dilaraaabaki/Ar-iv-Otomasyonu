using ArsivOtomasyonu.DAL;
using ArsivOtomasyonu.DOMAIN;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ArsivOtomasyonu.SERVER
{
    class evrakService
    {
        internal void evrakKaydet(string gevrakID,string gevrakAdi, string gevrakTuru, string gevrakYili)
        {
            (new evrakDAO()).evrakKaydet(new evrak(Convert.ToInt32(gevrakID), gevrakAdi,gevrakTuru,gevrakYili));
        }

        internal ArrayList evraklariOku()
        {
            return (new evrakDAO()).evraklariGetir();
        }

        internal void evraklariSil(int gevrakAdi)
        {
            (new evrakDAO()).evraklariSil(gevrakAdi);
        }

    }
}
