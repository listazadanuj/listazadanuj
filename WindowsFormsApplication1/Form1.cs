using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private String username;



        public Form1()
        {
            InitializeComponent();
        }


        private void textBox_login_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_community_Click(object sender, EventArgs e)
        {

        }

        private void login_button_Click(object sender, EventArgs e)
        {
            String username = textBox_login.Text;
            String password = textBox_password.Text;

            String check = Class1.getLogin(username, password)[0]["count(*)"];

            if (check == "0")
            {
                label_community.Text = "Uzytkownik o podanej nazwie nie istnieje!";
            }
            else
            {
                label_community.Text = "Logowanie przebieglo pomyslnie.";
                Class1.getLogin(username, password);
                this.username = username;

                Form2 form2 = new Form2(username);
                this.Visible = false;
                form2.ShowDialog();
            }
        }
    

        

        private void registration_button_Click(object sender, EventArgs e)
        {
            String username = textBox_login.Text;
            String password = textBox_password.Text;

            String check = Class1.checkIfExists(username)[0]["count(*)"];

            if (check == "1")
            {
                label_community.Text = "Taki użytkownik już istnieje! Spróbuj wybrać inny login.";
            }
            else if(check == "0")
            {
                label_community.Text = "Rejestracja przebiegla pomyslnie. Zostales zalogowany.";
                Class1.addUser(username, password);
                this.username = username;

                Form2 form2 = new Form2(username);
                this.Visible = false;
                form2.ShowDialog();
            }
        }
    }
}
