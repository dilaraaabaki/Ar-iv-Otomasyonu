using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArsivOtomasyonu.DOMAIN
{
    public class evrak
    {
        public evrak(int gevrakID,string gevrakAdi,string gevrakTuru, string gevrakYili)
        {
            this.evrakID = gevrakID;
            this.evrakAdi = gevrakAdi;
            this.evrakTuru = gevrakTuru;
            this.evrakYili = gevrakYili;
            
        }

        int evrakID;
        string evrakAdi;
        string evrakTuru;
        string evrakYili;
        

        public string EvrakAdi { get => evrakAdi; set => evrakAdi = value; }
        public string EvrakTuru { get => evrakTuru; set => evrakTuru = value; }
        public string EvrakYili { get => evrakYili; set => evrakYili = value; }
        public int EvrakID { get => evrakID; set => evrakID = value; }
    }
}
