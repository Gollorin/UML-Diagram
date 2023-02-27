using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UML_Diagram
{
    public partial class TableForm : Form
    {
        public Table Form_Table { get; set; }
        private BindingList<Property> all_properties { get; set; }
        private BindingList<Method> all_methods { get; set; }

        public TableForm(Table table)
        {
            InitializeComponent();

            if (table.Name != null)
                this.Text = table.Name;


            this.all_properties = table.Properties;
            this.all_methods = table.Methods;

            this.Form_Table = table;
            this.textBox_name.Text = table.Name;
            this.checkBox_abstr.Checked = table.Abstract;

            this.dataGridView_prop.DataSource = this.all_properties;
            this.dataGridView_meth.DataSource = this.all_methods;

            this.comboBox_prop_attri.SelectedIndex = 0;
            this.comboBox_prop_type.SelectedIndex = 0;
            this.comboBox_meth_attri.SelectedIndex = 0;
            this.comboBox_meth_type.SelectedIndex = 0;

        }

        private void button_meth_add_Click(object sender, EventArgs e)
        {
            Method meth = new Method(this.comboBox_meth_attri.Text, this.textBox_meth_values.Text, this.textBox_meth_name.Text, this.comboBox_meth_type.Text);
            this.all_methods.Add(meth); 
        }

        private void button_prop_add_Click(object sender, EventArgs e)
        {
            Property prop = new Property(this.comboBox_prop_attri.Text, this.comboBox_prop_type.Text, this.textBox_prop_name.Text);
            this.all_properties.Add(prop);
        }

        private void button_prop_del_Click(object sender, EventArgs e)
        {
            if (this.all_properties.Count > 0)
            {
                int index_to_del = this.dataGridView_prop.CurrentRow.Index;
                this.all_properties.RemoveAt(index_to_del);
            }
        }

        private void button_meth_del_Click(object sender, EventArgs e)
        {
            if (this.all_methods.Count > 0)
            {
                int index_to_del = this.dataGridView_meth.CurrentRow.Index;
                this.all_methods.RemoveAt(index_to_del);
            }
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                this.Form_Table.Name = this.textBox_name.Text.ToUpper();
                this.Form_Table.Abstract = this.checkBox_abstr.Checked;
                this.Form_Table.Properties = this.all_properties;
                this.Form_Table.Methods = this.all_methods;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void dataGridView_prop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.textBox_prop_name.Text = this.all_properties[e.RowIndex].Name;
            this.comboBox_prop_attri.Text = this.all_properties[e.RowIndex].Attribute;
        }

        private void dataGridView_meth_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.textBox_meth_name.Text = this.all_methods[e.RowIndex].Name;
            this.textBox_meth_values.Text = this.all_methods[e.RowIndex].Values;
            this.comboBox_meth_attri.Text = this.all_methods[e.RowIndex].Attribute;
        }

        private void button_add_meth_value_Click(object sender, EventArgs e)
        {
            AddValueForm adf = new AddValueForm();
            if (adf.ShowDialog() == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(this.textBox_meth_values.Text))
                {
                    this.textBox_meth_values.Text = adf.Value;
                }
                else
                {
                    this.textBox_meth_values.Text = this.textBox_meth_values.Text + ", " + adf.Value;
                }
            }
        }

        private void textBox_name_Validating(object sender, CancelEventArgs e)
        {
            this.errorProvider.SetError(this.textBox_name, null);
            if (!Regex.IsMatch(this.textBox_name.Text, @"^[A-Z]"))
            {
                this.errorProvider.SetError(this.textBox_name, "Name must start with Upper letter");
                e.Cancel = true;
            }
        }

        public bool IsValid()
        {
            bool valid = true;
            this.errorProvider.Clear();

            if (string.IsNullOrEmpty(this.textBox_name.Text))
            {
                this.errorProvider.SetError(this.textBox_name, "Enter your name!");
                valid = false;
            }
            
            return valid;
        }
    }
}
