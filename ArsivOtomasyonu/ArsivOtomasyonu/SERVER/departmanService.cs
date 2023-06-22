using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArsivOtomasyonu.DOMAIN;
using ArsivOtomasyonu.DAL;
using System.Collections;
using System.Security.Cryptography;

namespace ArsivOtomasyonu.SERVER
{
    class departmanService
    {
        internal void departmanKaydet(string gdepartmanAdi, string gdepartmanID)
        {
            (new DepartmanDAO()).departmanKaydet(new departman(gdepartmanAdi, Convert.ToInt32(gdepartmanID)));
        }

        internal ArrayList departmanlariOku()
        {
            return (new DepartmanDAO()).departmanlariGetir();
        }

        internal void departmanlariSil(int gId)
        {
            (new DepartmanDAO()).departmaniSil(gId);
        }
    }

}
