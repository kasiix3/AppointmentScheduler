using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace C969_Software_2_Kas_Kleespie
{
    public partial class Sign_In_Form : Form
    {
        
        public string errorMsg = "The username or password entered is incorrect. Please try again.";
        public string cancel = "Are you sure you want to exit the application?";
        public Sign_In_Form()
        {
            InitializeComponent();
            //CultureInfo.CurrentUICulture = new CultureInfo("fr-FR", false);
            //A. Supports English and/or French
            if (CultureInfo.CurrentCulture.TwoLetterISOLanguageName == "fr")
            {
                this.Text = "Accéder";
                signInLabel.Text = "Formulaire De Connexion";
                username.Text = "Nom d'utilisateur";
                password.Text = "Le mot de passe";
                btnSignIn.Text = "S'identifier";
                btnCancel.Text = "Cannelle";
                errorMsg = "Le nom d'utilisateur ou le mot de passe entre est incorrect. Veuillez reessayer.";
                cancel = "Etes-vous sur de vouloir quitter l'application?";

            }

        }
       
        //F.4 Exception incorrect username and/or password.
        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if (SQLHelper.userCheck(usernameTextBox.Text, passwordTextBox.Text) != 0)
            {
                // Log in text file username and time of login
                Logs.signIn(SQLHelper.GetCurrentUserName());
                // Show Dashboard
                Home home = new Home();
                //H. 15 minute alert of next appointment
                Logs.reminder();
                home.Show();
                this.Hide();
                
            }
            else
            {
                MessageBox.Show(errorMsg);
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show(cancel, this.Text, MessageBoxButtons.YesNo);
            if(confirm == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
