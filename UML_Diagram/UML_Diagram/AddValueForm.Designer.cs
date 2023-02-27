namespace UML_Diagram
{
    partial class AddValueForm
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
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.comboBox_value = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_add = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(14, 45);
            this.textBox_name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(173, 27);
            this.textBox_name.TabIndex = 0;
            this.textBox_name.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_name_Validating);
            // 
            // comboBox_value
            // 
            this.comboBox_value.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_value.FormattingEnabled = true;
            this.comboBox_value.Items.AddRange(new object[] {
            "bool",
            "byte",
            "char",
            "decimal",
            "double",
            "float",
            "int",
            "long",
            "string"});
            this.comboBox_value.Location = new System.Drawing.Point(194, 45);
            this.comboBox_value.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox_value.Name = "comboBox_value";
            this.comboBox_value.Size = new System.Drawing.Size(138, 28);
            this.comboBox_value.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name:";
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(247, 84);
            this.button_add.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(86, 31);
            this.button_add.TabIndex = 3;
            this.button_add.Text = "Add";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(14, 84);
            this.button_cancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(86, 31);
            this.button_cancel.TabIndex = 4;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // AddValueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(346, 131);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_value);
            this.Controls.Add(this.textBox_name);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AddValueForm";
            this.Text = "AddValueForm";
            this.Load += new System.EventHandler(this.AddValueForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox_name;
        private ComboBox comboBox_value;
        private Label label1;
        private Button button_add;
        private Button button_cancel;
        private ErrorProvider errorProvider;
    }
}