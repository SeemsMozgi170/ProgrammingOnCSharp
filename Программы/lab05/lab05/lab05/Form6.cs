using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab05 {
    public partial class Form6 : Form {

        Graphics g;
        double x2, y2;
        double orientX = 0, orientY = 0;
        Size size = new Size(50, 50);
        Point loc;

        private void pictureBox1_Paint(object sender, PaintEventArgs e) {
            g = e.Graphics;
            g.FillEllipse(new SolidBrush(Color.BurlyWood), new Rectangle(loc, size));
        }

        private void timer1_Tick(object sender, EventArgs e) {
            Point newLoc = new Point((int)(loc.X - orientX), (int)(loc.Y - orientY));
            if (newLoc.X >= pictureBox1.Width - 2 * size.Width)
                newLoc = new Point(pictureBox1.Width - 2 * size.Width, newLoc.Y);
            if (newLoc.X <= 2 * size.Width)
                newLoc = new Point(2 * size.Width, newLoc.Y);
            if (newLoc.Y >= pictureBox1.Height - 2 * size.Height)
                newLoc = new Point(newLoc.X, pictureBox1.Height - 2 * size.Height);
            if (newLoc.Y <= 2 * size.Height)
                newLoc = new Point(newLoc.X, 2 * size.Height);
            loc = newLoc;
            pictureBox1.Refresh();
            orientX = 0;
            orientY = 0;
        }

        private void Form6_Load(object sender, EventArgs e) {
            loc = new Point(pictureBox1.Width / 2, pictureBox1.Height / 2);
            x2 = loc.X;
            y2 = loc.Y;
        }

        public Form6() {
            InitializeComponent();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e) {
            orientX = e.X - x2;
            orientY = e.Y - y2;
            x2 = e.X;
            y2 = e.Y;
        }
    }
}
