using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegates
{
    class AutoService
    {
        string auto;

        private Delegate1 _meth;
        public Delegate1 meth
        {
            get { return _meth; }
        }

        public AutoService(string a, bool b) => _meth = b == true ? () => { return a[0]; } : () => { return a[a.Length - 1]; };
    }
}
