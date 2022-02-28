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
    }
}
