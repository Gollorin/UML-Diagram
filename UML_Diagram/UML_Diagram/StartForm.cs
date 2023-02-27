using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UML_Diagram
{
    public partial class StartForm : Form
    {
        public string PathToExistingProject { get; set; }
        public StartForm(bool save)
        {
            InitializeComponent();

            if (save == false)
                this.label2.Text = "Your project is unsaved!";
            else
                this.label2.Text = "";
        }

        private void button_no_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }

        private void button_yes_Click(object sender, EventArgs e)
        {
            this.openFileDialog.Multiselect = false;
            this.openFileDialog.Filter = "Json files (*.json)|*.json|Text files (*.txt)|*.txt";

            if (this.openFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.PathToExistingProject = this.openFileDialog.FileName;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
