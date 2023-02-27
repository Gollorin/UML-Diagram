using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UML_Diagram
{
    public partial class ExportToForm : Form
    {
        public string ProjectName { get; set; }
        public ExportToForm(string enter_what)
        {
            InitializeComponent();
            this.label_enter.Text = "Enter " + enter_what + " name:";
        }

        private void button_create_Click(object sender, EventArgs e)
        {
            this.ProjectName = this.textBox_name.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void textBox_name_Validating(object sender, CancelEventArgs e)
        {
            this.errorProvider.SetError(this.textBox_name, null);
            if (string.IsNullOrEmpty(this.textBox_name.Text))
            {
                this.errorProvider.SetError(this.textBox_name, "Name shouldnt be empty");
                e.Cancel = true;
            }
            else if (!Regex.IsMatch(this.textBox_name.Text, @"^[a-zA-Z]"))
            {
                this.errorProvider.SetError(this.textBox_name, "Name must start with a letter");
                e.Cancel = true;
            }
        }
    }
}
