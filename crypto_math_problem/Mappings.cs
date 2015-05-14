using System;

namespace crypto_math_problem
{
    public class Mappings
    {
        public int a { get; set; }
        public int b { get; set; }
        public int c { get; set; }
        public int d { get; set; }
        public int e { get; set; }
        public int f { get; set; }
        public int g { get; set; }
        public int h { get; set; }
        public int i { get; set; }
        public int j { get; set; }
        public int k { get; set; }
        public int l { get; set; }
        public int m { get; set; }
        public int n { get; set; }
        public int o { get; set; }
        public int p { get; set; }
        public int q { get; set; }
        public int r { get; set; }
        public int s { get; set; }
        public int t { get; set; }
        public int u { get; set; }
        public int v { get; set; }
        public int w { get; set; }
        public int x { get; set; }
        public int y { get; set; }
        public int z { get; set; }


        public int this[int number]
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