<<<<<<< HEAD
﻿using System;

namespace task1
{
    class ExClass       // Класс для задания 2 и 3
    {
        public readonly int index;      // Индекс класса(только для чтения)
        public int a;                   // Поле класса
        public ExClass(int index, int a)    // Конструктор класса
        {
            this.index = index;
            if (a > 10)
            {
                Console.WriteLine("Значение за диапазоном [5,10](Больше 10)");
                this.a = 10;
            }
            else
            {
                if (a < 5)
                {
                    Console.WriteLine("Значение за диапазоном [5,10](Меньше 5)");
                    this.a = 5;
                }
                else
                    this.a = a;
            }
        }
    }
    class CA1               // Задание 1 Класс Примера 1 
    {
        public int x, y, z;
        public CA1()        // Конструктор класса по умолчанию
        {
            x = 3;
            y = 2;
            z = x + y;
        }
    }
    class CA2                   // Задание 1 Класс Примера 2
    {
        public int x, y, z;
        public CA2()        // Конструктор класса по умолчанию
        {
            x = 3;
            y = 2;
            z = x + y;
        }
        public CA2(int a, int b)        // Конструктор класса с параметрами. Здесь происходит перегрузка конструктора
        {
            x = a;
            y = b;
            z = a + b;
        }
        public CA2(int a, int b, int c)     // Перегрузка конструктора с тремя параметрами
        {
            x = a;
            y = b;
            z = c;
        }

    }
    class CA3                   // Задание 1 Класс Примера 3
    {
        public int x, y, z;
        public readonly int rd;
        public CA3()            // Конструктор класса по умолчанию
        {
            x = 3;
            y = 2;
            z = x + y;
            rd = x + y + z;

        }
        public CA3(int a, int b)
        {
            x = a;
            y = b;
            z = a + b;
            rd = x + y + z;

        }
        public CA3(int a, int b, int c)
        {
            x = a;
            y = b;
            z = c;
            rd = x + y + z;
        }

    }
    class CA4                       // Задание 1 Класс Примера 4
    {
        public int x, y, z;
        public readonly int rd;
        public CA4()
        {
            x = 3;
            y = 2;
            z = x + y;
            rd = x + y + z;

        }
        public CA4(int a, int b)
        {
            x = a;
            y = b;
            z = a + b;
            rd = x + y + z;

        }
        public CA4(int a, int b, int c) : this(a, b)        // В этом конструкторе с тремя параметрами вызываем конструктор класса с двумя параметрами
        {
            z = c;
            rd = x + y + z;
        }

    }
    class Program                   // Основной класс
    {
        static void part1()         // Задание 1 работа с классом примера 1
        {
            CA1 obj = new CA1();
            Console.WriteLine("x={0,2} y={1,2} z={2,2}", obj.x, obj.y, obj.z);
        }
        static void part2()         // Задание 1 работа с классом примера 2
        {
            CA2 obj = new CA2();
            Console.WriteLine("x={0,2} y={1,2} z={2,2}", obj.x, obj.y, obj.z);
            CA2 obj1 = new CA2(5, 7);
            Console.WriteLine("x={0,2} y={1,2} z={2,2}", obj1.x, obj1.y, obj1.z);
            CA2 obj2 = new CA2(5, 7, 25);
            Console.WriteLine("x={0,2} y={1,2} z={2,2}", obj2.x, obj2.y, obj2.z);
        }
        static void part3()     // Задание 1 работа с классом примера 3
        {
            CA3 obj = new CA3();
            Console.WriteLine("x={0,2} y={1,2} z={2,2}", obj.x, obj.y, obj.z);
            CA3 obj1 = new CA3(5, 7);
            Console.WriteLine("x={0,2} y={1,2} z={2,2}", obj1.x, obj1.y, obj1.z);
            CA3 obj2 = new CA3(5, 7, 25);
            Console.WriteLine("x={0,2} y={1,2} z={2,2}", obj2.x, obj2.y, obj2.z);
            Console.WriteLine("поля для чтения{0,2}  {1,2} {2,2}", obj.rd, obj1.rd, obj2.rd);
        }
        static void part4()        // Задание 1 работа с классом примера 4
        {
            CA4 obj = new CA4();
            Console.WriteLine("x={0,2} y={1,2} z={2,2}", obj.x, obj.y, obj.z);
            CA4 obj1 = new CA4(5, 7);
            Console.WriteLine("x={0,2} y={1,2} z={2,2}", obj1.x, obj1.y, obj1.z);
            CA4 obj2 = new CA4(8, 9, 25);
            Console.WriteLine("x={0,2} y={1,2} z={2,2}", obj2.x, obj2.y, obj2.z);
            Console.WriteLine("поля для чтения  {0,2}  {1,2}  {2,2}", obj.rd, obj1.rd, obj2.rd);
        }
        static void solution()      // Решение задачи 2 и 3
        {
            ExClass[] exClasses = new ExClass[10];
            for (int i = 0; i < 10; i++)
            {
                exClasses[i] = new ExClass(i,i*2);
                Console.WriteLine("\nindex = " + exClasses[i].index + "\na = {0}", exClasses[i].a);
            }
        }

        static void Main(string[] args)     // Метод Main. В нем выполняются последовательно задания 1-3
        {
            Console.WriteLine("----------------------------Task №1--------------------------");
            Console.WriteLine("=================Example1=============");
            part1();
            Console.WriteLine("=================Example2=============");
            part2();
            Console.WriteLine("=================Example3=============");
            part3();
            Console.WriteLine("=================Example4=============");
            part4();
            Console.WriteLine("----------------------------Task №2 and №3--------------------------");
            solution();
        }
    }
}
=======
﻿using System;

namespace task1
{
    class ExClass       // Класс для задания 2 и 3
    {
        public readonly int index;      // Индекс класса(только для чтения)
        public int a;                   // Поле класса
        public ExClass(int index, int a)    // Конструктор класса
        {
            this.index = index;
            if (a > 10)
            {
                Console.WriteLine("Значение за диапазоном [5,10](Больше 10)");
                this.a = 10;
            }
            else
            {
                if (a < 5)
                {
                    Console.WriteLine("Значение за диапазоном [5,10](Меньше 5)");
                    this.a = 5;
                }
                else
                    this.a = a;
            }
        }
    }
    class CA1               // Задание 1 Класс Примера 1 
    {
        public int x, y, z;
        public CA1()        // Конструктор класса по умолчанию
        {
            x = 3;
            y = 2;
            z = x + y;
        }
    }
    class CA2                   // Задание 1 Класс Примера 2
    {
        public int x, y, z;
        public CA2()        // Конструктор класса по умолчанию
        {
            x = 3;
            y = 2;
            z = x + y;
        }
        public CA2(int a, int b)        // Конструктор класса с параметрами. Здесь происходит перегрузка конструктора
        {
            x = a;
            y = b;
            z = a + b;
        }
        public CA2(int a, int b, int c)     // Перегрузка конструктора с тремя параметрами
        {
            x = a;
            y = b;
            z = c;
        }

    }
    class CA3                   // Задание 1 Класс Примера 3
    {
        public int x, y, z;
        public readonly int rd;
        public CA3()            // Конструктор класса по умолчанию
        {
            x = 3;
            y = 2;
            z = x + y;
            rd = x + y + z;

        }
        public CA3(int a, int b)
        {
            x = a;
            y = b;
            z = a + b;
            rd = x + y + z;

        }
        public CA3(int a, int b, int c)
        {
            x = a;
            y = b;
            z = c;
            rd = x + y + z;
        }

    }
    class CA4                       // Задание 1 Класс Примера 4
    {
        public int x, y, z;
        public readonly int rd;
        public CA4()
        {
            x = 3;
            y = 2;
            z = x + y;
            rd = x + y + z;

        }
        public CA4(int a, int b)
        {
            x = a;
            y = b;
            z = a + b;
            rd = x + y + z;

        }
        public CA4(int a, int b, int c) : this(a, b)        // В этом конструкторе с тремя параметрами вызываем конструктор класса с двумя параметрами
        {
            z = c;
            rd = x + y + z;
        }

    }
    class Program                   // Основной класс
    {
        static void part1()         // Задание 1 работа с классом примера 1
        {
            CA1 obj = new CA1();
            Console.WriteLine("x={0,2} y={1,2} z={2,2}", obj.x, obj.y, obj.z);
        }
        static void part2()         // Задание 1 работа с классом примера 2
        {
            CA2 obj = new CA2();
            Console.WriteLine("x={0,2} y={1,2} z={2,2}", obj.x, obj.y, obj.z);
            CA2 obj1 = new CA2(5, 7);
            Console.WriteLine("x={0,2} y={1,2} z={2,2}", obj1.x, obj1.y, obj1.z);
            CA2 obj2 = new CA2(5, 7, 25);
            Console.WriteLine("x={0,2} y={1,2} z={2,2}", obj2.x, obj2.y, obj2.z);
        }
        static void part3()     // Задание 1 работа с классом примера 3
        {
            CA3 obj = new CA3();
            Console.WriteLine("x={0,2} y={1,2} z={2,2}", obj.x, obj.y, obj.z);
            CA3 obj1 = new CA3(5, 7);
            Console.WriteLine("x={0,2} y={1,2} z={2,2}", obj1.x, obj1.y, obj1.z);
            CA3 obj2 = new CA3(5, 7, 25);
            Console.WriteLine("x={0,2} y={1,2} z={2,2}", obj2.x, obj2.y, obj2.z);
            Console.WriteLine("поля для чтения{0,2}  {1,2} {2,2}", obj.rd, obj1.rd, obj2.rd);
        }
        static void part4()        // Задание 1 работа с классом примера 4
        {
            CA4 obj = new CA4();
            Console.WriteLine("x={0,2} y={1,2} z={2,2}", obj.x, obj.y, obj.z);
            CA4 obj1 = new CA4(5, 7);
            Console.WriteLine("x={0,2} y={1,2} z={2,2}", obj1.x, obj1.y, obj1.z);
            CA4 obj2 = new CA4(8, 9, 25);
            Console.WriteLine("x={0,2} y={1,2} z={2,2}", obj2.x, obj2.y, obj2.z);
            Console.WriteLine("поля для чтения  {0,2}  {1,2}  {2,2}", obj.rd, obj1.rd, obj2.rd);
        }
        static void solution()      // Решение задачи 2 и 3
        {
            ExClass[] exClasses = new ExClass[10];
            for (int i = 0; i < 10; i++)
            {
                exClasses[i] = new ExClass(i,i*2);
                Console.WriteLine("\nindex = " + exClasses[i].index + "\na = {0}", exClasses[i].a);
            }
        }

        static void Main(string[] args)     // Метод Main. В нем выполняются последовательно задания 1-3
        {
            Console.WriteLine("----------------------------Task №1--------------------------");
            Console.WriteLine("=================Example1=============");
            part1();
            Console.WriteLine("=================Example2=============");
            part2();
            Console.WriteLine("=================Example3=============");
            part3();
            Console.WriteLine("=================Example4=============");
            part4();
            Console.WriteLine("----------------------------Task №2 and №3--------------------------");
            solution();
        }
    }
}
>>>>>>> d9d21ade0fba1d9bf8262ff3ea6ec30fbb5904af
