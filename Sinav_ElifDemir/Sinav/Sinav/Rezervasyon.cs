using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinav
{
    class Rezervasyon
    {
        public string Adsoyad { get; set; }
        public string  TC { get; set; }
        public string Cinsiyet { get; set; }
        public string Dolumu { get; set; }
        public override string ToString()
        {
            return "Adı Soyadı: "+this.Adsoyad+"\n TC: "+this.TC+"\n Cinsiyeti: "+this.Cinsiyet+"\n Rezervasyon Durumu: "+this.Dolumu+"\n";
        }

    }
}
