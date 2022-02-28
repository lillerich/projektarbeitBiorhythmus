using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Text;
using System.Threading.Tasks;

namespace projektarbeitBio
{
    class Datum
    {


        private int tag;
        private int monat;
        private int jahr;



        public void setTag(int value)
        {
            tag = value;
        }
        public int getTag()
        {
            return tag;
        }


        public void setMonat(int value)
        {
            monat = value;
        }
        public int getMonat()
        {
            return monat;
        }


        public void setJahr(int value)
        {
            jahr = value;
        }
        public int getJahr()
        {
            return jahr;
        }




        public void setDatumAufHeute()
        {

            GregorianCalendar heute = new GregorianCalendar();
            tag = heute.GetDayOfMonth(DateTime.Today);
            monat = heute.GetMonth(DateTime.Today);
            jahr = heute.GetYear(DateTime.Today);
        }


        public bool pruefeObSchaltjahr(int jahr)
        {
            return ((jahr % 4 == 0) && (jahr % 100 != 0)) || (jahr % 400 == 0);
        }


        public int berechneAnzahlSchaltjahre(Datum datumAlt)
        {
            int anzahl = 0;
            for (int j = datumAlt.getJahr(); j < jahr; j++)
                if (pruefeObSchaltjahr(j)) anzahl++;
            return anzahl;
        }


        public int ermittleMonatstage(int monat)
        {
            int tage;
            switch (monat)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12: tage = 31; break;
                case 4:
                case 6:
                case 9:
                case 11: tage = 30; break;
                case 2:
                    if (pruefeObSchaltjahr(jahr)) tage = 29;
                    else tage = 28; break;
                default: tage = 0; break;
            }
            return tage;
        }


        public int berechneTageSeitJahresbeginn()
        {
            int tage = tag;
            for (int m = 1; m < monat; m++)
                tage = tage + ermittleMonatstage(m);
            return tage;
        }


        public int berechneTageDifferenz(Datum datumAlt)
        {
            return (jahr - datumAlt.getJahr()) * 365
            + berechneAnzahlSchaltjahre(datumAlt)
           - datumAlt.berechneTageSeitJahresbeginn()
           + berechneTageSeitJahresbeginn();
        }




        //Uhrzeit
        public string ErzeugeUhrzeit()
        {
            return DateTimeOffset.Now.ToString("H:mm tt");
        }


        //Timer
        public string ErzeugeUhrzeitZwei()
        {
            return DateTimeOffset.Now.ToString("H:mm:ss tt");
        }





    }
}
