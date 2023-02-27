using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_Diagram
{
    public class Table
    {
        public int Id { get; set; }
        public float StartX { get; set; }
        public float StartY { get; set; }
        public float FullWidth { get; set; }
        public float FullHeight { get; set; }
        public string Name { get; set; }
        public bool Abstract { get; set; }
        public BindingList<Property> Properties { get; set; }
        public BindingList<Method> Methods { get; set; }
        private Font TableFont { get; set; }
        private Font NameFont { get; set; }
        public float OneLineH { get; set; }

        public Table(int id, int x, int y)
        {
            this.Id = id;
            this.StartX = x;
            this.StartY = y;

            this.Properties = new BindingList<Property>();
            this.Methods = new BindingList<Method>();

            this.TableFont = new Font("Serif", 10);
        }

        public void Draw(Graphics g)
        {
            // JMENNO CLASSY
            this.NameFont = this.IsAbstract();
            CalcWidth(g);

            SizeF nameSize = g.MeasureString(this.Name, this.NameFont);
            g.FillRectangle(Brushes.BlueViolet, this.StartX, this.StartY, this.FullWidth, nameSize.Height + 5);
            this.OneLineH = nameSize.Height + 5;
            this.FullHeight = this.OneLineH;

            PointF name_position = new PointF(this.StartX + (this.FullWidth / 2) - (nameSize.Width / 2), this.StartY + ((nameSize.Height + 5) / 2) - (nameSize.Height / 2));
            g.DrawString(this.Name, this.NameFont, Brushes.White, name_position);

            //---------------------------------------------
            // POZADI PROP
            float prop_list_height = 0;

            if (this.Properties.Count > 0)
                prop_list_height = CalcHeight(this.Properties[0].Name, 5, g, this.Properties.Count);

            g.FillRectangle(Brushes.Beige, this.StartX, this.StartY + nameSize.Height + 5, this.FullWidth, prop_list_height);

            // STRING PROP
            float prop_hight = nameSize.Height + 5 + (5 / 2) + this.StartY;
            foreach (Property prop in this.Properties)
            {
                PointF temp_point = new PointF(this.StartX + 10, prop_hight);
                g.DrawString(prop.GetMeShortString(), this.TableFont, Brushes.Black,temp_point);

                prop_hight += g.MeasureString(prop.GetMeShortString(), this.TableFont).Height + 5;
            }

            //---------------------------------------------
            float meth_list_height = 0;
            if (this.Methods.Count > 0)
                meth_list_height = CalcHeight(this.Methods[0].Name, 5, g, this.Methods.Count);


            g.FillRectangle(Brushes.Beige, this.StartX, this.StartY + nameSize.Height + 5 + prop_list_height, this.FullWidth, meth_list_height);

            // STRING METH
            float meth_hight = nameSize.Height + 5 + (5 / 2) + this.StartY + prop_list_height;
            foreach (Method meth in this.Methods)
            {
                PointF temp_point = new PointF(this.StartX + 10, meth_hight);
                g.DrawString(meth.GetMeShortString(), this.TableFont, Brushes.Black, temp_point);

                meth_hight += g.MeasureString(meth.GetMeShortString(), this.TableFont).Height + 5;
            }

            //---------------------------------------------

            // MENU BOX
            g.FillRectangle(Brushes.DarkGray, this.StartX, this.StartY + nameSize.Height + 5 + prop_list_height + meth_list_height, this.FullWidth, 20);
            Image circle = Image.FromFile(this.GetPicPath("circle.png"));
            Image trash = Image.FromFile(this.GetPicPath("trash.png"));

            int size = 20;
            float height = this.StartY + nameSize.Height + 5 + prop_list_height + meth_list_height;

            g.FillRectangle(Brushes.Red, this.StartX + this.FullWidth - size, height, size, size);
            g.FillRectangle(Brushes.LightBlue, this.StartX, height, size, size);
            // CENTER - this.StartX + (this.FullWidth / 2) - (size / 2)
            g.DrawImage(circle, this.StartX, height, size, size);
            g.DrawImage(trash, this.StartX + this.FullWidth - size, height, size, size);




            //---------------------------------------------
            g.DrawRectangle(Pens.Gray, this.StartX, this.StartY + nameSize.Height + 5, this.FullWidth, prop_list_height);
            this.FullHeight += prop_list_height;
            g.DrawRectangle(Pens.Gray, this.StartX, this.StartY + nameSize.Height + 5 + prop_list_height, this.FullWidth, meth_list_height);
            this.FullHeight += meth_list_height;
            g.DrawRectangle(Pens.Black, this.StartX, this.StartY + nameSize.Height + 5 + prop_list_height + meth_list_height, this.FullWidth, 20);
            this.FullHeight += 20;
            g.DrawRectangle(Pens.Black, this.StartX, this.StartY, this.FullWidth, nameSize.Height + 5);
        }

        private void CalcWidth(Graphics g)
        {
            float max_width = g.MeasureString(this.Name, this.TableFont).Width;
            foreach (Property prop in this.Properties)
            {
                float temp = g.MeasureString(prop.GetMeShortString(), this.TableFont).Width;
                if (temp > max_width)
                    max_width = temp;
            }
            foreach (Method meth in this.Methods)
            {
                float temp = g.MeasureString(meth.GetMeShortString(), this.TableFont).Width;
                if (temp > max_width)
                    max_width = temp;
            }

            if (max_width < 80)
                this.FullWidth = 80;
            else
                this.FullWidth = max_width + 20;
            // 10 + text + 10
        }

        public float CalcHeight(string item, float gap, Graphics g, int lines)
        {
            float this_is_it = (g.MeasureString(item, this.TableFont).Height + gap) * lines;
            return this_is_it;
        }

        private Font IsAbstract()
        {
            if (this.Abstract)
                return new Font("Serif", 10, FontStyle.Italic);
            else
                return new Font("Serif", 10, FontStyle.Bold);
        }

        private string GetPicPath(string picture)
        {
            return Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "\\Src\\" + picture;
        }
    }
}
