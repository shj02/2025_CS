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
    class Dog : Animal
{
    //아래 두개는 부모 것을 접근 못해서
    //그대로 사용해도 문제 없음.
    //private string _name;
    //private int _level;

    //아래 한 개는 부모 것에 접근 할 수 
    //있지만 나만의 것을 만들 때 쓰는 경우
    //private new COLOR _color;

    //부모에도 없는 것
    private int _year;

    //나중에 한번 주석을 풀어서 이해를 해보세요.
    // public string Name { get { return _name; } }
    // public int Level { get { return _level; } }
    // public COLOR Color { get { return _color; } }
    public int Year { get { return _year; } }

    public Dog(string name, COLOR color, int year)
        //: base() //기본 base()생성자
        : base(name, color)
    {
        _year = year;
    }

    //Object 클래스의 ToString()을
    //override(재정의)한다.
    public override string ToString()
    {
        return $"DOG:{Name}";
    }

    public string Bark(int count)
    {
        string retValue = "";
        for (int i = 0; i < count; i++) {
            retValue += "왈!";
        }
        return retValue;
    }

    //오버라이딩(재정의): 대상-메소드
    public override void Eat() { AddLevel(30); }

    //하이딩(숨기기): 대상-변수, 프로퍼티, 메소드
    public new void Play() { AddLevel(20); }

    protected override bool AddLevel(int level)
    {
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
