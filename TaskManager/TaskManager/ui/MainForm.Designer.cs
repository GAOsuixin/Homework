namespace TaskManager.ui
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TaskPanel = new System.Windows.Forms.Panel();
            this.SortcomboBox = new System.Windows.Forms.ComboBox();
            this.sortlabel = new System.Windows.Forms.Label();
            this.showlabel = new System.Windows.Forms.Label();
            this.chooseByTaskStatuscheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.chooseByTaskTypescheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.deleteTaskBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.AddTaskButton = new System.Windows.Forms.Button();
            this.ListViewPanel = new System.Windows.Forms.Panel();
            this.TaskDataGridView = new System.Windows.Forms.DataGridView();
            this.ListPanel = new System.Windows.Forms.Panel();
            this.Search = new System.Windows.Forms.TextBox();
            this.ScheduledButton = new System.Windows.Forms.Button();
            this.WeekTaskButton = new System.Windows.Forms.Button();
            this.SettingButton = new System.Windows.Forms.Button();
            this.TodayTaskButton = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.TaskPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.ListViewPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TaskDataGridView)).BeginInit();
            this.ListPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.TaskPanel);
            this.panel1.Controls.Add(this.ListPanel);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1008, 450);
            this.panel1.TabIndex = 0;
            // 
            // TaskPanel
            // 
            this.TaskPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TaskPanel.Controls.Add(this.SortcomboBox);
            this.TaskPanel.Controls.Add(this.sortlabel);
            this.TaskPanel.Controls.Add(this.showlabel);
            this.TaskPanel.Controls.Add(this.chooseByTaskStatuscheckedListBox);
            this.TaskPanel.Controls.Add(this.chooseByTaskTypescheckedListBox);
            this.TaskPanel.Controls.Add(this.panel2);
            this.TaskPanel.Controls.Add(this.panel3);
            this.TaskPanel.Controls.Add(this.ListViewPanel);
            this.TaskPanel.Location = new System.Drawing.Point(178, 3);
            this.TaskPanel.Name = "TaskPanel";
            this.TaskPanel.Size = new System.Drawing.Size(827, 444);
            this.TaskPanel.TabIndex = 1;
            // 
            // SortcomboBox
            // 
            this.SortcomboBox.FormattingEnabled = true;
            this.SortcomboBox.Items.AddRange(new object[] {
            "根据开始时间",
            "根据截止之间",
            "根据提醒时间"});
            this.SortcomboBox.Location = new System.Drawing.Point(538, 6);
            this.SortcomboBox.Margin = new System.Windows.Forms.Padding(2);
            this.SortcomboBox.Name = "SortcomboBox";
            this.SortcomboBox.Size = new System.Drawing.Size(92, 20);
            this.SortcomboBox.TabIndex = 14;
            this.SortcomboBox.SelectedIndexChanged += new System.EventHandler(this.SortcomboBox_SelectedIndexChanged);
            // 
            // sortlabel
            // 
            this.sortlabel.AutoSize = true;
            this.sortlabel.Location = new System.Drawing.Point(506, 9);
            this.sortlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.sortlabel.Name = "sortlabel";
            this.sortlabel.Size = new System.Drawing.Size(29, 12);
            this.sortlabel.TabIndex = 13;
            this.sortlabel.Text = "排序";
            // 
            // showlabel
            // 
            this.showlabel.AutoSize = true;
            this.showlabel.Location = new System.Drawing.Point(23, 9);
            this.showlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.showlabel.Name = "showlabel";
            this.showlabel.Size = new System.Drawing.Size(29, 12);
            this.showlabel.TabIndex = 12;
            this.showlabel.Text = "展示";
            // 
            // chooseByTaskStatuscheckedListBox
            // 
            this.chooseByTaskStatuscheckedListBox.BackColor = System.Drawing.SystemColors.Control;
            this.chooseByTaskStatuscheckedListBox.CheckOnClick = true;
            this.chooseByTaskStatuscheckedListBox.FormattingEnabled = true;
            this.chooseByTaskStatuscheckedListBox.Items.AddRange(new object[] {
            "已完成",
            "未完成",
            "紧急任务"});
            this.chooseByTaskStatuscheckedListBox.Location = new System.Drawing.Point(217, 2);
            this.chooseByTaskStatuscheckedListBox.Margin = new System.Windows.Forms.Padding(2);
            this.chooseByTaskStatuscheckedListBox.Name = "chooseByTaskStatuscheckedListBox";
            this.chooseByTaskStatuscheckedListBox.Size = new System.Drawing.Size(159, 52);
            this.chooseByTaskStatuscheckedListBox.TabIndex = 10;
            this.chooseByTaskStatuscheckedListBox.SelectedIndexChanged += new System.EventHandler(this.chooseByTaskStatuscheckedListBox_SelectedIndexChanged);
            // 
            // chooseByTaskTypescheckedListBox
            // 
            this.chooseByTaskTypescheckedListBox.BackColor = System.Drawing.SystemColors.Control;
            this.chooseByTaskTypescheckedListBox.CheckOnClick = true;
            this.chooseByTaskTypescheckedListBox.FormattingEnabled = true;
            this.chooseByTaskTypescheckedListBox.Items.AddRange(new object[] {
            "学习任务",
            "工作任务",
            "生活任务"});
            this.chooseByTaskTypescheckedListBox.Location = new System.Drawing.Point(56, 2);
            this.chooseByTaskTypescheckedListBox.Margin = new System.Windows.Forms.Padding(2);
            this.chooseByTaskTypescheckedListBox.Name = "chooseByTaskTypescheckedListBox";
            this.chooseByTaskTypescheckedListBox.Size = new System.Drawing.Size(158, 52);
            this.chooseByTaskTypescheckedListBox.TabIndex = 11;
            this.chooseByTaskTypescheckedListBox.SelectedIndexChanged += new System.EventHandler(this.chooseByTaskTypescheckedListBox_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.Controls.Add(this.deleteTaskBtn);
            this.panel2.Location = new System.Drawing.Point(188, 405);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(175, 36);
            this.panel2.TabIndex = 2;
            // 
            // deleteTaskBtn
            // 
            this.deleteTaskBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.deleteTaskBtn.Location = new System.Drawing.Point(4, 0);
            this.deleteTaskBtn.Name = "deleteTaskBtn";
            this.deleteTaskBtn.Size = new System.Drawing.Size(168, 36);
            this.deleteTaskBtn.TabIndex = 1;
            this.deleteTaskBtn.Text = "删除任务";
            this.deleteTaskBtn.UseVisualStyleBackColor = true;
            this.deleteTaskBtn.Click += new System.EventHandler(this.deleteTaskBtn_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel3.Controls.Add(this.AddTaskButton);
            this.panel3.Location = new System.Drawing.Point(3, 405);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(169, 36);
            this.panel3.TabIndex = 1;
            // 
            // AddTaskButton
            // 
            this.AddTaskButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.AddTaskButton.Location = new System.Drawing.Point(0, 0);
            this.AddTaskButton.Name = "AddTaskButton";
            this.AddTaskButton.Size = new System.Drawing.Size(168, 36);
            this.AddTaskButton.TabIndex = 0;
            this.AddTaskButton.Text = "添加任务";
            this.AddTaskButton.UseVisualStyleBackColor = true;
            this.AddTaskButton.Click += new System.EventHandler(this.AddTaskButton_Click);
            // 
            // ListViewPanel
            // 
            this.ListViewPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListViewPanel.Controls.Add(this.TaskDataGridView);
            this.ListViewPanel.Location = new System.Drawing.Point(3, 54);
            this.ListViewPanel.Name = "ListViewPanel";
            this.ListViewPanel.Size = new System.Drawing.Size(821, 349);
            this.ListViewPanel.TabIndex = 0;
            // 
            // TaskDataGridView
            // 
            this.TaskDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TaskDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TaskDataGridView.Location = new System.Drawing.Point(3, 3);
            this.TaskDataGridView.MultiSelect = false;
            this.TaskDataGridView.Name = "TaskDataGridView";
            this.TaskDataGridView.ReadOnly = true;
            this.TaskDataGridView.RowHeadersWidth = 51;
            this.TaskDataGridView.RowTemplate.Height = 23;
            this.TaskDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TaskDataGridView.Size = new System.Drawing.Size(815, 342);
            this.TaskDataGridView.TabIndex = 0;
            this.TaskDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TaskDataGridView_CellContentClick);
            // 
            // ListPanel
            // 
            this.ListPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ListPanel.Controls.Add(this.label1);
            this.ListPanel.Controls.Add(this.Search);
            this.ListPanel.Controls.Add(this.ScheduledButton);
            this.ListPanel.Controls.Add(this.WeekTaskButton);
            this.ListPanel.Controls.Add(this.SettingButton);
            this.ListPanel.Controls.Add(this.TodayTaskButton);
            this.ListPanel.Location = new System.Drawing.Point(3, 3);
            this.ListPanel.Name = "ListPanel";
            this.ListPanel.Size = new System.Drawing.Size(169, 444);
            this.ListPanel.TabIndex = 0;
            // 
            // Search
            // 
            this.Search.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Search.Location = new System.Drawing.Point(44, 8);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(121, 21);
            this.Search.TabIndex = 5;
            this.Search.TextChanged += new System.EventHandler(this.Search_TextChanged);
            // 
            // ScheduledButton
            // 
            this.ScheduledButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ScheduledButton.Location = new System.Drawing.Point(3, 42);
            this.ScheduledButton.Name = "ScheduledButton";
            this.ScheduledButton.Size = new System.Drawing.Size(163, 34);
            this.ScheduledButton.TabIndex = 4;
            this.ScheduledButton.Text = "全部任务";
            this.ScheduledButton.UseVisualStyleBackColor = true;
            this.ScheduledButton.Click += new System.EventHandler(this.ScheduledButton_Click);
            // 
            // WeekTaskButton
            // 
            this.WeekTaskButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WeekTaskButton.Location = new System.Drawing.Point(3, 122);
            this.WeekTaskButton.Name = "WeekTaskButton";
            this.WeekTaskButton.Size = new System.Drawing.Size(163, 34);
            this.WeekTaskButton.TabIndex = 3;
            this.WeekTaskButton.Text = "一周计划";
            this.WeekTaskButton.UseVisualStyleBackColor = true;
            this.WeekTaskButton.Click += new System.EventHandler(this.WeekTaskButton_Click);
            // 
            // SettingButton
            // 
            this.SettingButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SettingButton.Location = new System.Drawing.Point(3, 405);
            this.SettingButton.Name = "SettingButton";
            this.SettingButton.Size = new System.Drawing.Size(163, 36);
            this.SettingButton.TabIndex = 1;
            this.SettingButton.Text = "清除已完成任务";
            this.SettingButton.UseVisualStyleBackColor = true;
            this.SettingButton.Click += new System.EventHandler(this.SettingButton_Click);
            // 
            // TodayTaskButton
            // 
            this.TodayTaskButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TodayTaskButton.Location = new System.Drawing.Point(3, 82);
            this.TodayTaskButton.Name = "TodayTaskButton";
            this.TodayTaskButton.Size = new System.Drawing.Size(163, 34);
            this.TodayTaskButton.TabIndex = 0;
            this.TodayTaskButton.Text = "今日任务";
            this.TodayTaskButton.UseVisualStyleBackColor = true;
            this.TodayTaskButton.Click += new System.EventHandler(this.TodayTaskButton_Click);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "搜索:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 450);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.TaskPanel.ResumeLayout(false);
            this.TaskPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ListViewPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TaskDataGridView)).EndInit();
            this.ListPanel.ResumeLayout(false);
            this.ListPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel ListPanel;
        private System.Windows.Forms.Panel TaskPanel;
        private System.Windows.Forms.Button TodayTaskButton;
        private System.Windows.Forms.Button ScheduledButton;
        private System.Windows.Forms.Button WeekTaskButton;
        private System.Windows.Forms.TextBox Search;
        private System.Windows.Forms.Panel ListViewPanel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button AddTaskButton;
        private System.Windows.Forms.DataGridView TaskDataGridView;
        private System.Windows.Forms.Button deleteTaskBtn;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button SettingButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckedListBox chooseByTaskStatuscheckedListBox;
        private System.Windows.Forms.CheckedListBox chooseByTaskTypescheckedListBox;
        private System.Windows.Forms.ComboBox SortcomboBox;
        private System.Windows.Forms.Label sortlabel;
        private System.Windows.Forms.Label showlabel;
        private System.Windows.Forms.Label label1;
    }
}

