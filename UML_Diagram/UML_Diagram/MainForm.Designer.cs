namespace UML_Diagram
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_del_line = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button_import = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_exp_code = new System.Windows.Forms.Button();
            this.button_exp_file = new System.Windows.Forms.Button();
            this.button_exp_pic = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button_add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.button_del_line);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.button_import);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.button_exp_code);
            this.panel1.Controls.Add(this.button_exp_file);
            this.panel1.Controls.Add(this.button_exp_pic);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button_add);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(100, 426);
            this.panel1.TabIndex = 0;
            // 
            // button_del_line
            // 
            this.button_del_line.Location = new System.Drawing.Point(3, 54);
            this.button_del_line.Name = "button_del_line";
            this.button_del_line.Size = new System.Drawing.Size(94, 23);
            this.button_del_line.TabIndex = 10;
            this.button_del_line.Text = "Delete Line";
            this.button_del_line.UseVisualStyleBackColor = true;
            this.button_del_line.Click += new System.EventHandler(this.button_del_line_Click);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(3, 300);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(0, 2, 0, 5);
            this.label7.Size = new System.Drawing.Size(94, 37);
            this.label7.TabIndex = 9;
            this.label7.Text = "#Circle to make connection";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(3, 263);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(0, 2, 0, 5);
            this.label6.Size = new System.Drawing.Size(94, 37);
            this.label6.TabIndex = 8;
            this.label6.Text = "#Red box to delete table";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(0, 375);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(0, 2, 0, 5);
            this.label5.Size = new System.Drawing.Size(49, 22);
            this.label5.TabIndex = 7;
            this.label5.Text = "Import:";
            // 
            // button_import
            // 
            this.button_import.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_import.Location = new System.Drawing.Point(3, 400);
            this.button_import.Name = "button_import";
            this.button_import.Size = new System.Drawing.Size(94, 23);
            this.button_import.TabIndex = 6;
            this.button_import.Text = "Load Project";
            this.button_import.UseVisualStyleBackColor = true;
            this.button_import.Click += new System.EventHandler(this.button_import_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(3, 226);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(0, 2, 0, 5);
            this.label4.Size = new System.Drawing.Size(94, 37);
            this.label4.TabIndex = 5;
            this.label4.Text = "#Drag and Drop to move table";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(3, 189);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 2, 0, 5);
            this.label3.Size = new System.Drawing.Size(94, 37);
            this.label3.TabIndex = 4;
            this.label3.Text = "#Double click to edit table";
            // 
            // button_exp_code
            // 
            this.button_exp_code.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_exp_code.Location = new System.Drawing.Point(3, 163);
            this.button_exp_code.Name = "button_exp_code";
            this.button_exp_code.Size = new System.Drawing.Size(94, 23);
            this.button_exp_code.TabIndex = 3;
            this.button_exp_code.Text = "Code";
            this.button_exp_code.UseVisualStyleBackColor = true;
            this.button_exp_code.Click += new System.EventHandler(this.button_exp_code_Click);
            // 
            // button_exp_file
            // 
            this.button_exp_file.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_exp_file.Location = new System.Drawing.Point(3, 134);
            this.button_exp_file.Name = "button_exp_file";
            this.button_exp_file.Size = new System.Drawing.Size(94, 23);
            this.button_exp_file.TabIndex = 2;
            this.button_exp_file.Text = "File";
            this.button_exp_file.UseVisualStyleBackColor = true;
            this.button_exp_file.Click += new System.EventHandler(this.button_exp_file_Click);
            // 
            // button_exp_pic
            // 
            this.button_exp_pic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_exp_pic.Location = new System.Drawing.Point(3, 105);
            this.button_exp_pic.Name = "button_exp_pic";
            this.button_exp_pic.Size = new System.Drawing.Size(94, 23);
            this.button_exp_pic.TabIndex = 1;
            this.button_exp_pic.Text = "Picture";
            this.button_exp_pic.UseVisualStyleBackColor = true;
            this.button_exp_pic.Click += new System.EventHandler(this.button_exp_pic_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(0, 80);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 2, 0, 5);
            this.label2.Size = new System.Drawing.Size(62, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Export to:";
            // 
            // button_add
            // 
            this.button_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_add.Location = new System.Drawing.Point(3, 25);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(94, 23);
            this.button_add.TabIndex = 0;
            this.button_add.Text = "Add Table";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 2, 0, 5);
            this.label1.Size = new System.Drawing.Size(51, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Actions:";
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox.Location = new System.Drawing.Point(115, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(670, 426);
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            this.pictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_Paint);
            this.pictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseClick);
            this.pictureBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDoubleClick);
            this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
            this.pictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseUp);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "MainForm";
            this.Text = "UML Diagram";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion


        private Panel panel1;
        private Label label2;
        private Button button_add;
        private Label label1;
        private Button button_exp_code;
        private Button button_exp_file;
        private Button button_exp_pic;
        private PictureBox pictureBox;
        private Label label3;
        private Label label4;
        private Button button_import;
        private Label label5;
        private Label label7;
        private Label label6;
        private Button button_del_line;
    }
}