using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.ComponentModel;
using System.Data;
using System.Drawing;





using System.Threading.Tasks;

namespace projektarbeitBio
{
    class Kondition
    {

        private int tageSeitGeburt = -1;
        private int[] GTag = new int[7];
        private int[] BTag = new int[7];


        public void setTageSeitGeburt(int value)
        {
            tageSeitGeburt = value;
        }
        public int getTageSeitGeburt()
        {
            return tageSeitGeburt;
        }



        public double berechneKonditionKoerperlich(int tageSeitHeute)
        {
            int koerperlicherRhythmus = 23;
            return 50 * (1 + Math.Sin(2 * Math.PI * (tageSeitGeburt + tageSeitHeute) / koerperlicherRhythmus));
        }



        public double berechneKonditionGeistig(int tageSeitHeute)
        {
            int geistigerRhythmus = 33;
            return 50 * (1 + Math.Sin(2 * Math.PI * (tageSeitGeburt + tageSeitHeute) /
            geistigerRhythmus));
        }



        public double berechneKonditionPsychisch(int tageSeitHeute)
        {
            int psychischerRythmus = 28;
            return 50 * (1 + Math.Sin(2 * Math.PI * (tageSeitGeburt + tageSeitHeute) /
            psychischerRythmus));
        }



        public String erzeugeKonditionPrognose_14Tage()
        {
            String prognose_14Tage = "";
            for (int t = 1; t <= 14; t++)
            {
                prognose_14Tage = prognose_14Tage +
                " " + t + " \t" +
                Math.Round(berechneKonditionKoerperlich(t), 0) + " \t\t" +
                Math.Round(berechneKonditionGeistig(t), 0) + " \t" +
                Math.Round(berechneKonditionPsychisch(t), 0) + "\n";
            }
            return prognose_14Tage;
        }



        public void zeichneKonditionPrognose_60Tage(Graphics g)
        {

            int koerperlich_1, geistig_1, psychisch_1; int koerperlich_2, geistig_2, psychisch_2;
            Pen penBlue = new Pen(Color.Blue);
            Pen penRed = new Pen(Color.Red);
            Pen penGreen = new Pen(Color.Green);
            Pen penBlack = new Pen(Color.Black);
            SolidBrush whiteBrush = new SolidBrush(Color.White);

            g.FillRectangle(whiteBrush, 0, 0, 240, 127);
            g.DrawLine(penBlack, 0, 110, 240, 110);
            g.DrawString("0", new Font("Arial", 12), new SolidBrush(Color.Black), 2, 115);
            g.DrawString("30", new Font("Arial", 12), new SolidBrush(Color.Black), 115, 115);
            g.DrawString("Tage", new Font("Arial", 12), new SolidBrush(Color.Black), 200, 115);
            for (int t = 0; t <= 59; t++)
            {
                koerperlich_1 = (int)(110 - berechneKonditionKoerperlich(t));
                geistig_1 = (int)(110 - berechneKonditionGeistig(t)); psychisch_1 = (int)(110 - berechneKonditionPsychisch(t));
                koerperlich_2 = (int)(110 - berechneKonditionKoerperlich(t + 1));
                geistig_2 = (int)(110 - berechneKonditionGeistig(t + 1)); psychisch_2 = (int)(110 - berechneKonditionPsychisch(t + 1));

                g.DrawLine(penBlue, 4 * t, koerperlich_1, 4 * (t + 1), koerperlich_2);
                g.DrawLine(penRed, 4 * t, geistig_1, 4 * (t + 1), geistig_2);
                g.DrawLine(penGreen, 4 * t, psychisch_1, 4 * (t + 1), psychisch_2);

            }

        }


        // Berechnung/Formel 7 Tage Vorschau von BadDay
        public string getBadDay()
        {
            string BadDay = "heute";
            int WelcherTag = -1;
            int koerperlich, geistig, psychisch;

            if (tageSeitGeburt > -1)
            {

                for (int i = 0; i < 7; i++)
                {
                    koerperlich = (int)(140 - berechneKonditionKoerperlich(tageSeitGeburt + i));
                    geistig = (int)(140 - berechneKonditionGeistig(tageSeitGeburt + i));
                    psychisch = (int)(140 - berechneKonditionPsychisch(tageSeitGeburt + i));
                    BTag[i] = koerperlich + geistig + psychisch;

                }

                int MinMax = 10000;
                for (int i = 0; i < 7; i++)

                {
                    if (MinMax > BTag[i])
                    {
                        MinMax = BTag[i];
                        WelcherTag = i;
                    }

                }

                switch (WelcherTag)
                {
                    case 0: BadDay = "heute"; break;
                    case 1: BadDay = "morgen"; break;
                    case 2: BadDay = "übermorgen"; break;
                    case 3: BadDay = "in " + WelcherTag + " Tagen"; break;
                    case 4: BadDay = "in " + WelcherTag + " Tagen"; break;
                    case 5: BadDay = "in " + WelcherTag + " Tagen"; break;
                    case 6: BadDay = "in " + WelcherTag + " Tagen"; break;

                }

            }

            return BadDay;
        }


        // Berechnung/Formel 7 Tage Vorschau von GoodDay
        public string getGoodDay()
        {

            string GoodDay = "heute";
            int WelcherTag = -1;
            int koerperlich, geistig, psychisch;

            if (tageSeitGeburt > -1)
            {

                for (int i = 0; i < 7; i++)
                {
                    koerperlich = (int)(140 - berechneKonditionKoerperlich(tageSeitGeburt + i));
                    geistig = (int)(140 - berechneKonditionGeistig(tageSeitGeburt + i));
                    psychisch = (int)(140 - berechneKonditionPsychisch(tageSeitGeburt + i));
                    GTag[i] = koerperlich + geistig + psychisch;

                }

                int Max = -10000;
                for (int i = 0; i < 7; i++)

                {
                    if (Max < GTag[i])
                    {
                        Max = GTag[i];
                        WelcherTag = i;
                    }

                }

                switch (WelcherTag)
                {
                    case 0: GoodDay = "heute"; break;
                    case 1: GoodDay = "morgen"; break;
                    case 2: GoodDay = "übermorgen"; break;
                    case 3: GoodDay = "in " + WelcherTag + " Tagen"; break;
                    case 4: GoodDay = "in " + WelcherTag + " Tagen"; break;
                    case 5: GoodDay = "in " + WelcherTag + " Tagen"; break;
                    case 6: GoodDay = "in " + WelcherTag + " Tagen"; break;

                }

            }

            return GoodDay;
        }



        //Sätze der 7 Tage Vorschau
        public string getausgabebesterTag()
        {
            return "Hallo dein bester Tag ist " + getGoodDay() + ".";
        }

        public string getausgabeschlechtesterTag()
        {
            return "Hallo dein schlechtester Tag ist " + getBadDay() + ".";
        }




        // Berechnung: Prognose 15-29 Tage
        public String erzeugeKonditionPrognose_15bis29Tage()
        {
            String prognose_14Tage = "";
            for (int t = 15; t <= 29; t++)
            {
                prognose_14Tage = prognose_14Tage +
                " " + t + " \t" +
                Math.Round(berechneKonditionKoerperlich(t), 0) + " \t\t" +
                Math.Round(berechneKonditionGeistig(t), 0) + " \t\t" +
                Math.Round(berechneKonditionPsychisch(t), 0) + "\n";
            }
            return prognose_14Tage;

        }













    }
}
