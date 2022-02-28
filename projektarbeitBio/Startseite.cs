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
        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Sehtestfenster sehtestfenster = new Sehtestfenster();
            sehtestfenster.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
