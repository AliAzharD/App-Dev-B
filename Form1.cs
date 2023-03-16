using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace THA_W3_Ali_Azhar_D
{
    public partial class Form1_Main_Window_Form : Form
    {
        public string bgColorr, forColorr;
        public Form1_Main_Window_Form(string bgcolor, string forcolor)
        {
            
            InitializeComponent();
            bgColorr = bgcolor;
            forColorr = forcolor;
        }
        public Form1_Main_Window_Form()
        {

            InitializeComponent();
           
        }

        private void button_OPen_Next_Form_Click(object sender, EventArgs e)
        {
            Form2_second_window_form form2 = new Form2_second_window_form(textBox_nama.Text,textBox_FavArtist.Text);
            form2.Show();
        }

        private void button_Submit1_Click(object sender, EventArgs e)
        {
           
            if (textBox_nama.Text == "" || textBox_FavArtist.Text == "")
            {
                MessageBox.Show("Mohon isi nama dan favorit artis");
            }
            else
            {
                Form2_second_window_form form2 = new Form2_second_window_form(textBox_nama.Text, textBox_FavArtist.Text);
                form2.Show();

            }
        }

        private void checkBox_agree_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox_agree.Checked == true)
            {
                button_Submit1.Enabled= true;
                
            }
            else
            {
                button_Submit1.Enabled= false;
            }
            
        }

        private void Form1_Main_Window_Form_Load(object sender, EventArgs e)
        {
            if (bgColorr == "Blue")
            {
                this.BackColor = Color.Blue;
            }
            else if (bgColorr == "Green")
            {
                this.BackColor = Color.Green;
            }
            else if (bgColorr == "Yellow")
            {
                this.BackColor = Color.Yellow;
            }
            else if (bgColorr == "Pink")
            {
                this.BackColor = Color.Pink;
            }
            else if (bgColorr == "Orange")
            {
                this.BackColor = Color.Orange;
            }
            if (forColorr == "White")
            {
                this.ForeColor = Color.White;
            }
            else if (forColorr == "Black")
            {
                this.ForeColor = Color.Black;
            }
            else if (forColorr == "Red")
            {
                this.ForeColor = Color.Red;
            }
        }
       


    }
}
