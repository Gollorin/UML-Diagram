namespace UML_Diagram
{
    partial class ExportToForm
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
            this.button_create = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label_enter = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // button_create
            // 
            this.button_create.Location = new System.Drawing.Point(221, 93);
            this.button_create.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_create.Name = "button_create";
            this.button_create.Size = new System.Drawing.Size(86, 31);
            this.button_create.TabIndex = 0;
            this.button_create.Text = "Create";
            this.button_create.UseVisualStyleBackColor = true;
            this.button_create.Click += new System.EventHandler(this.button_create_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(14, 93);
            this.button_cancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(86, 31);
            this.button_cancel.TabIndex = 1;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(14, 45);
            this.textBox_name.Margin = new System.Windows.Forms.Padding(0, 13, 0, 13);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(292, 27);
            this.textBox_name.TabIndex = 2;
            this.textBox_name.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_name_Validating);
            // 
            // label_enter
            // 
            this.label_enter.AutoSize = true;
            this.label_enter.Location = new System.Drawing.Point(14, 12);
            this.label_enter.Name = "label_enter";
            this.label_enter.Size = new System.Drawing.Size(138, 20);
            this.label_enter.TabIndex = 3;
            this.label_enter.Text = "Enter project name:";
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // ExportToForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(314, 127);
            this.Controls.Add(this.label_enter);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_create);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(332, 174);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(332, 174);
            this.Name = "ExportToForm";
            this.Text = "ExportTo";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button_create;
        private Button button_cancel;
        private TextBox textBox_name;
        private Label label_enter;
        private ErrorProvider errorProvider;
    }
}