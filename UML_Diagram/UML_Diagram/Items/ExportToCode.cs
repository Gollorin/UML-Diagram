using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_Diagram
{
    public class ExportToCode
    {
        private string Path;
        private string Name;
        private BindingList<Table> all_tables { get; set; }
        private BindingList<Line> all_lines { get; set; }

        public ExportToCode(BindingList<Table> table, BindingList<Line> lines, string proj_name, string path)
        { 
            this.Path = path + "\\" + proj_name;
            this.Name = proj_name;
            this.all_tables = table;
            this.all_lines = lines;

            ProjectManager();
        }

        private void ProjectManager()
        {
            if (Directory.Exists(this.Path))
                Directory.Delete(this.Path, true);
            else
                Directory.CreateDirectory(this.Path);


            foreach (Table table in this.all_tables)
            {
                MakeCS(table);
            }
        }

        private void MakeCS(Table table)
        {
            string name = table.Name.Substring(0, 1).ToUpper() + table.Name.Substring(1).ToLower();

            if (File.Exists(this.Path + "\\" + name + ".cs"))
            {
                File.Delete(this.Path + "\\" + name + ".cs");
            }

            using (File.Create(this.Path + "\\" + name + ".cs")) { }

            using (StreamWriter writer = new StreamWriter(this.Path + "\\" + name + ".cs"))
            {
                // Zacatek kodu
                writer.WriteLine("using System;");
                writer.WriteLine("using System.Collections.Generic;");
                writer.WriteLine("using System.Linq;");
                writer.WriteLine("using System.Text;");
                writer.WriteLine("using System.Threading.Tasks;");
                writer.WriteLine();
                writer.WriteLine("namespace " + this.Name.Substring(0, 1).ToUpper() + this.Name.Substring(1).ToLower());
                writer.WriteLine("{");

                // Name class
                string class_name = table.Name.Substring(0, 1).ToUpper() + table.Name.Substring(1).ToLower();

                List<string> all_names = new List<string>();
                foreach (Line line in this.all_lines)
                {
                    if (line.TableEnd == table && line.Type.Equals("Realization") && line.Type.Equals("Dependency"))
                        all_names.Add(line.TableStart.Name.Substring(0, 1).ToUpper() + line.TableStart.Name.Substring(1).ToLower());
                }
                string classtoadd = "";
                foreach (string add_name in all_names)
                {
                    classtoadd = classtoadd + ", ";
                }

                if (all_names.Count > 0)
                    class_name = class_name + " : " + classtoadd.Substring(0, classtoadd.Length - 2);


                string start = "public";
                if (table.Abstract)
                    start = "abstract";

                writer.WriteLine($"    {start} class " + class_name);
                writer.WriteLine("    {");

                // Prop
                foreach (Property prop in table.Properties)
                {
                    writer.WriteLine($"        {prop.GetMeFullString()} {"{ get; set; }"}");
                }

                // Konstruktor
                writer.WriteLine("        public " + class_name + "()");
                writer.WriteLine("        {");
                writer.WriteLine("            ");
                writer.WriteLine("        }");
                writer.WriteLine();
                
                // Metho
                foreach (Method meth in table.Methods)
                {
                    writer.WriteLine($"        {meth.GetMeFullString()}");
                    writer.WriteLine("        {");
                    writer.WriteLine("            throw new NotImplementedException();");
                    writer.WriteLine("        }");
                    writer.WriteLine();
                }

                // Konec
                writer.WriteLine("    }");
                writer.WriteLine("}");
            }
        }
    }
}
