using System;
using System.Windows.Forms;

namespace ruscehproj2
{
    public partial class End : Form
    {
        private readonly Timer T = new Timer();
        private int Time;
        private bool exit;

        public End(string Text)
        {
            InitializeComponent();
            Label2.Text = Text;
            T.Tick += T_Tick;
            T.Interval = 1000;
            T.Start();
        }

        private void T_Tick(object sender, EventArgs e)
        {
            Time++;
            label1.Text = "Введите пароль для продолжения, либо подождите еще " + (120 - Time).ToString() + " секунд...";
            if (Time > 120)
            {
                T.Stop();
                Time = 0;
                exit = true;
                FormManager.disp();
                Dispose();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "vk" || textBox1.Text == "мл")
            {
                exit = true;
                FormManager.disp();
                Dispose();
            }
        }

        private void End_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!exit)
            {
                e.Cancel = true;
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                if (textBox1.Text == "vk" || textBox1.Text == "мл")
                {
                    exit = true;
                    FormManager.disp();
                    Dispose();
                }
            }
        }
    }
}