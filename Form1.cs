using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        static Graphics g;
        const int INF = 1000000000;

        Pen pen1 = new Pen(Color.Blue, 1);
        Pen pen2O = new Pen(Color.White, 3);
        Pen pen2N = new Pen(Color.White, 1);

        public struct triangles
        {
            public PointF p1, p2, p3;

            public triangles(PointF p1, PointF p2, PointF p3)
            {
                this.p1 = p1;
                this.p2 = p2;
                this.p3 = p3;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        List<triangles> Arr = new List<triangles>();

        int width;
        int height;

        int iter = 0;

        PointF p1, p2, p3;

        void draw()
        {
            g = Snowflake.CreateGraphics();
            g.Clear(Color.White);

            width = Snowflake.Width;
            height = Snowflake.Height + 70;

            int kp = 150;
            double med = Math.Sqrt(kp * kp + 4 * kp * kp) / 3;

            p1 = new PointF((float)(width / 2), (float)((height / 2) + med));
            p2 = new PointF((float)((width / 2) - kp), (float)((height / 2) - med));
            p3 = new PointF((float)((width / 2) + kp), (float)((height / 2) - med));

            triangles a = new triangles(p1, p2, p3);
            Arr.Add(a);

            g.DrawLine(pen1, p1, p2);
            g.DrawLine(pen1, p2, p3);
            g.DrawLine(pen1, p3, p1);
        }

        void fractal(PointF p1, PointF p2, PointF p3)
        {
            PointF m1 = new PointF((p2.X + 2 * p1.X) / 3, (p2.Y + 2 * p1.Y) / 3);
            PointF m2 = new PointF((2 * p2.X + p1.X) / 3, (p1.Y + 2 * p2.Y) / 3);

            if (iter >= 5)
                g.DrawLine(pen2N, m1, m2);
            else
                g.DrawLine(pen2O, m1, m2);

            var pm = new PointF((p2.X + p1.X) / 2, (p2.Y + p1.Y) / 2);
            var pn = new PointF((4 * pm.X - p3.X) / 3, (4 * pm.Y - p3.Y) / 3);

            g.DrawLine(pen1, m1, pn);
            g.DrawLine(pen1, m2, pn);

            triangles a = new triangles(m1, m2, pn);
            triangles b = new triangles(p1, m1, new PointF((2 * p1.X + p3.X) / 3, (2 * p1.Y + p3.Y) / 3));
            triangles c = new triangles(m2, p2, new PointF((2 * p2.X + p3.X) / 3, (2 * p2.Y + p3.Y) / 3));

            Arr.Add(a);
            Arr.Add(b);
            Arr.Add(c);
        }

        private void CLR_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);

            iter = 0;
            Arr.Clear();
            Out.Text = "0";
        }

        private void StrtDraw_Click(object sender, EventArgs e)
        {
            draw();

            Out.Text = "1";
            ++iter;
        }

        private void NextD_Click(object sender, EventArgs e)
        {
            ++iter;

            int cnt = Arr.Count;

            if (iter == 2)
            {
                fractal(Arr[0].p1, Arr[0].p2, Arr[0].p3);
                fractal(Arr[0].p2, Arr[0].p3, Arr[0].p1);
                fractal(Arr[0].p3, Arr[0].p1, Arr[0].p2);
            }
            else
                for (int i = 0; i < cnt; ++i)
                    if (iter > 12)
                        continue;
                    else
                    {
                        fractal(Arr[i].p1, Arr[i].p3, Arr[i].p2);
                        fractal(Arr[i].p3, Arr[i].p2, Arr[i].p1);

                        ++i;

                        fractal(Arr[i].p1, Arr[i].p2, Arr[i].p3);

                        ++i;

                        fractal(Arr[i].p1, Arr[i].p2, Arr[i].p3);
                    }

            Arr.RemoveRange(0, cnt);

            Out.Text = Convert.ToString(iter);
        }
    }
}
