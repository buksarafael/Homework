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




    internal class triangle
    {
        Random rnd = new Random();
        public triangle()
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
            




        }
    }
}