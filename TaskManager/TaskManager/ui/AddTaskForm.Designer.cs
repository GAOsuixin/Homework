namespace TaskManager.ui
{
    partial class AddTaskForm
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
            this.DDLTime_label = new System.Windows.Forms.Label();
            this.ReminderTime_label = new System.Windows.Forms.Label();
            this.StartTime_lable = new System.Windows.Forms.Label();
            this.isImportant_checkBox = new System.Windows.Forms.CheckBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.TaskRemindMinTextBox = new System.Windows.Forms.TextBox();
            this.TaskRemindMinLabel = new System.Windows.Forms.Label();
            this.TaskRemindHourTextBox = new System.Windows.Forms.TextBox();
            this.TaskRemindHourLebal = new System.Windows.Forms.Label();
            this.TaskRemindDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.TaskEndMinTextBox = new System.Windows.Forms.TextBox();
            this.AddTaskButton = new System.Windows.Forms.Button();
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
            this.ReminderTime10MinEarliercheckBox = new System.Windows.Forms.CheckBox();
            this.ReminderTime20MinEarliercheckbox = new System.Windows.Forms.CheckBox();
            this.ReminderTimeByYourselfcheckbox = new System.Windows.Forms.CheckBox();
            this.EndTimeOneDayLatercheckBox = new System.Windows.Forms.CheckBox();
            this.EndTimeOneWeekLatercheckBox = new System.Windows.Forms.CheckBox();
            this.EndTimeByYourselfcheckBox = new System.Windows.Forms.CheckBox();
            this.EverydaycheckBox = new System.Windows.Forms.CheckBox();
            this.TaskAttributePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TaskAttributePanel
            // 
            this.TaskAttributePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TaskAttributePanel.Controls.Add(this.EverydaycheckBox);
            this.TaskAttributePanel.Controls.Add(this.EndTimeByYourselfcheckBox);
            this.TaskAttributePanel.Controls.Add(this.EndTimeOneWeekLatercheckBox);
            this.TaskAttributePanel.Controls.Add(this.EndTimeOneDayLatercheckBox);
            this.TaskAttributePanel.Controls.Add(this.ReminderTimeByYourselfcheckbox);
            this.TaskAttributePanel.Controls.Add(this.ReminderTime20MinEarliercheckbox);
            this.TaskAttributePanel.Controls.Add(this.ReminderTime10MinEarliercheckBox);
            this.TaskAttributePanel.Controls.Add(this.DDLTime_label);
            this.TaskAttributePanel.Controls.Add(this.ReminderTime_label);
            this.TaskAttributePanel.Controls.Add(this.StartTime_lable);
            this.TaskAttributePanel.Controls.Add(this.isImportant_checkBox);
            this.TaskAttributePanel.Controls.Add(this.CancelButton);
            this.TaskAttributePanel.Controls.Add(this.TaskRemindMinTextBox);
            this.TaskAttributePanel.Controls.Add(this.TaskRemindMinLabel);
            this.TaskAttributePanel.Controls.Add(this.TaskRemindHourTextBox);
            this.TaskAttributePanel.Controls.Add(this.TaskRemindHourLebal);
            this.TaskAttributePanel.Controls.Add(this.TaskRemindDateTimePicker);
            this.TaskAttributePanel.Controls.Add(this.TaskEndMinTextBox);
            this.TaskAttributePanel.Controls.Add(this.AddTaskButton);
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
            this.TaskAttributePanel.Location = new System.Drawing.Point(15, 14);
            this.TaskAttributePanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TaskAttributePanel.Name = "TaskAttributePanel";
            this.TaskAttributePanel.Size = new System.Drawing.Size(1096, 483);
            this.TaskAttributePanel.TabIndex = 1;
            // 
            // DDLTime_label
            // 
            this.DDLTime_label.AutoSize = true;
            this.DDLTime_label.Location = new System.Drawing.Point(35, 277);
            this.DDLTime_label.Name = "DDLTime_label";
            this.DDLTime_label.Size = new System.Drawing.Size(67, 15);
            this.DDLTime_label.TabIndex = 29;
            this.DDLTime_label.Text = "截止时间";
            // 
            // ReminderTime_label
            // 
            this.ReminderTime_label.AutoSize = true;
            this.ReminderTime_label.Location = new System.Drawing.Point(35, 228);
            this.ReminderTime_label.Name = "ReminderTime_label";
            this.ReminderTime_label.Size = new System.Drawing.Size(67, 15);
            this.ReminderTime_label.TabIndex = 28;
            this.ReminderTime_label.Text = "提醒时间";
            // 
            // StartTime_lable
            // 
            this.StartTime_lable.AutoSize = true;
            this.StartTime_lable.Location = new System.Drawing.Point(35, 182);
            this.StartTime_lable.Name = "StartTime_lable";
            this.StartTime_lable.Size = new System.Drawing.Size(67, 15);
            this.StartTime_lable.TabIndex = 27;
            this.StartTime_lable.Text = "开始时间";
            // 
            // isImportant_checkBox
            // 
            this.isImportant_checkBox.AutoSize = true;
            this.isImportant_checkBox.Location = new System.Drawing.Point(38, 328);
            this.isImportant_checkBox.Name = "isImportant_checkBox";
            this.isImportant_checkBox.Size = new System.Drawing.Size(59, 19);
            this.isImportant_checkBox.TabIndex = 26;
            this.isImportant_checkBox.Text = "紧急";
            this.isImportant_checkBox.UseVisualStyleBackColor = true;
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelButton.Location = new System.Drawing.Point(920, 409);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(153, 59);
            this.CancelButton.TabIndex = 1;
            this.CancelButton.Text = "返回主页";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // TaskRemindMinTextBox
            // 
            this.TaskRemindMinTextBox.Location = new System.Drawing.Point(758, 218);
            this.TaskRemindMinTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TaskRemindMinTextBox.Name = "TaskRemindMinTextBox";
            this.TaskRemindMinTextBox.Size = new System.Drawing.Size(44, 25);
            this.TaskRemindMinTextBox.TabIndex = 22;
            this.TaskRemindMinTextBox.Text = "0";
            // 
            // TaskRemindMinLabel
            // 
            this.TaskRemindMinLabel.AutoSize = true;
            this.TaskRemindMinLabel.Location = new System.Drawing.Point(709, 221);
            this.TaskRemindMinLabel.Name = "TaskRemindMinLabel";
            this.TaskRemindMinLabel.Size = new System.Drawing.Size(52, 15);
            this.TaskRemindMinLabel.TabIndex = 21;
            this.TaskRemindMinLabel.Text = "分钟：";
            // 
            // TaskRemindHourTextBox
            // 
            this.TaskRemindHourTextBox.Location = new System.Drawing.Point(649, 218);
            this.TaskRemindHourTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TaskRemindHourTextBox.Name = "TaskRemindHourTextBox";
            this.TaskRemindHourTextBox.Size = new System.Drawing.Size(40, 25);
            this.TaskRemindHourTextBox.TabIndex = 20;
            this.TaskRemindHourTextBox.Text = "0";
            // 
            // TaskRemindHourLebal
            // 
            this.TaskRemindHourLebal.AutoSize = true;
            this.TaskRemindHourLebal.Location = new System.Drawing.Point(605, 221);
            this.TaskRemindHourLebal.Name = "TaskRemindHourLebal";
            this.TaskRemindHourLebal.Size = new System.Drawing.Size(52, 15);
            this.TaskRemindHourLebal.TabIndex = 19;
            this.TaskRemindHourLebal.Text = "小时：";
            // 
            // TaskRemindDateTimePicker
            // 
            this.TaskRemindDateTimePicker.Location = new System.Drawing.Point(421, 218);
            this.TaskRemindDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TaskRemindDateTimePicker.Name = "TaskRemindDateTimePicker";
            this.TaskRemindDateTimePicker.Size = new System.Drawing.Size(179, 25);
            this.TaskRemindDateTimePicker.TabIndex = 18;
            // 
            // TaskEndMinTextBox
            // 
            this.TaskEndMinTextBox.Location = new System.Drawing.Point(758, 271);
            this.TaskEndMinTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TaskEndMinTextBox.Name = "TaskEndMinTextBox";
            this.TaskEndMinTextBox.Size = new System.Drawing.Size(44, 25);
            this.TaskEndMinTextBox.TabIndex = 17;
            this.TaskEndMinTextBox.Text = "59";
            // 
            // AddTaskButton
            // 
            this.AddTaskButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddTaskButton.Location = new System.Drawing.Point(721, 412);
            this.AddTaskButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddTaskButton.Name = "AddTaskButton";
            this.AddTaskButton.Size = new System.Drawing.Size(155, 56);
            this.AddTaskButton.TabIndex = 0;
            this.AddTaskButton.Text = "确认添加";
            this.AddTaskButton.UseVisualStyleBackColor = true;
            this.AddTaskButton.Click += new System.EventHandler(this.AddTaskButton_Click);
            // 
            // TaskEndHourTextBox
            // 
            this.TaskEndHourTextBox.Location = new System.Drawing.Point(649, 271);
            this.TaskEndHourTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TaskEndHourTextBox.Name = "TaskEndHourTextBox";
            this.TaskEndHourTextBox.Size = new System.Drawing.Size(40, 25);
            this.TaskEndHourTextBox.TabIndex = 16;
            this.TaskEndHourTextBox.Text = "23";
            // 
            // TaskStartMinTextBox
            // 
            this.TaskStartMinTextBox.Location = new System.Drawing.Point(457, 176);
            this.TaskStartMinTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TaskStartMinTextBox.Name = "TaskStartMinTextBox";
            this.TaskStartMinTextBox.Size = new System.Drawing.Size(44, 25);
            this.TaskStartMinTextBox.TabIndex = 15;
            this.TaskStartMinTextBox.Text = "0";
            // 
            // TaskStartHourTextBox
            // 
            this.TaskStartHourTextBox.Location = new System.Drawing.Point(348, 176);
            this.TaskStartHourTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TaskStartHourTextBox.Name = "TaskStartHourTextBox";
            this.TaskStartHourTextBox.Size = new System.Drawing.Size(40, 25);
            this.TaskStartHourTextBox.TabIndex = 14;
            this.TaskStartHourTextBox.Text = "0";
            // 
            // TaskEndMinLabel
            // 
            this.TaskEndMinLabel.AutoSize = true;
            this.TaskEndMinLabel.Location = new System.Drawing.Point(709, 277);
            this.TaskEndMinLabel.Name = "TaskEndMinLabel";
            this.TaskEndMinLabel.Size = new System.Drawing.Size(52, 15);
            this.TaskEndMinLabel.TabIndex = 13;
            this.TaskEndMinLabel.Text = "分钟：";
            // 
            // TaskEndHourLabel
            // 
            this.TaskEndHourLabel.AutoSize = true;
            this.TaskEndHourLabel.Location = new System.Drawing.Point(605, 277);
            this.TaskEndHourLabel.Name = "TaskEndHourLabel";
            this.TaskEndHourLabel.Size = new System.Drawing.Size(52, 15);
            this.TaskEndHourLabel.TabIndex = 12;
            this.TaskEndHourLabel.Text = "小时：";
            // 
            // TaskStartMinLabel
            // 
            this.TaskStartMinLabel.AutoSize = true;
            this.TaskStartMinLabel.Location = new System.Drawing.Point(408, 182);
            this.TaskStartMinLabel.Name = "TaskStartMinLabel";
            this.TaskStartMinLabel.Size = new System.Drawing.Size(52, 15);
            this.TaskStartMinLabel.TabIndex = 11;
            this.TaskStartMinLabel.Text = "分钟：";
            // 
            // TaskStartHourLabel
            // 
            this.TaskStartHourLabel.AutoSize = true;
            this.TaskStartHourLabel.Location = new System.Drawing.Point(301, 182);
            this.TaskStartHourLabel.Name = "TaskStartHourLabel";
            this.TaskStartHourLabel.Size = new System.Drawing.Size(52, 15);
            this.TaskStartHourLabel.TabIndex = 10;
            this.TaskStartHourLabel.Text = "小时：";
            // 
            // TaskEndDateTimePicker
            // 
            this.TaskEndDateTimePicker.Location = new System.Drawing.Point(421, 271);
            this.TaskEndDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TaskEndDateTimePicker.Name = "TaskEndDateTimePicker";
            this.TaskEndDateTimePicker.Size = new System.Drawing.Size(179, 25);
            this.TaskEndDateTimePicker.TabIndex = 9;
            // 
            // TaskStartDateTimePicker
            // 
            this.TaskStartDateTimePicker.Location = new System.Drawing.Point(119, 176);
            this.TaskStartDateTimePicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TaskStartDateTimePicker.Name = "TaskStartDateTimePicker";
            this.TaskStartDateTimePicker.Size = new System.Drawing.Size(179, 25);
            this.TaskStartDateTimePicker.TabIndex = 8;
            // 
            // TaskStartTimeLabel
            // 
            this.TaskStartTimeLabel.AutoSize = true;
            this.TaskStartTimeLabel.Location = new System.Drawing.Point(35, 182);
            this.TaskStartTimeLabel.Name = "TaskStartTimeLabel";
            this.TaskStartTimeLabel.Size = new System.Drawing.Size(0, 15);
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
            this.TaskClassComboBox.Location = new System.Drawing.Point(119, 94);
            this.TaskClassComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TaskClassComboBox.Name = "TaskClassComboBox";
            this.TaskClassComboBox.Size = new System.Drawing.Size(279, 23);
            this.TaskClassComboBox.TabIndex = 4;
            // 
            // TaskNameTextBox
            // 
            this.TaskNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TaskNameTextBox.Location = new System.Drawing.Point(119, 24);
            this.TaskNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TaskNameTextBox.Name = "TaskNameTextBox";
            this.TaskNameTextBox.Size = new System.Drawing.Size(279, 25);
            this.TaskNameTextBox.TabIndex = 3;
            // 
            // TaskClassLabel
            // 
            this.TaskClassLabel.AutoSize = true;
            this.TaskClassLabel.Location = new System.Drawing.Point(35, 98);
            this.TaskClassLabel.Name = "TaskClassLabel";
            this.TaskClassLabel.Size = new System.Drawing.Size(82, 15);
            this.TaskClassLabel.TabIndex = 1;
            this.TaskClassLabel.Text = "任务类型：";
            // 
            // TaskNameLabel
            // 
            this.TaskNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TaskNameLabel.AutoSize = true;
            this.TaskNameLabel.Location = new System.Drawing.Point(35, 28);
            this.TaskNameLabel.Name = "TaskNameLabel";
            this.TaskNameLabel.Size = new System.Drawing.Size(67, 15);
            this.TaskNameLabel.TabIndex = 0;
            this.TaskNameLabel.Text = "任务名：";
            // 
            // ReminderTime10MinEarliercheckBox
            // 
            this.ReminderTime10MinEarliercheckBox.AutoSize = true;
            this.ReminderTime10MinEarliercheckBox.Location = new System.Drawing.Point(119, 227);
            this.ReminderTime10MinEarliercheckBox.Name = "ReminderTime10MinEarliercheckBox";
            this.ReminderTime10MinEarliercheckBox.Size = new System.Drawing.Size(105, 19);
            this.ReminderTime10MinEarliercheckBox.TabIndex = 30;
            this.ReminderTime10MinEarliercheckBox.Text = "提前10分钟";
            this.ReminderTime10MinEarliercheckBox.UseVisualStyleBackColor = true;
            this.ReminderTime10MinEarliercheckBox.CheckedChanged += new System.EventHandler(this.ReminderTime10MinEarliercheckBox_CheckedChanged);
            // 
            // ReminderTime20MinEarliercheckbox
            // 
            this.ReminderTime20MinEarliercheckbox.AutoSize = true;
            this.ReminderTime20MinEarliercheckbox.Location = new System.Drawing.Point(230, 225);
            this.ReminderTime20MinEarliercheckbox.Name = "ReminderTime20MinEarliercheckbox";
            this.ReminderTime20MinEarliercheckbox.Size = new System.Drawing.Size(105, 19);
            this.ReminderTime20MinEarliercheckbox.TabIndex = 31;
            this.ReminderTime20MinEarliercheckbox.Text = "提前20分钟";
            this.ReminderTime20MinEarliercheckbox.UseVisualStyleBackColor = true;
            this.ReminderTime20MinEarliercheckbox.CheckedChanged += new System.EventHandler(this.ReminderTime20MinEarliercheckbox_CheckedChanged);
            // 
            // ReminderTimeByYourselfcheckbox
            // 
            this.ReminderTimeByYourselfcheckbox.AutoSize = true;
            this.ReminderTimeByYourselfcheckbox.Checked = true;
            this.ReminderTimeByYourselfcheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ReminderTimeByYourselfcheckbox.Location = new System.Drawing.Point(341, 225);
            this.ReminderTimeByYourselfcheckbox.Name = "ReminderTimeByYourselfcheckbox";
            this.ReminderTimeByYourselfcheckbox.Size = new System.Drawing.Size(74, 19);
            this.ReminderTimeByYourselfcheckbox.TabIndex = 32;
            this.ReminderTimeByYourselfcheckbox.Text = "自定义";
            this.ReminderTimeByYourselfcheckbox.UseVisualStyleBackColor = true;
            this.ReminderTimeByYourselfcheckbox.CheckedChanged += new System.EventHandler(this.ReminderTimeByYourselfcheckbox_CheckedChanged);
            // 
            // EndTimeOneDayLatercheckBox
            // 
            this.EndTimeOneDayLatercheckBox.AutoSize = true;
            this.EndTimeOneDayLatercheckBox.Location = new System.Drawing.Point(119, 277);
            this.EndTimeOneDayLatercheckBox.Name = "EndTimeOneDayLatercheckBox";
            this.EndTimeOneDayLatercheckBox.Size = new System.Drawing.Size(74, 19);
            this.EndTimeOneDayLatercheckBox.TabIndex = 33;
            this.EndTimeOneDayLatercheckBox.Text = "一天后";
            this.EndTimeOneDayLatercheckBox.UseVisualStyleBackColor = true;
            this.EndTimeOneDayLatercheckBox.CheckedChanged += new System.EventHandler(this.EndTimeOneDayLatercheckBox_CheckedChanged);
            // 
            // EndTimeOneWeekLatercheckBox
            // 
            this.EndTimeOneWeekLatercheckBox.AutoSize = true;
            this.EndTimeOneWeekLatercheckBox.Location = new System.Drawing.Point(230, 276);
            this.EndTimeOneWeekLatercheckBox.Name = "EndTimeOneWeekLatercheckBox";
            this.EndTimeOneWeekLatercheckBox.Size = new System.Drawing.Size(74, 19);
            this.EndTimeOneWeekLatercheckBox.TabIndex = 34;
            this.EndTimeOneWeekLatercheckBox.Text = "一周后";
            this.EndTimeOneWeekLatercheckBox.UseVisualStyleBackColor = true;
            this.EndTimeOneWeekLatercheckBox.CheckedChanged += new System.EventHandler(this.EndTimeOneWeekLatercheckBox_CheckedChanged);
            // 
            // EndTimeByYourselfcheckBox
            // 
            this.EndTimeByYourselfcheckBox.AutoSize = true;
            this.EndTimeByYourselfcheckBox.Checked = true;
            this.EndTimeByYourselfcheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.EndTimeByYourselfcheckBox.Location = new System.Drawing.Point(341, 277);
            this.EndTimeByYourselfcheckBox.Name = "EndTimeByYourselfcheckBox";
            this.EndTimeByYourselfcheckBox.Size = new System.Drawing.Size(74, 19);
            this.EndTimeByYourselfcheckBox.TabIndex = 35;
            this.EndTimeByYourselfcheckBox.Text = "自定义";
            this.EndTimeByYourselfcheckBox.UseVisualStyleBackColor = true;
            this.EndTimeByYourselfcheckBox.CheckedChanged += new System.EventHandler(this.EndTimeByYourselfcheckBox_CheckedChanged);
            // 
            // EverydaycheckBox
            // 
            this.EverydaycheckBox.AutoSize = true;
            this.EverydaycheckBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.EverydaycheckBox.Location = new System.Drawing.Point(119, 327);
            this.EverydaycheckBox.Name = "EverydaycheckBox";
            this.EverydaycheckBox.Size = new System.Drawing.Size(59, 19);
            this.EverydaycheckBox.TabIndex = 36;
            this.EverydaycheckBox.Text = "每天";
            this.EverydaycheckBox.UseVisualStyleBackColor = true;
            // 
            // AddTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 513);
            this.Controls.Add(this.TaskAttributePanel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddTaskForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.AddTaskForm_Load);
            this.TaskAttributePanel.ResumeLayout(false);
            this.TaskAttributePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TaskAttributePanel;
        private System.Windows.Forms.TextBox TaskEndMinTextBox;
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
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button AddTaskButton;
        private System.Windows.Forms.DateTimePicker TaskRemindDateTimePicker;
        private System.Windows.Forms.TextBox TaskRemindMinTextBox;
        private System.Windows.Forms.Label TaskRemindMinLabel;
        private System.Windows.Forms.TextBox TaskRemindHourTextBox;
        private System.Windows.Forms.Label TaskRemindHourLebal;
        private System.Windows.Forms.CheckBox isImportant_checkBox;
        private System.Windows.Forms.Label DDLTime_label;
        private System.Windows.Forms.Label ReminderTime_label;
        private System.Windows.Forms.Label StartTime_lable;
        private System.Windows.Forms.CheckBox EndTimeByYourselfcheckBox;
        private System.Windows.Forms.CheckBox EndTimeOneWeekLatercheckBox;
        private System.Windows.Forms.CheckBox EndTimeOneDayLatercheckBox;
        private System.Windows.Forms.CheckBox ReminderTimeByYourselfcheckbox;
        private System.Windows.Forms.CheckBox ReminderTime20MinEarliercheckbox;
        private System.Windows.Forms.CheckBox ReminderTime10MinEarliercheckBox;
        private System.Windows.Forms.CheckBox EverydaycheckBox;
    }
}