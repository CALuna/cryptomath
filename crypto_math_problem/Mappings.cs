using System;

namespace crypto_math_problem
{
    public class Mappings<T>
    {
        public T a { get; set; }
        public T b { get; set; }
        public T c { get; set; }
        public T d { get; set; }
        public T e { get; set; }
        public T f { get; set; }
        public T g { get; set; }
        public T h { get; set; }
        public T i { get; set; }
        public T j { get; set; }
        public T k { get; set; }
        public T l { get; set; }
        public T m { get; set; }
        public T n { get; set; }
        public T o { get; set; }
        public T p { get; set; }
        public T q { get; set; }
        public T r { get; set; }
        public T s { get; set; }
        public T t { get; set; }
        public T u { get; set; }
        public T v { get; set; }
        public T w { get; set; }
        public T x { get; set; }
        public T y { get; set; }
        public T z { get; set; }


        public T this[int number]
        {
            get
            {
                switch (number)
                {
                    case 97:
                        return a;
                    case 98:
                        return b;
                    case 99:
                        return c;
                    case 100:
                        return d;
                    case 101:
                        return e;
                    case 102:
                        return f;
                    case 103:
                        return g;
                    case 104:
                        return h;
                    case 105:
                        return i;
                    case 106:
                        return j;
                    case 107:
                        return k;
                    case 108:
                        return l;
                    case 109:
                        return m;
                    case 110:
                        return n;
                    case 111:
                        return o;
                    case 112:
                        return p;
                    case 113:
                        return q;
                    case 114:
                        return r;
                    case 115:
                        return s;
                    case 116:
                        return t;
                    case 117:
                        return u;
                    case 118:
                        return v;
                    case 119:
                        return w;
                    case 120:
                        return x;
                    case 121:
                        return y;
                    case 122:
                        return z;

                    default:
                        throw new IndexOutOfRangeException();
                }
            
            }
            set
            {
                switch (number)
                {
                    case 97:
                        a = value;
                        break;
                    case 98:
                        b = value;
                        break;
                    case 99:
                        c = value;
                        break;
                    case 100:
                        d = value;
                        break;
                    case 101:
                        e = value;
                        break;
                    case 102:
                        f = value;
                        break;
                    case 103:
                        g = value;
                        break;
                    case 104:
                        h = value;
                        break;
                    case 105:
                        i = value;
                        break;
                    case 106:
                        j = value;
                        break;
                    case 107:
                        k = value;
                        break;
                    case 108:
                        l = value;
                        break;
                    case 109:
                        m = value;
                        break;
                    case 110:
                        n = value;
                        break;
                    case 111:
                        o = value;
                        break;
                    case 112:
                        p = value;
                        break;
                    case 113:
                        q = value;
                        break;
                    case 114:
                        r = value;
                        break;
                    case 115:
                        s = value;
                        break;
                    case 116:
                        t = value;
                        break;
                    case 117:
                        u = value;
                        break;
                    case 118:
                        v = value;
                        break;
                    case 119:
                        w = value;
                        break;
                    case 120:
                        x = value;
                        break;
                    case 121:
                        y = value;
                        break;
                    case 122:
                        z = value;
                        break;
                    default:    
                        throw new IndexOutOfRangeException();
                }
           
            }
        }
    }
}