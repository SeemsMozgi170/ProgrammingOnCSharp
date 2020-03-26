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
    public partial class Form4 : Form {
        Graphics g;
        int orientationLoc = 1, orientationSize = 1;
        Size size = new Size(50, 50);
        Point loc;
        public Form4() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            timer1.Enabled = !timer1.Enabled;
        }

        private void button2_Click(object sender, EventArgs e) {
            timer2.Enabled = !timer2.Enabled;
        }

        private void timer1_Tick(object sender, EventArgs e) {
            if (loc.X >= pictureBox1.Width - size.Width) orientationLoc = -1;
            if (loc.X <= size.Width) orientationLoc = 1;
            loc = new Point(loc.X + orientationLoc, loc.Y);
            pictureBox1.Refresh();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e) {
            g = e.Graphics;
            g.FillEllipse(new SolidBrush(Color.BurlyWood), new Rectangle(loc,size));
        }

        private void Form4_Load(object sender, EventArgs e) {
            loc = new Point(size.Width, pictureBox1.Height / 2);
        }

        private void timer2_Tick(object sender, EventArgs e) {
            if (size.Width >= 150) orientationSize = -1;
            if (size.Width <= 5) orientationSize = 1;
            size = new Size(size.Width + orientationSize, size.Height + orientationSize);
            pictureBox1.Refresh();
        }
    }
}
