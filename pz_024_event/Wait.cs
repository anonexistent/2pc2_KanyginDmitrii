using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_024_event
{
    internal class Wait
    {
        private static MD _wait200;
        public static MD wait200
        {
            get { return _wait200; }
            set { _wait200 = value; }
        }

        private static MD _wait800;
        public static event MD ME200;
        public static event MD ME800;

        void Temp200(int a)
        {
            ME200 += a == 200 ? (a) => { global::System.Console.WriteLine("warning!!!!\ta\twarning!!!!"); } : null;
            ME200(a);
        }

        void Temp800(int a) 
        { 
            ME800 += a == 800 ? (a) => { global::System.Console.WriteLine("warning!!!!\ta\twarning!!!!"); } : null;
            ME800(a);
        }
        
    }
}
