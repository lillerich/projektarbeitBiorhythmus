using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace projektarbeitBio
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
       
        //Datenbank 
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_users.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        // Einlogen suche nach vorhanden Benutzername und Passwort.
        private void button1_Click(object sender, EventArgs e)
        {
            con.Close();
            con.Open();
            string login = "SELECT * FROM tbl_users WHERE username= '" + tbusername.Text + "' and password= '" + tbpassword.Text + "'"; 
            cmd = new OleDbCommand(login,con);
            OleDbDataReader dr = cmd.ExecuteReader();

            if (dr.Read() == true)
            {
                new dashboard().Show();
                this.Hide();               
                //Zeigt Form dashboard.
            }
            else
            {
                MessageBox.Show("Falsches Passwort oder Benutzername, Bitte versuchen sie es nocheinmal!", "Login fehlgeschlagen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbusername.Text = "";
                tbpassword.Text = "";
                tbusername.Focus();
            }
        }

        // Letzten Eingaben in den Textboxen werden gelöscht.
        private void button2_Click(object sender, EventArgs e)
        {
            tbusername.Text = "";
            tbpassword.Text = "";
            tbusername.Focus();
        }

        // Checkbox Passwort anzeigen oder nicht.
        private void ckbShowPas_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbShowPas.Checked)
            {
                tbpassword .PasswordChar = '\0';               
            }
            else
            {
                tbpassword.PasswordChar = '°';              
            }
        }

        // Form AnmeldeRegistriere wird geöffnet.
        private void label5_Click(object sender, EventArgs e)
        {
            new frmRegister().Show();
            this.Hide();
        }

        // Zurück zur Startseite.
        private void label3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
