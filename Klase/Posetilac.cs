using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Klase
{
    public interface Posetilac
    {
        void posetiRed(Red r);
        void posetiOtvoreniTag(OtvoreniTag ot);
        void posetiZatvoreniTag(ZatvoreniTag zt);
        void posetiVrednost(Vrednost v);
    }
}
