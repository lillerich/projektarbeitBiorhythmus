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
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        //Datenbank
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_users.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        
        //Registrieren 
        private void button1_Click(object sender, EventArgs e)
        {
            if (tbusername.Text == "" && tbPassword.Text == "" && tbComPassword.Text == "")
            {
                MessageBox.Show("Benutzername und Password sind leer", "Registrieren fehlgeschlagen", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (tbPassword.Text == tbComPassword.Text)
            {
                
                con.Open();
                string register = "INSERT INTO tbl_users VALUES (' " + tbusername.Text + " ', '" + tbPassword + "')";
                cmd = new OleDbCommand(register, con);
                cmd.ExecuteNonQuery();
                con.Close();

                tbusername.Text = "";
                tbPassword.Text = "";
                tbComPassword.Text = "";

                MessageBox.Show("Dein Account wurde erstellt", "Registrieren erfolgreich", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Passwörter stimmen nicht überein, Bitte erneut versuchen!", "Registrieren fehlgeschlagen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbPassword.Text = "";
                tbComPassword.Text = "";
                tbPassword.Focus(); 
            }


        }

        // Checkbox Passwort anzeigen oder nicht.
        private void ckbShowPas_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbShowPas.Checked)
            {
                tbPassword.PasswordChar = '\0';
                tbComPassword.PasswordChar = '\0';
            }
            else
            {
                tbPassword.PasswordChar = '°';
                tbComPassword.PasswordChar = '°';
            }
        }

        // Letzten Eingaben in den Textboxen werden gelöscht.
        private void button2_Click(object sender, EventArgs e)
        {
            tbusername.Text = "";
            tbPassword.Text = "";
            tbComPassword.Text = "";
            tbusername.Focus();
        }

        // Label führt zurück zu Login.
        private void label5_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }

        // Schließt Form, zurück zur Startseite.
        private void label6_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
