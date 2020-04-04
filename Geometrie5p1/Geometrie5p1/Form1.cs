using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Geometrie5p1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            gp = panel1.CreateGraphics();
            gp2 = panel2.CreateGraphics();
            gp3 = panel3.CreateGraphics();
            gp4 = panel4.CreateGraphics();
        }
        Graphics gp,gp2,gp3,gp4;

        private void button3_Click(object sender, EventArgs e)
        {
           
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                v1 = new Point(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
                getv1 = true;
            }
            if (textBox3.Text != "" && textBox4.Text != "")
            {
                v2 = new Point(Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text));
                getv2 = true;
                gp.DrawLine(p, v1, v2);
                gp2.DrawLine(p, v1, v2);
                gp3.DrawLine(p, v1, v2);
                gp4.DrawLine(p, v1, v2);
            }
            if (textBox5.Text != "" && textBox6.Text != "")
            {
                v3 = new Point(Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox6.Text));
                getv3 = true;
                gp.DrawLine(p, v3, v2);
                gp.DrawLine(p, v3, v1);

                gp2.DrawLine(p, v3, v2);
                gp2.DrawLine(p, v3, v1);

                gp3.DrawLine(p, v3, v2);
                gp3.DrawLine(p, v3, v1);

                gp4.DrawLine(p, v3, v2);
                gp4.DrawLine(p, v3, v1);
            }

            if (getv1 && getv2 && getv3)
            {
                v4 = new Point((Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox3.Text)) / 2, (Convert.ToInt32(textBox2.Text) + Convert.ToInt32(textBox4.Text)) / 2);
                v5 = new Point((Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox5.Text)) / 2, (Convert.ToInt32(textBox2.Text) + Convert.ToInt32(textBox6.Text)) / 2);
                v6 = new Point((Convert.ToInt32(textBox3.Text) + Convert.ToInt32(textBox5.Text)) / 2, (Convert.ToInt32(textBox4.Text) + Convert.ToInt32(textBox6.Text)) / 2);
                gp.DrawLine(p2, v1, v6);
                gp.DrawLine(p2, v2, v5);
                gp.DrawLine(p2, v3, v4);

               
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //colorDialog1.ShowDialog();
            //SolidBrush sb = new SolidBrush(colorDialog1.Color);
            //gp.FillPolygon(sb, new Point[] { v1, v2, v3 });
            panel1.Invalidate();
            panel2.Invalidate();
            panel3.Invalidate();
            panel4.Invalidate();
        }
        Point v1;
        Point v2;
        Point v3;
        Point v4;
        Point v5;
        Point v6;
        bool getv1 = false;
        bool getv2 = false;
        bool getv3 = false;

        Pen p = new Pen(Brushes.Black,5);
        Pen p2 = new Pen(Brushes.Red, 2);
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            getv1 = true;
            panel1.Cursor = Cursors.Cross;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            getv2 = true;
            panel1.Cursor = Cursors.Cross;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
