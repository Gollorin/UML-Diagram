namespace UML_Diagram
{
    partial class EndConnectionForm
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
            this.button_done = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_con1 = new System.Windows.Forms.TextBox();
            this.comboBox_type = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_ratio = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_con2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_done
            // 
            this.button_done.Location = new System.Drawing.Point(177, 156);
            this.button_done.Name = "button_done";
            this.button_done.Size = new System.Drawing.Size(75, 23);
            this.button_done.TabIndex = 0;
            this.button_done.Text = "Done";
            this.button_done.UseVisualStyleBackColor = true;
            this.button_done.Click += new System.EventHandler(this.button_done_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(12, 156);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(75, 23);
            this.button_cancel.TabIndex = 1;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Table con1.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Table con2.";
            // 
            // textBox_con1
            // 
            this.textBox_con1.Enabled = false;
            this.textBox_con1.Location = new System.Drawing.Point(84, 12);
            this.textBox_con1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.textBox_con1.Name = "textBox_con1";
            this.textBox_con1.ReadOnly = true;
            this.textBox_con1.Size = new System.Drawing.Size(168, 23);
            this.textBox_con1.TabIndex = 5;
            // 
            // comboBox_type
            // 
            this.comboBox_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_type.FormattingEnabled = true;
            this.comboBox_type.Items.AddRange(new object[] {
            "Association",
            "Inheritance",
            "Realization",
            "Dependency",
            "Aggregation",
            "Composition"});
            this.comboBox_type.Location = new System.Drawing.Point(84, 74);
            this.comboBox_type.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.comboBox_type.Name = "comboBox_type";
            this.comboBox_type.Size = new System.Drawing.Size(168, 23);
            this.comboBox_type.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Type:";
            // 
            // comboBox_ratio
            // 
            this.comboBox_ratio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_ratio.FormattingEnabled = true;
            this.comboBox_ratio.Items.AddRange(new object[] {
            "Exactly one",
            "0 or 1",
            "0 or more",
            "1 or more",
            "Ordered"});
            this.comboBox_ratio.Location = new System.Drawing.Point(84, 105);
            this.comboBox_ratio.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.comboBox_ratio.Name = "comboBox_ratio";
            this.comboBox_ratio.Size = new System.Drawing.Size(168, 23);
            this.comboBox_ratio.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Poměr:";
            // 
            // textBox_con2
            // 
            this.textBox_con2.Enabled = false;
            this.textBox_con2.Location = new System.Drawing.Point(84, 43);
            this.textBox_con2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.textBox_con2.Name = "textBox_con2";
            this.textBox_con2.ReadOnly = true;
            this.textBox_con2.Size = new System.Drawing.Size(168, 23);
            this.textBox_con2.TabIndex = 10;
            // 
            // EndConnectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 191);
            this.Controls.Add(this.textBox_con2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox_ratio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox_type);
            this.Controls.Add(this.textBox_con1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_done);
            this.Name = "EndConnectionForm";
            this.Text = "End of Connection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button_done;
        private Button button_cancel;
        private Label label1;
        private Label label2;
        private TextBox textBox_con1;
        private ComboBox comboBox_type;
        private Label label3;
        private ComboBox comboBox_ratio;
        private Label label4;
        private TextBox textBox_con2;
    }
}