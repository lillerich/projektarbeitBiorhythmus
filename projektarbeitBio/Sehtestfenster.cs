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
    public partial class Sehtestfenster : Form
    {
        private int indice;
        public Sehtestfenster()
        {
            InitializeComponent();
            indice = 0;
        }

        //Sehtest
        private void Button1_Click(object sender, EventArgs e)
        {            
            indice++;
            if (indice > 2)
                indice = 0;
            lbSehtest.ImageIndex = indice;
            //Timer3
            timer3.Start();
        }


        private void Button2_Click(object sender, EventArgs e)
        {
            if (lbSehtest.ImageIndex.Equals(0))
            {
                if (tbeingabe.Text.Equals("12"))
                {
                    MessageBox.Show("Richtig, deine Sehstärke ist gut");

                }
                else
                {
                    MessageBox.Show("Falsch, deine Sehstärke ist nicht so gut");
                }
            }

            if (lbSehtest.ImageIndex.Equals(1))
            {
                if (tbeingabe.Text.Equals("49"))
                {
                    MessageBox.Show("Richtig, deine Sehstärke ist gut");

                }
                else
                {
                    MessageBox.Show("Falsch, deine Sehstärke ist nicht so gut");
                }
            }

            if (lbSehtest.ImageIndex.Equals(2))
            {
                if (tbeingabe.Text.Equals("6"))
                {
                    MessageBox.Show("Richtig, deine Sehstärke ist gut");

                }
                else
                {
                    MessageBox.Show("Falsch, deine Sehstärke ist nicht so gut");
                }
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Timer3
        private void timer3_Tick(object sender, EventArgs e)
        {
            Datum d = new Datum();
            lbTimer3.Text = d.ErzeugeUhrzeitZwei();
        }

        //Timer3
        private void lbTimer3_Click(object sender, EventArgs e)
        {

        }

        // Erscheinungsbild
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbErscheinungsbild.Text == "Light")
            {
                ApplyTheme(Color.White, zcolor(250, 250, 250), zcolor(255, 255, 255), zcolor(255, 255, 255), Color.White, Color.Black);
            }
            else if (cbErscheinungsbild.Text == "Dark")
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
            cbErscheinungsbild.BackColor = comboBox;
            cbErscheinungsbild.ForeColor = Textcolor;

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

            buttons.Add(btZeigeBild);
            buttons.Add(btErgebnis);
            buttons.Add(btZZSt);
            
            labels.Add(lbUebersSeh);
            labels.Add(lbEr);
            labels.Add(lbTimer3);
            labels.Add(lbDE);
            labels.Add(lbSehtest);

            textboxes.Add(tbeingabe);
        }

        //ErscheinungsBild
        List<Control> textboxes;
        List<Control> labels;
        List<Control> buttons;

        private void Sehtestfenster_Load(object sender, EventArgs e)
        {
            Initialize_Add();
            cbErscheinungsbild.SelectedIndex = 0;
        }
    }
}
