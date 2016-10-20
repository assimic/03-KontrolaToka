using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.CSharp
{
    public class Pretraga
    {
        public static bool Sadrži(IEnumerable<string> nizRiječi, string tražena)
        {
            // foreach(string riječ in nizRiječi)
            //  {
            //      if (riječ == tražena)
            //          return true;
            //  }
            //   return false;
           return nizRiječi.Contains(tražena);
            // throw new NotImplementedException();
        }

        public static int Zbroj(IEnumerable<int> brojevi)
        {
            //int zbroj = 0;
            //foreach(int broj in brojevi)
            //{
            //  zbroj += broj;
            //}
            //return zbroj;
            return brojevi.Sum();
            //throw new NotImplementedException();
        }

        public static IEnumerable<string> NađiSveIza(IEnumerable<string> riječi, string riječ)
        {
            return riječi.Where(r => r.CompareTo(riječ) > 0);
            throw new NotImplementedException();
        }
    }
}
