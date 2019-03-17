using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Pangram_ja__Palindrome_eesti_keele_tähestikune
{
    class Program
    {


        /* kodutöö - Pangram(ei tea kas eesti keeles eksisteerib sellist mõistet või mitte) on põhimõtteliselt lause,
         mis sisaldab endas kõiki inglise tähestiku tähti vähemalt ühe korra.Näiteks:
         The quick brown fox jumps over the lazy dog.Palindroom on keelend, mis on nii päri-kui ka tagurpidi lugedes täpselt samasugune.
        Näiteks: Aias sadas saia või Never odd or even Eesti tähestikus koos võõrtähtedega on 32 tähte
        : abcdefghijklmnopqrsšzžtuvwõäöüxy Loo programm, mis kontrollib kas kasutaja poolt sisestatuga on tegu pangrami ja palindroomiga või mitte
        (kasutades eesti tähestiku).
        */
           static void Main(string[] args)
           {
            //
            alg:
            //Palidrom
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Sisesta string");
            string kontroll= Console.ReadLine();
            Console.WriteLine(kontroll.SequenceEqual(kontroll.Reverse()));
            Console.ReadKey();
            Console.Clear();
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Sisesta Pangram");
            kontroll = Console.ReadLine();
            //Pangram
            Console.WriteLine("{1} on {0} ", CheckPangram(kontroll), kontroll);
            Console.ReadKey();
            Console.Clear();
            Console.ResetColor();
            goto alg;
           }

           static bool CheckPangram(string str)
           {
            return str.ToLower().Where(ch => Char.IsLetter(ch)).GroupBy(ch => ch).Count() == 26;
            /*
 return str.ToLower().Where(ch => Char.IsLetter(ch)).GroupBy(ch => ch).Count() == 32;
            seda saab kasutada eesti keele tähestiku puhul.
            */
        }
    }
           
    }
