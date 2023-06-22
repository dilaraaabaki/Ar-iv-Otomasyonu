using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArsivOtomasyonu.DOMAIN
{
    public class departman
    {
        public departman(string gdepartmanAdi,int gdepartmanID) 
        {
            this.departmanAdi = gdepartmanAdi;
            this.departmanID = gdepartmanID;
        }

        
        
        string departmanAdi;
        int departmanID;

        public string DepartmanAdi { get => departmanAdi; set => departmanAdi = value; }
        public int DepartmanID { get => departmanID; set => departmanID = value; }
        public int Id { get; internal set; }

        public override string ToString()
        {
            return this.DepartmanAdi;
        }

    }
    
   
}
