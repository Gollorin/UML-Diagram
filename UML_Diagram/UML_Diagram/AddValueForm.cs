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
    public partial class AddValueForm : Form
    {
        public string Value { get; set; }
        public AddValueForm()
        {
            InitializeComponent();
            this.comboBox_value.SelectedIndex = 0;
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            this.Value = this.textBox_name.Text.ToLower() + " : " + this.comboBox_value.Text;

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
            else if (!Regex.IsMatch(this.textBox_name.Text, @"^[a-z]"))
            {
                this.errorProvider.SetError(this.textBox_name, "Name must be lower case");
                e.Cancel = true;
            }
        }

        private void AddValueForm_Load(object sender, EventArgs e)
        {

        }
    }
}
