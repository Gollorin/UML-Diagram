using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_Diagram
{
    public class Pencil
    {
        public static Pen Association()
        {
            Pen pen = new Pen(Color.Black, 2);

            GraphicsPath hPath = new GraphicsPath();
            hPath.AddLine(new Point(0, 0), new Point(5, -10));
            hPath.AddLine(new Point(0, 0), new Point(-5, -10));

            pen.CustomEndCap = new CustomLineCap(null, hPath);

            return pen;
        }

        public static Pen Inheritance()
        {
            Pen pen = new Pen(Color.Black, 2);

            GraphicsPath hPath = new GraphicsPath();
            hPath.AddLine(new Point(0, 0), new Point(5, -10));
            hPath.AddLine(new Point(0, 0), new Point(-5, -10));
            hPath.AddLine(new Point(5, -10), new Point(-5, -10));

            CustomLineCap cust = new(null, hPath);
            cust.BaseInset = 10;

            pen.CustomEndCap = cust;

            return pen;
        }

        public static Pen Realization()
        {
            Pen pen = new Pen(Color.Black, 2);
            pen.DashStyle = DashStyle.Dash;

            GraphicsPath hPath = new GraphicsPath();
            hPath.AddLine(new Point(0, 0), new Point(5, -10));
            hPath.AddLine(new Point(5, -10), new Point(-5, -10));
            hPath.AddLine(new Point(0, 0), new Point(-5, -10));

            CustomLineCap cust = new(null, hPath);
            cust.BaseInset = 10;

            pen.CustomEndCap = cust;

            return pen;
        }

        public static Pen Dependency()
        {
            Pen pen = new Pen(Color.Black, 2);
            pen.DashStyle = DashStyle.Dash;

            GraphicsPath hPath = new GraphicsPath();
            hPath.AddLine(new Point(0, 0), new Point(5, -10));
            hPath.AddLine(new Point(0, 0), new Point(-5, -10));

            pen.CustomEndCap = new CustomLineCap(null, hPath);

            return pen;
        }

        public static Pen Aggregation()
        {
            Pen pen = new Pen(Color.Black, 2);

            GraphicsPath hPath = new GraphicsPath();
            hPath.AddLine(new Point(0, 0), new Point(5, -10));
            hPath.AddLine(new Point(0, 0), new Point(-5, -10));

            hPath.AddLine(new Point(-5, -10), new Point(0, -20));
            hPath.AddLine(new Point(5, -10), new Point(0, -20));

            CustomLineCap cust = new(null, hPath);
            cust.BaseInset = 20;

            pen.CustomEndCap = cust;

            return pen;
        }

        public static Pen Composition()
        {
            Pen pen = new Pen(Color.Black, 2);

            GraphicsPath hPath = new GraphicsPath();
            PointF[] rect = new PointF[4] { new Point(0, 0), new Point(-5, -10), new Point(0, -20), new Point(5, -10) };
            hPath.AddPolygon(rect);

            CustomLineCap cust = new(hPath, null);
            pen.CustomEndCap = cust;

            return pen;
        }
    }
}
