using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week09Homework
{
    enum YEAR
    {
        ONE = 0,
        TWO,
        THREE,
        FOUR,

        END,
    }

    enum CLASS
    {
        A = 0,
        B,
        C,

        END,
    }

    enum REG_STATUS
    {
        ENROLLED = 0,
        GRADUATED,
        ONLEAVE,
        EXPELLED,

        END,
    }

    class Student : Member
    {
        //static 필드
        public static Dictionary<YEAR, string> YearName
            = new Dictionary<YEAR, string>{
                { YEAR.ONE,   "1학년" },
                { YEAR.TWO,   "2학년" },
                { YEAR.THREE, "3학년" },
                { YEAR.FOUR,  "4학년(심화)" },
            };

        public static Dictionary<REG_STATUS, string> RegStatusName
            = new Dictionary<REG_STATUS, string>{
                { REG_STATUS.ENROLLED,    "재학"},
                { REG_STATUS.GRADUATED,   "졸업"},
                { REG_STATUS.ONLEAVE,     "휴학"},
                { REG_STATUS.EXPELLED,    "퇴학"},
            };

        //public string Number { get; private set; }
        //public string Name { get; private set; }
        public DateTime BirthInfo { get; private set; }
        public void SetBirthInfo(int year, int month, int day)
        {
            BirthInfo = new DateTime(year, month, day);
        }
        //public string DepartmentCode { get; set; }
        public string AdvisorNumber { get; set; }
        public YEAR Year { get; set; }
        public CLASS Class { get; set; }
        public REG_STATUS RegStatus { get; set; }
        public string Address { get; set; }
        public string Contact { get; set; }

        public Student(string number, string name) : base(number, name, null)
        {
            //Number = number;
            //Name = name;
        }

        //오버로딩
        public Student(string number, string name, Department dept) : base(number, name, dept) {
            //Number = number;
            //Name = name;
        }

        public override string ToString()
        {
            return $"[{this.Number}]{this.Name}";
        }
    }
}
