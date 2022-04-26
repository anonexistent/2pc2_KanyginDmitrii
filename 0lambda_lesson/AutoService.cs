using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0lambda_lesson
{
    internal class AutoService
    {
        string auto;

        private MD _meth;
        public MD meth
        {
            get { return _meth; }
        }

        public AutoService(string a, bool b) => _meth = b == true ? () => { return a[0]; } : () => { return a[a.Length - 1]; };
    }
}
