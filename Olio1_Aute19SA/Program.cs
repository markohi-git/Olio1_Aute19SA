using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olio1_Aute19SA
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            //Paikka johon tallennetaan "henkilöitä"
            ArrayList a = new ArrayList();
            //luetaan rivejä niin kauan että rivinä on vain kirjain q
            while ((input = Console.ReadLine()) != "q")
            {
                //Luodaan uusi henkilö olio
                Henkilo h = new Henkilo();
                //slip pilkkoo merkkijonon taulukoksi
                h.setEtunimi(input.Split(' ')[0]);
                h.setSukunimi(input.Split(' ')[1]);
                a.Add(h);
            }
            Console.WriteLine("Henkilöitä on " + a.Count);
            //käydään läpi arraylist
            for (int i = 0; i < a.Count; i++) 
            {
                //otetaan arraylististä olio joka on i indeksissä
                Henkilo h = (Henkilo)a[i];
                Console.WriteLine("Henkilö "+i+" "+h.nimi());
            }

            Console.ReadLine();
        }
    }
}
