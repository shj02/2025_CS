using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week09Homework
{
    class Professor : Member, IFile
    {
        public override string ToString()
        {
            return $"[{Number}]{Name}";
        }

        public Professor(string number, string name, Department dept)
            : base(number, name, dept)
        {
          
        }

        public string Record {
            get { return $"{Number}|{Name}|{Dept.Code}"; }
        }

        public static Professor Restore(string record, Department[] departments) {
            Professor prof = null;

            try {
                var sdatas = record.Trim().Split('|');

                var dept = departments.FirstOrDefault(m => m != null && m.Code == sdatas[2]);

                prof = new Professor(sdatas[0], sdatas[1], dept);
            } catch(Exception ex) {
                Console.WriteLine(ex); //에러를 남김
                throw ex; //에러를 다시 뱉어냄
            }

            return prof;
        }
    }
}
