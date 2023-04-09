using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sudokuCLI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int meret = Convert.ToInt32(textBox1.Text);
            if (meret > 4)
            {
                meret--;
                textBox1.Text = meret.ToString();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int meret = Convert.ToInt32(textBox1.Text);
            if (meret < 9) 
            {
                meret++;
                textBox1.Text = meret.ToString();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int hossz = textBox2.Text.Length;
            label3.Text = ("Hossz: ") + hossz;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int hossz = textBox2.Text.Length;
            int meret = Convert.ToInt32(textBox1.Text);
            if (hossz==meret*meret)
            {
                MessageBox.Show("A feladvány megfelelő hosszúságú!");
            }
            else if (hossz<meret*meret)
            {
                MessageBox.Show("A feladvány túl rövid: kell még " + (meret*meret-hossz) + " számjegy");
            }
            else
            {
                MessageBox.Show("A feladvány túl hosszú: törlendő "+ (hossz- meret * meret) + " számjegy");
            }
        }
    }
}
