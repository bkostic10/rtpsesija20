using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Klase;
namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            Cvor c1 = new OtvoreniTag();
            c1.Tag = "<CD>";

            Cvor c4 = new OtvoreniTag();
            c4.Tag = "<NAZIV>";
            Cvor c3 = new Vrednost();
            c3.Tag = "Californication";
            Cvor c5 = new OtvoreniTag();
            c5.Tag = "</NAZIV>";

            Cvor c6 = new OtvoreniTag();
            c6.Tag = "<GODINA>";
            Cvor c7 = new Vrednost();
            c7.Tag = "1999";
            Cvor c8 = new OtvoreniTag();
            c8.Tag = "</GODINA>";

            Cvor c2 = new ZatvoreniTag();
            c2.Tag = "</CD>";

            Cvor c9 = new Red();
            c9.Tag = "\n";

            EkstrakcijaTeksta et = new EkstrakcijaTeksta();
            et.Cvorovi.Add(c1);
            et.Cvorovi.Add(c9);
            et.Cvorovi.Add(c4);
            et.Cvorovi.Add(c3);
            et.Cvorovi.Add(c5);
            et.Cvorovi.Add(c9);
            et.Cvorovi.Add(c6);
            et.Cvorovi.Add(c7);
            et.Cvorovi.Add(c8);
            et.Cvorovi.Add(c9);
            et.Cvorovi.Add(c2);

            Console.WriteLine(et.ekstraktujTekst());
            Console.ReadLine();
        }
    }
}
