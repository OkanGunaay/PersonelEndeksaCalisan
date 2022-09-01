using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelEndeksaCalisan
{
      public class endeksaCalisan
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string SoyAd { get; set; }
        public Departman Departman { get; set; }
        public DateTime IseGiris { get; set; }
        public int ticketMiktar { get; set; }
        public char Cinsiyet { get; set; }
    }
    public enum Departman
    {
        Yazılım = 2,
        Ik = 1,
        Stajyer = 3,
        Muhasebe = 4

    }
}
