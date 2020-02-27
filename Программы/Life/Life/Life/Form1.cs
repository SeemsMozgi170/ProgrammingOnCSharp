using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Life {
    public partial class Form1 : Form {

        public static Size size = new Size(10, 10);
        List<Entity> allPersonM = new List<Entity>();
        List<Entity> allPersonW = new List<Entity>();
        List<Point> allFood = new List<Point>();
        Graphics g;
        readonly Random random = new Random();
        long step = 0;

        public Form1() {
            InitializeComponent();
        }

        public void generateFood() {
            Point p;
            allFood.Clear();
            for (int i = 0; i < random.Next(10, 100); i++) {
                p = new Point(random.Next(5, board.Width - 5), random.Next(5, board.Height - 5));
                allFood.Add(p);
            }
        }

        private void Form1_Load(object sender, EventArgs e) {
            board.Size = new Size(800, 600);
            timer1.Enabled = true;
            allPersonM.Add(new Entity(new Point(395, 295),Color.Blue));
            allPersonW.Add(new Entity(new Point(400, 300),Color.Red));
        }

        private void board_Paint(object sender, PaintEventArgs e) {
            g = e.Graphics;
            foreach (Entity entity in allPersonM) {
                g.FillEllipse(new SolidBrush(entity.gender), new Rectangle(entity.position, size));
            }
            foreach (Entity entity in allPersonW) {
                g.FillEllipse(new SolidBrush(entity.gender), new Rectangle(entity.position, size));
            }
            if (step % 100 == 0) generateFood();
            foreach (Point p in allFood)
                g.FillEllipse(new SolidBrush(Color.Green), new Rectangle(p, size));
        }

        private void Timer1_Tick(object sender, EventArgs e) {
            step++;
            foreach (Entity entity in allPersonM) entity.Run(board);
            foreach (Entity entity in allPersonW) entity.Run(board);
            board.Refresh();
        }
    }

    public class Entity {
        readonly List<Point> orientations = new List<Point>() { new Point(0, -1), new Point(-1, 0), new Point(0, 1), new Point(1, 0) };
        public Point position;
        public int countStepsInLife = 500;
        public int countSteps = 20;
        private static readonly Random random = new Random();
        public Color gender;

        public Entity(Point position, Color gender) {
            this.position = position;
            this.gender = gender;
        }

        public void Run(PictureBox board) {
//            ((Bitmap)board.Image).GetPixel(1, 1);

            Point orientation = orientations[random.Next(orientations.Count)];
            int countSteps = random.Next(1, this.countSteps);
            position.X += orientation.X * countSteps;
            position.Y += orientation.Y * countSteps;
            while (position.X + 5 > board.Width)
                position.X -= 2 * (position.X + 5 - board.Width);
            while (position.X - 5 < 0)
                position.X += 2 * (position.X - 5);
            while (position.Y + 5 > board.Height)
                position.Y -= 2 * (position.Y + 5 - board.Height);
            while (position.Y - 5 < 0)
                position.Y += 2 * (position.Y - 5);

            //            this.countSteps -= countSteps;
            //            countStepsInLife -= countSteps;
        }
    }
}
