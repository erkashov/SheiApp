using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SheiApp
{
    public partial class ShveiEntities
    {
        private static ShveiEntities _context;
        public static ShveiEntities GetContext
        {
            get
            {
                if (_context == null) _context = new ShveiEntities();
                return _context;
            }
        }
    }
}
