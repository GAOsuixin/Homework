namespace TaskManager.ui
{
    partial class SettingForm
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
            this.SettingModifyButton = new System.Windows.Forms.Button();
            this.ReturnButton = new System.Windows.Forms.Button();
            this.TaskSortLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // SettingModifyButton
            // 
            this.SettingModifyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SettingModifyButton.Location = new System.Drawing.Point(344, 229);
            this.SettingModifyButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SettingModifyButton.Name = "SettingModifyButton";
            this.SettingModifyButton.Size = new System.Drawing.Size(155, 56);
            this.SettingModifyButton.TabIndex = 1;
            this.SettingModifyButton.Text = "确认设置";
            this.SettingModifyButton.UseVisualStyleBackColor = true;
            this.SettingModifyButton.Click += new System.EventHandler(this.SettingModifyButton_Click);
            // 
            // ReturnButton
            // 
            this.ReturnButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ReturnButton.Location = new System.Drawing.Point(519, 229);
            this.ReturnButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(153, 59);
            this.ReturnButton.TabIndex = 2;
            this.ReturnButton.Text = "返回主页";
            this.ReturnButton.UseVisualStyleBackColor = true;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // TaskSortLabel
            // 
            this.TaskSortLabel.AutoSize = true;
            this.TaskSortLabel.Location = new System.Drawing.Point(99, 69);
            this.TaskSortLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TaskSortLabel.Name = "TaskSortLabel";
            this.TaskSortLabel.Size = new System.Drawing.Size(99, 15);
            this.TaskSortLabel.TabIndex = 3;
            this.TaskSortLabel.Text = "Task排序方式";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "提醒时间",
            "截止时间"});
            this.comboBox1.Location = new System.Drawing.Point(209, 65);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 23);
            this.comboBox1.TabIndex = 4;
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 312);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.TaskSortLabel);
            this.Controls.Add(this.ReturnButton);
            this.Controls.Add(this.SettingModifyButton);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SettingForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SettingModifyButton;
        private System.Windows.Forms.Button ReturnButton;
        private System.Windows.Forms.Label TaskSortLabel;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}