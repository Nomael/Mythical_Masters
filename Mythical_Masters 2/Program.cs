using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Mythical_Masters_2
{
    internal class Program
    {

        static Held Heldenwerte(Held Figur)
        {
            int eingabe = 0;
            string name;

            Console.Clear();

            Console.WriteLine("########");
            Console.WriteLine("Gebe einen Namen ein : ");
            name = Convert.ToString(Console.ReadLine());
            Figur.name = name;
            Console.WriteLine("Gib die Stärke an : ");
            eingabe = Convert.ToInt32(Console.ReadLine());
            Figur.Stärke = eingabe;
            Console.WriteLine("Gib Geschick : ");
            eingabe = Convert.ToInt32(Console.ReadLine());
            Figur.Geschieck = eingabe;
            Console.WriteLine("Gib Intelligenz : ");
            eingabe = Convert.ToInt32(Console.ReadLine());
            Figur.Intilligenz = eingabe;

            // Überprüfen, ob es sich um einen Magier handelt und falls ja, Mana setzen
            if (Figur is Magier)
            {
                Console.WriteLine("Gib Mana : ");
                eingabe = Convert.ToInt32(Console.ReadLine());
                ((Magier)Figur).mana = eingabe; // Hier setzen wir Mana für den Magier
            }
            if(Figur is Schurke)
            {
                Console.WriteLine("Gib Täuschung : ");
                eingabe = Convert.ToInt32(Console.ReadLine());
                ((Schurke)Figur).Täuschung = eingabe;

            }
            if (Figur is Krieger)
            {
                Console.WriteLine("Gib Wut : ");
                eingabe = Convert.ToInt32(Console.ReadLine());
                ((Krieger)Figur).Wut = eingabe;

            }

            Console.WriteLine("(END) = Zurück");
            Console.WriteLine("########");
            Console.Clear() ;
            return Figur;
        }


        static Held Heldmachen()
        {
            Held Figur = null;
            string eingabe;
            do
            {
                Console.Clear();

                Console.WriteLine("########");
                Console.WriteLine("Magier Erstellen : 1");
                Console.WriteLine("Krieger Erstellen : 2");
                Console.WriteLine("Schurke Erstellen : 3");
                Console.WriteLine("(END) = Zurück");
                Console.WriteLine("########");
                eingabe = Convert.ToString(Console.ReadLine()).ToLower();
                switch (eingabe)
                {
                    case "1":
                        Figur = new Magier();
                        Figur = Heldenwerte(Figur);
                        goto default;
                    case "2":
                        Figur = new Krieger();
                        Figur = Heldenwerte(Figur);
                        goto default;
                    case "3":
                        Figur = new Schurke();
                        Figur = Heldenwerte(Figur);
                        goto default;


                    default:
                        eingabe = "end";
                        break;




                }

            } while (eingabe != "end");
            return Figur;

        }
        static void ZeigeHeldenliste(List<Held> heldenListe)
        {
            Console.WriteLine("### Heldenliste ###");
            foreach (Held figur in heldenListe)
            {
                Console.WriteLine($"Klasse: {figur.GetType().Name}");
                Console.WriteLine($"Name: {figur.name}");
                Console.WriteLine($"Stärke: {figur.Stärke}");
                Console.WriteLine($"Geschick: {figur.Geschieck}");
                Console.WriteLine($"Intelligenz: {figur.Intilligenz}");

                if (figur is Magier)
                {
                    Console.WriteLine($"Mana: {((Magier)figur).mana}");
                }
                else if (figur is Schurke)
                {
                    Console.WriteLine($"Täuschung: {((Schurke)figur).Täuschung}");
                }
                else if (figur is Krieger)
                {
                    Console.WriteLine($"Wut: {((Krieger)figur).Wut}");
                }

                Console.WriteLine("###");
            }
            Console.WriteLine("### Ende der Heldenliste ###");
        }



        static void Main(string[] args)
        {
            List<Held> Heldenliste = new List<Held>();

            string eingabe;
            do
            {
                Console.Clear();

                Console.WriteLine("########");
                Console.WriteLine("Held Erstellen : 1");
                Console.WriteLine("Helden anzeigen : 2");
                Console.WriteLine("gegeneinnander Kämpfen : 3");
                Console.WriteLine("(END) zum beenden");
                Console.WriteLine("########");
                eingabe = Convert.ToString(Console.ReadLine()).ToLower();
                switch (eingabe)
                {
                    case "1":
                        
                        Held TestHeld = Heldmachen();
                        if (TestHeld != null)
                        {
                            Heldenliste.Add(TestHeld);
                            Console.WriteLine(Heldenliste[0].name);
                            Console.ReadKey();
                        };
                        break;
                    case "2":
                        ZeigeHeldenliste(Heldenliste);
                        Console.ReadKey();

                        break;




                }

            } while (eingabe != "end");




        }
    }
}
