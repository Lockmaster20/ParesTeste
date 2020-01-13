using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paresteste
{
    class Calculo
    {
        private double quadruplo;

        public string recebe
        {
            set
            {
                quadruplo = Convert.ToDouble(value) * 4;
            }
        }

        public string resultado
        {
            get
            {
                return quadruplo.ToString();
            }
        }
    }
}
