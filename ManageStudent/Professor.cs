using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week09Homework {
    class Professor : Member, IFile {
        //public string DepartmentCode { get; set; }
        //private string _number;
        //public string Number
        //{
        // get { return _number; }
        //}
        //
        //private string _name;
        //public string Name
        //{
        // get { return _name; }
        // set { _name = value; }
        //}
        public override string ToString() {
            return $"[{Number}]{Name}";
        }
        public Professor(string number, string name, Department dept)
        : base(number, name, dept) {
            //_number = number;
            //_name = name;
            //DepartmentCode = deptcode;
        }
        //public new string Record
        //public override string Record
        public string Record {
            get { return $"{Number}|{Name}|{Dept.Code}"; }
        }
        public static Professor Restore(string record, Department[]
       departments) {
            Professor prof = null;
            //참고
            try {
                var sdata = record.Trim().Split('|');
                var dept = departments.FirstOrDefault(m => m != null && m.Code == sdata[2]);
                prof = new Professor(sdata[0], sdata[1], dept);
            } catch (IndexOutOfRangeException ex) {
                Console.WriteLine("파일 포맷이 잘못되었음");
                Console.WriteLine(ex);
                throw ex;
            } catch (Exception ex) {
                Console.WriteLine(ex);
            }
            return prof;
        }
    }
}
