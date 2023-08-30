using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Klassen_Vererbung
{
    public class Held
    {
        private int Stärke;
        private int Geschieck;
        private int Intilligenz;
        

        public Held(int pstärke, int pGeschieck, int pIntilligenz)
        { 
             Stärke = pstärke;
             Geschieck = pGeschieck;
            Intilligenz = pIntilligenz;
        }

        void angriff()
        {

        }
    }
}