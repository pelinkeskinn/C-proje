namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        private Form2 form2;

        public Form1()
        {
            InitializeComponent();
            form2 = new Form2();
        }





        private void UpdateForm2CheckBoxes()
        {
            form2.EnableCheckBoxes(checkBox1.Checked, checkBox2.Checked);
        }

        private void openForm2Button_Click(object sender, EventArgs e)
        {
            form2.Show();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {

            checkBox2.Enabled = false;
            UpdateForm2CheckBoxes();
        }

        private void checkBox2_CheckedChanged_1(object sender, EventArgs e)
        {

            checkBox1.Enabled = false;
            UpdateForm2CheckBoxes();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string selectedOption = comboBox1.SelectedItem.ToString();

            switch (selectedOption)
            {
                case "Sert":
                    form2.DisableCheckBoxes2(2, 3, 4, 5, 6, 8, 9);
                    break;
                case "Orta":
                    form2.DisableCheckBoxes2(1, 4, 5, 6, 7, 9, 10);
                    break;
                case "Yumuþak/Tatlý":
                    form2.DisableCheckBoxes2(1, 2, 3, 5, 6, 7, 8, 9, 10);
                    break;
                case "Kafeinsiz":
                    form2.DisableCheckBoxes2(1, 2, 3, 4, 7, 8, 10);
                    break;
                default:
                    break;
            }
            form2.Show();
        }
    }
}