﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Klase
{
    public interface Cvor
    {
        string Tag
        {
            get;
            set;
        }
        void prihvati(Posetilac p);
    }
}
