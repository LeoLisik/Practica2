using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prakt_1
{
    public partial class Form1 : Form
    {
        Point p;
        Bitmap bmp;
        public Form1()
        {
            InitializeComponent();
            this.Paint += new System.Windows.Forms.PaintEventHandler(Form1_Paint);
            bmp = new Bitmap(this.ClientSize.Width, this.ClientSize.Height);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Point p1, p2;
            Pen myPen = new Pen(Color.Black);
            for (int i = 0; 10 * i < this.Size.Width; i++)
            {
                p1 = new Point(20*i, 0);
                p2 = new Point(20*i, this.Size.Height);
                e.Graphics.DrawLine(myPen, p1, p2);
            }
            for (int i = 0; 20 * i < this.Size.Width; i++)
            {
                p1 = new Point(0, 20 * i);
                p2 = new Point(this.Size.Width, 20 * i);
                e.Graphics.DrawLine(myPen, p1, p2);
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            p = e.Location;
        }

        private void Form1_Paint(object sender, PaintEventArgs e, Point p)
        {
            e.Graphics.FillRectangle(Brushes.Red, new Rectangle(p, new Size(19, 19)));
        }

        private void Draw(object sender, EventArgs e)
        {
            bmp = new Bitmap(this.ClientSize.Width, this.ClientSize.Height);
            if (bmp.GetPixel(p.X, p.Y).ToArgb() == Color.White.ToArgb()) { MessageBox.Show("Красный"); }
            //MessageBox.Show(Convert.ToString(bmp.GetPixel(10, 10)));
            //if (Color.Red.ToArgb() == Color.Red.ToArgb()) { MessageBox.Show("Ne tak"); }
            Point ColorPoint = new Point((((int)p.X / (int)20) * 20) + 1, (((int)p.Y / (int)20) * 20) + 1);
            Graphics g = this.CreateGraphics();
            Form1_Paint(new object(), new PaintEventArgs(g, new Rectangle(new Point(0, 0), this.Size)) ,ColorPoint);
        }
    }
}
