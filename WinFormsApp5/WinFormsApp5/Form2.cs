using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WinFormsApp5
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();


        }


        public void EnableCheckBoxes(bool checkbox1Checked, bool checkbox2Checked)
        {


            if (checkbox2Checked)
            {
                checkBox1.Enabled = false;
                checkBox3.Enabled = false;
                checkBox5.Enabled = false;
                checkBox9.Enabled = false;




            }

            if (checkbox1Checked)
            {


                checkBox2.Enabled = false;
                checkBox4.Enabled = false;
                checkBox6.Enabled = false;
                checkBox7.Enabled = false;
                checkBox8.Enabled = false;
                checkBox10.Enabled = false;

            }
        }



        private void Form2_Load(object sender, EventArgs e)
        {

        }
        int toplam;


        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            int toplam = 0;

            if (checkBox1.Checked == true)
            {
                toplam = toplam + 60;
            }

            if (checkBox2.Checked == true)
            {
                toplam = toplam + 75;
            }

            if (checkBox3.Checked == true)
            {
                toplam = toplam + 80;
            }
            if (checkBox4.Checked == true)
            {
                toplam = toplam + 80;
            }
            if (checkBox5.Checked == true)
            {
                toplam = toplam + 60;
            }
            if (checkBox6.Checked == true)
            {
                toplam = toplam + 20;
            }
            if (checkBox7.Checked == true)
            {
                toplam = toplam + 65;
            }
            if (checkBox8.Checked == true)
            {
                toplam = toplam + 75;
            }
            if (checkBox9.Checked == true)
            {
                toplam = toplam + 60;
            }
            if (checkBox10.Checked == true)
            {
                toplam = toplam + 40;
            }


            label14.Text = Convert.ToString(toplam);
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            int toplam = 0;

            if (checkBox1.Checked == true)
            {
                toplam = toplam + 60;
            }

            if (checkBox2.Checked == true)
            {
                toplam = toplam + 75;
            }

            if (checkBox3.Checked == true)
            {
                toplam = toplam + 80;
            }
            if (checkBox4.Checked == true)
            {
                toplam = toplam + 80;
            }
            if (checkBox5.Checked == true)
            {
                toplam = toplam + 60;
            }
            if (checkBox6.Checked == true)
            {
                toplam = toplam + 20;
            }
            if (checkBox7.Checked == true)
            {
                toplam = toplam + 65;
            }
            if (checkBox8.Checked == true)
            {
                toplam = toplam + 75;
            }
            if (checkBox9.Checked == true)
            {
                toplam = toplam + 60;
            }
            if (checkBox10.Checked == true)
            {
                toplam = toplam + 40;
            }


            label14.Text = Convert.ToString(toplam);
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            int toplam = 0;

            if (checkBox1.Checked == true)
            {
                toplam = toplam + 60;
            }

            if (checkBox2.Checked == true)
            {
                toplam = toplam + 75;
            }

            if (checkBox3.Checked == true)
            {
                toplam = toplam + 80;
            }
            if (checkBox4.Checked == true)
            {
                toplam = toplam + 80;
            }
            if (checkBox5.Checked == true)
            {
                toplam = toplam + 60;
            }
            if (checkBox6.Checked == true)
            {
                toplam = toplam + 20;
            }
            if (checkBox7.Checked == true)
            {
                toplam = toplam + 65;
            }
            if (checkBox8.Checked == true)
            {
                toplam = toplam + 75;
            }
            if (checkBox9.Checked == true)
            {
                toplam = toplam + 60;
            }
            if (checkBox10.Checked == true)
            {
                toplam = toplam + 40;
            }


            label14.Text = Convert.ToString(toplam);
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            int toplam = 0;

            if (checkBox1.Checked == true)
            {
                toplam = toplam + 60;
            }

            if (checkBox2.Checked == true)
            {
                toplam = toplam + 75;
            }

            if (checkBox3.Checked == true)
            {
                toplam = toplam + 80;
            }
            if (checkBox4.Checked == true)
            {
                toplam = toplam + 80;
            }
            if (checkBox5.Checked == true)
            {
                toplam = toplam + 60;
            }
            if (checkBox6.Checked == true)
            {
                toplam = toplam + 20;
            }
            if (checkBox7.Checked == true)
            {
                toplam = toplam + 65;
            }
            if (checkBox8.Checked == true)
            {
                toplam = toplam + 75;
            }
            if (checkBox9.Checked == true)
            {
                toplam = toplam + 60;
            }
            if (checkBox10.Checked == true)
            {
                toplam = toplam + 40;
            }

            label14.Text = Convert.ToString(toplam);
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            int toplam = 0;

            if (checkBox1.Checked == true)
            {
                toplam = toplam + 60;
            }

            if (checkBox2.Checked == true)
            {
                toplam = toplam + 75;
            }

            if (checkBox3.Checked == true)
            {
                toplam = toplam + 80;
            }
            if (checkBox4.Checked == true)
            {
                toplam = toplam + 80;
            }
            if (checkBox5.Checked == true)
            {
                toplam = toplam + 60;
            }
            if (checkBox6.Checked == true)
            {
                toplam = toplam + 20;
            }
            if (checkBox7.Checked == true)
            {
                toplam = toplam + 65;
            }
            if (checkBox8.Checked == true)
            {
                toplam = toplam + 75;
            }
            if (checkBox9.Checked == true)
            {
                toplam = toplam + 60;
            }
            if (checkBox10.Checked == true)
            {
                toplam = toplam + 40;
            }

            label14.Text = Convert.ToString(toplam);
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            int toplam = 0;

            if (checkBox1.Checked == true)
            {
                toplam = toplam + 60;
            }

            if (checkBox2.Checked == true)
            {
                toplam = toplam + 75;
            }

            if (checkBox3.Checked == true)
            {
                toplam = toplam + 80;
            }
            if (checkBox4.Checked == true)
            {
                toplam = toplam + 80;
            }
            if (checkBox5.Checked == true)
            {
                toplam = toplam + 60;
            }
            if (checkBox6.Checked == true)
            {
                toplam = toplam + 20;
            }
            if (checkBox7.Checked == true)
            {
                toplam = toplam + 65;
            }
            if (checkBox8.Checked == true)
            {
                toplam = toplam + 75;
            }
            if (checkBox9.Checked == true)
            {
                toplam = toplam + 60;
            }
            if (checkBox10.Checked == true)
            {
                toplam = toplam + 40;
            }

            label14.Text = Convert.ToString(toplam);
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            int toplam = 0;

            if (checkBox1.Checked == true)
            {
                toplam = toplam + 60;
            }

            if (checkBox2.Checked == true)
            {
                toplam = toplam + 75;
            }

            if (checkBox3.Checked == true)
            {
                toplam = toplam + 80;
            }
            if (checkBox4.Checked == true)
            {
                toplam = toplam + 80;
            }
            if (checkBox5.Checked == true)
            {
                toplam = toplam + 60;
            }
            if (checkBox6.Checked == true)
            {
                toplam = toplam + 20;
            }
            if (checkBox7.Checked == true)
            {
                toplam = toplam + 65;
            }
            if (checkBox8.Checked == true)
            {
                toplam = toplam + 75;
            }
            if (checkBox9.Checked == true)
            {
                toplam = toplam + 60;
            }
            if (checkBox10.Checked == true)
            {
                toplam = toplam + 40;
            }

            label14.Text = Convert.ToString(toplam);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            int toplam = 0;

            if (checkBox1.Checked == true)
            {
                toplam = toplam + 60;
            }

            if (checkBox2.Checked == true)
            {
                toplam = toplam + 75;
            }

            if (checkBox3.Checked == true)
            {
                toplam = toplam + 80;
            }
            if (checkBox4.Checked == true)
            {
                toplam = toplam + 80;
            }
            if (checkBox5.Checked == true)
            {
                toplam = toplam + 60;
            }
            if (checkBox6.Checked == true)
            {
                toplam = toplam + 20;
            }
            if (checkBox7.Checked == true)
            {
                toplam = toplam + 65;
            }
            if (checkBox8.Checked == true)
            {
                toplam = toplam + 75;
            }
            if (checkBox9.Checked == true)
            {
                toplam = toplam + 60;
            }
            if (checkBox10.Checked == true)
            {
                toplam = toplam + 40;
            }

            label14.Text = Convert.ToString(toplam);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            int toplam = 0;

            if (checkBox1.Checked == true)
            {
                toplam = toplam + 60;
            }

            if (checkBox2.Checked == true)
            {
                toplam = toplam + 75;
            }

            if (checkBox3.Checked == true)
            {
                toplam = toplam + 80;
            }
            if (checkBox4.Checked == true)
            {
                toplam = toplam + 80;
            }
            if (checkBox5.Checked == true)
            {
                toplam = toplam + 60;
            }
            if (checkBox6.Checked == true)
            {
                toplam = toplam + 20;
            }
            if (checkBox7.Checked == true)
            {
                toplam = toplam + 65;
            }
            if (checkBox8.Checked == true)
            {
                toplam = toplam + 75;
            }
            if (checkBox9.Checked == true)
            {
                toplam = toplam + 60;
            }
            if (checkBox10.Checked == true)
            {
                toplam = toplam + 40;
            }

            label14.Text = Convert.ToString(toplam);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            int toplam = 0;

            if (checkBox1.Checked == true)
            {
                toplam = toplam + 60;
            }

            if (checkBox2.Checked == true)
            {
                toplam = toplam + 75;
            }

            if (checkBox3.Checked == true)
            {
                toplam = toplam + 80;
            }
            if (checkBox4.Checked == true)
            {
                toplam = toplam + 80;
            }
            if (checkBox5.Checked == true)
            {
                toplam = toplam + 60;
            }
            if (checkBox6.Checked == true)
            {
                toplam = toplam + 20;
            }
            if (checkBox7.Checked == true)
            {
                toplam = toplam + 65;
            }
            if (checkBox8.Checked == true)
            {
                toplam = toplam + 75;
            }
            if (checkBox9.Checked == true)
            {
                toplam = toplam + 60;
            }
            if (checkBox10.Checked == true)
            {
                toplam = toplam + 40;
            }

            label14.Text = Convert.ToString(toplam);
        }


        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        public void DisableCheckBoxes2(params int[] checkboxIndices)
        {

            foreach (int index in checkboxIndices)
            {
                GetCheckBoxByIndex(index).Enabled = false;
            }
        }

        private System.Windows.Forms.CheckBox GetCheckBoxByIndex(int index)
        {
            switch (index)
            {
                case 1: return checkBox1;
                case 2: return checkBox2;
                case 3: return checkBox3;
                case 4: return checkBox4;
                case 5: return checkBox5;
                case 6: return checkBox6;
                case 7: return checkBox7;
                case 8: return checkBox8;
                case 9: return checkBox9;
                case 10: return checkBox10;
                default: return null;
            }
        }

        private void EnableCheckBoxes(params int[] checkboxIndices)
        {
            foreach (int index in checkboxIndices)
            {
                GetCheckBoxByIndex(index).Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sipraşiniz Başarıyla Alındı.");
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
    }
}
