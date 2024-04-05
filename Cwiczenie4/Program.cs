using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Laboratorium.NET_metody;

namespace Laboratorium.NET_cwiczenie3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string lokalizacja = "C:\\aaMag\\test.txt";

            if (File.Exists(lokalizacja))
            {
                using (StreamReader sr = new StreamReader(lokalizacja))
                {
                    string linliniaTekstu;

                    while ((linliniaTekstu = sr.ReadLine()) != null)
                    {
                        string reversedLine = Metody.Odwroc(linliniaTekstu);
                        Console.WriteLine(reversedLine);
                    }
                }
            }
            else
            {
                Console.WriteLine("Podany plik nie istnieje.");
            }

            Console.ReadKey();
        }
    }




}
