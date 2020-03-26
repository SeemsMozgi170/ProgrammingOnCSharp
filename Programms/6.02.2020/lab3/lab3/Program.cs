<<<<<<< HEAD
﻿using System;

namespace lab3
{
    class CA
    {
        public int x, y, z;
        public readonly int rd;
        public CA()
        {
            x = 3;
            y = 2;
            z = x + y;
            rd = x + y + z;

        }
        public CA(int a, int b)
        {
            x = a;
            y = b;
            z = a + b;
            rd = x + y + z;

        }
        public CA(int a, int b, int c) : this(a, b)
        {
            z = c;
            rd = x + y + z;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            CA obj = new CA();
            Console.WriteLine("x={0,2} y={1,2} z={2,2}", obj.x, obj.y, obj.z);
            CA obj1 = new CA(5, 7);
            Console.WriteLine("x={0,2} y={1,2} z={2,2}", obj1.x, obj1.y, obj1.z);
            CA obj2 = new CA(8, 9, 25);
            Console.WriteLine("x={0,2} y={1,2} z={2,2}", obj2.x, obj2.y, obj2.z);
            Console.WriteLine("поля для чтения  {0,2}  {1,2}  {2,2}", obj.rd, obj1.rd, obj2.rd);

        }
    }
}
=======
﻿using System;

namespace lab3
{
    class CA
    {
        public int x, y, z;
        public readonly int rd;
        public CA()
        {
            x = 3;
            y = 2;
            z = x + y;
            rd = x + y + z;

        }
        public CA(int a, int b)
        {
            x = a;
            y = b;
            z = a + b;
            rd = x + y + z;

        }
        public CA(int a, int b, int c) : this(a, b)
        {
            z = c;
            rd = x + y + z;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            CA obj = new CA();
            Console.WriteLine("x={0,2} y={1,2} z={2,2}", obj.x, obj.y, obj.z);
            CA obj1 = new CA(5, 7);
            Console.WriteLine("x={0,2} y={1,2} z={2,2}", obj1.x, obj1.y, obj1.z);
            CA obj2 = new CA(8, 9, 25);
            Console.WriteLine("x={0,2} y={1,2} z={2,2}", obj2.x, obj2.y, obj2.z);
            Console.WriteLine("поля для чтения  {0,2}  {1,2}  {2,2}", obj.rd, obj1.rd, obj2.rd);

        }
    }
}
>>>>>>> d9d21ade0fba1d9bf8262ff3ea6ec30fbb5904af
