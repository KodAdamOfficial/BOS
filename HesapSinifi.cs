using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÖDEVV
{
    public class HesapSinifi
    {
        public static List<int> HesapListe = new List<int>();
        public int Hesapno { get; set; }
        private decimal bakiye;
        public decimal Limit { get; set; }
        
        public decimal Bakiye
        {
            get { return bakiye; }
            set { bakiye = value; }
        }
        public HesapSinifi()
        {
            this.Bakiye = 0m;
        }

        public DateTime HesapAcmaTarihi { get; set; }
        public void HesapNumarasiAtama()
        {
            int a;
            Random r = new Random();
            here: a = r.Next(10000, 100000);
            foreach (int item in HesapListe)
            {
                if (item == a)
                {
                    goto here;
                }
                else
                    continue;
            }
            HesapListe.Add(a);
            this.Hesapno = a;
        }
    }
}
