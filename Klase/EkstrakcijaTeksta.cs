using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Klase
{
    public class EkstrakcijaTeksta : Posetilac
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
                c.prihvati(this);
            }
            return Sb.ToString();
        }
        public void posetiRed(Red r)
        {
            r = (Red)c;
            Sb.Append(r.Tag);
        }
        public void posetiOtvoreniTag(OtvoreniTag ot)
        {
            ot = (OtvoreniTag)c;
            Sb.Append(ot.Tag);
        }
        public void posetiZatvoreniTag(ZatvoreniTag zt)
        {
            zt = (ZatvoreniTag)c;
            Sb.Append(zt.Tag);
        }
        public void posetiVrednost(Vrednost v)
        {
            v = (Vrednost)c;
            Sb.Append(v.Tag);
        }
    }
}
