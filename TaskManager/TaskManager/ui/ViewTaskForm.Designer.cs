namespace TaskManager.ui
{
    partial class ViewTaskForm
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
            this.TaskAttributePanel = new System.Windows.Forms.Panel();
            this.ReturnButton = new System.Windows.Forms.Button();
            this.TaskRemindTimeCheckBox = new System.Windows.Forms.CheckBox();
            this.TaskEndTimeCheckBox = new System.Windows.Forms.CheckBox();
            this.TaskStartTimeCheckBox = new System.Windows.Forms.CheckBox();
            this.TaskRemindMinTextBox = new System.Windows.Forms.TextBox();
            this.TaskRemindMinLabel = new System.Windows.Forms.Label();
            this.TaskRemindHourTextBox = new System.Windows.Forms.TextBox();
            this.TaskRemindHourLebal = new System.Windows.Forms.Label();
            this.TaskRemindDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.TaskEndMinTextBox = new System.Windows.Forms.TextBox();
            this.TaskModifyButton = new System.Windows.Forms.Button();
            this.TaskEndHourTextBox = new System.Windows.Forms.TextBox();
            this.TaskStartMinTextBox = new System.Windows.Forms.TextBox();
            this.TaskStartHourTextBox = new System.Windows.Forms.TextBox();
            this.TaskEndMinLabel = new System.Windows.Forms.Label();
            this.TaskEndHourLabel = new System.Windows.Forms.Label();
            this.TaskStartMinLabel = new System.Windows.Forms.Label();
            this.TaskStartHourLabel = new System.Windows.Forms.Label();
            this.TaskEndDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.TaskStartDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.TaskStartTimeLabel = new System.Windows.Forms.Label();
            this.TaskClassComboBox = new System.Windows.Forms.ComboBox();
            this.TaskNameTextBox = new System.Windows.Forms.TextBox();
            this.TaskClassLabel = new System.Windows.Forms.Label();
            this.TaskNameLabel = new System.Windows.Forms.Label();
            this.TaskStatusLabel = new System.Windows.Forms.Label();
            this.TaskStatusComboBox = new System.Windows.Forms.ComboBox();
            this.TaskAttributePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TaskAttributePanel
            // 
            this.TaskAttributePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TaskAttributePanel.Controls.Add(this.TaskStatusComboBox);
            this.TaskAttributePanel.Controls.Add(this.TaskStatusLabel);
            this.TaskAttributePanel.Controls.Add(this.ReturnButton);
            this.TaskAttributePanel.Controls.Add(this.TaskRemindTimeCheckBox);
            this.TaskAttributePanel.Controls.Add(this.TaskEndTimeCheckBox);
            this.TaskAttributePanel.Controls.Add(this.TaskStartTimeCheckBox);
            this.TaskAttributePanel.Controls.Add(this.TaskRemindMinTextBox);
            this.TaskAttributePanel.Controls.Add(this.TaskRemindMinLabel);
            this.TaskAttributePanel.Controls.Add(this.TaskRemindHourTextBox);
            this.TaskAttributePanel.Controls.Add(this.TaskRemindHourLebal);
            this.TaskAttributePanel.Controls.Add(this.TaskRemindDateTimePicker);
            this.TaskAttributePanel.Controls.Add(this.TaskEndMinTextBox);
            this.TaskAttributePanel.Controls.Add(this.TaskModifyButton);
            this.TaskAttributePanel.Controls.Add(this.TaskEndHourTextBox);
            this.TaskAttributePanel.Controls.Add(this.TaskStartMinTextBox);
            this.TaskAttributePanel.Controls.Add(this.TaskStartHourTextBox);
            this.TaskAttributePanel.Controls.Add(this.TaskEndMinLabel);
            this.TaskAttributePanel.Controls.Add(this.TaskEndHourLabel);
            this.TaskAttributePanel.Controls.Add(this.TaskStartMinLabel);
            this.TaskAttributePanel.Controls.Add(this.TaskStartHourLabel);
            this.TaskAttributePanel.Controls.Add(this.TaskEndDateTimePicker);
            this.TaskAttributePanel.Controls.Add(this.TaskStartDateTimePicker);
            this.TaskAttributePanel.Controls.Add(this.TaskStartTimeLabel);
            this.TaskAttributePanel.Controls.Add(this.TaskClassComboBox);
            this.TaskAttributePanel.Controls.Add(this.TaskNameTextBox);
            this.TaskAttributePanel.Controls.Add(this.TaskClassLabel);
            this.TaskAttributePanel.Controls.Add(this.TaskNameLabel);
            this.TaskAttributePanel.Location = new System.Drawing.Point(11, 11);
            this.TaskAttributePanel.Margin = new System.Windows.Forms.Padding(2);
            this.TaskAttributePanel.Name = "TaskAttributePanel";
            this.TaskAttributePanel.Size = new System.Drawing.Size(568, 356);
            this.TaskAttributePanel.TabIndex = 2;
            // 
            // ReturnButton
            // 
            this.ReturnButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ReturnButton.Location = new System.Drawing.Point(427, 282);
            this.ReturnButton.Margin = new System.Windows.Forms.Padding(2);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(115, 47);
            this.ReturnButton.TabIndex = 1;
            this.ReturnButton.Text = "返回主页";
            this.ReturnButton.UseVisualStyleBackColor = true;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // TaskRemindTimeCheckBox
            // 
            this.TaskRemindTimeCheckBox.AutoSize = true;
            this.TaskRemindTimeCheckBox.Location = new System.Drawing.Point(47, 108);
            this.TaskRemindTimeCheckBox.Name = "TaskRemindTimeCheckBox";
            this.TaskRemindTimeCheckBox.Size = new System.Drawing.Size(72, 16);
            this.TaskRemindTimeCheckBox.TabIndex = 25;
            this.TaskRemindTimeCheckBox.Text = "提醒时间";
            this.TaskRemindTimeCheckBox.UseVisualStyleBackColor = true;
            // 
            // TaskEndTimeCheckBox
            // 
            this.TaskEndTimeCheckBox.AutoSize = true;
            this.TaskEndTimeCheckBox.Location = new System.Drawing.Point(47, 236);
            this.TaskEndTimeCheckBox.Name = "TaskEndTimeCheckBox";
            this.TaskEndTimeCheckBox.Size = new System.Drawing.Size(72, 16);
            this.TaskEndTimeCheckBox.TabIndex = 24;
            this.TaskEndTimeCheckBox.Text = "截至时间";
            this.TaskEndTimeCheckBox.UseVisualStyleBackColor = true;
            // 
            // TaskStartTimeCheckBox
            // 
            this.TaskStartTimeCheckBox.AutoSize = true;
            this.TaskStartTimeCheckBox.Location = new System.Drawing.Point(47, 171);
            this.TaskStartTimeCheckBox.Name = "TaskStartTimeCheckBox";
            this.TaskStartTimeCheckBox.Size = new System.Drawing.Size(72, 16);
            this.TaskStartTimeCheckBox.TabIndex = 23;
            this.TaskStartTimeCheckBox.Text = "开始时间";
            this.TaskStartTimeCheckBox.UseVisualStyleBackColor = true;
            // 
            // TaskRemindMinTextBox
            // 
            this.TaskRemindMinTextBox.Location = new System.Drawing.Point(378, 106);
            this.TaskRemindMinTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.TaskRemindMinTextBox.Name = "TaskRemindMinTextBox";
            this.TaskRemindMinTextBox.Size = new System.Drawing.Size(34, 21);
            this.TaskRemindMinTextBox.TabIndex = 22;
            this.TaskRemindMinTextBox.Text = "0";
            // 
            // TaskRemindMinLabel
            // 
            this.TaskRemindMinLabel.AutoSize = true;
            this.TaskRemindMinLabel.Location = new System.Drawing.Point(341, 109);
            this.TaskRemindMinLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TaskRemindMinLabel.Name = "TaskRemindMinLabel";
            this.TaskRemindMinLabel.Size = new System.Drawing.Size(41, 12);
            this.TaskRemindMinLabel.TabIndex = 21;
            this.TaskRemindMinLabel.Text = "分钟：";
            // 
            // TaskRemindHourTextBox
            // 
            this.TaskRemindHourTextBox.Location = new System.Drawing.Point(296, 106);
            this.TaskRemindHourTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.TaskRemindHourTextBox.Name = "TaskRemindHourTextBox";
            this.TaskRemindHourTextBox.Size = new System.Drawing.Size(31, 21);
            this.TaskRemindHourTextBox.TabIndex = 20;
            this.TaskRemindHourTextBox.Text = "0";
            // 
            // TaskRemindHourLebal
            // 
            this.TaskRemindHourLebal.AutoSize = true;
            this.TaskRemindHourLebal.Location = new System.Drawing.Point(263, 109);
            this.TaskRemindHourLebal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TaskRemindHourLebal.Name = "TaskRemindHourLebal";
            this.TaskRemindHourLebal.Size = new System.Drawing.Size(41, 12);
            this.TaskRemindHourLebal.TabIndex = 19;
            this.TaskRemindHourLebal.Text = "小时：";
            // 
            // TaskRemindDateTimePicker
            // 
            this.TaskRemindDateTimePicker.Location = new System.Drawing.Point(124, 103);
            this.TaskRemindDateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.TaskRemindDateTimePicker.Name = "TaskRemindDateTimePicker";
            this.TaskRemindDateTimePicker.Size = new System.Drawing.Size(135, 21);
            this.TaskRemindDateTimePicker.TabIndex = 18;
            // 
            // TaskEndMinTextBox
            // 
            this.TaskEndMinTextBox.Location = new System.Drawing.Point(378, 231);
            this.TaskEndMinTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.TaskEndMinTextBox.Name = "TaskEndMinTextBox";
            this.TaskEndMinTextBox.Size = new System.Drawing.Size(32, 21);
            this.TaskEndMinTextBox.TabIndex = 17;
            this.TaskEndMinTextBox.Text = "59";
            // 
            // TaskModifyButton
            // 
            this.TaskModifyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TaskModifyButton.Location = new System.Drawing.Point(285, 283);
            this.TaskModifyButton.Margin = new System.Windows.Forms.Padding(2);
            this.TaskModifyButton.Name = "TaskModifyButton";
            this.TaskModifyButton.Size = new System.Drawing.Size(116, 45);
            this.TaskModifyButton.TabIndex = 0;
            this.TaskModifyButton.Text = "确认修改";
            this.TaskModifyButton.UseVisualStyleBackColor = true;
            this.TaskModifyButton.Click += new System.EventHandler(this.TaskModifyButton_Click);
            // 
            // TaskEndHourTextBox
            // 
            this.TaskEndHourTextBox.Location = new System.Drawing.Point(296, 231);
            this.TaskEndHourTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.TaskEndHourTextBox.Name = "TaskEndHourTextBox";
            this.TaskEndHourTextBox.Size = new System.Drawing.Size(31, 21);
            this.TaskEndHourTextBox.TabIndex = 16;
            this.TaskEndHourTextBox.Text = "23";
            // 
            // TaskStartMinTextBox
            // 
            this.TaskStartMinTextBox.Location = new System.Drawing.Point(378, 166);
            this.TaskStartMinTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.TaskStartMinTextBox.Name = "TaskStartMinTextBox";
            this.TaskStartMinTextBox.Size = new System.Drawing.Size(34, 21);
            this.TaskStartMinTextBox.TabIndex = 15;
            this.TaskStartMinTextBox.Text = "0";
            // 
            // TaskStartHourTextBox
            // 
            this.TaskStartHourTextBox.Location = new System.Drawing.Point(296, 166);
            this.TaskStartHourTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.TaskStartHourTextBox.Name = "TaskStartHourTextBox";
            this.TaskStartHourTextBox.Size = new System.Drawing.Size(31, 21);
            this.TaskStartHourTextBox.TabIndex = 14;
            this.TaskStartHourTextBox.Text = "0";
            // 
            // TaskEndMinLabel
            // 
            this.TaskEndMinLabel.AutoSize = true;
            this.TaskEndMinLabel.Location = new System.Drawing.Point(341, 236);
            this.TaskEndMinLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TaskEndMinLabel.Name = "TaskEndMinLabel";
            this.TaskEndMinLabel.Size = new System.Drawing.Size(41, 12);
            this.TaskEndMinLabel.TabIndex = 13;
            this.TaskEndMinLabel.Text = "分钟：";
            // 
            // TaskEndHourLabel
            // 
            this.TaskEndHourLabel.AutoSize = true;
            this.TaskEndHourLabel.Location = new System.Drawing.Point(263, 236);
            this.TaskEndHourLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TaskEndHourLabel.Name = "TaskEndHourLabel";
            this.TaskEndHourLabel.Size = new System.Drawing.Size(41, 12);
            this.TaskEndHourLabel.TabIndex = 12;
            this.TaskEndHourLabel.Text = "小时：";
            // 
            // TaskStartMinLabel
            // 
            this.TaskStartMinLabel.AutoSize = true;
            this.TaskStartMinLabel.Location = new System.Drawing.Point(341, 171);
            this.TaskStartMinLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TaskStartMinLabel.Name = "TaskStartMinLabel";
            this.TaskStartMinLabel.Size = new System.Drawing.Size(41, 12);
            this.TaskStartMinLabel.TabIndex = 11;
            this.TaskStartMinLabel.Text = "分钟：";
            // 
            // TaskStartHourLabel
            // 
            this.TaskStartHourLabel.AutoSize = true;
            this.TaskStartHourLabel.Location = new System.Drawing.Point(261, 171);
            this.TaskStartHourLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TaskStartHourLabel.Name = "TaskStartHourLabel";
            this.TaskStartHourLabel.Size = new System.Drawing.Size(41, 12);
            this.TaskStartHourLabel.TabIndex = 10;
            this.TaskStartHourLabel.Text = "小时：";
            // 
            // TaskEndDateTimePicker
            // 
            this.TaskEndDateTimePicker.Location = new System.Drawing.Point(124, 231);
            this.TaskEndDateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.TaskEndDateTimePicker.Name = "TaskEndDateTimePicker";
            this.TaskEndDateTimePicker.Size = new System.Drawing.Size(135, 21);
            this.TaskEndDateTimePicker.TabIndex = 9;
            // 
            // TaskStartDateTimePicker
            // 
            this.TaskStartDateTimePicker.Location = new System.Drawing.Point(124, 166);
            this.TaskStartDateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.TaskStartDateTimePicker.Name = "TaskStartDateTimePicker";
            this.TaskStartDateTimePicker.Size = new System.Drawing.Size(135, 21);
            this.TaskStartDateTimePicker.TabIndex = 8;
            // 
            // TaskStartTimeLabel
            // 
            this.TaskStartTimeLabel.AutoSize = true;
            this.TaskStartTimeLabel.Location = new System.Drawing.Point(61, 171);
            this.TaskStartTimeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TaskStartTimeLabel.Name = "TaskStartTimeLabel";
            this.TaskStartTimeLabel.Size = new System.Drawing.Size(0, 12);
            this.TaskStartTimeLabel.TabIndex = 6;
            // 
            // TaskClassComboBox
            // 
            this.TaskClassComboBox.FormattingEnabled = true;
            this.TaskClassComboBox.Items.AddRange(new object[] {
            "学习任务",
            "工作任务",
            "生活任务",
            "未归档"});
            this.TaskClassComboBox.Location = new System.Drawing.Point(343, 19);
            this.TaskClassComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.TaskClassComboBox.Name = "TaskClassComboBox";
            this.TaskClassComboBox.Size = new System.Drawing.Size(164, 20);
            this.TaskClassComboBox.TabIndex = 4;
            // 
            // TaskNameTextBox
            // 
            this.TaskNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TaskNameTextBox.Location = new System.Drawing.Point(124, 18);
            this.TaskNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.TaskNameTextBox.Name = "TaskNameTextBox";
            this.TaskNameTextBox.Size = new System.Drawing.Size(118, 21);
            this.TaskNameTextBox.TabIndex = 3;
            // 
            // TaskClassLabel
            // 
            this.TaskClassLabel.AutoSize = true;
            this.TaskClassLabel.Location = new System.Drawing.Point(273, 22);
            this.TaskClassLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TaskClassLabel.Name = "TaskClassLabel";
            this.TaskClassLabel.Size = new System.Drawing.Size(65, 12);
            this.TaskClassLabel.TabIndex = 1;
            this.TaskClassLabel.Text = "任务类型：";
            // 
            // TaskNameLabel
            // 
            this.TaskNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TaskNameLabel.AutoSize = true;
            this.TaskNameLabel.Location = new System.Drawing.Point(61, 22);
            this.TaskNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TaskNameLabel.Name = "TaskNameLabel";
            this.TaskNameLabel.Size = new System.Drawing.Size(53, 12);
            this.TaskNameLabel.TabIndex = 0;
            this.TaskNameLabel.Text = "任务名：";
            // 
            // TaskStatusLabel
            // 
            this.TaskStatusLabel.AutoSize = true;
            this.TaskStatusLabel.Location = new System.Drawing.Point(61, 65);
            this.TaskStatusLabel.Name = "TaskStatusLabel";
            this.TaskStatusLabel.Size = new System.Drawing.Size(65, 12);
            this.TaskStatusLabel.TabIndex = 26;
            this.TaskStatusLabel.Text = "任务状态：";
            // 
            // TaskStatusComboBox
            // 
            this.TaskStatusComboBox.FormattingEnabled = true;
            this.TaskStatusComboBox.Items.AddRange(new object[] {
            "未完成",
            "过期",
            "紧急",
            "已完成"});
            this.TaskStatusComboBox.Location = new System.Drawing.Point(124, 62);
            this.TaskStatusComboBox.Name = "TaskStatusComboBox";
            this.TaskStatusComboBox.Size = new System.Drawing.Size(121, 20);
            this.TaskStatusComboBox.TabIndex = 27;
            // 
            // ViewTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 377);
            this.Controls.Add(this.TaskAttributePanel);
            this.Name = "ViewTaskForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ViewTaskForm_Load);
            this.TaskAttributePanel.ResumeLayout(false);
            this.TaskAttributePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TaskAttributePanel;
        private System.Windows.Forms.Button ReturnButton;
        private System.Windows.Forms.CheckBox TaskRemindTimeCheckBox;
        private System.Windows.Forms.CheckBox TaskEndTimeCheckBox;
        private System.Windows.Forms.CheckBox TaskStartTimeCheckBox;
        private System.Windows.Forms.TextBox TaskRemindMinTextBox;
        private System.Windows.Forms.Label TaskRemindMinLabel;
        private System.Windows.Forms.TextBox TaskRemindHourTextBox;
        private System.Windows.Forms.Label TaskRemindHourLebal;
        private System.Windows.Forms.DateTimePicker TaskRemindDateTimePicker;
        private System.Windows.Forms.TextBox TaskEndMinTextBox;
        private System.Windows.Forms.Button TaskModifyButton;
        private System.Windows.Forms.TextBox TaskEndHourTextBox;
        private System.Windows.Forms.TextBox TaskStartMinTextBox;
        private System.Windows.Forms.TextBox TaskStartHourTextBox;
        private System.Windows.Forms.Label TaskEndMinLabel;
        private System.Windows.Forms.Label TaskEndHourLabel;
        private System.Windows.Forms.Label TaskStartMinLabel;
        private System.Windows.Forms.Label TaskStartHourLabel;
        private System.Windows.Forms.DateTimePicker TaskEndDateTimePicker;
        private System.Windows.Forms.DateTimePicker TaskStartDateTimePicker;
        private System.Windows.Forms.Label TaskStartTimeLabel;
        private System.Windows.Forms.ComboBox TaskClassComboBox;
        private System.Windows.Forms.TextBox TaskNameTextBox;
        private System.Windows.Forms.Label TaskClassLabel;
        private System.Windows.Forms.Label TaskNameLabel;
        private System.Windows.Forms.Label TaskStatusLabel;
        private System.Windows.Forms.ComboBox TaskStatusComboBox;
    }
}