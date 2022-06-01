namespace pz_024_event
{
    internal class Counter
    {
        private int _number;
        public int number
        {
            get { return _number; }
            set { _number = value > 100 ? 100 : value; }
        }

        public Counter(int a) => number = a;
    }
}
