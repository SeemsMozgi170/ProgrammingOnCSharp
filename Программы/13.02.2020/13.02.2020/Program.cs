using System;
using System.Drawing;

namespace _13._02._2020
{
    class Pole
    {
        byte size;
        byte[,] pole;
        Pole(byte size)
        {
            this.size = size;
            this.pole = new byte[size, size];
            Graphics g = Graphics.FromHwnd(pictureBox)
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input size : ");
            byte size = System.Convert.ToByte(Console.ReadLine());
        }
    }
}