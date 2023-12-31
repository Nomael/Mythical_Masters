﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mythical_Masters_2
{
    public class Schurke : Held
    {
        public int Täuschung;



        public Schurke(int pTäuschung, int pstärke, int pGeschieck, int pIntilligenz, string pname) : base(pstärke, pGeschieck, pIntilligenz, pname)

        {

            int Sterke = 10;
            Täuschung = pTäuschung;
        }


        public Schurke() : this(0, 0, 0, 0, "DefaultName") // Default values
        {
            // You can add any additional initialization logic here if needed
        }




        public override int angriff(int bonus_wert)
        {
            return base.angriff(bonus_wert) + Täuschung + this.Geschieck;
        }

        public override int rechne_abwehr(int bonus_wert)
        {
            return base.rechne_abwehr(bonus_wert) + Täuschung + this.Geschieck;
        }







    }
}
