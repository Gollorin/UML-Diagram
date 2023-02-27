namespace UML_Diagram
{
    partial class TableForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.checkBox_abstr = new System.Windows.Forms.CheckBox();
            this.dataGridView_prop = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.button_prop_add = new System.Windows.Forms.Button();
            this.button_prop_del = new System.Windows.Forms.Button();
            this.dataGridView_meth = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.button_meth_add = new System.Windows.Forms.Button();
            this.button_meth_del = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.comboBox_prop_attri = new System.Windows.Forms.ComboBox();
            this.textBox_prop_name = new System.Windows.Forms.TextBox();
            this.comboBox_prop_type = new System.Windows.Forms.ComboBox();
            this.comboBox_meth_attri = new System.Windows.Forms.ComboBox();
            this.textBox_meth_name = new System.Windows.Forms.TextBox();
            this.textBox_meth_values = new System.Windows.Forms.TextBox();
            this.comboBox_meth_type = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.button_add_meth_value = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_prop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_meth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "*Name:";
            // 
            // textBox_name
            // 
            this.textBox_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_name.Location = new System.Drawing.Point(97, 15);
            this.textBox_name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(231, 27);
            this.textBox_name.TabIndex = 1;
            this.textBox_name.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_name_Validating);
            // 
            // checkBox_abstr
            // 
            this.checkBox_abstr.AutoSize = true;
            this.checkBox_abstr.Location = new System.Drawing.Point(335, 19);
            this.checkBox_abstr.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBox_abstr.Name = "checkBox_abstr";
            this.checkBox_abstr.Size = new System.Drawing.Size(121, 24);
            this.checkBox_abstr.TabIndex = 2;
            this.checkBox_abstr.Text = "Abstract class";
            this.checkBox_abstr.UseVisualStyleBackColor = true;
            // 
            // dataGridView_prop
            // 
            this.dataGridView_prop.AllowUserToAddRows = false;
            this.dataGridView_prop.AllowUserToDeleteRows = false;
            this.dataGridView_prop.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView_prop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_prop.Location = new System.Drawing.Point(97, 112);
            this.dataGridView_prop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView_prop.Name = "dataGridView_prop";
            this.dataGridView_prop.RowHeadersWidth = 51;
            this.dataGridView_prop.RowTemplate.Height = 25;
            this.dataGridView_prop.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_prop.Size = new System.Drawing.Size(617, 208);
            this.dataGridView_prop.TabIndex = 3;
            this.dataGridView_prop.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_prop_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 77);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Properties:";
            // 
            // button_prop_add
            // 
            this.button_prop_add.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button_prop_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_prop_add.Location = new System.Drawing.Point(721, 73);
            this.button_prop_add.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_prop_add.Name = "button_prop_add";
            this.button_prop_add.Size = new System.Drawing.Size(86, 31);
            this.button_prop_add.TabIndex = 5;
            this.button_prop_add.Text = "+";
            this.button_prop_add.UseVisualStyleBackColor = false;
            this.button_prop_add.Click += new System.EventHandler(this.button_prop_add_Click);
            // 
            // button_prop_del
            // 
            this.button_prop_del.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button_prop_del.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_prop_del.Location = new System.Drawing.Point(721, 112);
            this.button_prop_del.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_prop_del.Name = "button_prop_del";
            this.button_prop_del.Size = new System.Drawing.Size(86, 31);
            this.button_prop_del.TabIndex = 6;
            this.button_prop_del.Text = "-";
            this.button_prop_del.UseVisualStyleBackColor = false;
            this.button_prop_del.Click += new System.EventHandler(this.button_prop_del_Click);
            // 
            // dataGridView_meth
            // 
            this.dataGridView_meth.AllowUserToAddRows = false;
            this.dataGridView_meth.AllowUserToDeleteRows = false;
            this.dataGridView_meth.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView_meth.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_meth.Location = new System.Drawing.Point(97, 387);
            this.dataGridView_meth.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView_meth.Name = "dataGridView_meth";
            this.dataGridView_meth.RowHeadersWidth = 51;
            this.dataGridView_meth.RowTemplate.Height = 25;
            this.dataGridView_meth.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_meth.Size = new System.Drawing.Size(617, 208);
            this.dataGridView_meth.TabIndex = 7;
            this.dataGridView_meth.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_meth_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 352);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Methods:";
            // 
            // button_meth_add
            // 
            this.button_meth_add.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button_meth_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_meth_add.Location = new System.Drawing.Point(721, 348);
            this.button_meth_add.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_meth_add.Name = "button_meth_add";
            this.button_meth_add.Size = new System.Drawing.Size(86, 31);
            this.button_meth_add.TabIndex = 9;
            this.button_meth_add.Text = "+";
            this.button_meth_add.UseVisualStyleBackColor = false;
            this.button_meth_add.Click += new System.EventHandler(this.button_meth_add_Click);
            // 
            // button_meth_del
            // 
            this.button_meth_del.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button_meth_del.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_meth_del.Location = new System.Drawing.Point(721, 387);
            this.button_meth_del.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_meth_del.Name = "button_meth_del";
            this.button_meth_del.Size = new System.Drawing.Size(86, 31);
            this.button_meth_del.TabIndex = 10;
            this.button_meth_del.Text = "-";
            this.button_meth_del.UseVisualStyleBackColor = false;
            this.button_meth_del.Click += new System.EventHandler(this.button_meth_del_Click);
            // 
            // button_add
            // 
            this.button_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_add.Location = new System.Drawing.Point(629, 624);
            this.button_add.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(86, 31);
            this.button_add.TabIndex = 11;
            this.button_add.Text = "ADD";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_cancel.Location = new System.Drawing.Point(97, 624);
            this.button_cancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(86, 31);
            this.button_cancel.TabIndex = 12;
            this.button_cancel.Text = "CANCEL";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // comboBox_prop_attri
            // 
            this.comboBox_prop_attri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_prop_attri.FormattingEnabled = true;
            this.comboBox_prop_attri.Items.AddRange(new object[] {
            "Public",
            "Private",
            "Protected"});
            this.comboBox_prop_attri.Location = new System.Drawing.Point(97, 73);
            this.comboBox_prop_attri.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox_prop_attri.Name = "comboBox_prop_attri";
            this.comboBox_prop_attri.Size = new System.Drawing.Size(111, 28);
            this.comboBox_prop_attri.TabIndex = 13;
            // 
            // textBox_prop_name
            // 
            this.textBox_prop_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_prop_name.Location = new System.Drawing.Point(339, 73);
            this.textBox_prop_name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_prop_name.Name = "textBox_prop_name";
            this.textBox_prop_name.Size = new System.Drawing.Size(375, 27);
            this.textBox_prop_name.TabIndex = 14;
            // 
            // comboBox_prop_type
            // 
            this.comboBox_prop_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_prop_type.FormattingEnabled = true;
            this.comboBox_prop_type.Items.AddRange(new object[] {
            "bool",
            "byte",
            "char",
            "decimal",
            "double",
            "float",
            "int",
            "long",
            "string"});
            this.comboBox_prop_type.Location = new System.Drawing.Point(216, 73);
            this.comboBox_prop_type.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox_prop_type.Name = "comboBox_prop_type";
            this.comboBox_prop_type.Size = new System.Drawing.Size(116, 28);
            this.comboBox_prop_type.TabIndex = 15;
            // 
            // comboBox_meth_attri
            // 
            this.comboBox_meth_attri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_meth_attri.FormattingEnabled = true;
            this.comboBox_meth_attri.Items.AddRange(new object[] {
            "Public",
            "Private",
            "Protected"});
            this.comboBox_meth_attri.Location = new System.Drawing.Point(97, 348);
            this.comboBox_meth_attri.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox_meth_attri.Name = "comboBox_meth_attri";
            this.comboBox_meth_attri.Size = new System.Drawing.Size(111, 28);
            this.comboBox_meth_attri.TabIndex = 16;
            // 
            // textBox_meth_name
            // 
            this.textBox_meth_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_meth_name.Location = new System.Drawing.Point(339, 348);
            this.textBox_meth_name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_meth_name.Name = "textBox_meth_name";
            this.textBox_meth_name.Size = new System.Drawing.Size(144, 27);
            this.textBox_meth_name.TabIndex = 17;
            // 
            // textBox_meth_values
            // 
            this.textBox_meth_values.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_meth_values.Location = new System.Drawing.Point(490, 348);
            this.textBox_meth_values.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_meth_values.Name = "textBox_meth_values";
            this.textBox_meth_values.Size = new System.Drawing.Size(177, 27);
            this.textBox_meth_values.TabIndex = 18;
            // 
            // comboBox_meth_type
            // 
            this.comboBox_meth_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_meth_type.FormattingEnabled = true;
            this.comboBox_meth_type.Items.AddRange(new object[] {
            "bool",
            "byte",
            "char",
            "decimal",
            "double",
            "float",
            "int",
            "long",
            "string"});
            this.comboBox_meth_type.Location = new System.Drawing.Point(216, 348);
            this.comboBox_meth_type.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox_meth_type.Name = "comboBox_meth_type";
            this.comboBox_meth_type.Size = new System.Drawing.Size(116, 28);
            this.comboBox_meth_type.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(339, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Name of property:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(339, 324);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Name of method:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(490, 324);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "Values:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(539, 324);
            this.label7.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 20);
            this.label7.TabIndex = 23;
            this.label7.Text = "p1 : Bool; p2 : String";
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // button_add_meth_value
            // 
            this.button_add_meth_value.BackColor = System.Drawing.Color.Yellow;
            this.button_add_meth_value.Location = new System.Drawing.Point(674, 348);
            this.button_add_meth_value.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_add_meth_value.Name = "button_add_meth_value";
            this.button_add_meth_value.Size = new System.Drawing.Size(40, 31);
            this.button_add_meth_value.TabIndex = 24;
            this.button_add_meth_value.Text = "+";
            this.button_add_meth_value.UseVisualStyleBackColor = false;
            this.button_add_meth_value.Click += new System.EventHandler(this.button_add_meth_value_Click);
            // 
            // TableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(818, 660);
            this.Controls.Add(this.button_add_meth_value);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox_meth_type);
            this.Controls.Add(this.textBox_meth_values);
            this.Controls.Add(this.textBox_meth_name);
            this.Controls.Add(this.comboBox_meth_attri);
            this.Controls.Add(this.comboBox_prop_type);
            this.Controls.Add(this.textBox_prop_name);
            this.Controls.Add(this.comboBox_prop_attri);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.button_meth_del);
            this.Controls.Add(this.button_meth_add);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView_meth);
            this.Controls.Add(this.button_prop_del);
            this.Controls.Add(this.button_prop_add);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView_prop);
            this.Controls.Add(this.checkBox_abstr);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(836, 707);
            this.MinimumSize = new System.Drawing.Size(836, 707);
            this.Name = "TableForm";
            this.Text = "New table";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_prop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_meth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox textBox_name;
        private CheckBox checkBox_abstr;
        private DataGridView dataGridView_prop;
        private Label label2;
        private Button button_prop_add;
        private Button button_prop_del;
        private DataGridView dataGridView_meth;
        private Label label3;
        private Button button_meth_add;
        private Button button_meth_del;
        private Button button_add;
        private Button button_cancel;
        private ComboBox comboBox_prop_attri;
        private TextBox textBox_prop_name;
        private ComboBox comboBox_prop_type;
        private ComboBox comboBox_meth_attri;
        private TextBox textBox_meth_name;
        private TextBox textBox_meth_values;
        private ComboBox comboBox_meth_type;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private ErrorProvider errorProvider;
        private Button button_add_meth_value;
    }
}