using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ZooApp
{
    class Cat : Animal
    {
        public Cat(string name, COLOR color) : base(name, color) {

        }

        public override string ToString() {
            return $"CAT: {Name}";
        }

        public string Meow(int count) {
            string retValue = "";
            for (int i=0; i<count; i++) {
                retValue = "냥!";
            }
            return retValue;
        }

        public override void Eat() { AddLevel(300); } 

        public new void Play() { AddLevel(200); }

        protected override bool AddLevel(int level) {
            if (_level + level <= 2000) {
                _level += level;
                return true;
            } else {
                _level = 2000;
                return false;
            }
        }
    }
}
