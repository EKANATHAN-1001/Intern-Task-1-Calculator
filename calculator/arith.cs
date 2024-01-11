using System;

namespace calculator
{
    public class arith
    {
        public arith()
        { }
        public float add(float n1, float n2)
        {
            return n1 + n2;
        }
        public float sub(float n1, float n2)
        {
            return n1 - n2;
        }
        public float mul(float n1, float n2)
        {
            return n1 * n2;
        }
        public float divi(float n1, float n2)
        {
            if (n2 != 0)
                return n1 / n2;
            else
                return 0;
        }
    }
}
