using System;

namespace FirstForm
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox2.Text); /// 문자 -> 숫자
            a *= 2;
            label1.Text = a.ToString(); /// 숫자 -> 문자
        }
    }
}

/// 도구 : textbox, button, label
