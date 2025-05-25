using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week09Homework
{
    class Department : object
    {
        private string _code;

        public string Code
        {
            get { return _code; }
            private set {
                if (false == string.IsNullOrEmpty(value)) {
                    _code = value;
                } else {
                    throw new Exception("Value is Empty");
                }
            }
        }

        public string GetCode()
        {
            return _code;
        }

        private void SetCode(string value)
        {
            if (false == string.IsNullOrEmpty(value)) {
                _code = value;
            }
        }

        private string _name;

        public string Name
        {
            get { return _name; }
            private set {
                if (false == string.IsNullOrEmpty(value)
                    && value.Length >= 2) {
                    _name = value;
                } else {
                    throw new Exception("Value is Empty");
                }
            }
        }

        public override string ToString()
        {
            return $"[{Code}] {Name}";
        }

#if false
        public Department()
        {
        
        }
#endif

        public Department(string code, string name)
        {
            Code = code;
            Name = name;
        }
    }
}
