using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userTXT = textBox1.Text.ToString();
            string userTXT2 = textBox2.Text.ToString();
            string userTXT3 = textBox3.Text.ToString();
            string userTXT4 = textBox4.Text.ToString();
            string userTXT5 = textBox5.Text.ToString();
            MessageBox.Show("добавлена новая задача в список");
            string result = textBox1.Text + " " + textBox2.Text + "" + textBox3 + "" + textBox4 + "" + textBox5 + "";
            textBox1.Text = null;
            textBox2.Text = null;   
            textBox3.Text = null;
            textBox4.Text = null;
            textBox5.Text = null;

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string userText = Text.ToString();
            MessageBox.Show("задача была удалена из списка");
            listBox1.Items.Remove(userText);
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
