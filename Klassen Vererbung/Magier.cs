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
        int mana = 1;
        


        public Magier(int pMana, int pstärke, int pGeschieck, int pIntilligenz, string pname) : base(pstärke, pGeschieck,pIntilligenz,pname)
        
        {
             
            int Sterke = 10;
            mana = 0;
        }

        



        
    }
}