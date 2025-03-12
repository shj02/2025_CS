using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week02Proj01
{
    public partial class FormMain: Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnOutput01_Click(object sender, EventArgs e)
        {
            bool isToggle = chkToggle.Checked; //true or false
            if (isToggle) {
                string data1 = tbxInput1.Text;
                string data2 = tbxInput2.Text;
                string result = data1 + data2; //문자열 연결 연산자
                lblResult.Text = result;
            } else {
                int data1 = int.Parse(tbxInput1.Text);
                int data2 = int.Parse(tbxInput2.Text);
                int result = data1 + data2; //산술 연산자
                lblResult.Text = result.ToString();
            }
        }

        private void btnOutput02_Click(object sender, EventArgs e)
        {
            if (chkToggle.Checked == false) {
                int data1 = int.Parse(tbxInput1.Text);
                int data2 = int.Parse(tbxInput2.Text);
                int result = data1 + data2; //산술 연산자
                lblResult.Text = "더하기 : " + result.ToString();
            } else {
                int data1 = int.Parse(tbxInput1.Text);
                int data2 = int.Parse(tbxInput2.Text);
                int result = data1 - data2; //산술 연산자
                lblResult.Text = "빼기 : " + result; //문자열+숫자 => 문자열 연결 연산자로 동작
            }
        }

        private void btnOutput03_Click(object sender, EventArgs e)
        {
            int data1 = int.Parse(tbxInput1.Text);
            int data2 = int.Parse(tbxInput2.Text);
            if (chkToggle.Checked == false)
            {
                int result = data1 + data2; //산술 연산자
                lblResult.Text = string.Format("더하기 : {0}", result);
            }
            else
            {
                int result = data1 - data2; //산술 연산자
                lblResult.Text = $"빼기 : {result}"; //문자열 보간법
            }
        }

        private void btnOutput04_Click(object sender, EventArgs e)
        {
            double data1 = double.Parse(tbxInput1.Text);
            double data2 = double.Parse(tbxInput2.Text);
            if (chkToggle.Checked == false)
            {
                double result = data1 + data2; //산술 연산자
                lblResult.Text = string.Format("더하기 : {0}", result);
            }
            else
            {
                double result = data1 - data2; //산술 연산자
                lblResult.Text = $"빼기 : {result}"; //문자열 보간법
            }
        }

        private void btnOutput05_Click(object sender, EventArgs e)
        {
            lblResult.Text = tbxInput1.Text;
            lblResult.Text += Environment.NewLine; //"\r\n", Environment.NewLine: 운영체제에 적합한 줄바꿈으로 변환
            //lblResult.Text = Environment.NewLine;
            lblResult.Text += tbxInput1.Text.GetType(); //string
            //lblResult.Text = tbxInput1.Text.GetType(); GetType으로 가져오는 건 문자열이 아님
            lblResult.Text += Environment.NewLine;

            lblResult.Text += tbxInput1.Text[0]; //char 문자형
            // lblResult.Text = tbxInput1.Text[0];
            lblResult.Text += Environment.NewLine;
            lblResult.Text += tbxInput1.Text[0].GetType(); //char

            lblResult.Text += Environment.NewLine;
            char test1 = tbxInput1.Text[0];
            //c언어: ascii char 1바이트
            //c#언어 : unicode char 2바이트

            byte result1 = (byte)test1; //1바이트 정수형
            sbyte result4 = (sbyte)test1; //1바이트 정수형 (부호지원)
            short result2 = (short)test1; //2바이트 정수형 (부호지원)
            ushort result3 = test1; //2바이트 정수형

            lblResult.Text += $"{test1}, {result1}, {result2}, {result3}";
        }

        private void btnOutput06_Click(object sender, EventArgs e)
        {
            //정수 -> 실수 : ok
            //실수 -> 정수 : 처리 필요
            //작은 숫자 -> 큰 숫자 : ok
            //큰 숫자 -> 작은 숫자 : 처리 필요

            int data1 = short.Parse(tbxInput1.Text); //2바이트 -> 4바이트
            float data2 = (float)double.Parse(tbxInput2.Text);
            long data3 = long.Parse(tbxInput3.Text);
            int data4 = (int)data3;

            double result1 = data1 + data2 + data3 + data4;
            lblResult.Text = result1.ToString();

            //(int)1.9 + (int)1.6 => 1 + 1 = 2
            long result2 = data1 + (long)data2 + data3 + data4; //long 8바이트 < double 8바이트 (같은 8바이트지만 double이 큼)
            lblResult.Text = result2.ToString();

            //(int)(1.9 + 1.6) -> (int)3.5 => 3
            long result3 = (long)(data1 + data2 + data3 + data4);
            lblResult.Text = result3.ToString();
        }
    }
}
