using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projektarbeitBio
{
    public partial class Startseite : Form
    {

        public Startseite()
        {
            InitializeComponent();
        }

        //Startseite
        
        private void Button1_Click(object sender, EventArgs e)
        {
            Sehtestfenster sehtestfenster = new Sehtestfenster();
            sehtestfenster.Show();
            //Timer2
            timer2.Start();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            //Timer2
            timer2.Start();
        }

        //END Button
        private void button1_Click_1(object sender, EventArgs e)
        {
            Beenden beenden = new Beenden();
            beenden.Show();
        }

        //Timer2
        private void lbTimer2_Click(object sender, EventArgs e)
        {
          
        }

        //Timer2
        private void timer2_Tick_1(object sender, EventArgs e)
        {
            Datum d = new Datum();
            lbTimer2.Text = d.ErzeugeUhrzeitZwei();
         
        }

        

        //Erscheinungsbild
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
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

        void Initialize_Add()
        {
            buttons = new List<Control>();
            textboxes = new List<Control>();
            labels = new List<Control>();

            buttons.Add(btGoToBio);
            buttons.Add(btGoToBio);
            buttons.Add(btGoToSeh);
            buttons.Add(btEND);
          
            labels.Add(label1);
            labels.Add(label2);
            labels.Add(lbUeberschrift);
            labels.Add(lbTimer2);
        }
       
        List<Control> textboxes;
        List<Control> labels;
        List<Control> buttons;

        private void Startseite_Load(object sender, EventArgs e)
        {
            Initialize_Add();
            comboBox1.SelectedIndex = 0;
        }
    }
}
