using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SheiApp
{
    public partial class Zakaz
    {
        public int GetCountIzdeliy
        {
            get
            {
                return ZakazannieIzdeliyas.Count;
            }
        }
        public int Summa
        {
            get
            {
                return ZakazannieIzdeliyas.Sum(p => p.Summa);
            }
        }
    }
}
