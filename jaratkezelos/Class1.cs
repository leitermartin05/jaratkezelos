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
                        jarat.Keses = 0;
                    }
                    else
                    {
                        jarat.Keses += keses;
                    }
                }
            }
        }

        public DateTime MikorIndul(string jaratSzam)
        {
            foreach (var jarat in jaratok)
                {
                    if (jarat.JaratSzam==jaratSzam)
                    {
                        return jarat.Indulas.AddMinutes(jarat.Keses);
                    }
                    
                    
                }
            throw new ArgumentException("Nincs ilyen járat", "jaratSzam");
           
           
        }

        public List<string> JaratokRepuloterrol(string repter)
        {
            List<string> jaratSzamok = new List<string>();
             foreach (var jarat in jaratok)
                {
                    if (jarat.HonnanRepter == repter)
                    {
                        jaratSzamok.Add(jarat.JaratSzam);
                    }
                }
            if (jaratSzamok.Count!=0)
            {
                return jaratSzamok;
            } else
            {
                throw new ArgumentException("Nincs ilyen reptér", repter);
            }   
            } 
        
    }


}
