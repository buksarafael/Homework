using System;

namespace Lab4_2
{
    public class DT
    {
        int h, mm, ss, zi, luna, an;
        public DT()
        {
            DateTime dt = DateTime.Now;
            h = dt.Hour;
            mm = dt.Minute;
            ss = dt.Second;
            zi = dt.Day;
            luna = dt.Month;
            an = dt.Year;
        }
        public DT(int an, int luna, int zi, int h, int mm, int ss)
        {
            this.h = h;
            this.mm = mm;
            this.ss = ss;
            this.zi = zi;
            this.luna = luna;
            this.an = an;

        }

        //proprietatea Read-Only
        public int Year
        {
            get
            {
                return an;
            }
        }

        internal void AddYears(int v)
        {
            an = an + v;
        }

        //TODO
        //proprietati readonly pentru celelalte campuri
        public override string ToString()
        {
            return h.ToString() + ":" + mm.ToString() + ":" + ss.ToString() + " " + zi.ToString() + "/" + luna.ToString() + "/" + an.ToString();
        }
    }
}