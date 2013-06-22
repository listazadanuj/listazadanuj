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
    public partial class Form2 : Form
    {
        Form1 form1 = new Form1();
        private String username;


        public Form2(String username_)
        {
            InitializeComponent();
            this.username = username_;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void text_box_check_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_kategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_date_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void ostatnio_dodane_Click(object sender, EventArgs e)
        {
           
        }


        private void button_search_Click(object sender, EventArgs e)
        {
            if (text_box_check_name.Text == "nazwa" || text_box_check_name.Text == "")
            {
              //  ostatnio_dodane.Text = Class1.getAllTasks();

            }
        }

        private void button_wydarzenie_Click(object sender, EventArgs e)
        {
            Wydarzenie wydarzenie = new Wydarzenie(this.username);
            this.Visible = false;
            wydarzenie.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = "Jestes zalogowany jako: " + this.username;
        }

    }
}
