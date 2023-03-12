using System;
using System.Collections.Generic;

class KodePos
{
    private Dictionary<string, string> Kodepos = new Dictionary<string, string>
    {
        {"Batununggal", "40266"},
        {"A. Kujangsari", "40287"},
        {"Mengger", "40267"},
        {"Wates", "40256"},
        {"Cijaura", "40287"},
        {"Jatisari", "40286"},
        {"Margasari", "40286"},
        {"Sekejati", "40286"},
        {"Kebonwaru", "40272"},
        {"Maleer", "40274"},
        {"Samoja", "40273"}
    };

    public string getKodepos(string kelurahan)
    {
        if (Kodepos.ContainsKey(kelurahan))
        {
            return Kodepos[kelurahan];
        }
        else
        {
            return "Kode Pos tidak ada";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            KodePos kodepos = new KodePos();

            Console.WriteLine(kodepos.getKodepos("Batununggal")); // Output: 40266
            Console.WriteLine(kodepos.getKodepos("A. Kujangsari")); // Output: 40287
            Console.WriteLine(kodepos.getKodepos("Mengger")); // Output: 40267
            Console.WriteLine(kodepos.getKodepos("Wates")); // Output: 40256
            Console.WriteLine(kodepos.getKodepos("Cijaura")); // Output: 40287
            Console.WriteLine(kodepos.getKodepos("Jatisari")); // Output: 40286
            Console.WriteLine(kodepos.getKodepos("Margasari")); // Output: 40286
            Console.WriteLine(kodepos.getKodepos("Sekejati")); // Output: 40286
            Console.WriteLine(kodepos.getKodepos("Kebonwaru")); // Output: 40272
            Console.WriteLine(kodepos.getKodepos("Maleer")); // Output: 40274
            Console.WriteLine(kodepos.getKodepos("Samoja")); // Output: 40273
            Console.WriteLine(kodepos.getKodepos("Cilaki")); // Output: Kode Pos tidak ada
        }
    }
}