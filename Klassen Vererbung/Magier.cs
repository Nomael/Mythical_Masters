using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security;
using System.Text;

namespace Klassen_Vererbung
{
    
    public class Magier : Held
    {
        double mana_bonus = 0.1;
        int dumm = 10;


        public Magier(int pMana, int pstärke, int pGeschieck, int pIntilligenz) : base(pstärke, pGeschieck,pIntilligenz)
        
        {
            
            int Sterke = 10;
            mana_bonus = 0;
        }

        



        public void Eis()
        {
            throw new System.NotImplementedException();
        }
        
    }
}