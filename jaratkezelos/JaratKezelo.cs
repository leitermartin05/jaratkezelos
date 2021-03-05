using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jaratkezelos
{
    public class JaratKezelo
    {
        List<Jarat> jaratok = new List<Jarat>();
        public void UjJarat(string jaratSzam, string repterHonnan, string repterHova, DateTime indulas)
        {
            bool sikeres = false;
            foreach (var jarat in jaratok)
            {
                if (jarat.JaratSzam == jaratSzam)
                {
                    throw new ArgumentException("Létező járat: ", jaratSzam);
                    return;
                }

                
                
            }
            try
            {
                Jarat felveendo = new Jarat(jaratSzam, repterHonnan, repterHova, indulas);
                jaratok.Add(felveendo);
                sikeres = true;
            } catch (ArgumentException e)
            {
                throw e;
            }
            
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
                if (jarat.Keses< 0)
                {
                    throw new NegativKesesExaption(jaratSzam);
                }
                else
                {
                    throw new FormatException("Hibás bemeneti paraméter");
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
