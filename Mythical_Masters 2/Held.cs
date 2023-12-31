﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mythical_Masters_2
{
    public class Held
    {
        public int Stärke;
        public int Geschieck;
        public int Intilligenz;
        
        public string name;


        public Held(int pstärke, int pGeschieck, int pIntilligenz, string pname)

        {
            name = pname;
            Stärke = pstärke;
            Geschieck = pGeschieck;
            Intilligenz = pIntilligenz;
        }

        public Held() { }


        public virtual int angriff(int bonus_wert)
        {
            return Stärke + bonus_wert;

        }

        public virtual int rechne_abwehr(int bonus_wert)
        {
            return Geschieck + bonus_wert;
        }


        public override string ToString()
        {
            return name + ";" + Stärke + ";" + Geschieck + ";" + Intilligenz;
        }
    }
}

