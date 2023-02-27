using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UML_Diagram
{
    public partial class DeleteLineForm : Form
    {
        public Table T_start { get; set; }
        public Table T_end { get; set; }

        private BindingList<Line> Lines { get; set; }

        public DeleteLineForm(BindingList<Line> lines)
        {
            InitializeComponent();

            this.Lines = lines;
            MadeComboBox();
        }

        private void MadeComboBox()
        {
            foreach (Line line in this.Lines)
            {
                this.comboBox_lines.Items.Add(line.TableStart.Name + "  ->  " + line.Type + "  ->  " + line.TableEnd.Name);
            }

            this.comboBox_lines.SelectedIndex = 0;
        }

        private void button_done_Click(object sender, EventArgs e)
        {
            int table = this.comboBox_lines.SelectedIndex;

            this.T_start = this.Lines[table].TableStart;
            this.T_end = this.Lines[table].TableEnd;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
