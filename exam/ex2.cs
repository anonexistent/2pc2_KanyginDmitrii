using System;

namespace exam
{
    internal struct ex2
    {
        private string _name;
        public string name
        {
            get
            {
                if (_name == null) return "0";
                else return _name;
            }
            set { _name = value; }
        }

        private DateTime _birth;
        public DateTime birth
        {
            get
            {
                if (_birth == new DateTime(1, 1, 1)) return new DateTime(1, 1, 1);
                else return _birth;
            }
            set { _birth = value; }
        }

        private string _owner;
        public string owner
        {
            get { return _owner; }
            set { _owner = value; }
        }

    }
}
