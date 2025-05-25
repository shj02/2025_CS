using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooApp {
    abstract class Animal { //추상 클래스
        private string _name;
        protected int _level;
        protected COLOR _color;

        public string Name { get { return _name; } }
        public COLOR Color { get { return _color; } }
        public int Level { get { return _level; } }

        public Animal(string name, COLOR color) {
            _name = name;
            _color = color;
        }

        //Object 클래스의 ToString()을 override(재정의)한다.
        public override string ToString() {
            return $"ANIMAL: {_name}";
        }

        public virtual void Eat() { AddLevel(3); }

        public void Play() { AddLevel(2); }

        abstract protected bool AddLevel(int level); //추상메소드는 머리(header)만 있고 몸(내용)은 없음!
    }
}
