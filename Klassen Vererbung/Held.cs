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
        private string name;
        

        public Held(int pstärke, int pGeschieck, int pIntilligenz, string pname)

        { 
             name = pname;
             Stärke = pstärke;
             Geschieck = pGeschieck;
            Intilligenz = pIntilligenz;
        }

        public virtual int angriff()
        {
            return Stärke;

        }


        public override string ToString()
        {
            return name + ";" + Stärke+ ";" + Geschieck + ";" + Intilligenz;
        }
    }
}