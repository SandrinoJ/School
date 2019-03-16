using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juku_Koolis
{
    class Program
    {
        static void Main(string[] args)
        {
            int jukutuju = 100;
            Console.OutputEncoding = Encoding.Unicode;
            //mmenuuuu
            Console.WriteLine("Juku läheb kooli ja tal on tuju {0}%", jukutuju);
            Console.WriteLine("1. tund Programmeerimine\n2. tund Eesti keel\n3. tund Inglise keel\n4. tund Lõuna\n5. tund Keemia\n6. tund Matemaatika\n7. tund Operatsiooni süsteemide alused");
            Console.ReadKey();
            Console.Clear();
            //Juku tujud
            if (jukutuju >= 50)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Juku tuju on {0}", jukutuju);
                Console.ResetColor();
            }
            if (jukutuju <= 49 && jukutuju >= 15)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Jukul on kerge masendus {0}", jukutuju);
                Console.ResetColor();
            }
            if (jukutuju <= 14 && jukutuju >= 1)
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("Juku mõtleb koolist ära minna {0}", jukutuju);
                Console.ResetColor();
            }
            if (jukutuju < 1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Jukul on väga halb tuju ja peab arsti juurde minema {0}", jukutuju);
                Console.ResetColor();
            }
            Console.ReadKey();
            int juhtum, hinne;
            //jukul tuleb kt toode esitlemine
            string[] töö = { "kontrolltöö", "kodutööde esitlemine", "tunnikontroll" };
            Random rng = new Random();
            juhtum = rng.Next(0, 3);
            hinne = rng.Next(1, 6);
            //esimene tund
            Console.WriteLine("Esimene tund: Programeerimine\nÕpetaja ütles, et tana tuleb {0}", töö[juhtum]);

            //hinde saamine
            Console.WriteLine("Juku sai hinne {0}", hinne);
            if (hinne == 1)
            {
                Console.WriteLine("Juku sai hinde {0}", hinne);
            }
            switch (hinne)
            {
                case 1:
                    jukutuju -= 75;
                    break;
                case 2:
                    jukutuju -= 50;
                    break;
                case 3:
                    jukutuju -= 40;
                    break;
                case 4:
                    jukutuju -= 30;
                    break;
                case 5:
                    jukutuju -= 20;
                    break;
                default:
                    jukutuju -= 1;
                    break;
            }
            if (jukutuju < 0)
            {
                jukutuju = 0;
            }
            if (jukutuju >= 50)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Juku tuju on {0}", jukutuju);
                Console.ResetColor();
            }
            if (jukutuju <= 49 && jukutuju >= 15)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Jukul on kerge masendus {0}", jukutuju);
                Console.ResetColor();
            }
            if (jukutuju <= 14 && jukutuju >= 1)
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("Juku mõtleb koolist ära minna {0}", jukutuju);
                Console.ResetColor();
            }
            if (jukutuju < 1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Jukul on väga halb tuju ja ta läheb arsti juurde, et oma tuju tõsta +15 ");
                jukutuju += 15;
                Console.ResetColor();
            }
            ////////TUNDDDD 2222

            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Teine tund: Eesti keel\nÕpetaja ütles, et tana tuleb {0}", töö[juhtum]);
            juhtum = rng.Next(0, 3);
            hinne = rng.Next(1, 6);
            Console.WriteLine("Juku sai hinne {0}", hinne);
            if (hinne == 1)
            {
                Console.WriteLine("Juku sai hinde {0}", hinne);
            }
            switch (hinne)
            {
                case 1:
                    jukutuju -= 75;
                    break;
                case 2:
                    jukutuju -= 50;
                    break;
                case 3:
                    jukutuju -= 40;
                    break;
                case 4:
                    jukutuju -= 30;
                    break;
                case 5:
                    jukutuju -= 20;
                    break;
                default:
                    jukutuju -= 1;
                    break;
            }
            if (jukutuju < 0)
            {
                jukutuju = 0;
            }
            if (jukutuju >= 50)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Juku tuju on {0}", jukutuju);
                Console.ResetColor();
            }
            if (jukutuju <= 49 && jukutuju >= 15)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Jukul on kerge masendus {0}", jukutuju);
                Console.ResetColor();
            }
            if (jukutuju <= 14 && jukutuju >= 1)
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("Juku mõtleb koolist ära minna {0}", jukutuju);
                Console.ResetColor();
            }
            if (jukutuju < 1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Jukul on väga halb tuju ja ta läheb arsti juurde, et oma tuju tõsta +15 ");
                jukutuju += 15;
                Console.ResetColor();
            }
            ///tund 3
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Kolmas tund: Inglise keel\nÕpetaja ütles, et tana tuleb {0}", töö[juhtum]);
            juhtum = rng.Next(0, 3);
            hinne = rng.Next(1, 6);
            Console.WriteLine("Juku sai hinne {0}", hinne);
            if (hinne == 1)
            {
                Console.WriteLine("Juku sai hinde {0}", hinne);
            }
            switch (hinne)
            {
                case 1:
                    jukutuju -= 75;
                    break;
                case 2:
                    jukutuju -= 50;
                    break;
                case 3:
                    jukutuju -= 40;
                    break;
                case 4:
                    jukutuju -= 30;
                    break;
                case 5:
                    jukutuju -= 20;
                    break;
                default:
                    jukutuju -= 1;
                    break;
            }
            if (jukutuju < 0)
            {
                jukutuju = 0;
            }
            if (jukutuju >= 50)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Juku tuju on {0}", jukutuju);
                Console.ResetColor();
            }
            if (jukutuju <= 49 && jukutuju >= 15)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Jukul on kerge masendus {0}", jukutuju);
                Console.ResetColor();
            }
            if (jukutuju <= 14 && jukutuju >= 1)
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("Juku mõtleb koolist ära minna {0}", jukutuju);
                Console.ResetColor();
            }
            if (jukutuju < 1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Jukul on väga halb tuju ja ta läheb arsti juurde, et oma tuju tõsta +15 ");
                jukutuju += 15;
                Console.ResetColor();
            }
            Console.ReadKey();
            Console.Clear();
            //////////tund 4
            Console.WriteLine("Neljas tund: Juku läheb sööma, et tuju paremaks saada");
            ///louna 
            Console.WriteLine("1.Värskekapsa borš sealihaga\n2.Värskekapsa borš sealihaga\n3.Friikartulid viineritega\n4.Köögiviljavormiroog\n5.Praetud kanafilee");
            int valik = int.Parse(Console.ReadLine());
            switch (valik)
            {
                case 1:
                    Console.WriteLine("Värskekapsa borš sealihaga");
                    jukutuju += 20;
                    break;
                case 2:
                    Console.WriteLine("Makaronid hakklihaga");
                    jukutuju += 25;
                    break;
                case 3:
                    Console.WriteLine("Friikartulid viineritega");
                    jukutuju += 15;
                    break;
                case 4:
                    Console.WriteLine("Köögiviljavormiroog");
                    jukutuju += 10;
                    break;
                case 5:
                    Console.WriteLine("Praetud kanafilee");
                    jukutuju += 50;
                    break;

                default:
                    break;

            }
            if (jukutuju < 0)
            {
                jukutuju = 0;
            }
            if (jukutuju >= 50)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Juku tuju on {0}", jukutuju);
                Console.ResetColor();
            }
            if (jukutuju <= 49 && jukutuju >= 15)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Jukul on kerge masendus {0}", jukutuju);
                Console.ResetColor();
            }
            if (jukutuju <= 14 && jukutuju >= 1)
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("Juku mõtleb koolist ära minna {0}", jukutuju);
                Console.ResetColor();
            }
            if (jukutuju < 1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Jukul on väga halb tuju ja ta läheb arsti juurde, et oma tuju tõsta +15 ");
                jukutuju += 15;
                Console.ResetColor();
            }
            Console.WriteLine("Juku sõi kõhu täis ja tal hakkas parem");
            Console.ReadKey();
            Console.Clear();

            ///////////tund 5
            Console.WriteLine("Viies tund: Keemia\nÕpetaja ütles, et tana tuleb {0}", töö[juhtum]);
            juhtum = rng.Next(0, 3);
            hinne = rng.Next(1, 6);
            Console.WriteLine("Juku sai hinne {0}", hinne);
            if (hinne == 1)
            {
                Console.WriteLine("Juku sai hinde {0}", hinne);
            }
            switch (hinne)
            {
                case 1:
                    jukutuju -= 75;
                    break;
                case 2:
                    jukutuju -= 50;
                    break;
                case 3:
                    jukutuju -= 40;
                    break;
                case 4:
                    jukutuju -= 30;
                    break;
                case 5:
                    jukutuju -= 20;
                    break;
                default:
                    jukutuju -= 1;
                    break;
            }
            if (jukutuju < 0)
            {
                jukutuju = 0;
            }
            if (jukutuju >= 50)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Juku tuju on {0}", jukutuju);
                Console.ResetColor();
            }
            if (jukutuju <= 49 && jukutuju >= 15)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Jukul on kerge masendus {0}", jukutuju);
                Console.ResetColor();
            }
            if (jukutuju <= 14 && jukutuju >= 1)
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("Juku mõtleb koolist ära minna {0}", jukutuju);
                Console.ResetColor();
            }
                if (jukutuju < 1)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Jukul on väga halb tuju ja ta läheb arsti juurde, et oma tuju tõsta +15 ");
                    jukutuju += 15;
                    Console.ResetColor();
                }
            Console.ReadKey();
            Console.Clear();
            ///////////tund 6
            Console.WriteLine("Kuues tund: Matemaatika\nÕpetaja ütles, et tana tuleb {0}", töö[juhtum]);
            juhtum = rng.Next(0, 3);
            hinne = rng.Next(1, 6);
            Console.WriteLine("Juku sai hinne {0}", hinne);
            if (hinne == 1)
            {
                Console.WriteLine("Juku sai hinde {0}", hinne);
            }
            switch (hinne)
            {
                case 1:
                    jukutuju -= 75;
                    break;
                case 2:
                    jukutuju -= 50;
                    break;
                case 3:
                    jukutuju -= 40;
                    break;
                case 4:
                    jukutuju -= 30;
                    break;
                case 5:
                    jukutuju -= 20;
                    break;
                default:
                    jukutuju -= 1;
                    break;
            }
            if (jukutuju < 0)
            {
                jukutuju = 0;
            }
            if (jukutuju >= 50)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Juku tuju on {0}", jukutuju);
                Console.ResetColor();
            }
            if (jukutuju <= 49 && jukutuju >= 15)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Jukul on kerge masendus {0}", jukutuju);
                Console.ResetColor();
            }
            if (jukutuju <= 14 && jukutuju >= 1)
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("Juku mõtleb koolist ära minna {0}", jukutuju);
                Console.ResetColor();
            }
            if (jukutuju < 1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Jukul on väga halb tuju ja ta läheb arsti juurde, et oma tuju tõsta +15 ");
                jukutuju += 15;
                Console.ResetColor();
            }
            Console.ReadKey();
            Console.Clear();
            ///////////tund 7
            Console.WriteLine("Seitsmes tund: Operatsiooni süsteemide alused\nÕpetaja ütles, et tana tuleb {0}", töö[juhtum]);
            juhtum = rng.Next(0, 3);
            hinne = rng.Next(1, 6);
            Console.WriteLine("Juku sai hinne {0}", hinne);
            if (hinne == 1)
            {
                Console.WriteLine("Juku sai hinde {0}", hinne);
            }
            switch (hinne)
            {
                case 1:
                    jukutuju -= 75;
                    break;
                case 2:
                    jukutuju -= 50;
                    break;
                case 3:
                    jukutuju -= 40;
                    break;
                case 4:
                    jukutuju -= 30;
                    break;
                case 5:
                    jukutuju -= 20;
                    break;
                default:
                    jukutuju -= 1;
                    break;
            }
            if (jukutuju < 0)
            {
                jukutuju = 0;
            }
            if (jukutuju >= 50)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Juku tuju on {0}", jukutuju);
                Console.ResetColor();
            }
            if (jukutuju <= 49 && jukutuju >= 15)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Jukul on kerge masendus {0}", jukutuju);
                Console.ResetColor();
            }
            if (jukutuju <= 14 && jukutuju >= 1)
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("Juku mõtleb koolist ära minna {0}", jukutuju);
                Console.ResetColor();
            }
            if (jukutuju < 1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Jukul on väga halb tuju ja ta läheb arsti juurde, et oma tuju tõsta +15 ");
                jukutuju += 15;
                Console.ResetColor();
            }

            Console.ReadKey();
            Console.Clear();
        }
    }
}   
