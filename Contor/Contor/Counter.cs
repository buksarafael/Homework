using System;

namespace Contor
{
    internal class Counter
    {
        private int n;

        public int Value
        {
            get { return n; }


        }

        public Counter()
        {
            n = 0;
        }

        internal void Count()
        {
            n++;
            if (n == 10)
            {
                n = 0;
            }
        }
        public override string ToString()
        {
            return "[" + n.ToString() + "]";
        }
    }
}