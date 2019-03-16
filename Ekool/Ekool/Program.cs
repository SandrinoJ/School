using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ekool
{
    class Program
    {

        static void Main(string[] args)
        {
            #region massiiv
            /* Loo lihtne programm, kus kasutaja saab salvestada massiivi 12 tähemärgi suuruse
             parooli. Parool peab sisaldama ideaalis suur/väikseid tähi ning sümboleid.
             Lisaks on vaja luua kontroll meetod tingimuste kontrollimiseks, kus annad kasutajale
             teada ka tegu on tugeva või nõrga parooliga. Nõrga parooli korral annad talle võimaluse
             parool uuesti teha. */

            // |0|1|2|3|4|5|6|7|8|9|10|11| => parool[4] = "k"

            //char[] parool = new char[12];
            //algus:
            //Console.WriteLine("Enter a 12 character long password.");
            //for (int i = 0; i < parool.Length; i++)
            //{
            //    Console.Write("Enter password {0} character: ", i + 1);
            //    parool[i] = char.Parse(Console.ReadLine());
            //}

            //if (parool.Any(char.IsUpper) == true && parool.Any(char.IsSymbol) == true)
            //{
            //    Console.WriteLine("It's a strong password.");
            //}
            //else
            //{
            //    Console.WriteLine("This is a weak password, consider adding uppercase letters and special characters. Y/N");
            //    ConsoleKeyInfo keyInfo = Console.ReadKey();
            //    if (keyInfo.Key == ConsoleKey.Y) goto algus;
            //    else Console.WriteLine("You're an idiot, hope you get cyber randsomed.");
            //}

            //// ühe korraga kogu sõa massiivi
            //Console.WriteLine("Enter a 12 character long password.");
            //StringBuilder secret = new StringBuilder(Console.ReadLine());
            //char[] passWord = secret.ToString().ToCharArray();
            //Console.WriteLine();
            //foreach (char item in passWord)
            //{
            //    Console.Write(item);
            //}
            #endregion

            #region List
            /* Non-generic collection:
             * ArrayList
             * SortedList
             * Stack
             * Queue
             * Hastable
             * BitArray
             * */

            /* Õpilaste arvu ei ole antud, õpetaja ise otsustab.
             * Loo programm, kus õpetaja saab salvestada nimekirja õpilaste nimed, hinded ja puudumised.
             * Lisaks on tal võimalik nimekirjast otsida õpilast nime järgi ning siis näha tema hindeid ja puudumisi
             * Võimalik kuvada kogu õpilaste nimekiri tulemustega.
            */
            #endregion
            Console.OutputEncoding = Encoding.Unicode;
            List<string> opList = new List<string>();
            List<string> teadmineList = new List<string>();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
        algus:
            Console.WriteLine("1.õpilaste nimekiri:\n2.Õpilaste lisamine}\n3.Hinnete sisestamine\n4.Õpilaste leidmine nimekirjast");
            string listid = Console.ReadLine();

            if (listid == "1")
            {
                Opilastenim(opList, teadmineList);
            }
            else if (listid == "2")
            {
                Opilastelist(ref opList);
            }
            else if (listid == "3")
            {
                Hinded(ref teadmineList, opList);
            }
            else if (listid == "4")
            {
                Otsing(opList, teadmineList);
            }
            else
            {
                Console.WriteLine("Sisestage uuesti 1-4. ");
            }
            Console.ReadKey();
            Console.Clear();
            goto algus;


        }
        // Õpilaste lisamine !!
        static void Opilastelist(ref List<string> opilane)
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Mitu õpilast te juurte lisada soovite");
            int Opkogus = int.Parse(Console.ReadLine());
            for (int i = 0; i < Opkogus; i++)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Sisestage õpilase nimi: {0}", i + 1); //;
                opilane.Add(Console.ReadLine());
            }
            Console.Clear();
            Console.ReadKey();
            if (Opkogus > 1)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Teie klassis on nüüd õpilasi \n");
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Teie klassis on nüüd õpilasi \n");
            }
            foreach (string Kogus in opilane)
            {
                Console.WriteLine(Kogus);
            }
            Console.ResetColor();
            Console.ReadKey();
        }
        static void Opilastenim(List<string> op, List<string> teadmine)
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Opkogus(op.Count);
            Console.WriteLine("Õpilasi on teie klassis:\n");
            for (int i = 0; i < op.Count; i++)
            {
                Console.WriteLine("Õpilane {0}", op[i]);
            }
            if (teadmine.Count == op.Count)
            {
                Console.WriteLine("Hinne: {0}\n", teadmine);
            }
            else
            {
                Console.WriteLine("Hinne puudub\n");
            }
            Console.ResetColor();
            Console.ReadKey();
        }
        static void Opkogus(int kogus)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Teie klassis on {0} õpilast", kogus);
            Console.ResetColor();
        }

        static void Hinded(ref List<string> teadmine, List<string> opilane)
        {
        algus:
            teadmine.Clear();
            foreach (var VARIABLE in opilane)
            {
                string hinne = " ";
                Opkogus((opilane.Count));
                Console.WriteLine("Sisestage hinne {0}", VARIABLE);
                Console.WriteLine("1.Hinne x, 2.Hinne 2, 3.Hinne 3, 4.Hinne 4, 5.Hinne 5, 6.Puudumine-P");
                int hindas;
                hindas = int.Parse(Console.ReadLine());
                switch (hindas)
                {
                    case 1:
                        hinne = "x";
                        break;
                    case 2:
                        hinne = "2";
                        break;
                    case 3:
                        hinne = "3";
                        break;
                    case 4:
                        hinne = "4";
                        break;
                    case 5:
                        hinne = "5";
                        break;
                    case 6:
                        hinne = "P";
                        break;
                    default:
                        Console.WriteLine("Sisestage uuesti 1-6 või muidu saan vihaseks");
                        goto algus;
                }
                teadmine.Add(hinne);
            }

            for (int j = 0; j < opilane.Count; j++)
            {
                Console.WriteLine("õpilane {0}", opilane[j]);
                Console.WriteLine("Hinne {0} \n", teadmine[j]);
                Console.WriteLine();
            }

            Console.ReadKey();
        }

        static void Otsing(List<string> op, List<string> teadmine)
        {
            Opkogus(op.Count);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Black;
         
            int i = 1;
            Console.WriteLine("Millist õpilast te soovite leida? Sisestage nimi:");
            string otsing1 = Console.ReadLine();
            if (op.Contains(otsing1))
            {
                Console.WriteLine("Otsing: {0}", op[op.IndexOf(otsing1)]);
                if (teadmine.Count > 0)
                {
                    Console.WriteLine("Hinne: {0}", teadmine[op.IndexOf(otsing1)]);
                }
                else
                {
                    Console.WriteLine("Hinne puudub");
                }
            }
            else
            {
                Console.WriteLine("Nimekirjas pole sellist õpilast, kontrollige kas nimi on õigesti sisestatud! ");
            }
            Console.ResetColor();
            Console.ReadKey();
        }
    }
}