using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lottozahlen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Main();
        }
        Random random = new Random();
        int[] numbers = new int[7];
        string[] input = new string[7];
        void Main()
        {
            /*
            for(int i = 0; i < numbers.Length; i++)
            {
                    numbers[i] = random.Next(1, 49);
            }
            label1.Text = Convert.ToString(numbers[0]);
            label2.Text = Convert.ToString(numbers[1]);
            label3.Text = Convert.ToString(numbers[2]);
            label4.Text = Convert.ToString(numbers[3]);
            label5.Text = Convert.ToString(numbers[4]);
            label6.Text = Convert.ToString(numbers[5]);
            label7.Text = Convert.ToString(numbers[6]);
            */

            textBox1.Text = input[0];
            textBox1.Text = input[1];
            textBox1.Text = input[2];
            textBox1.Text = input[3];
            textBox1.Text = input[4];
            textBox1.Text = input[5];
            textBox1.Text = input[6];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int temp;
            for (int i = 0; i < numbers.Length-1; i++)
            {
                temp = random.Next(1, 49);
                if (!numbers.Contains(temp))
                {
                    numbers[i] = temp;
                }

                if (numbers[i].ToString() == input[i])
                {

                }
                
            }
            numbers[6] = random.Next(1, 49);
            label1.Text = Convert.ToString(numbers[0]);
            label2.Text = Convert.ToString(numbers[1]);
            label3.Text = Convert.ToString(numbers[2]);
            label4.Text = Convert.ToString(numbers[3]);
            label5.Text = Convert.ToString(numbers[4]);
            label6.Text = Convert.ToString(numbers[5]);
            label7.Text = Convert.ToString(numbers[6]);
        }




        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
