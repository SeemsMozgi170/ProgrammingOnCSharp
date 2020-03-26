<<<<<<< HEAD
﻿using System;

namespace lab2
{
    class CStatic
    {
        private int m = 35;
        public int y
        {
            get
            {
                return m;
            }

            set
            {
                m = value;
            }
        }
    }
    class Cmin
    {
        private int m = 35;
        public int y
        {
            get
            {
                return m;
            }
            set
            {
                m = value;
            }
        }
        public static int min(int x, int y)
        {

            return (x < y) ? x : y;
        }
        public static int minabs(ref int x, ref int y)
        {
            x = (x < 0) ? -x : x;
            y = (y < 0) ? -y : y;
            int z = (x < y) ? x : y;
            return z;
        }

    }
    class Rmas
    {
        protected float[] msf = new float[10];
        public float this[int j]
        {
            get
            {
                return msf[j];
            }
            set
            {
                msf[j] = value;
            }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            int a = -4;
            int b = 2;
            Console.WriteLine("a={0}  b={1}", a, b);
            int k = Cmin.min(a, b);
            Console.WriteLine("a={0}  b={1}", a, b);
            Console.WriteLine("k=" + k);
            k = Cmin.minabs(ref a, ref b);
            Console.WriteLine("a={0}  b={1}", a, b);
            Console.WriteLine("k=" + k);

            CStatic p = new CStatic();//создается экземпляр класса
            Console.WriteLine("{0}", p.y);
            p.y = 75;
            int z = p.y;
            Console.WriteLine("{0}", z);

            Rmas obj = new Rmas();
            for (int i = 0; i < 10; i++)
            {
                obj[i] = (float)1.5 * i;
            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("{0}", obj[i]);
            }

        }
    }
}
=======
﻿using System;

namespace lab2
{
    class CStatic
    {
        private int m = 35;
        public int y
        {
            get
            {
                return m;
            }

            set
            {
                m = value;
            }
        }
    }
    class Cmin
    {
        private int m = 35;
        public int y
        {
            get
            {
                return m;
            }
            set
            {
                m = value;
            }
        }
        public static int min(int x, int y)
        {

            return (x < y) ? x : y;
        }
        public static int minabs(ref int x, ref int y)
        {
            x = (x < 0) ? -x : x;
            y = (y < 0) ? -y : y;
            int z = (x < y) ? x : y;
            return z;
        }

    }
    class Rmas
    {
        protected float[] msf = new float[10];
        public float this[int j]
        {
            get
            {
                return msf[j];
            }
            set
            {
                msf[j] = value;
            }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            int a = -4;
            int b = 2;
            Console.WriteLine("a={0}  b={1}", a, b);
            int k = Cmin.min(a, b);
            Console.WriteLine("a={0}  b={1}", a, b);
            Console.WriteLine("k=" + k);
            k = Cmin.minabs(ref a, ref b);
            Console.WriteLine("a={0}  b={1}", a, b);
            Console.WriteLine("k=" + k);

            CStatic p = new CStatic();//создается экземпляр класса
            Console.WriteLine("{0}", p.y);
            p.y = 75;
            int z = p.y;
            Console.WriteLine("{0}", z);

            Rmas obj = new Rmas();
            for (int i = 0; i < 10; i++)
            {
                obj[i] = (float)1.5 * i;
            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("{0}", obj[i]);
            }

        }
    }
}
>>>>>>> d9d21ade0fba1d9bf8262ff3ea6ec30fbb5904af
