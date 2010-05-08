using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Klase
{
    public class EkstrakcijaTeksta
    {
        StringBuilder sb;

        public StringBuilder Sb
        {
            get { return sb; }
            set { sb = value; }
        }

        List<Cvor> cvorovi = new List<Cvor>();

        public List<Cvor> Cvorovi
        {
            get { return cvorovi; }
            set { cvorovi = value; }
        }

        Cvor c;
        public string ekstraktujTekst() 
        {
            Sb = new StringBuilder();
            IEnumerator<Cvor> it = Cvorovi.GetEnumerator();
            while (it.MoveNext())
            {
                c = (Cvor)it.Current;
                if (c is OtvoreniTag) 
                {
                    OtvoreniTag ot = (OtvoreniTag)c;
                    Sb.Append(ot.Tag);
                }
                else if (c is ZatvoreniTag)
                {
                    ZatvoreniTag zt = (ZatvoreniTag)c;
                    Sb.Append(zt.Tag);
                }
                else if (c is Vrednost)
                {
                    Vrednost vred = (Vrednost)c;
                    Sb.Append(vred.Tag);
                }
                else
                {
                    Red r = (Red)c;
                    Sb.Append(r.Tag);
                }
            }
            return Sb.ToString();
        }
    }
}
