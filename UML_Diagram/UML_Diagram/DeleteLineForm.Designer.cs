namespace UML_Diagram
{
    partial class DeleteLineForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_lines = new System.Windows.Forms.ComboBox();
            this.button_done = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Which one delete?";
            // 
            // comboBox_lines
            // 
            this.comboBox_lines.FormattingEnabled = true;
            this.comboBox_lines.Location = new System.Drawing.Point(12, 32);
            this.comboBox_lines.Name = "comboBox_lines";
            this.comboBox_lines.Size = new System.Drawing.Size(376, 23);
            this.comboBox_lines.TabIndex = 1;
            // 
            // button_done
            // 
            this.button_done.Location = new System.Drawing.Point(313, 77);
            this.button_done.Name = "button_done";
            this.button_done.Size = new System.Drawing.Size(75, 23);
            this.button_done.TabIndex = 2;
            this.button_done.Text = "Done";
            this.button_done.UseVisualStyleBackColor = true;
            this.button_done.Click += new System.EventHandler(this.button_done_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(12, 77);
            this.button_cancel.MaximumSize = new System.Drawing.Size(75, 23);
            this.button_cancel.MinimumSize = new System.Drawing.Size(75, 23);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(75, 23);
            this.button_cancel.TabIndex = 3;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // DeleteLineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 112);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_done);
            this.Controls.Add(this.comboBox_lines);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(416, 151);
            this.MinimumSize = new System.Drawing.Size(416, 151);
            this.Name = "DeleteLineForm";
            this.Text = "DeleteLineForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ComboBox comboBox_lines;
        private Button button_done;
        private Button button_cancel;
    }
}