﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab06 {
    public partial class Form4 : Form {
        Graphics g;
        Size size;
        Point loc;
        int adds = 5;

        public Form4() {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e) {
            g = CreateGraphics();
            size = new Size(Width / 5, Height / 8);
            loc = new Point((Width - size.Width) / 2, (Height - size.Height) / 2);
        }

        private void timer1_Tick(object sender, EventArgs e) {
            loc = new Point(loc.X - 3*adds, loc.Y - 2*adds);
            size = new Size(size.Width + 6*adds, size.Height + 4*adds);
            Refresh();
        }

        private void Form4_Paint(object sender, PaintEventArgs e) {
            g.FillRectangle(Brushes.Red, new Rectangle(loc, size));
        }
    }
}
