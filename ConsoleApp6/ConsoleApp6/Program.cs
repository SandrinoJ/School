using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace Raamatuh
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta tiitel:");
            string T = Console.ReadLine();
            Console.WriteLine("Sisesta autor:");
            string A = Console.ReadLine();
            Console.WriteLine("Sisesta raamatu hind:");
            decimal H = decimal.Parse(Console.ReadLine());

            Raamat NimeKiri = new Raamat(T, A, H);
            Console.WriteLine("Raamatu nimi: {0}", NimeKiri.raamatunimi);
            Console.WriteLine("Tiitel: {0}", NimeKiri.raamatutiitel);
            Console.WriteLine("Autor: {0}", NimeKiri.raamatuautor);
            Console.WriteLine("Raamatu hind on {0}", NimeKiri.Raamatuhind);
            Console.ReadKey();
        }
    }
    public class Raamat
    {
        //klassi muutujad
        public string raamatunimi;
        public string raamatutiitel;
        public string raamatuautor;
        public decimal raamatuhind;
        //konstruktor 
        public Raamat(string raamatutiitel, string raamatuautor, decimal raamatuhind)
        {
            Raamatutiitel = raamatutiitel;
            Raamatuautor = raamatuautor;
            Raamatuhind = raamatuhind;
        }
        public string Raamatunimi
        {
            get { return raamatunimi; }
            set { raamatunimi = value; }
        }
        public string Raamatutiitel { get { return raamatutiitel; } set { raamatutiitel = value; } }
        public string Raamatuautor { get { return raamatuautor; } set { raamatuautor = value; } }
        public decimal Raamatuhind
        {
            get { return Raamatuhind; }
            set
            {
                if (value < 0)
                {
                    value = 0;
                }
                else
                    Raamatuhind = value;
            }
        }
        public decimal RaamatuHind()
        {
            return Raamatuhind * 1.30m;
        }

    }

}
