using System;
using System.Collections.Generic;
namespace inlämninglist3
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,int> storlek = new Dictionary<string,int>();
            storlek.Add("Sverige", 450);
            storlek.Add("Norge", 385);
            storlek.Add("Danmark", 43);
            storlek.Add("Finland", 338);
            Console.WriteLine("Skriv in ett land i Norden");
            string svar = Console.ReadLine();
            Console.WriteLine(svar + " är " + storlek[svar] + " är hundratals kvadratkilometer stort");
        }
    }
}