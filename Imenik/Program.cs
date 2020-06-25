using System;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters;

namespace Imenik
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Imena = new List<string>();
            List<string> TelBroj = new List<string>();
            string izbor = "";
            while (izbor != "5")
            {
                Console.WriteLine("1 --- Unos.");
                Console.WriteLine("2 --- Pregled.");
                Console.WriteLine("3 --- Pretraga.");
                Console.WriteLine("4 --- Ukloni");
                Console.WriteLine("5 --- Izlaz.");
                Console.WriteLine("------------------");
                Console.Write("Unesite izbor: ");
                izbor = Console.ReadKey().KeyChar.ToString();
                Console.WriteLine();

                switch (izbor)
                {
                    case "1":
                        Console.Write("Unesite ime i prezime: ");
                        Imena.Add(Console.ReadLine());
                        Console.Write("Unesite tel: ");
                        TelBroj.Add(Console.ReadLine());
                        break;
                    case "2":
                        for (int indeks = 0; indeks < Imena.Count; indeks++)
                        {
                            Console.WriteLine($"{indeks + 1}.{Imena[indeks]} -- {TelBroj[indeks]}");
                        }
                        break;
                    case "3":
                        Console.Write("Unesite ime: ");
                        string pretraga = Console.ReadLine();
                   
                        for(int indeks = 0; indeks<Imena.Count; indeks++)
                        {
                            if (Imena[indeks].ToLower().Contains(pretraga.ToLower()))
                            {
                                Console.WriteLine($"{indeks + 1}.{Imena[indeks]} -- {TelBroj[indeks]}");
                            }                                
                        }
                        break;
                    case "4":
                        //TODO Treba brisanje po imenu. Moramo da pretrazimo listu sa imenima, uzmemo indeks(kao i u pretrazi) pa obirsemo i broj i ime iz liste ;)
                        //string.IsNullOrEmpty(NekiString) vraca true ako je string u zagradama prazan
                        Console.Write("Unesite ime: ");
                        string search = Console.ReadLine();
                        for (int ind = 0; ind < Imena.Count; ind++)
                        {
                            if(Imena[ind].ToLower().Contains(search.ToLower()))
                            {
                                Imena.RemoveAt(ind);
                                TelBroj.RemoveAt(ind);
                                Console.WriteLine("Uspesno obrisan korisnik: " + search);
                            }
                        }
                        break;
                    case "5":
                        Console.WriteLine("Vidimo se :)");
                        break;
                    default:
                        Console.WriteLine("Pogresna opcija :(");
                        break;
                }
            }
            Console.ReadKey();
           
        }
    }
}
