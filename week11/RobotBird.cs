using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ZooApp
{
    class RobotBird : Animal, IRobot
    {
        public RobotBird
           (string name, COLOR color) : base(name, color)
        {

        }

        int _batteryLevel;
        public int BatteryLevel
        {
            get { return _batteryLevel; }
            set {
                if (value > 1000) {
                    _batteryLevel = 1000;
                } else {
                    _batteryLevel = value;
                }
            }
        }

        public void Charge()
        {
            BatteryLevel = 1000;
        }

        public override string ToString()
        {
            return $"ROBOTBIRD:{Name}";
        }

        public string Fly(int count)
        {
            string retValue = "";
            for (int i = 0; i < count; i++) {
                retValue += "푸드득~";
            }
            return retValue;
        }

        protected override bool AddLevel(int level)
        {
            if (_level + level <= 50) {
                _level += level;
                return true;
            } else {
                _level = 100;
                return false;
            }
        }
    }
}
