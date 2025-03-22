using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week03Proj01
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProcess01_Click(object sender, EventArgs e)
        {
            //배열의 가장 큰 특징 : 고정 길이
            //배열 생성 시 사용할 길이(Length)를 정해놓고 시작해야 함
            TextBox[] arrTbxData = new TextBox[5];
            arrTbxData[0] = tbxData1;
            arrTbxData[1] = tbxData2;
            arrTbxData[2] = tbxData3;
            arrTbxData[3] = tbxData4;
            arrTbxData[4] = tbxData5;

            //int[] arrIntData = new int[5];
            //배열의 길이는 반드시 상수(변하지 않는) 값이 들어가야 함
            //배열의 길이는 생성 변하지 않기 때문에 다른 배열의 길이로 사용해도 괜찮음
            //배열 요소의 값은 struct는 struct의 기본값(int는 0, class는 null)
            int[] arrIntData = new int[arrTbxData.Length];

            for(int i = 0; i < arrTbxData.Length; i++)
            {
                if (arrTbxData[i].Text != null && arrTbxData[i].Text != "")
                {
                    arrIntData[i] = int.Parse(arrTbxData[i].Text);
                }
                else
                {
                    //값이 없으면 0이 자동으로 할당됨
                }
            }

            int result = 0;
            if (rbtAdd.Checked)
            {
                for (int i = 0; i < arrIntData.Length; i++)
                {
                    result += arrIntData[i];
                }
            }
            else if (rbtSub.Checked)
            {
                result = arrIntData[0];
                for (int i = 1; i < arrIntData.Length; i++)
                {
                    result -= arrIntData[i];
                }
            }
            else if (rbtMul.Checked)
            {
                result = arrIntData[0];
                for (int i = 1; i < arrIntData.Length; i++)
                {
                    result *= arrIntData[i];
                }
            }
            else if (rbtDiv.Checked)
            {
                result = arrIntData[0];
                for (int i = 1; i < arrIntData.Length; i++)
                {
                    if (arrIntData[i] == 0)
                    {
                        arrTbxData[i].Focus();
                        MessageBox.Show("0은 안돼!");
                        return;
                    }
                    result /= arrIntData[i];
                }
            } else
            {
                MessageBox.Show("연산을 선택하세요.");
                return; //메소드를 즉시 종료하고 호출한 곳으로 돌아감
            }

            lblResult.Text = result.ToString();
        }

        private void btnProcess02_Click(object sender, EventArgs e)
        {
            //배열의 가장 큰 특징 : 고정길이
            //배열생성시 사용할 길이(Length)를 정해놓고 시작해야 함
            TextBox[] arrTbxData = new TextBox[5];
            arrTbxData[0] = tbxData1;
            arrTbxData[1] = tbxData2;
            arrTbxData[2] = tbxData3;
            arrTbxData[3] = tbxData4;
            arrTbxData[4] = tbxData5;

            int[] arrIntData = new int[arrTbxData.Length];

            for (int i = 0; i < arrTbxData.Length; i++)
            {
                //null도 아니고 비어있지 않음
                if (false == string.IsNullOrEmpty(arrTbxData[i].Text))
                {
                    arrIntData[i] = int.Parse(arrTbxData[i].Text);
                }
                else
                {
                    //값이 없으면 0이 자동으로 할당됨
                }
            }

            int result = 0;
            if (rbtAdd.Checked)
            {
                for (int i = 0; i < arrIntData.Length; i++)
                {
                    result += arrIntData[i];
                }
            }
            else if (rbtSub.Checked)
            {
                result = arrIntData[0];
                for (int i = 1; i < arrIntData.Length; i++)
                {
                    result -= arrIntData[i];
                }
            }
            else if (rbtMul.Checked)
            {
                result = arrIntData[0];
                for (int i = 1; i < arrIntData.Length; i++)
                {
                    result *= arrIntData[i];
                }
            }
            else if (rbtDiv.Checked)
            {
                result = arrIntData[0];
                for (int i = 1; i < arrIntData.Length; i++)
                {
                    if (arrIntData[i] == 0)
                    {
                        arrTbxData[i].Focus();
                        MessageBox.Show("0은 안돼!");
                        return;
                    }
                    result /= arrIntData[i];
                }
            }
            else
            {
                MessageBox.Show("연산을 선택하세요.");
                return;
            }

            lblResult.Text = result.ToString();
        }
    }
}
