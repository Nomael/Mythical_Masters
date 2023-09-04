using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mythical_Masters_2
{
    public class Krieger : Held
    {
        public int Wut;



        public Krieger(int pWut, int pstärke, int pGeschieck, int pIntilligenz, string pname) : base(pstärke, pGeschieck, pIntilligenz, pname)

        {

            int Sterke = 10;
            Wut = pWut;
        }


        public Krieger() : this(0, 0, 0, 0, "DefaultName") // Default values
        {
            // You can add any additional initialization logic here if needed
        }



        public override int angriff(int bonus_wert)
        {
            return base.angriff(bonus_wert) + Wut + this.Stärke;
        }

        public override int rechne_abwehr(int bonus_wert)
        {
            return base.rechne_abwehr(bonus_wert) + Wut + this.Stärke;
        }




    }
}
