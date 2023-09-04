using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Net;
using System.Net.Sockets;


namespace Mythical_Masters_2
{
    internal class Program
    {
        class Server
        {
            static string get_data()
            {
                // IP-Endpunkt, auf den der Server lauschen wird
                IPEndPoint endPoint = new IPEndPoint(IPAddress.Any, 4201); // Hier die gewünschte Portnummer angeben

                // TCP-Listener erstellen
                TcpListener listener = new TcpListener(endPoint);

                listener.Start();
                Console.WriteLine("Server gestartet. Warte auf Verbindung...");

                // Auf eingehende Verbindung warten
                TcpClient client = listener.AcceptTcpClient();
                Console.WriteLine("Client verbunden.");

                // Daten vom Client empfangen
                NetworkStream stream = client.GetStream();
                byte[] buffer = new byte[1024];
                int bytesRead = stream.Read(buffer, 0, buffer.Length);
                string receivedData = Encoding.ASCII.GetString(buffer, 0, bytesRead);

                Console.WriteLine("Empfangene Daten: " + receivedData);
                Console.ReadKey();
                Console.ReadKey();
                // Hier kannst du die empfangenen Daten weiterverarbeiten

                // Verbindung schließen
                client.Close();
                listener.Stop();
                return receivedData;
            }
        }


        static Held ZufälligeHeldenwerte(Held figur)
        {
            Random zufall = new Random();

            Console.Clear();

            Console.WriteLine("########");
            Console.WriteLine("Gebe einen Namen ein : ");
            string name = Console.ReadLine();

            int stärke = zufall.Next(1, 16); // Zufällige Stärke zwischen 1 und 200
            int geschick = zufall.Next(1, 16); // Zufälliges Geschick zwischen 1 und 200
            int intelligenz = zufall.Next(1, 16); // Zufällige Intelligenz zwischen 1 und 200
           
            figur.Stärke = stärke;
            figur.Geschieck = geschick;
            figur.Intilligenz = intelligenz;
            figur.name= name;
            

            if (figur is Magier)
            {
                int mana = zufall.Next(1, 16); // Zufälliges Mana zwischen 1 und 200
                ((Magier)figur).mana = mana;
                geschick = Math.Abs(intelligenz - stärke);
                figur.Stärke = stärke;

            }
            else if (figur is Schurke)
            {
                int täuschung = zufall.Next(1, 16); // Zufällige Täuschung zwischen 1 und 200
                ((Schurke)figur).Täuschung = täuschung;
                stärke = Math.Abs(geschick - intelligenz);
                figur.Stärke = stärke;
            }
            else if (figur is Krieger)
            {
                int wut = zufall.Next(1, 16); // Zufällige Wut zwischen 1 und 200
                ((Krieger)figur).Wut = wut;
                intelligenz = Math.Abs(stärke - geschick);
                figur.Intilligenz = intelligenz;
                Console.WriteLine(intelligenz + geschick + stärke);
                Console.ReadKey();
            }

            Console.Clear();

            return figur;
        }


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
                        
                       
                        goto default;
                    case "2":
                        Figur = new Krieger();
                       
                        goto default;
                    case "3":
                        Figur = new Schurke();
                        
                        goto default;


                    default:
                        Console.WriteLine("Zufällige werte ? ");
                        Console.WriteLine(" JA : 1 ");
                        Console.WriteLine(" NEIN : 2 ");
                        eingabe = Convert.ToString(Console.ReadLine()).ToLower();
                        if (eingabe == "1")
                        {
                            Figur = ZufälligeHeldenwerte(Figur);
                        }
                        else if (eingabe == "2")
                        {
                            Figur = Heldenwerte(Figur);
                        }
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
                    case "3":

                        break;




                }

            } while (eingabe != "end");




        }
    }
}
