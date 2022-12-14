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
using Microsoft.Toolkit.Uwp.Notifications;


namespace Bank
{
    public partial class Form1 : Form
    {
        Class1 a = new Class1();
        public Form1()
        {
            InitializeComponent();
        }

        void Notific()
        {
            new ToastContentBuilder()
                .AddText($"{listBox1.Items[listBox1.Items.Count - 1]}")
                .Show();
            
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public Class1 b = new Class1(0);
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            
            listBox1.Items.Add($"Инициализирован пользователь с именем: {textBox1.Text}   ||   Денег на счету: {b.Sum}");
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            b.Notify += DisplayMessage;
            b.Put(Convert.ToInt32(textBox2.Text));
            Notific();
            b.Notify -= DisplayMessage;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            b.Notify += DisplayMessage;
            b.Take(Convert.ToInt32(textBox2.Text));
            Notific();
            b.Notify -= DisplayMessage;
        }
        void DisplayMessage(Class1 sender, AccountEventArgs e)
        {
            //listBox1.Items.Add($"Сумма транзакции: {e.Sum}");
            listBox1.Items.Add($"{e.Message} | Остаток на счету: {sender.Sum}");
            //listBox1.Items.Add($"Остаток на счету: {sender.Sum}\n");

        }
    }
}
