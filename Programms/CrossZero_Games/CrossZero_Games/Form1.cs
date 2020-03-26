using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrossZero_Games
{
    public class Pole
    {
        public byte size;
        public byte[,] pole;
        public Button[,] buttonsPole;
        public Pole(byte size)
        {
            this.size = size;
            pole = new byte[size, size];
            buttonsPole = new Button[size, size];
        }
    }
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            //Button button = new Button();
            //button.Text = "X";
            //button.Size = new Size(Width, Height);
            //Controls.Add(button);
            byte size = System.Convert.ToByte(Console.ReadLine());
            size = 5;
            Pole pole = new Pole(5);
            byte widthPole = (byte)(Width / 2);
            byte heightPole = (byte)Height;
            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++) {
                    pole.buttonsPole[i, j] = new Button();
                    pole.buttonsPole[i, j].Size = new Size((int)(widthPole / size), (int)(heightPole / size));
                    pole.buttonsPole[i, j].Location = new Point(j* (pole.buttonsPole[i, j].Width + 10) + 5, i * (pole.buttonsPole[i, j].Height + 10) + 5);
                    Controls.Add(pole.buttonsPole[i, j]);
                }
        }

    }
}
