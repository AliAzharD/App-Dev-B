using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week4_B
{
    public partial class main_form : Form
    {
        public main_form()
        {
            InitializeComponent();
        }

        private int count = 0;

        private void check_qst1_4_CheckedChanged(object sender, EventArgs e)
        {
            if (check_qst1_4.Checked)
            {
                text_qst1_4.Enabled = true;
                text_qst1_4.Text = "";
            }
            else
            {
                text_qst1_4.Enabled = false;
                text_qst1_4.Text = "others . . .";
            }
        }

        private void check_agree_CheckedChanged(object sender, EventArgs e)
        {
            if (check_agree.Checked)
            {
                btn_submit.Enabled = true;
            }
            else
            {
                btn_submit.Enabled = false;
            }
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            string text = "Saya tahu UC dari ";
            if (check_qst1_1.Checked == false && check_qst1_2.Checked == false &&
                check_qst1_3.Checked == false && check_qst1_4.Checked == false)
            {
                string errorText = "Minimal 1 Checkbox harus di Centang";
                MessageBox.Show(errorText, "Checkbox Kosong",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            }
            else
            {
                if (check_qst1_1.Checked)
                {
                    text += "Teman, ";
                }
                if (check_qst1_2.Checked)
                {
                    text += "Social Media, ";
                }
                if (check_qst1_3.Checked)
                {
                    text += "Guru ";
                }
                if (check_qst1_4.Checked)
                {
                    text += text_qst1_4.Text;
                }
                MessageBox.Show(text, "Saya Tahu UC",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void check_qst2_1_CheckedChanged(object sender, EventArgs e)
        {

            if (check_qst2_1.Checked)
            {

                count++;
                Console.WriteLine(count);
            }
            else
            {
                count--;
                Console.WriteLine(count);
            }
            if (count == 2)
            {
                if (check_qst2_2.Checked)
                {
                    check_qst2_3.Enabled = false;
                    check_qst2_4.Enabled = false;
                }
                else if (check_qst2_3.Checked)
                {
                    check_qst2_2.Enabled = false;
                    check_qst2_4.Enabled = false;
                }
                else if (check_qst2_4.Checked)
                {
                    check_qst2_2.Enabled = false;
                    check_qst2_3.Enabled = false;
                }
            }
            checkChoice();
        }
        private void radio_green_CheckedChanged(object sender, EventArgs e)
        {
            panel_color.BackColor = Color.Green;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radio_red_CheckedChanged(object sender, EventArgs e)
        {
            panel_color.BackColor = Color.Red;
            main_form.ActiveForm.BackColor = Color.Khaki;
        }

        private void radio_blue_CheckedChanged(object sender, EventArgs e)
        {
            panel_color.BackColor = Color.Blue;
        }

        private void checkChoice()
        {
            if (count < 2)
            {
                check_qst2_1.Enabled = true;
                check_qst2_2.Enabled = true;
                check_qst2_3.Enabled = true;
                check_qst2_4.Enabled = true;
            }
        }



        private void check_qst2_2_CheckedChanged(object sender, EventArgs e)
        {

            if (check_qst2_2.Checked)
            {
                count++;
            }
            else
            {
                count--;
            }
            if (count == 2)
            {
                if (check_qst2_1.Checked)
                {
                    check_qst2_3.Enabled = false;
                    check_qst2_4.Enabled = false;
                }
                else if (check_qst2_3.Checked)
                {
                    check_qst2_1.Enabled = false;
                    check_qst2_4.Enabled = false;
                }
                else if (check_qst2_4.Checked)
                {
                    check_qst2_1.Enabled = false;
                    check_qst2_3.Enabled = false;
                }
                
            }
            checkChoice();
        }

        private void check_qst2_3_CheckedChanged(object sender, EventArgs e)
        {
            if (check_qst2_3.Checked)
            {
                count++;
            }
            else
            {
                count--;
            }
            if (count == 2)
            {
                if (check_qst2_1.Checked)
                {
                    check_qst2_2.Enabled = false;
                    check_qst2_4.Enabled = false;
                }
                else if (check_qst2_2.Checked)
                {
                    check_qst2_1.Enabled = false;
                    check_qst2_4.Enabled = false;
                }
                else if (check_qst2_4.Checked)
                {
                    check_qst2_1.Enabled = false;
                    check_qst2_2.Enabled = false;
                }
                
            }
            checkChoice();
        }

        private void check_qst2_4_CheckedChanged(object sender, EventArgs e)
        {
            if (check_qst2_4.Checked)
            {
                count++;
            }
            else
            {
                count--;
            }
            if (count == 2)
            {
                if (check_qst2_1.Checked)
                {
                    check_qst2_2.Enabled = false;
                    check_qst2_3.Enabled = false;
                }
                else if (check_qst2_2.Checked)
                {
                    check_qst2_1.Enabled = false;
                    check_qst2_3.Enabled = false;
                }
                else if (check_qst2_3.Checked)
                {
                    check_qst2_1.Enabled = false;
                    check_qst2_2.Enabled = false;
                }
                
            }
            checkChoice();
        }
    }
}
