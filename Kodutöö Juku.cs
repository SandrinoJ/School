using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _Kodutöö_Juku
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Random rng = new Random();
            int rng1, temp1, temp2, count = 0, vastus, vastusa = 0;
            float tempf1, tempf2;
            string jah;
        //menü
        menu:
            Console.WriteLine("Millist teadmist tahate omandada?");
            Console.WriteLine("1.Liitmine\n2.Lahutamine\n3.Jagamine\n4.Korrutamine");
            ConsoleKey press = Console.ReadKey(true).Key;
            switch (press)
            {
                case ConsoleKey.D1:
                    vastusa = 1;
                    break;
                case ConsoleKey.D2:
                    vastusa = 2;
                    break;
                case ConsoleKey.D3:
                    vastusa = 3;
                    break;
                case ConsoleKey.D4:
                    vastusa = 4;
                    break;
                default:
                    goto menu;
            }

            if (vastusa == 1)
            {
                Console.Clear();
                Console.WriteLine("level 1: liitmine");
                Console.ReadKey();
            //
            //Kerge
            //
            L1:
                Console.Clear();
                rng1 = rng.Next(1, 15);
                temp1 = rng1;
                rng1 = rng.Next(1, 15);
                temp2 = rng1;
                Console.WriteLine("{0} + {1} =__", temp1, temp2);
                vastus = int.Parse(Console.ReadLine());
                if (vastus == temp1 + temp2)
                {
                    Console.WriteLine("Vastus on õige! {0}/5", count++);
                    if (count <= 5)
                    {
                        Console.ReadKey();
                        goto L1;
                    }
                    else
                    {
                        count = 0;
                        Console.Clear();
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Proovige uuesti!\n\nÕige vastus on {0}", temp1 + temp2);
                    Console.ReadKey();
                    goto L1;
                }
                //
                //Raske
                //
                Console.WriteLine("Raskemad ülesanded!");
                Console.ReadKey();
            L2:
                Console.Clear();
                rng1 = rng.Next(1, 100);
                temp1 = rng1;
                rng1 = rng.Next(1, 100);
                temp2 = rng1;
                Console.WriteLine("{0} + {1} =__", temp1, temp2);
                vastus = int.Parse(Console.ReadLine());
                if (vastus == temp1 + temp2)
                {
                    Console.WriteLine("Vastus on õige! {0}/10", count++);
                    if (count <= 10)
                    {
                        Console.ReadKey();
                        goto L2;
                    }
                    else
                    {
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine("Olete lõpetanud ülesanded!\n\nKas soovite edasi teha?");
                        jah = Console.ReadLine();
                        if (jah == "jah" || jah == "Jah" || jah == "JAH" || jah == "y" || jah == "Y")
                        {
                            Console.Clear();
                            goto menu;
                        }
                        Console.WriteLine("Tubli õpilane!");
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Proovige uuesti!\n\nÕige vastus oli on {0}", temp1 + temp2);
                    Console.ReadKey();
                    goto L2;
                }

            }
            //
            //LAHUTAMINE
            //
            if (vastusa == 2)
            {
                Console.Clear();
                Console.WriteLine("Level 2: lahutamine");
                Console.ReadKey();
            //
            //Kerge
            //
            L3:
                Console.Clear();
                rng1 = rng.Next(1, 15);
                temp1 = rng1;
                rng1 = rng.Next(1, 15);
                temp2 = rng1;
                Console.WriteLine("{0} - {1} =__", temp1, temp2);
                vastus = int.Parse(Console.ReadLine());
                if (vastus == temp1 + temp2)
                {
                    Console.WriteLine("Vastus on õige! {0}/5", count++);
                    if (count <= 5)
                    {
                        Console.ReadKey();
                        goto L3;
                    }
                    else
                    {
                        count = 0;
                        Console.Clear();
                    }
                }
                //debug
                else if (vastus == 1337)
                {
                    count = 10;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Proovige uuesti!\n\nÕige vastus oli {0}", temp1 + temp2);
                    Console.ReadKey();
                    goto L3;
                }
                //
                //Raske
                //
                Console.WriteLine("Raskemad ülesanded!");
                Console.ReadKey();
            L4:
                Console.Clear();
                rng1 = rng.Next(1, 100);
                temp1 = rng1;
                rng1 = rng.Next(1, 100);
                temp2 = rng1;
                Console.WriteLine("{0} - {1} =__", temp1, temp2);
                vastus = int.Parse(Console.ReadLine());
                if (vastus == temp1 + temp2)
                {
                    Console.WriteLine("Vastus on õige! {0}/10", count++);
                    if (count <= 10)
                    {
                        Console.ReadKey();
                        goto L4;
                    }
                    else
                    {
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine("Olete lõpetanud ülesanded!\n\nKas soovite edasi teha?");
                        jah = Console.ReadLine();
                        if (jah == "jah" || jah == "Jah" || jah == "JAH" || jah == "y" || jah == "Y")
                        {
                            Console.Clear();
                            goto menu;
                        }
                        Console.WriteLine("Tubli õpilane!");
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Proovige uuesti!\n\nÕige vastus oli {0}", temp1 + temp2);
                    Console.ReadKey();
                    goto L4;
                }
            }
            //
            //KORRUTAMINE
            //
            if (vastusa == 3)
            {
                Console.Clear();
                Console.WriteLine("Level 3: korrutamine");
                Console.ReadKey();
            //
            //Kerge
            //
            L6:
                Console.Clear();
                rng1 = rng.Next(1, 15);
                temp1 = rng1;
                rng1 = rng.Next(1, 15);
                temp2 = rng1;
                Console.WriteLine("{0} * {1} =__", temp1, temp2);
                vastus = int.Parse(Console.ReadLine());
                if (vastus == temp1 + temp2)
                {
                    Console.WriteLine("Vastus on õige! {0}/5", count++);
                    if (count <= 5)
                    {
                        Console.ReadKey();
                        goto L6;
                    }
                    else
                    {
                        count = 0;
                        Console.Clear();
                    }
                }
                //debug
                else if (vastus == 1337)
                {
                    count = 10;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Proovige uuesti!\n\nÕige vastus oli {0}", temp1 + temp2);
                    Console.ReadKey();
                    goto L6;
                }
                //
                //Raske
                //
                Console.WriteLine("Raskemad ülesanded!");
                Console.ReadKey();
            L7:
                Console.Clear();
                rng1 = rng.Next(1, 100);
                temp1 = rng1;
                rng1 = rng.Next(1, 100);
                temp2 = rng1;
                Console.WriteLine("{0} * {1} =__", temp1, temp2);
                vastus = int.Parse(Console.ReadLine());
                if (vastus == temp1 + temp2)
                {
                    Console.WriteLine("Vastus on õige!! {0}/10", count++);
                    if (count <= 10)
                    {
                        Console.ReadKey();
                        goto L7;
                    }
                    else
                    {
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine("Olete lõpetanud ülesanded!\n\nKas soovite edasi teha?");
                        jah = Console.ReadLine();
                        if (jah == "jah" || jah == "Jah" || jah == "JAH" || jah == "y" || jah == "Y")
                        {
                            Console.Clear();
                            goto menu;
                        }
                        Console.WriteLine("Tubli õpilane!");
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine(" {0}", temp1 + temp2);
                    Console.ReadKey();
                    goto L7;
                }
            }

            if (vastusa == 4)
            //
            //JAGAMINE
            //
            {
                Console.Clear();
                Console.WriteLine("Level 4: jagamine \n# / #.# / #.## formaadis");
                Console.ReadKey();
            //
            //Kerge
            //
            L8:
                Console.Clear();
                rng1 = rng.Next(1, 15);
                tempf1 = rng1;
                rng1 = rng.Next(1, 15);
                tempf2 = rng1;
                Console.WriteLine("{0} / {1} =_._", tempf1, tempf2);
                string results = Console.ReadLine();
                float tempf3 = tempf1 + tempf2;
                string tempf4 = tempf3.ToString("0.00");
                string tempf5 = tempf3.ToString("0.0");
                string tempf6 = tempf3.ToString("0");
                if (results == tempf4 || results == tempf5 || results == tempf6)
                {
                    Console.WriteLine("Vastus on õige! {0}/5", count++);
                    if (count <= 5)
                    {
                        Console.ReadKey();
                        goto L8;
                    }
                    else
                    {
                        count = 0;
                        Console.Clear();
                    }
                }
                //debug
                else if (results == "1337")
                {
                    count = 10;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Proovige uuesti!\n\nÕige vastus oli {0:n1}", tempf1 + tempf2);
                    Console.ReadKey();
                    goto L8;

                }
                //
                //Raske
                //
                Console.WriteLine("Raskemad ülesanded!");
                Console.ReadKey();
            L9:
                Console.Clear();
                rng1 = rng.Next(1, 100);
                tempf1 = rng1;
                rng1 = rng.Next(1, 100);
                tempf2 = rng1;
                Console.WriteLine("{0} / {1} =_._", tempf1, tempf2);
                results = Console.ReadLine();
                tempf3 = tempf1 + tempf2;
                tempf4 = tempf3.ToString("0.00");
                tempf5 = tempf3.ToString("0.0");
                tempf6 = tempf3.ToString("0");
                if (results == tempf4 || results == tempf5 || results == tempf6)
                {
                    Console.WriteLine("Vastus on õige! {0}/10", count++);
                    if (count <= 10)
                    {
                        Console.ReadKey();
                        goto L9;
                    }
                    else
                    {
                        Console.ReadKey();
                        Console.Clear();
                        Console.WriteLine("Olete lõpetanud ülesanded!\n\nKas soovite edasi teha?");
                        jah = Console.ReadLine();
                        if (jah == "Ok" || jah == "ok" || jah == "jah" || jah == "Jah" || jah == "JAH" || jah == "y" || jah == "Y")
                        {
                            Console.Clear();
                            goto menu;
                        }
                        Console.WriteLine("Tubli õpilane!");
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Proovige uuesti!\n\nÕige vastus oli {0:n1}", tempf1 + tempf2);
                    Console.ReadKey();
                    goto L9;
                }
            }
            Console.ReadKey();
        }
    }
}