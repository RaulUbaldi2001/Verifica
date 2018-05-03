using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatisticaLibrary
{
    public class Statistica
    {
        public static bool IsPositivo (double a,bool ris)
        {
            ris = false;
            if (a > 0)
            {
                ris = true;
            }
            return ris;
        }
        public static int CaricaPositiva(int[]a,int ctr)
        {
            for(int i = 0; i < a.Length; i++)
            {
                if(a[i]>0)
                {
                    ctr = ctr + 1;
                }
            }
            return ctr; 
        }
        public static int[] Positivi(int[] a, int[] b)
        {
            for(int i = 0; i < a.Length; i++)
            {
                if (a[i] > 0)
                {
                    b[i] = a[i];
                }
            }

            return b;
        }
    }
}
