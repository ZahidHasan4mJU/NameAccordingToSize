namespace NameWithSize
{
    partial class NameWidSizeForm
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
            this.employeeNoLabel = new System.Windows.Forms.Label();
            this.listBox = new System.Windows.Forms.ListBox();
            this.employeeNameLabel = new System.Windows.Forms.Label();
            this.countLabel = new System.Windows.Forms.Label();
            this.employeeNoTextBox = new System.Windows.Forms.TextBox();
            this.employeeNameTextBox = new System.Windows.Forms.TextBox();
            this.countTextBox = new System.Windows.Forms.TextBox();
            this.setButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.showButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // employeeNoLabel
            // 
            this.employeeNoLabel.AutoSize = true;
            this.employeeNoLabel.Location = new System.Drawing.Point(12, 21);
            this.employeeNoLabel.Name = "employeeNoLabel";
            this.employeeNoLabel.Size = new System.Drawing.Size(70, 13);
            this.employeeNoLabel.TabIndex = 0;
            this.employeeNoLabel.Text = "EmployeeNo.";
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(94, 173);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(440, 134);
            this.listBox.TabIndex = 1;
            // 
            // employeeNameLabel
            // 
            this.employeeNameLabel.AutoSize = true;
            this.employeeNameLabel.Location = new System.Drawing.Point(12, 75);
            this.employeeNameLabel.Name = "employeeNameLabel";
            this.employeeNameLabel.Size = new System.Drawing.Size(81, 13);
            this.employeeNameLabel.TabIndex = 2;
            this.employeeNameLabel.Text = "EmployeeName";
            // 
            // countLabel
            // 
            this.countLabel.AutoSize = true;
            this.countLabel.Location = new System.Drawing.Point(12, 135);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(35, 13);
            this.countLabel.TabIndex = 3;
            this.countLabel.Text = "Count";
            // 
            // employeeNoTextBox
            // 
            this.employeeNoTextBox.Location = new System.Drawing.Point(94, 18);
            this.employeeNoTextBox.Name = "employeeNoTextBox";
            this.employeeNoTextBox.Size = new System.Drawing.Size(130, 20);
            this.employeeNoTextBox.TabIndex = 4;
            // 
            // employeeNameTextBox
            // 
            this.employeeNameTextBox.Location = new System.Drawing.Point(94, 75);
            this.employeeNameTextBox.Name = "employeeNameTextBox";
            this.employeeNameTextBox.Size = new System.Drawing.Size(130, 20);
            this.employeeNameTextBox.TabIndex = 5;
            // 
            // countTextBox
            // 
            this.countTextBox.Location = new System.Drawing.Point(94, 128);
            this.countTextBox.Name = "countTextBox";
            this.countTextBox.Size = new System.Drawing.Size(130, 20);
            this.countTextBox.TabIndex = 6;
            // 
            // setButton
            // 
            this.setButton.Location = new System.Drawing.Point(241, 18);
            this.setButton.Name = "setButton";
            this.setButton.Size = new System.Drawing.Size(92, 51);
            this.setButton.TabIndex = 7;
            this.setButton.Text = "Set";
            this.setButton.UseVisualStyleBackColor = true;
            this.setButton.Click += new System.EventHandler(this.setButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(349, 18);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(84, 51);
            this.addButton.TabIndex = 8;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(454, 19);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(80, 48);
            this.resetButton.TabIndex = 9;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(241, 75);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(293, 73);
            this.showButton.TabIndex = 10;
            this.showButton.Text = "Show All Name";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // NameWidSizeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 323);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.setButton);
            this.Controls.Add(this.countTextBox);
            this.Controls.Add(this.employeeNameTextBox);
            this.Controls.Add(this.employeeNoTextBox);
            this.Controls.Add(this.countLabel);
            this.Controls.Add(this.employeeNameLabel);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.employeeNoLabel);
            this.Name = "NameWidSizeForm";
            this.Text = "NameForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label employeeNoLabel;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Label employeeNameLabel;
        private System.Windows.Forms.Label countLabel;
        private System.Windows.Forms.TextBox employeeNoTextBox;
        private System.Windows.Forms.TextBox employeeNameTextBox;
        private System.Windows.Forms.TextBox countTextBox;
        private System.Windows.Forms.Button setButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button showButton;
    }
}

