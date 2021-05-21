using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacionsM5
{
    public class OperacionsBasiques
    {
        public string CalculaImpacte(int lectors, int prestigi)
        {
            // prestigi > 100  => Impacte = A    
            // prestigi entre 50 i  100  
            //            lectors > 1000 => Impacte = A
            //            lectors entre 500 i 1000 => Impacte = B
            //            lectors < 500 => Impacte = C
            // prestigi entre 1 i  49  
            //            lectors > 1000 => Impacte = B
            //            lectors  =<1000  Impacte = C
            string Impacte= "";
            switch (prestigi)
            {
                case int n when (n > 100):
                    Impacte = "A";
                    break;

                case int n when (n <= 100 && n >= 50):
                    if (lectors > 1000) Impacte = "A"; 
                    if (lectors <= 1000 && lectors >= 500) Impacte = "B";
                    if (lectors < 500) Impacte = "C";
                    break;

                case int n when (n < 50):
                    if (lectors > 1000) Impacte = "B";
                    if (lectors <= 1000) Impacte = "C";
                    break;
                default:
                    Impacte = "";
                    break;
            }
            return Impacte;
        }
    }
}
