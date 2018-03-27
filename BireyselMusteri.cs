using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÖDEVV
{
    public class BireyselMusteri:MusteriSinifi
    {
        public override decimal hvl(decimal a)
        {
            decimal b;
            b = (a * 0.02m);
            return b;
        }
    }
}
