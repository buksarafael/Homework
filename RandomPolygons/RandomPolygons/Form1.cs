using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomPolygons
{

    public partial class Form1 : Form
    {
        public Graphics gp;
        public Form1()
        {
            InitializeComponent();
            gp = panel1.CreateGraphics();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //triangle t1 = new triangle();

            for (int i = 0; i < 8; i++)
            {



                Brush result = Brushes.Transparent;

                Random rnd = new Random();

                Type brushesType = typeof(Brushes);

                PropertyInfo[] properties = brushesType.GetProperties();

                int random = rnd.Next(properties.Length);
                result = (Brush)properties[random].GetValue(null, null);



                Pen p = new Pen(result, 5);


                Point v1, v2, v3;
                int ax, ay, bx, by, cx, cy;
                ax = rnd.Next(0, 1255);
                ay = rnd.Next(0, 586);
                v1 = new Point(ax, ay);

                bx = rnd.Next(0, 1255);
                by = rnd.Next(0, 586);
                v2 = new Point(bx, by);

                cx = rnd.Next(0, 1255);
                cy = rnd.Next(0, 586);
                v3 = new Point(cx, cy);

                gp.DrawLine(p, v1, v2);
                System.Threading.Thread.Sleep(500);
                gp.DrawLine(p, v1, v3);
                System.Threading.Thread.Sleep(500);
                gp.DrawLine(p, v2, v3);

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Invalidate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 8; i++)
            {



                Brush result = Brushes.Transparent;

                Random rnd = new Random();

                Type brushesType = typeof(Brushes);

                PropertyInfo[] properties = brushesType.GetProperties();

                int random = rnd.Next(properties.Length);
                result = (Brush)properties[random].GetValue(null, null);



                Pen p = new Pen(result, 5);
                int x,y,w,h;
                x = rnd.Next(0, 1255);
                y = rnd.Next(0, 586);
                w = rnd.Next(0, 400);
                if (x + w > 1255)
                {
                    x = x - w;
                }
                if (y + w > 586)
                {
                    y = y - w;
                }
                System.Threading.Thread.Sleep(500);
                Rectangle rect = new Rectangle(x, y, w, w);
                gp.DrawRectangle(p, rect);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //gp.DrawEllipse(p, rect);

            for (int i = 0; i < 8; i++)
            {



                Brush result = Brushes.Transparent;

                Random rnd = new Random();

                Type brushesType = typeof(Brushes);

                PropertyInfo[] properties = brushesType.GetProperties();

                int random = rnd.Next(properties.Length);
                result = (Brush)properties[random].GetValue(null, null);



                Pen p = new Pen(result, 5);
                int x, y, w, h;
                x = rnd.Next(0, 1255);
                y = rnd.Next(0, 586);
                w = rnd.Next(0, 400);
                h = rnd.Next(0, 400);
                if (x + w > 1255)
                {
                    x = x - w;
                }
                if (y + w > 586)
                {
                    y = y - w;
                }
                System.Threading.Thread.Sleep(500);
                Rectangle rect = new Rectangle(x, y, w, w);
                gp.DrawEllipse(p, rect);
            }
        }
    }
}
