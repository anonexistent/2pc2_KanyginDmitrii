namespace _0delegate
{
    internal class AutoService
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
