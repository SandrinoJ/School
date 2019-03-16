using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Menüü vormistamine 
            menu:

            Console.Clear();
            int rng1, menuSelection = 0, võrdVastus, counter=0, liitmine1=0, liitmine2=0;
            menu1:
            Console.WriteLine("Tere Juku!, millist teadmist soovite omandada?");
            Console.WriteLine("1.Liitmine\n2.Lahutamine\n3.Korrutamine\n4.Jagamine");
            Random rng = new Random ();
            ConsoleKey valik = Console.ReadKey(true).Key;
            Console.Clear();
            rng1 = rng.Next(1,15);



            switch (valik)
            {
                case ConsoleKey.D1:
                Console.WriteLine("1.Liitmine");
                    Console.ReadKey();
                    menuSelection = 1;
                    break;
                case ConsoleKey.D2:
                    Console.Write("2.Lahutamine");
                    menuSelection = 2;
                    break;
                case ConsoleKey.D3:
                    Console.WriteLine("3.Korrutamine");
                    menuSelection =3;
                    break;
                case ConsoleKey.D4:
                    Console.WriteLine("4.Jagamine");
                    menuSelection = 4;
                    break;
                case ConsoleKey.Subtract:
                    counter = 14;
                    goto menu1;
                   
                default:
                    Console.WriteLine("Palun sisestage uuesti 1-4!");
                    goto menu;
            }
            //arvutuse vormistamine
            while (menuSelection==1)
            {
                liitmineGo:
                Console.Clear();
                liitmine1 = rng.Next(1,15);
                liitmine2 = rng.Next(1,15);
                võrdVastus = liitmine1 + liitmine2;
                Console.WriteLine("{0} + {1}=____", liitmine1, liitmine2);
                int õigearv = int.Parse(Console.ReadLine());
                if (võrdVastus==õigearv)
                {
                    Console.Clear();
                    Console.WriteLine("Oled tubli vastus on õige!");
                    Console.ReadKey();
                    counter += 1;
                }
                else
                {
                    Console.WriteLine("Vale vastus proovi uuesti!!");
                    Console.ReadKey();
                    goto liitmineGo;
                }
                if (counter > 5)
                {
                    Console.Clear();
                    Console.WriteLine("Väga tubli, nüüd on raskemad ülesanded");
                    Console.ReadKey();
                    Console.Clear();
                    liitmineGo1:
                    Console.Clear();
                    liitmine1 = rng.Next(1, 100);
                    liitmine2 = rng.Next(1, 100);
                    võrdVastus = liitmine1 + liitmine2;
                    Console.WriteLine("{0} + {1}=____", liitmine1, liitmine2);
                    õigearv = int.Parse(Console.ReadLine());
                    if (võrdVastus == õigearv)
                    {
                        Console.Clear();
                        Console.WriteLine("Oled tubli vastus on õige!");
                        Console.ReadKey();
                        counter += 1;
                        

                        if (counter > 15)
                        {
                            Console.WriteLine("Sa oled lõpetanud liitmise ülesanded");
                            Console.ReadKey();
                            goto menu;
                            
                        }
                        goto liitmineGo1;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Vale vastus proovi uuesti!!");
                        Console.ReadKey();
                        goto liitmineGo1;
                    }
                    
                }
            }
            /////////////////////////////LAHUTAMINE//////////////////////////////////////////
            while (menuSelection == 2)
            {
                lahutamineGo:
                Console.Clear();
                liitmine1 = rng.Next(1, 15);
                liitmine2 = rng.Next(1, 15);
                võrdVastus = liitmine1 - liitmine2;
                Console.WriteLine("{0} - {1}=____", liitmine1, liitmine2);
                int õigearv = int.Parse(Console.ReadLine());
                if (võrdVastus == õigearv)
                {
                    Console.Clear();
                    Console.WriteLine("Oled tubli vastus on õige!");
                    Console.ReadKey();
                    counter += 1;
                }
                else
                {
                    Console.WriteLine("Vale vastus proovi uuesti!!");
                    Console.ReadKey();
                    goto lahutamineGo;
                }
                if (counter > 5)
                {
                    Console.Clear();
                    Console.WriteLine("Väga tubli, nüüd on raskemad ülesanded");
                    Console.ReadKey();
                    Console.Clear();
                    lahutamineGo1:
                    Console.Clear();
                    liitmine1 = rng.Next(1, 100);
                    liitmine2 = rng.Next(1, 100);
                    võrdVastus = liitmine1 - liitmine2;
                    Console.WriteLine("{0} - {1}=____", liitmine1, liitmine2);
                    õigearv = int.Parse(Console.ReadLine());
                    if (võrdVastus == õigearv)
                    {
                        Console.Clear();
                        Console.WriteLine("Oled tubli vastus on õige!");
                        Console.ReadKey();
                        counter += 1;


                        if (counter > 15)
                        {
                            Console.WriteLine("Sa oled lõpetanud liitmise ülesanded");
                            Console.ReadKey();
                            goto menu;

                        }
                        goto lahutamineGo1;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Vale vastus proovi uuesti!!");
                        Console.ReadKey();
                        goto lahutamineGo1;
                    }

                }
            }
            //////////////////////////KORRRUTAMINE////////////////////////
            while (menuSelection == 3)
            {
                korrutamineGo:
                Console.Clear();
                liitmine1 = rng.Next(1, 15);
                liitmine2 = rng.Next(1, 15);
                võrdVastus = liitmine1 * liitmine2;
                Console.WriteLine("{0} * {1}=____", liitmine1, liitmine2);
                int õigearv = int.Parse(Console.ReadLine());
                if (võrdVastus == õigearv)
                {
                    Console.Clear();
                    Console.WriteLine("Oled tubli vastus on õige!");
                    Console.ReadKey();
                    counter += 1;
                }
                else
                {
                    Console.WriteLine("Vale vastus proovi uuesti!!");
                    Console.ReadKey();
                    goto korrutamineGo;
                }
                if (counter > 5)
                {
                    Console.Clear();
                    Console.WriteLine("Väga tubli, nüüd on raskemad ülesanded");
                    Console.ReadKey();
                    Console.Clear();
                    korrutamineGo1:
                    Console.Clear();
                    liitmine1 = rng.Next(1, 100);
                    liitmine2 = rng.Next(1, 100);
                    võrdVastus = liitmine1 * liitmine2;
                    Console.WriteLine("{0} * {1}=____", liitmine1, liitmine2);
                    õigearv = int.Parse(Console.ReadLine());
                    if (võrdVastus == õigearv)
                    {
                        Console.Clear();
                        Console.WriteLine("Oled tubli vastus on õige!");
                        Console.ReadKey();
                        counter += 1;


                        if (counter > 15)
                        {
                            Console.WriteLine("Sa oled lõpetanud liitmise ülesanded");
                            Console.ReadKey();
                            goto menu;

                        }
                        goto korrutamineGo1;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Vale vastus proovi uuesti!!");
                        Console.ReadKey();
                        goto korrutamineGo1;
                    }

                }
            }
            /////////////////////////////JAGAMINE RAISK///////////
            while (menuSelection == 4)
            {
                jagamineGo:
                Console.Clear();
                double jagamine1F = Convert.ToDouble(rng.Next(1, 15));
                double jagamine2F = Convert.ToDouble(rng.Next(1, 15));
                double võrdVastusd = jagamine1F / jagamine2F;
                Console.WriteLine("{0} / {1}=____", jagamine1F, jagamine2F);
                string tempf4 = võrdVastusd.ToString("0.00");
                string tempf5 = võrdVastusd.ToString("0.0");
                string tempf6 = võrdVastusd.ToString("0");
                string õigearvs = Console.ReadLine();
                if (tempf4 == õigearvs || tempf5 == õigearvs || tempf6==õigearvs)
                {
                    Console.Clear();
                    Console.WriteLine("Oled tubli vastus on õige!");
                    Console.ReadKey();
                    counter += 1;
                }
                else
                {
                    Console.WriteLine("Vale vastus proovi uuesti!!");
                    Console.ReadKey();
                    goto jagamineGo;
                }
                if (counter > 5)
                {
                    Console.Clear();
                    Console.WriteLine("Väga tubli, nüüd on raskemad ülesanded");
                    Console.ReadKey();
                    Console.Clear();
                    jagamineGo1:
                    Console.Clear();
                    jagamine1F = Convert.ToDouble(rng.Next(1, 100));
                    jagamine2F = Convert.ToDouble(rng.Next(1, 100));
                    võrdVastusd = jagamine1F / jagamine2F;
                    Console.WriteLine("{0} / {1}=____", jagamine1F, jagamine2F);
                     tempf4 = võrdVastusd.ToString("0.00");
                     tempf5 = võrdVastusd.ToString("0.0");
                     tempf6 = võrdVastusd.ToString("0");
                     õigearvs = Console.ReadLine();
                    if (tempf4 == õigearvs || tempf5 == õigearvs || tempf6 == õigearvs)
                    {
                        Console.Clear();
                        Console.WriteLine("Oled tubli vastus on õige!");
                        Console.ReadKey();
                        counter += 1;


                        if (counter > 15)
                        {
                            Console.WriteLine("Sa oled lõpetanud liitmise ülesanded");
                            Console.ReadKey();
                            goto menu;

                        }
                        goto jagamineGo1;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Vale vastus proovi uuesti!!");
                        Console.ReadKey();
                        goto jagamineGo1;
                    }

                }
            }
            
        }
    }
}
