using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
namespace MathCalculus
{
    public class Calculus
    {
      public List<int> setCalculs(int numero1, int numero2)
       {
            bool numberSup300 = false; 
            List<int> lista = new List<int>();
            lista.Add(numero1 + numero2);
            lista.Add(numero1 - numero2);
            lista.Add(numero2 - numero1);
            lista.Add((int)numero1 * numero2);
            lista.Add((int)(numero1 / numero2));
            lista.Add((int)(numero2 / numero1));

            var numero = numero1 * numero2;
            foreach (var item in lista)
            {

                if (item>= 300)
                {
                    numberSup300 = true; 
                }
            }

            if (numberSup300)
            {
                lista.Clear();
            }
            return lista;
        }
        
        public int getMCM(int numero1, int numero2)
        {
                int mcm = 0, a, b;
                a = Math.Max(numero1, numero2);
                b = Math.Min(numero1, numero2);
                mcm = (a / getMCD(numero1, numero2)) * b;
                return mcm;
        }

        public int getMCD(int numero1, int numero2)
        {
            int mcd = 0, a, b;
            a = Math.Max(numero1, numero2);
            b = Math.Min(numero1, numero2);
            do
            {
                mcd = b;
                b = a % b;
                a = mcd;
            } while (b != 0);

            return mcd;
        }
    }
}
