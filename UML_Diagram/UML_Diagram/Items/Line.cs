using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_Diagram
{
    public class Line
    {
        public Table TableStart { get; set; }
        public Table TableEnd { get; set; }
        public string Type { get; set; }
        public string Ratio { get; set; }
        public float End_X { get; set; }
        public float End_Y { get; set; }
        private float Start_X { get; set; }
        private float Start_Y { get; set; }

        public Line(Table start)
        {
            this.TableStart = start;
        }

        public void Draw(Graphics g)
        {
            CalcStart();
            if (this.TableEnd == null)
            {
                PointF start = new PointF(this.Start_X, this.Start_Y);
                PointF end = new PointF(this.Start_X, this.End_Y);
                g.DrawLine(new Pen(Brushes.Black, 2), start, end);

                start = new PointF(this.Start_X, this.End_Y);
                end = new PointF(this.End_X, this.End_Y);
                g.DrawLine(new Pen(Brushes.Black, 2), start, end);

            }
            else
            {
                // *-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-
                CalcEnd();
                //POD
                if (this.TableStart.StartX > this.TableEnd.StartX + this.TableEnd.FullWidth + 42 && this.TableStart.StartX + this.TableStart.FullWidth + 42 < this.TableEnd.StartX && (this.TableStart.StartY < this.TableEnd.StartY + this.TableEnd.FullHeight || this.TableStart.StartY > this.TableEnd.StartY))
                {
                    DoDrawLine(g, new PointF(this.Start_X, this.Start_Y), new PointF(this.End_X, this.End_Y), true);
                }
                else if (this.TableStart.StartY > this.End_Y)
                {
                    PointF start = new PointF(this.TableStart.StartX + (this.TableStart.FullWidth / 2), this.TableStart.StartY);
                    PointF middle = new PointF(start.X, this.End_Y);

                    if (this.Start_X < this.TableEnd.StartX - 42)
                    {
                        DoDrawLine(g, start, middle, true);
                        PointF end = new PointF(this.TableEnd.StartX, middle.Y);
                        DoDrawLine(g, middle, end, false);
                    }
                    else if (this.Start_X > this.TableEnd.StartX + this.TableEnd.FullWidth + 42)
                    {
                        DoDrawLine(g, start, middle, true);
                        PointF end = new PointF(this.TableEnd.StartX + this.TableEnd.FullWidth, middle.Y);
                        DoDrawLine(g, middle, end, false);
                    }
                    else if (this.Start_X < this.TableEnd.StartX + this.TableEnd.FullWidth + 42 && this.Start_X > this.TableEnd.StartX - 42 && this.TableStart.StartY > this.TableEnd.StartY + this.TableEnd.FullHeight + 42)
                    {
                        float mid = this.TableEnd.StartY + this.TableEnd.FullHeight + 42;
                        DoDrawLine(g, new PointF(this.Start_X, this.TableStart.StartY), new PointF(this.Start_X, mid), true);
                        DoDrawLine(g, new PointF(this.Start_X, mid), new PointF(this.End_X, mid), true);
                        DoDrawLine(g, new PointF(this.End_X, mid), new PointF(this.End_X, this.TableEnd.StartY + this.TableEnd.FullHeight), false);
                    }
                    else
                    {
                        DoDrawLine(g, new PointF(this.Start_X, this.Start_Y), new PointF(this.End_X, this.End_Y), true);
                    }
                }
                else if (this.TableStart.StartY < this.End_Y)
                {
                    PointF start = new PointF(this.TableStart.StartX + (this.TableStart.FullWidth / 2), this.TableStart.StartY + this.TableStart.FullHeight);
                    PointF middle = new PointF(start.X, this.End_Y);

                    if (this.Start_X < this.TableEnd.StartX - 42)
                    {
                        DoDrawLine(g, start, middle, true);
                        PointF end = new PointF(this.TableEnd.StartX, middle.Y);
                        DoDrawLine(g, middle, end, false);
                    }
                    else if (this.Start_X > this.TableEnd.StartX + this.TableEnd.FullWidth + 42)
                    {
                        DoDrawLine(g, start, middle, true);
                        PointF end = new PointF(this.TableEnd.StartX + this.TableEnd.FullWidth, middle.Y);
                        DoDrawLine(g, middle, end, false);
                    }
                    else if (this.Start_X < this.TableEnd.StartX + this.TableEnd.FullWidth + 42 && this.Start_X > this.TableEnd.StartX - 42 && this.TableStart.StartY + this.TableStart.FullHeight < this.TableEnd.StartY - 42)
                    {
                        float mid = this.TableEnd.StartY - 42;
                        DoDrawLine(g, new PointF(this.Start_X, this.TableStart.StartY), new PointF(this.Start_X, mid), true);
                        DoDrawLine(g, new PointF(this.Start_X, mid), new PointF(this.End_X, mid), true);
                        DoDrawLine(g, new PointF(this.End_X, mid), new PointF(this.End_X, this.TableEnd.StartY), false);
                    }
                    else
                    {
                        DoDrawLine(g, new PointF(this.Start_X, this.Start_Y), new PointF(this.End_X, this.End_Y), true);
                    }
                }
                else
                {
                    DoDrawLine(g, new PointF(this.Start_X, this.Start_Y), new PointF(this.End_X, this.End_Y), true);
                }
                // *-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-               
                DoString(g);
            }
        }

        private void DoString(Graphics g)
        {
            SizeF size = g.MeasureString(this.Ratio, new Font("Serif", 10));

            PointF point = new PointF();
            if (this.End_Y > this.TableStart.StartY && this.End_Y < this.TableStart.StartY + this.TableStart.FullHeight)
            {
                point.Y = this.End_Y - 2 - size.Height;
                if (this.Start_X < this.End_X)
                {
                    point.X = this.TableStart.StartX + this.TableStart.FullWidth + 2;
                }
                else if (this.Start_X > this.End_X)
                {
                    point.X = this.TableStart.StartX - size.Width - 2;
                }
            }
            else if (this.TableStart.StartY > this.End_Y)
            {
                point = new PointF(this.Start_X + 2, this.TableStart.StartY - 2 - size.Height);
            }
            else if (this.TableStart.StartY + this.TableStart.FullHeight < this.End_Y)
            {
                point = new PointF(this.Start_X + 2, this.TableStart.StartY + this.TableStart.FullHeight + 2);
            }

            g.DrawString(this.Ratio, new Font("Serif", 10), Brushes.Black, point);

        }

        private void DoDrawLine(Graphics g, PointF start, PointF end, bool not_special)
        {
            if (not_special)
            {
                Pen pen = new Pen(Color.Black, 2);

                if (this.Type.Equals("Realization") || this.Type.Equals("Dependency"))
                    pen.DashStyle = DashStyle.Dash;

                g.DrawLine(pen, start, end);
            }
            else if (this.Type.Equals("Association"))
            {
                g.DrawLine(Pencil.Association(), start, end);
            }
            else if (this.Type.Equals("Inheritance"))
            {
                g.DrawLine(Pencil.Inheritance(), start, end);
            }
            else if (this.Type.Equals("Realization"))
            {
                g.DrawLine(Pencil.Realization(), start, end);
            }
            else if (this.Type.Equals("Dependency"))
            {
                g.DrawLine(Pencil.Dependency(), start, end);
            }
            else if (this.Type.Equals("Aggregation"))
            {
                g.DrawLine(Pencil.Aggregation(), start, end);
            }
            else if (this.Type.Equals("Composition"))
            {
                g.DrawLine(Pencil.Composition(), start, end);
            }
        }
        private void CalcEnd()
        {
            this.End_X = this.TableEnd.StartX + (this.TableEnd.FullWidth / 2);
            this.End_Y = this.TableEnd.StartY + (this.TableEnd.FullHeight / 2);
        }

        private void CalcStart()
        {
            this.Start_X = this.TableStart.StartX + (this.TableStart.FullWidth / 2);
            this.Start_Y = this.TableStart.StartY + (this.TableStart.FullHeight / 2);
        }
    }
}
