using System;

namespace Interview.Implementation
{
    public class Custommer<T> : Interview.IStoreable<T>
    {
        private T _id;
        public T Id
        {
            get { return _id; }
            set { _id = value; }
        }
        private string _name;
        public string  Name
        {
            get { return _name; }
            set { _name = value; }
        }
    }
}
