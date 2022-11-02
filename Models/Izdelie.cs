using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SheiApp
{
    public partial class ZakazannieIzdeliya
    {
        public int Summa
        {
            get
            {
                return 100 * int.Parse(Kolichestvo);
            }
        }
    }
}
