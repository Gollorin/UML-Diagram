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
    public partial class EndConnectionForm : Form
    {
        public string Type { get; set; }
        public string Ratio { get; set; }

        public EndConnectionForm(string con1, string con2)
        {
            InitializeComponent();

            this.textBox_con1.Text = con1;
            this.textBox_con2.Text = con2;

            this.comboBox_ratio.SelectedIndex = 0;
            this.comboBox_type.SelectedIndex = 0;
        }

        private void button_done_Click(object sender, EventArgs e)
        {
            this.Type = this.comboBox_type.SelectedItem.ToString();
            this.Ratio = Translator(this.comboBox_ratio.SelectedItem.ToString());

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close(); 
        }

        private string Translator(string temp)
        {
            if (temp.Equals("Exactly one"))
                return "1";
            else if (temp.Equals("0 or 1"))
                return "0..1";
            else if(temp.Equals("0 or more"))
                return "*";
            else if(temp.Equals("1 or more"))
                return "1..*";
            else if(temp.Equals("Ordered"))
                return "{ordered}";

            return "?";
        }
    }
}
