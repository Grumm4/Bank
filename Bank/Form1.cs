using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using bb;

namespace Bank
{
    public partial class Form1 : Form
    {
        Class1 a = new Class1();
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            a.sum = 0;
            Class1 b_cl = new Class1(0);
            listBox1.Items.Add($"Инициализирован пользователь с именем: {textBox1.Text}   ||   Денег на счету: {a.sum}");
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            a.sum += Convert.ToInt32(textBox2.Text);
            listBox1.Items.Add($"Счёт пополнен на {textBox2.Text}   ||   Денег на счету: {a.sum}");
            textBox2.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            a.sum -= Convert.ToInt32(textBox2.Text);
            listBox1.Items.Add($"Со счёта снято {textBox2.Text}   ||   Денег на счету: {a.sum}");
            textBox2.Text = "";
        }
    }
}
