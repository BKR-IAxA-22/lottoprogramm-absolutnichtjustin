using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Lottozahlen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random random = new Random();
        int[] numbers = new int[7];
        string[] input = new string[7];
        bool tip;

        private void button1_Click(object sender, EventArgs e)
        {
            int temp;
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                temp = random.Next(1, 50);
                if (!numbers.Contains(temp))
                {
                    numbers[i] = temp;
                }
            }
            numbers[6] = random.Next(0, 10);

            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "")
            {
                MessageBox.Show("Bitte Tipp abgeben.");
                tip = false;
            }

            if (tip)
            {
                if (int.TryParse(textBox1.Text, out int temp2) && numbers.Contains(temp2)) textBox1.BackColor = Color.Green;
                else textBox1.BackColor = Color.White;
                if (int.TryParse(textBox2.Text, out int temp3) && numbers.Contains(temp3)) textBox2.BackColor = Color.Green;
                else textBox2.BackColor = Color.White;
                if (int.TryParse(textBox3.Text, out int temp4) && numbers.Contains(temp4)) textBox3.BackColor = Color.Green;
                else textBox3.BackColor = Color.White;
                if (int.TryParse(textBox4.Text, out int temp5) && numbers.Contains(temp5)) textBox4.BackColor = Color.Green;
                else textBox4.BackColor = Color.White;
                if (int.TryParse(textBox5.Text, out int temp6) && numbers.Contains(temp6)) textBox5.BackColor = Color.Green;
                else textBox5.BackColor = Color.White;
                if (int.TryParse(textBox6.Text, out int temp7) && numbers.Contains(temp7)) textBox6.BackColor = Color.Green;
                else textBox6.BackColor = Color.White;
                if (int.TryParse(textBox7.Text, out int temp8) && numbers.Contains(temp8)) textBox7.BackColor = Color.Green;
                else textBox7.BackColor = Color.White;

                label1.Text = Convert.ToString(numbers[0]);
                label2.Text = Convert.ToString(numbers[1]);
                label3.Text = Convert.ToString(numbers[2]);
                label4.Text = Convert.ToString(numbers[3]);
                label5.Text = Convert.ToString(numbers[4]);
                label6.Text = Convert.ToString(numbers[5]);
                label7.Text = Convert.ToString(numbers[6]);
            }
            tip = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            input[0] = textBox1.Text;
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            input[1] = textBox2.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            input[2] = textBox3.Text;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            input[3] = textBox4.Text;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            input[4] = textBox5.Text;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            input[5] = textBox6.Text;
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            input[6] = textBox7.Text;
        }
    }
}
