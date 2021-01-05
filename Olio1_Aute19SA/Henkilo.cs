using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Olio1_Aute19SA
{
    class Henkilo
    {
        //jäsenmuuttujat
        private string Etunimi;
        private string Sukunimi;
        private string Kotipaikka;

        //metodi saa parametrina merkkijonon, mutta ei palauta mitään (void)
        public void setEtunimi(string e)
        {
            Etunimi = e;
        }
        public void setSukunimi(string s)
        {
            Sukunimi = s;
        }
        public void setKotipaikka(string k)
        {
            Kotipaikka = k;
        }

        //metodi palauttaa merkkijonon
        public string nimi()
        {
            return Etunimi + " " + Sukunimi;
        }
        public string kotipaikka()
        {
            return Kotipaikka;
        }

    }
}
