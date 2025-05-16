using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace ZooApp
{
    class RobotBird : Animal, IRobot
    {
        public RobotBird(string n, COLOR c) : base(n, c) {
        //public RobotBird(string n, COLOR c, int y) : base(n, c, y) {

        }

        public override string ToString() {
            return $"ROBOTBIRD: {Name}";
        }

        //자동 구현 프로퍼티 o
        public int BatteryLevel { get; set; }

        public void Charge() {
            BatteryLevel = 1000;
        }

        public string Fly(int count) {
            string retValue = "";
            for (int i=0; i<count; i++) {
                retValue = "푸드득~";
            }
            return retValue;
        }

        protected override bool AddLevel(int level) {
            if (_level + level <= 50) {
                _level += level;
                return true;
            } else {
                _level = 50;
                return false;
            }
        }
    }
}
