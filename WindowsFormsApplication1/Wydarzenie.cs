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
    public partial class Wydarzenie : Form
    {
        // tymczasowe nadanie nazwy, docelowo username musi byc zapisany gdzies po zalogowaniu i tu przekazany
        private String username;
        String category;

        public Wydarzenie(String username_)
        {
            InitializeComponent();
            this.username = username_;
        }

        private void Wydarzenie_Load(object sender, EventArgs e)
        {

        }

        private void button_wydarzenie_Click(object sender, EventArgs e)
        {
            category = "wydarzenie";
            this.Visible = false;
            this.Show();
        }

        private void button_przypomnienie_Click(object sender, EventArgs e)
        {
            category = "przypomnienie";
            this.Visible = false;
            this.Show();
        }

        private void button_lista_zakupow_Click(object sender, EventArgs e)
        {
            category = "lista zakupow";
            this.Visible = false;
            this.Show();
        }

        private void button_do_zrobienia_Click(object sender, EventArgs e)
        {
            category = "do zrobienia";
            this.Visible = false;
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String name = textBox1.Text;
            String creationTime = Convert.ToString(DateTime.Now);
            String description = textBox2.Text;
            String priority = comboBox2.Text;
            String eventTime = textBox3.Text;
            String reminderTime = textBox4.Text;
            
            try
            {
                Class1.createTask(name, description, username , category, priority, creationTime, reminderTime,eventTime,null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            label8.Text = "Jestes zalogowany jako: " + this.username;
        }
    }
}
