using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jaratkezelos
{
    public class Class1
    {
        List<Jarat> jaratok = new List<Jarat>();
        public void UjJarat(string jaratSzam, string repterHonnan, string repterHova, DateTime indulas)
        {
            Jarat felveendo = new Jarat(jaratSzam, repterHonnan, repterHova, indulas);
        }

        public void Keses(string jaratSzam, int keses)
        {
            foreach (var jarat in jaratok)
            {
                if (jarat.JaratSzam==jaratSzam)
                {
                    if (jarat.Keses+keses<0)
                    {

                    }
                }
            }
        }

        public DateTime MikorIndul(string jaratSzam)
        {
            return ;
        }

        public List<string> JaratokRepuloterrol(string repter)
        {
            return;
        }
    }


}
