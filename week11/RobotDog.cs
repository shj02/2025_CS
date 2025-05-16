using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooApp
{
    class RobotDog : Dog, IRobot
    {
        public RobotDog(string n, COLOR c, int y) : base(n, c, y) {

        }

        public override string ToString() {
            return $"ROBOTDOG: {Name}";
        }

        //자동 구현 프로퍼티 o
        public int BatteryLevel { get; set; }

        public void Charge() {
            BatteryLevel = 1000;
        }
    }
}
