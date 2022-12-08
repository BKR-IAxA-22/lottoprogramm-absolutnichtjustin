using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Lottozahlen
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        int[] numbers = new int[7];
        string[] input = new string[7];
        bool tip;

        public Form1()
        {
            InitializeComponent();
        }

        //Wenn Der "Generate" Button gedrückt wird
        private void button1_Click(object sender, EventArgs e)
        {
            //tempöräres int zum zwischenspeichern
            int temp;
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                temp = random.Next(1, 50);
                //.Contains schaut ob die Zahl in temp bereits im numbers Array existiert, wenn nicht fügt er diese hinzu
                if (!numbers.Contains(temp))
                {
                    numbers[i] = temp;
                }
                //Ansonsten geht er im Array einen Schritt zurück und generiert neue Zahlen
                else i--;
            }
            //Superzahl wird extra generiert, da kleinerer Zahlenbereich (0 - 9)
            numbers[6] = random.Next(0, 10);

            //Falls min. 1 Textbox keine Eingabe hat (würde das Programm zum crashen bringen)
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "")
            {
                MessageBox.Show("Bitte Tipp abgeben.");
                tip = false;
            }

            //Falls ein Tipp abgegeben wurde
            if (tip)
            {
                //Versucht die Eingabe in ein int umzuwandeln, speichert dabei die Zahl in temp ints zwischen. Gibt einen boolean zurück
                //Falls erfolgreich, ändert die Farbe der Textbox in grün, falls nicht wird die Farbe weiß.
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

                //Der Text des Labels wird auf die Zahl im Array gesetzt
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

        //Falls der "Random Tip" button gedrückt wird
        private void button2_Click(object sender, EventArgs e)
        {
            //Selbes vorgehen wie beim ersten Button nur mit input als Variable
            int temp;
            for (int i = 0; i < input.Length - 1; i++)
            {
                temp = random.Next(1, 50);
                if (!input.Contains(temp.ToString()))
                {
                    input[i] = temp.ToString();
                }
                else i--;
            }
            input[6] = Convert.ToString(random.Next(1, 10));

            //Text in den Textboxen werden auf die Zahlen im Array gesetzt
            textBox1.Text = input[0];
            textBox2.Text = input[1];
            textBox3.Text = input[2];
            textBox4.Text = input[3];
            textBox5.Text = input[4];
            textBox6.Text = input[5];
            textBox7.Text = input[6];
            textBox1.BackColor = Color.White;
            textBox2.BackColor = Color.White;
            textBox3.BackColor = Color.White;
            textBox4.BackColor = Color.White;
            textBox5.BackColor = Color.White;
            textBox6.BackColor = Color.White;
            textBox7.BackColor = Color.White;
        }

        //Falls der input verändert wird, wird der Text in der Textbox geändert
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
