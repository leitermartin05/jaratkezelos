using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jaratkezelos
{
    class NegativKesesExaption:Exception
    {
        public NegativKesesExaption(string jaratSzam):
            base("A késés nem lehet kisebb, mint 0. Hibás járat száma: "+jaratSzam)
        {

        }
    }
}
