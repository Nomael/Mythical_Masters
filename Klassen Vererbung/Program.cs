using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Klassen_Vererbung
{
    internal class Program
    {
       
        static Held Held_bauen(int heldennummer,string name, int stärke, int intiligenz,int geschieck)
        {
            Held Figur;
            
            switch (heldennummer)
            {
                case 1:
                    Figur = new Magier(100,stärke, geschieck,intiligenz,name);
                    break;
                case 2:
                    Figur = new Schurke();
                    break;
                default: return new Schurke();

            }
            return Figur;
        }

        static void werte_eingeben(int heldennummer)
        {
            int stearke;
            int intiligenz;
            int geschieck;
            int mana;
           
            Console.Clear();
            Console.WriteLine("Werte des Helden eingeben!");
            Console.WriteLine();
            Console.WriteLine("Stärke");
            stearke = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Intiligenz");
            intiligenz = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Geschiek");
            geschieck = Convert.ToInt32(Console.ReadLine());
            if(heldennummer == 1)
            {
                Console.WriteLine("Mana");
                mana = Convert.ToInt32(Console.ReadLine());
            }
            Heldenliste.Add(Held_bauen);
        }



        static void Helderstellen()
        {
            string eingabe;
            do
            {
                Console.Clear();

                Console.WriteLine("########");
                Console.WriteLine("Welche Klasse?");
                Console.WriteLine("Magier : 1");
                Console.WriteLine("Krieger : 2");
                Console.WriteLine("Bösewicht : 3");
                Console.WriteLine("########");
                eingabe = Convert.ToString(Console.ReadKey());
                werte_eingeben(Convert.ToInt32(eingabe));

            } while (eingabe != "x" || eingabe != "X");

        }
        
        
        

        static void Main(string[] args)
        {
            Held held2;
            Held held1;
             List<Held> Heldenliste = new List<Held>();

            string eingabe;
            do
            {
                Console.Clear();

                Console.WriteLine("########");
                Console.WriteLine("Held Erstellen : 1");
                Console.WriteLine("Helden anzeigen : 1");
                Console.WriteLine("Kämpfen gegeneinnander");
                Console.WriteLine("########");
                eingabe = Convert.ToString(Console.ReadKey());
                switch (eingabe)
                {
                    case "1":
                        
                        Helderstellen();
                        break;
                       


                }

            } while (eingabe != "x" || eingabe != "X");
            
            


        }
    }
}
