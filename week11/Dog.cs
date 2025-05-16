using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Security.Authentication.ExtendedProtection.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace ZooApp
{
    class Dog : Animal //Animal 상속
    {
        //아래 2개(_name, _level)는 부모 것을 접근 못해서(private) 그대로 사용해도 문제 없음
        //private string _name;
        //private int _level;

        //초록색 밑줄 : 물려받았는데(protected) 굳이 왜 썼어? 오류는 아니지만..
        //부모 것에 접근할 수 있지만(protected) 나만의 것을 만들 때 쓰는 경우 -> new
        //private new COLOR _color;

        //_year는 부모에도 없기 때문에 만들어야 함
        int _year;

        //나중에 한 번 주석 풀어서 이해해보기
        //_name, _color 오류 이유 : Animal에 private이라 접근 x
        //public string Name { get { return _name; } }
        //public COLOR Color { get { return _color; } }
        //public int Level { get { return _level; } }
        public int Year { get { return _year; } }

        public Dog(string name, COLOR color, int year) //+ Dog(string, COLOR, int)
            //: base() //기본 base() 생성자 (base : 부모, this : 나)
            : base(name, color)
            { 
            //_name = name;
            //_color = color;
            _year = year;
        }

        public override string ToString() { //+ ToString() : string
            return $"DOG: {Name}"; //_name -> Name으로 변경 (프로퍼티를 통해)
        }

        public string Bark(int count) { //+ Bark(int) : string
            string retValue = "";
            for (int i=0; i<count; i++) {
                retValue = "왈!";
            }
            return retValue;
        }

        //C#에서는 하이딩이 기본, 자바에서는 하이딩이 없고 오버라이딩이 기본
        //오버라이딩
        public override void Eat() { AddLevel(30); } //+ Eat() : void

        //하이딩 : 부모 거를 숨기고 내 거를 새로 만듦
        public new void Play() { AddLevel(20); } //+ Play() : void

        protected override bool AddLevel(int level) {
            if (_level + level <= 100) {
                _level += level;
                return true;
            } else {
                _level = 100;
                return false;
            }
        }
    }
}
