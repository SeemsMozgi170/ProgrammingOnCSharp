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
    public partial class Form2 : Form {
        Graphics g;
        Point locCircle;
        Size sizeCircle;
        int CR, CG, CB, orientation = 1;
        public Form2() {
            InitializeComponent();
        }

        private void StopButton_Click(object sender, EventArgs e) {
            timer1.Enabled = !timer1.Enabled;
        }

        private void RePaintButton_Click(object sender, EventArgs e) {
            CR = Convert.ToInt32(R.Text);
            if (CR > 255) CR = 255;
            CG = Convert.ToInt32(G.Text);
            if (CG > 255) CG = 255;
            CB = Convert.ToInt32(B.Text);
            if (CB > 255) CB = 255;
        }

        private void timer1_Tick(object sender, EventArgs e) {
            if (locCircle.X >= pictureBox1.Width - sizeCircle.Width) orientation = -1;
            if (locCircle.X <= sizeCircle.Width) orientation = 1;
            locCircle = new Point(locCircle.X + orientation, locCircle.Y);
            pictureBox1.Refresh();
        }

        private void Form2_Load(object sender, EventArgs e) {
            sizeCircle = new Size(100, 100);
            locCircle = new Point(sizeCircle.Width, (int)(pictureBox1.Height/2));
            R.Text = "0"; G.Text = "0"; B.Text = "0";
            CR = Convert.ToInt32(R.Text);   CG = Convert.ToInt32(G.Text);   CB = Convert.ToInt32(B.Text);
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e) {
            g = e.Graphics;
            g.FillEllipse(new SolidBrush(Color.FromArgb(CR,CG,CB)), new Rectangle(locCircle,sizeCircle));
        }
    }
}
