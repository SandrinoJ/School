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
            alg:
            Console.WriteLine("Sisesta tiitel:");
            string T = Console.ReadLine();
            if (T.Length <= 3)
            {
                Console.WriteLine("Tiitel ei kehti");

            }
            Console.WriteLine("Sisesta autor:");
            string A = Console.ReadLine();
            if (A.Contains("0") || A.Contains("1") || A.Contains("2") || A.Contains("3") || A.Contains("4") || A.Contains("5") || A.Contains("6") || A.Contains("7") || A.Contains("8") || A.Contains("9"))
            {
                Console.WriteLine("Autor ei kehti");
            }
            Console.WriteLine("Sisesta raamatu hind:");
            decimal H = decimal.Parse(Console.ReadLine());
            if (H <= 0)
            {
                Console.WriteLine("Hind ei kehti");

            }

            Raamat NimeKiri = new Raamat(T, A, H);
            Console.WriteLine("Tiitel: {0}", NimeKiri.Raamatutiitel);
            Console.WriteLine("Autor: {0}", NimeKiri.Raamatuautor);
            Console.WriteLine("Raamatu hind on {0}", NimeKiri.Raamatuhind);
            Console.WriteLine("Raamatu esmatrüki hind on {0}", EsmaTrükk.EsmaPrint());
            Console.ReadKey();
            goto alg;
        }
    }
    public class Raamat
    {
        //klassi muutujad
        public static string raamatutiitel;
        public static string raamatuautor;
        public static decimal raamatuhind;
        //konstruktor 
        public Raamat(string raamatutiitel, string raamatuautor, decimal raamatuhind)
        {
            Raamatutiitel = raamatutiitel;
            Raamatuautor = raamatuautor;
            Raamatuhind = raamatuhind;
        }
        public string Raamatutiitel { get { return raamatutiitel; } set { raamatutiitel = value; } }
        public string Raamatuautor { get { return raamatuautor; } set { raamatuautor = value; } }
        public decimal Raamatuhind { get { return raamatuhind; } set { raamatuhind = value; } }
        public decimal RaamatuHind()
        {
            return Raamatuhind * 1.30m;
        }

    }
    class EsmaTrükk
    {
        public static decimal EsmaPrint()
        {
            return Raamat.raamatuhind * 1.3m;
        }
    }
}
