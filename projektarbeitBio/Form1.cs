using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


namespace projektarbeitBio
{
    public partial class Form1 : Form
    {
        //ErscheinungsBild
        List<Control> textboxes;
        List<Control> labels;
        List<Control> buttons;


        public Form1()
        {
            InitializeComponent();
        }

        private void BtVerarbeitung_Click(object sender, EventArgs e)
        {

            Kondition k = new Kondition();
            Datum d = new Datum();
            Datum datumAlt = new Datum();

            datumAlt.setTag(Convert.ToInt32(tbTag.Text));
            datumAlt.setMonat(Convert.ToInt32(tbMonat.Text));
            datumAlt.setJahr(Convert.ToInt32(tbJahr.Text));
            d.setDatumAufHeute();

            k.setTageSeitGeburt(d.berechneTageDifferenz(datumAlt));
            lbTagesdatum.Text = (d.getTag() + "." +
            d.getMonat() + "." +
            d.getJahr());
            lbTageSeitGeburt.Text = Convert.ToString(k.getTageSeitGeburt());
            lbKoerperlich.Text = Math.Round(k.berechneKonditionKoerperlich(0), 2) + "%";
            lbGeistig.Text = Math.Round(k.berechneKonditionGeistig(0), 2) + "%";
            lbPsychisch.Text = Math.Round(k.berechneKonditionPsychisch(0), 2) + "%";
            rtbPrognose_14Tage.Text = k.erzeugeKonditionPrognose_14Tage();
            k.zeichneKonditionPrognose_60Tage(plPrognose_60Tage.CreateGraphics());

            //Ausgabe Uhrzeit im Moment des Knopfdruckes.
            lbUhrzeit.Text = d.ErzeugeUhrzeit();

            //Timer1 wird gestartet und zählt Stunden, Minuten und Sekunden.
            timer1.Start();

            //7 Tage Vorschau
            lbAusgabeGDay.Text = k.getausgabebesterTag();
            lbAusagbeBDay.Text = k.getausgabeschlechtesterTag();
        }

        //Zurück zur Startseitte 
        private void Button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Timer
        private void Timer1_Tick(object sender, EventArgs e)
        {
            Datum d = new Datum();
            lbTimer.Text = d.ErzeugeUhrzeitZwei();
        }

        //Zurück zur Startseite
        private void BtWechsel_Click(object sender, EventArgs e)
        {
            Sehtestfenster sehtestfenster = new Sehtestfenster();
            sehtestfenster.Show();
        }

        //Timer
        private void LbTimer_Click(object sender, EventArgs e)
        {

        }

        //Aufzählunf der ganzen Labels, Buttons, Textboxen... deren Farbe für den darkmode geändert wird im Form.
        void Initialize_Add()
        {
            buttons = new List<Control>();
            textboxes = new List<Control>();
            labels = new List<Control>();

            buttons.Add(btVerarbeitung);

            textboxes.Add(tbTag);
            textboxes.Add(tbMonat);
            textboxes.Add(tbJahr);
          
            labels.Add(label1);
            labels.Add(label2);
            labels.Add(label3);
            labels.Add(label4);
            labels.Add(lbGeburtsdatum);
            labels.Add(lbT);
            labels.Add(lbTagesdatum);
            labels.Add(lbTD);
            labels.Add(lbTageSeitGeburt);
            labels.Add(label11);
            labels.Add(label12);
            labels.Add(label13);
            labels.Add(label14);
            labels.Add(label15);
            labels.Add(label16);
            labels.Add(lbKoerperlich);
            labels.Add(lbGeistig);
            labels.Add(lbPsychisch);
            labels.Add(lbU);
            labels.Add(lbM);
            labels.Add(lbJ);
            labels.Add(label18);
            labels.Add(lbUhrzeit);        
            labels.Add(lbUebTDK);
            labels.Add(lbTimer);
            labels.Add(label10);
            labels.Add(label19);
            labels.Add(lbAusgabeGDay);
            labels.Add(label21);
            labels.Add(lbAusagbeBDay);
            labels.Add(label22);
        }

        //Für alle Textboxen, Labels, buttons... Hintergrundfarbe und Schriftfarbe änderung.
        void ApplyTheme(Color back, Color btn, Color tbox, Color lb, Color comboBox, Color Textcolor)
        {

            this.BackColor = back;
            comboBox1.BackColor = comboBox;
            comboBox1.ForeColor = Textcolor;

            foreach (Control item in buttons)
            {
                item.BackColor = btn;
                item.ForeColor = Textcolor;
            }

            foreach (Control item in textboxes)
            {
                item.BackColor = tbox;
                item.ForeColor = Textcolor;
            }

            foreach (Control item in labels)
            {
                item.BackColor = lb;
                item.ForeColor = Textcolor;
            }

        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            Initialize_Add();
            comboBox1.SelectedIndex = 0;
        }

        //Erscheinungsbild für den Darkmode die Farbänderung der Labels, Textboxen, Buttons... .
        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Light")
            {
                ApplyTheme(Color.White, zcolor(250, 250, 250), zcolor(255, 255, 255), zcolor(255, 255, 255), Color.White, Color.Black);
            }
            else if (comboBox1.Text == "Dark")
            {
                ApplyTheme(zcolor(30, 30, 30), zcolor(45, 45, 45), zcolor(30, 30, 30), zcolor(30, 30, 30), Color.Black, Color.White);
            }

            Color zcolor(int r, int g, int b)
            {
                return Color.FromArgb(r, g, b);
            }
        }

        // Button zur Ausgabe der Berechnung: Prognose 15-29 Tage

        private void Button2_Click(object sender, EventArgs e)
        {
            Kondition k = new Kondition();
            rtbPrognose_14Tage.Text = k.erzeugeKonditionPrognose_15bis29Tage();
            button2.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        // WEnn man auf die Werbund klickt öffnet sich der online Shop.
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Process.Start("https://www.nespresso.com/de/de/");
        }

        
    }
}
