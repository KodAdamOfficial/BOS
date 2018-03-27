using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÖDEVV
{
    public abstract class MusteriSinifi:Banka
    {
        public static List<MusteriSinifi> MusteriListesi = new List<MusteriSinifi>();
        public void YeniMusteri(MusteriSinifi m)
        {
            MusteriListesi.Add(m);
        }
        public string Ad { get; set; }
        public string SoyAd { get; set; }
        public long TC  { get; set; }
        public List<string> HesapOzeti = new List<string>(); 
        public DateTime KayitTarihi { get; set; }
        public string MusteriTuru { get; set; }
        public int Sifre { get; set; }
        public List<HesapSinifi> HesapListesi = new List<HesapSinifi>();
        public abstract decimal hvl(decimal a);
        public List<HesapSinifi> EkHesap = new List<HesapSinifi>();
        
    }
}
