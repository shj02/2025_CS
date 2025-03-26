  using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week03Proj01 {
    //class 구성요소 : 값(변수) + 기능(메소드)

    public partial class FormWeek2 : Form {
        //멤버변수, 인스터스 변수
        //c#: 인스턴스 필드(field)
        TextBox[] arrTbxData;

        
        //생성자
        //(1) 이름은 Class이름과 동일해야 함
        //(2) 반환타입 없음
        //인스턴스 생성 시 무조건 1번만 호출됨(*중요*)
        public FormWeek2() {
            InitializeComponent();
            arrTbxData = new TextBox[5];
            arrTbxData[0] = tbxData1;
            arrTbxData[1] = tbxData2;
            arrTbxData[2] = tbxData3;
            arrTbxData[3] = tbxData4;
            arrTbxData[4] = tbxData5;
        }

        private void btnProcess01_Click(object sender, EventArgs e) {
            //배열의 가장 큰 특징 : 고정 길이
            //배열 생성 시 사용할 길이(Length)를 정해놓고 시작해야 함
            //arrTbxData = new TextBox[5];
            //arrTbxData[0] = tbxData1;
            //arrTbxData[1] = tbxData2;
            //arrTbxData[2] = tbxData3;
            //arrTbxData[3] = tbxData4;
            //arrTbxData[4] = tbxData5;

            //int[] arrIntData = new int[5];
            //배열의 길이는 반드시 상수(변하지 않는) 값이 들어가야 함
            //배열의 길이는 생성 변하지 않기 때문에 다른 배열의 길이로 사용해도 괜찮음
            //배열 요소의 값은 struct는 struct의 기본값(int는 0, class는 null)
            int[] arrIntData = new int[arrTbxData.Length];

            for (int i = 0; i < arrTbxData.Length; i++) {
                if (arrTbxData[i].Text != null && arrTbxData[i].Text != "") {
                    arrIntData[i] = int.Parse(arrTbxData[i].Text);
                } else {
                    //값이 없으면 0이 자동으로 할당됨
                }
            }

            int result = 0;
            if (rbtAdd.Checked) {
                for (int i = 0; i < arrIntData.Length; i++) {
                    result += arrIntData[i];
                }
            } else if (rbtSub.Checked) {
                result = arrIntData[0];
                for (int i = 1; i < arrIntData.Length; i++) {
                    result -= arrIntData[i];
                }
            } else if (rbtMul.Checked) {
                result = arrIntData[0];
                for (int i = 1; i < arrIntData.Length; i++) {
                    result *= arrIntData[i];
                }
            } else if (rbtDiv.Checked) {
                result = arrIntData[0];
                for (int i = 1; i < arrIntData.Length; i++) {
                    if (arrIntData[i] == 0) {
                        arrTbxData[i].Focus();
                        MessageBox.Show("0은 안돼!");
                        return;
                    }
                    result /= arrIntData[i];
                }
            } else {
                MessageBox.Show("연산을 선택하세요.");
                return; //메소드를 즉시 종료하고 호출한 곳으로 돌아감
            }

            lblResult.Text = result.ToString();
        }

        private void btnProcess02_Click(object sender, EventArgs e) {
            //배열의 가장 큰 특징 : 고정길이
            //배열생성시 사용할 길이(Length)를 정해놓고 시작해야 함
            //TextBox[] arrTbxData = new TextBox[5];
            //arrTbxData[0] = tbxData1;
            //arrTbxData[1] = tbxData2;
            //arrTbxData[2] = tbxData3;
            //arrTbxData[3] = tbxData4;
            //arrTbxData[4] = tbxData5;

            int[] arrIntData = new int[arrTbxData.Length];

            for (int i = 0; i < arrTbxData.Length; i++) {
                //null도 아니고 비어있지 않음
                if (false == string.IsNullOrEmpty(arrTbxData[i].Text)) {
                    arrIntData[i] = int.Parse(arrTbxData[i].Text);
                } else {
                    //값이 없으면 0이 자동으로 할당됨
                }
            }

            int result = 0;
            if (rbtAdd.Checked) {
                for (int i = 0; i < arrIntData.Length; i++) {
                    result += arrIntData[i];
                }
            } else if (rbtSub.Checked) {
                result = arrIntData[0];
                for (int i = 1; i < arrIntData.Length; i++) {
                    result -= arrIntData[i];
                }
            } else if (rbtMul.Checked) {
                result = arrIntData[0];
                for (int i = 1; i < arrIntData.Length; i++) {
                    result *= arrIntData[i];
                }
            } else if (rbtDiv.Checked) {
                result = arrIntData[0];
                for (int i = 1; i < arrIntData.Length; i++) {
                    if (arrIntData[i] == 0) {
                        arrTbxData[i].Focus();
                        MessageBox.Show("0은 안돼!");
                        return;
                    }
                    result /= arrIntData[i];
                }
            } else {
                MessageBox.Show("연산을 선택하세요.");
                return;
            }

            lblResult.Text = result.ToString();
        }

        private void btnProcess03_Click(object sender, EventArgs e) {
            //Array vs List
            //고정길이  가변길이
            //Length   Count

            //string a = 11;
            //int b = a.Length; -> 2
            //a += "b"; -> 11b
            //b = a.Length; -> 3 -> a의 길이가 변함(11이 늘어난 것이 아닌 11b가 "새로 생긴" 것)

            //TextBox[] arrTbxData = new TextBox[5];
            //arrTbxData[0] = tbxData1;
            //arrTbxData[1] = tbxData2;
            //arrTbxData[2] = tbxData3;
            //arrTbxData[3] = tbxData4;
            //arrTbxData[4] = tbxData5;

            //<> : Generic(일반화) 지원 자료형
            List<int> arrIntData = new List<int>();

            for (int i = 0; i < arrTbxData.Length; i++) {
                if (false == string.IsNullOrEmpty(arrTbxData[i].Text)) {
                    //Add() 추가, Insert() 삽입, Remove() 내용지우기, RemoveAt() 위치지우기
                    arrIntData.Add(int.Parse(arrTbxData[i].Text));
                } else {
                    //값이 없으면 0이 자동으로 할당됨
                }
            }

            int result = 0;
            if (rbtAdd.Checked) {
                for (int i = 0; i < arrIntData.Count; i++) {
                    result += arrIntData[i];
                }
            } else if (rbtSub.Checked) {
                result = arrIntData[0];
                for (int i = 1; i < arrIntData.Count; i++) {
                    result -= arrIntData[i];
                }
            } else if (rbtMul.Checked) {
                result = arrIntData[0];
                for (int i = 1; i < arrIntData.Count; i++) {
                    result *= arrIntData[i];
                }
            } else if (rbtDiv.Checked) {
                result = arrIntData[0];
                for (int i = 1; i < arrIntData.Count; i++) {
                    if (arrIntData[i] == 0) {
                        arrTbxData[i].Focus();
                        MessageBox.Show("0은 안돼!");
                        return;
                    }
                    result /= arrIntData[i];
                }
            } else {
                MessageBox.Show("연산을 선택하세요.");
                return;
            }

            lblResult.Text = result.ToString();
        }

        private void btnProcess04_Click(object sender, EventArgs e) {
            //TextBox[] arrTbxData = new TextBox[5];
            //arrTbxData[0] = tbxData1;
            //arrTbxData[1] = tbxData2;
            //arrTbxData[2] = tbxData3;
            //arrTbxData[3] = tbxData4;
            //arrTbxData[4] = tbxData5;

            List<int> arrIntData = new List<int>();

            for (int i = 0; i < arrTbxData.Length; i++) {
                if (false == string.IsNullOrEmpty(arrTbxData[i].Text)) {
                    arrIntData.Add(int.Parse(arrTbxData[i].Text));
                } else {
                    //값이 없으면 0이 자동으로 할당됨
                }
            }

            int result = 0;
            string totalResult = "";

            if (chkAdd.Checked) {
                for (int i = 0; i < arrIntData.Count; i++) {
                    result += arrIntData[i];
                }
                totalResult += $"더하기:{result}";
                totalResult += Environment.NewLine;
            }
            if (chkSub.Checked) {
                result = arrIntData[0];
                for (int i = 1; i < arrIntData.Count; i++) {
                    result -= arrIntData[i];
                }
                totalResult += $"빼기:{result}";
                totalResult += Environment.NewLine;
            }
            if (chkMul.Checked) {
                result = arrIntData[0];
                for (int i = 1; i < arrIntData.Count; i++) {
                    result *= arrIntData[i];
                }
                totalResult += $"곱하기:{result}";
                totalResult += Environment.NewLine;
            }
            if (chkDiv.Checked) {
                result = arrIntData[0];
                for (int i = 1; i < arrIntData.Count; i++) {
                    if (arrIntData[i] == 0) {
                        arrTbxData[i].Focus();
                        MessageBox.Show("0은 안돼!");
                        return;
                    }
                    result /= arrIntData[i];
                }
                totalResult += $"나누기:{result}";
                totalResult += Environment.NewLine;
            }

            lblResult.Text = totalResult.ToString();
        }

        private void chkOption_CheckedChanged(object sender, EventArgs e) {
            RadioButton[] radioButtons = new RadioButton[] {
               rbtAdd,
               rbtSub,
               rbtMul,
               rbtDiv
            };
            List<CheckBox> checkBoxes = new List<CheckBox> {
                chkAdd,
                chkSub,
                chkMul,
                chkDiv
            };

            var isEng = chkOption.Checked;
            string word;

            for (int i = 0; i < radioButtons.Length; i++) {
                switch (i) {
                    case 0:
                        word = isEng ? "Add" : "더하기";
                        break;
                    case 1:
                        word = isEng ? "Sub" : "빼기";
                        break;
                    case 2:
                        word = isEng ? "Mul" : "곱하기";
                        break;
                    case 3:
                        word = isEng ? "Div" : "나누기";
                        break;
                    default:
                        continue;
                }
                radioButtons[i].Text = word;
                checkBoxes[i].Text = word;
            }
        }

        private void btnProcess06_Click(object sender, EventArgs e) {
            if (cmbBeverage.SelectedIndex < 0) {
                //Combo 미 선택 시 SelectedIndex == -1
                MessageBox.Show("음료를 선택하세요.");
                return;
            }
            int price = 0;

            switch (cmbBeverage.SelectedItem.ToString()) {
                case "아메리카노":
                    price = 2500;
                    break;
                case "카페라떼":
                    price = 3500;
                    break;
                case "플랫화이트":
                    price = 3800;
                    break;
                default:
                    return;
            }

            var iceoption = chkIce.Checked ? "아이스" : ""; //string
            var iceprice = chkIce.Checked ? 500 : 0; //int
            //iceprice = "100" 안됨

            lblResult.Text = $"{iceoption}{cmbBeverage.SelectedItem} : " + $"{price + iceprice}";
        }

        private void btnProcess07_Click(object sender, EventArgs e) {
            if (cmbBeverage.SelectedIndex < 0) {
                MessageBox.Show("음료를 선택하세요.");
                return;
            }
            int price = 0;

            switch (cmbBeverage.SelectedIndex) {
                case 0:
                    price = 2500;
                    break;
                case 1:
                    price = 3500;
                    break;
                case 2:
                    price = 3800;
                    break;
                default:
                    return;
            }

            var iceoption = chkIce.Checked ? "아이스" : "";
            var iceprice = chkIce.Checked ? 500 : 0;

            lblResult.Text = $"{iceoption}{cmbBeverage.SelectedItem} : " + $"{price + iceprice}";
        }

        private void btnProcess08_Click(object sender, EventArgs e) {
            if (cmbBeverage.SelectedIndex < 0) {
                MessageBox.Show("음료를 선택하세요.");
                return;
            }

            var prices = new int[] {
                2500,
                3500,
                3800
            };

            int price = 0;
            if (cmbBeverage.SelectedIndex < prices.Length) {
                price = prices[cmbBeverage.SelectedIndex];
            } else {
                return;
            }

                var iceoption = chkIce.Checked ? "아이스" : "";
            var iceprice = chkIce.Checked ? 500 : 0;

            lblResult.Text = $"{iceoption}{cmbBeverage.SelectedItem} : " + $"{price + iceprice}";
        }
    }
}
