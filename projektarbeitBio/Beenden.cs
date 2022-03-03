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
    public partial class Beenden : Form
    {
        public Beenden()
        {
            InitializeComponent();
        }

        //Wirklich beenden 
        private void btJa_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btNein_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
