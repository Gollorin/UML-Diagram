using Newtonsoft.Json;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing.Imaging;

namespace UML_Diagram
{
    public partial class MainForm : Form
    {
        private int NewX { get; set; }
        private int NewY { get; set; }
        private string Path { get; set; }
        private bool IsSaved { get; set; }
        private bool MoveTableFunIsOn = false;
        private bool MakeConection = false;

        private JsonSerializerSettings js_set = new() { TypeNameHandling = TypeNameHandling.Objects, PreserveReferencesHandling = PreserveReferencesHandling.Objects}; 
        private BindingList<Table> all_tables {get; set;}
        private BindingList<Line> all_lines {get; set;}
        // Move
        private float MouseX { get; set; }
        private float MouseY { get; set; }
        private Table MoveMe { get; set; }
        //Connection
        private Table Connection1 { get; set; }
        private Table Connection2 { get; set; }
        private Line TempLine { get; set; }
        // Add table > dodìlat
        // Line bude Ratio
        public MainForm()
        {
            InitializeComponent();

            this.IsSaved = true;
            this.NewX = 10;
            this.NewY = 10;
            this.all_tables = new BindingList<Table>();
            this.all_lines = new BindingList<Line>();
            this.Path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        }

        #region IMPORT / EXPORT
        private void button_exp_pic_Click(object sender, EventArgs e)
        {
            ExportToForm exp_form = new ExportToForm("picture");
            if (exp_form.ShowDialog() == DialogResult.OK)
            {
                this.IsSaved = true;

                Image image = new Bitmap(this.pictureBox.Width, this.pictureBox.Height);
                Graphics g = Graphics.FromImage(image);
                g.Clear(Color.White);

                foreach (Line line in this.all_lines)
                {
                    line.Draw(g);
                }
                foreach (Table table in this.all_tables)
                {
                    table.Draw(g);
                }

                string full_path = this.Path + "\\" + exp_form.ProjectName + ".png";
                image.Save(full_path, ImageFormat.Png);
            }
        }

        private void button_exp_file_Click(object sender, EventArgs e)
        {
            ExportToForm exp_form = new ExportToForm("file");
            if (exp_form.ShowDialog() == DialogResult.OK)
            {
                this.IsSaved = true;

                Json json_to_exp = new Json();
                json_to_exp.Table = this.all_tables;
                json_to_exp.Lines = this.all_lines;

                string json = JsonConvert.SerializeObject(json_to_exp, js_set);
                File.WriteAllText(this.Path + "\\" + exp_form.ProjectName + ".json", json);
            }
        }

        private void button_exp_code_Click(object sender, EventArgs e)
        {
            ExportToForm exp_form = new ExportToForm("project");
            if (exp_form.ShowDialog() == DialogResult.OK)
            {
                this.IsSaved = true;
                ExportToCode exp = new ExportToCode(this.all_tables, this.all_lines, exp_form.ProjectName, this.Path);
            }
        }

        private void button_import_Click(object sender, EventArgs e)
        {
            StartForm start_form = new StartForm(this.IsSaved);

            if (start_form.ShowDialog() == DialogResult.OK)
            {
                Json jsonos = JsonConvert.DeserializeObject<Json>(File.ReadAllText(start_form.PathToExistingProject), js_set);
                this.all_tables = jsonos.Table;
                this.all_lines = jsonos.Lines;
            }

            this.pictureBox.Invalidate();
        }
        #endregion

        private void button_add_Click(object sender, EventArgs e)
        {
            this.IsSaved = false;

            TableForm add_new_table = new TableForm(new Table(this.all_tables.Count, this.NewX, this.NewY));
            if (add_new_table.ShowDialog() == DialogResult.OK)
            {
                this.all_tables.Add(add_new_table.Form_Table);
            }

            if (this.NewX == 100 ||this.NewY == 100)
            {
                this.NewX = 0;
                this.NewY = 0;
            }

            this.NewX += 10;
            this.NewY += 10;

            this.pictureBox.Invalidate();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            string message = " Your project is unsaved";
            if (this.IsSaved == true)
                message = "";

            switch (MessageBox.Show(this, "Are you sure you want to close? " + message, "Exit?", MessageBoxButtons.YesNo))
            {
                case DialogResult.No:
                    e.Cancel = true;
                    break;
                default:
                    break;
            }
        }

        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            this.IsSaved = false;

            Graphics g = e.Graphics;
            foreach (Line line in this.all_lines)
            {
                line.Draw(g);
            }
            foreach (Table table in this.all_tables)
            {
                table.Draw(g);
            }
        }

        private void pictureBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Table remake = this.all_tables.FirstOrDefault(table => e.X > table.StartX && e.X < table.StartX + table.FullWidth && e.Y < table.StartY + table .FullHeight && e.Y > table.StartY);
            if (remake != null)
            {
                TableForm add_new_table = new TableForm(remake);
                if (add_new_table.ShowDialog() == DialogResult.Yes)
                {
                    this.all_tables[this.all_tables.IndexOf(remake)] = add_new_table.Form_Table;
                }
            }
            this.pictureBox.Invalidate();
        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            this.MoveMe = this.all_tables.LastOrDefault(t => e.X > t.StartX && e.X < t.StartX + t.FullWidth && e.Y < t.StartY + t.FullHeight && e.Y > t.StartY);
            if (this.MoveMe != null)
            {
                this.MoveTableFunIsOn = true;

                this.MouseX = e.X - this.MoveMe.StartX;
                this.MouseY = e.Y - this.MoveMe.StartY;
            }
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            // KRESLENI CARY
            if (this.MakeConection)
            {
                this.TempLine.End_X = e.X;
                this.TempLine.End_Y = e.Y;

                this.pictureBox.Invalidate();
            } 
            else if (this.MoveTableFunIsOn)
            {
                // PRENASENI TABLU
                Table tablos = this.MoveMe;
                if (this.MoveMe != null)
                {
                    this.MoveMe.StartX = e.X - this.MouseX;
                    this.MoveMe.StartY = e.Y - this.MouseY;

                    if (this.MoveMe.StartY + this.MoveMe.FullHeight > this.pictureBox.Height)
                    {
                        this.MoveMe.StartY = this.pictureBox.Height - this.MoveMe.FullHeight - 6;
                    }
                    if (this.MoveMe.StartX + this.MoveMe.FullWidth > this.pictureBox.Width)
                    {
                        this.MoveMe.StartX = this.pictureBox.Width - this.MoveMe.FullWidth - 6;
                    }
                    if (this.MoveMe.StartX < 0)
                    {
                        this.MoveMe.StartX = 1;
                    }
                    if (this.MoveMe.StartY < 0)
                    {
                        this.MoveMe.StartY = 1;
                    }
                }

                this.pictureBox.Invalidate();
            }
        }

        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            this.MoveTableFunIsOn = false;
            this.MoveMe = null;
        }

        private void pictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            // PRO PRIPOJENI 2
            if (this.MakeConection)
            {
                this.Connection2 = this.all_tables.LastOrDefault(t => e.X > t.StartX && e.X < t.StartX + t.FullWidth && e.Y < t.StartY + t.FullHeight && e.Y > t.StartY && this.TempLine.TableStart != t);
                if (this.Connection2 != null)
                {
                    EndConnectionForm end_form = new EndConnectionForm(this.TempLine.TableStart.Name, this.Connection2.Name);
                    if (end_form.ShowDialog() == DialogResult.OK)
                    {
                        this.TempLine.TableEnd = this.Connection2;
                        this.TempLine.Type = end_form.Type;
                        this.TempLine.Ratio = end_form.Ratio;
                    }
                    else if (end_form.ShowDialog() == DialogResult.Cancel)
                    {
                        this.all_lines.Remove(this.TempLine);
                    }

                    this.MakeConection = false;
                    this.TempLine = null;
                }
                else
                {
                    this.all_lines.Remove(this.TempLine);
                    this.MakeConection = false;
                    this.TempLine = null;
                }
            }
            else
            { 
                // PRO DELETE
                Table table_del = this.all_tables.FirstOrDefault(table => e.X > table.StartX + table.FullWidth - 20 && e.X < table.StartX + table.FullWidth && e.Y > table.StartY + table.FullHeight - 20 && e.Y < table.StartY + table.FullHeight);
                if (table_del != null)
                {
                    bool delete_con = false;
                    switch (MessageBox.Show(this, $"Are you sure you want to delete {table_del.Name}?", "Close", MessageBoxButtons.YesNo))
                    {
                        case DialogResult.Yes:
                            delete_con = true;
                            break;
                        default:
                            break;
                    }

                    if (delete_con)
                    {
                        this.all_tables.Remove(table_del);

                        List<Line> temp = new List<Line>();
                        foreach (Line line in this.all_lines)
                        {
                            if (line.TableStart == table_del || line.TableEnd == table_del)
                            {
                                temp.Add(line);
                            }
                        }
                        foreach (Line line in temp)
                        {
                            this.all_lines.Remove(line);
                        }
                    }
                }

                // PRO PROPOJENI 1
                this.Connection1 = this.all_tables.FirstOrDefault(table => e.X > table.StartX && e.X < table.StartX + 20 && e.Y > table.StartY + table.FullHeight - 20 && e.Y < table.StartY + table.FullHeight);
                if (this.Connection1 != null)
                {
                    this.MakeConection = true;
                    this.TempLine = new Line(this.Connection1);
                    this.all_lines.Add(this.TempLine);
                }
            }

            this.pictureBox.Invalidate();
        }

        private void button_del_line_Click(object sender, EventArgs e)
        {
            if (this.all_lines.Count < 1)
                return;

            DeleteLineForm del_line = new DeleteLineForm(this.all_lines);
            if (del_line.ShowDialog() == DialogResult.OK)
            {
                Line temp_line = this.all_lines.FirstOrDefault(table => table.TableStart == del_line.T_start && table.TableEnd == del_line.T_end);
                this.all_lines.Remove(temp_line);
            }

            this.pictureBox.Invalidate();
        }
    }
}