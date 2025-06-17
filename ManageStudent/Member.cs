using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week09Homework {
    abstract class Member {
        public string Number { get; protected set; }
        public string Name { get; protected set; }
        public Department Dept { get; set; }
        //public string Record { get; } //자동구현프로퍼티
        //public virtual string Record { get; } //가상자동구현프로퍼티
        //public abstract string Record { get; } //추상프로퍼티
        public Member
        (string number, string name, Department dept) {
            this.Number = number;
            this.Name = name;
            this.Dept = dept;
        }
    }
}
