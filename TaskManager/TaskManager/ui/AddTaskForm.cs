using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskManager.dao.impl;
using TaskManager.model;
using TaskManager.service;
using TaskManager.utils;

namespace TaskManager.ui
{

    public partial class AddTaskForm : Form
    {
        private TaskModel task;
        private TaskService taskService;
        public AddTaskForm(TaskService taskService)
        {
            this.taskService = taskService;
            InitializeComponent();
        }

        private void AddTaskForm_Load(object sender, EventArgs e)
        {
            TaskClassComboBox.SelectedIndex = 0;
        }

        private void AddTaskButton_Click(object sender, EventArgs e)
        {
            DateTime start = new DateTime();
            DateTime end = new DateTime();
            DateTime remind = new DateTime();


            DateTime temp = TaskStartDateTimePicker.Value;
            start = new DateTime(temp.Year, temp.Month, temp.Day);
            //start = TaskStartDateTimePicker.Value;
            double hour;
            double.TryParse(TaskStartHourTextBox.Text, out hour);
            double min;
            double.TryParse(TaskStartMinTextBox.Text, out min);
            start = start.AddHours(hour - start.Hour);
            start = start.AddMinutes(min - start.Minute);

            if (ReminderTime10MinEarliercheckBox.Checked) 
            {
                remind = start;
                remind.AddMinutes(-10);
            }
            if (ReminderTime20MinEarliercheckbox.Checked) 
            {
                remind = start;
                remind.AddMinutes(-20);
            }
            if (ReminderTimeByYourselfcheckbox.Checked) 
            {
                DateTime tempForReminderTime = TaskRemindDateTimePicker.Value;
                remind = new DateTime(tempForReminderTime.Year,tempForReminderTime.Month,tempForReminderTime.Day);
                double hourForReminderTime;
                double.TryParse(TaskRemindHourTextBox.Text, out hourForReminderTime);
                double minForReminderTime;
                double.TryParse(TaskRemindMinTextBox.Text, out minForReminderTime);
                remind = remind.AddHours(hourForReminderTime-remind.Hour);
                remind = remind.AddMinutes(minForReminderTime-remind.Minute);
            }

            if (EndTimeOneDayLatercheckBox.Checked) 
            {
                end = start;
                end.AddDays(1);
            }
            if (EndTimeOneWeekLatercheckBox.Checked) 
            {
                end = start;
                end.AddDays(7);
            }
            if (EndTimeByYourselfcheckBox.Checked)
            {
                DateTime tempForEndTime = TaskRemindDateTimePicker.Value;
                end = new DateTime(tempForEndTime.Year, tempForEndTime.Month, tempForEndTime.Day);
                //end = TaskEndDateTimePicker.Value;
                double hourForEndTime;
                double.TryParse(TaskEndHourTextBox.Text, out hourForEndTime);
                double minForEndTime;
                double.TryParse(TaskEndMinTextBox.Text, out minForEndTime);
                end = end.AddHours(hourForEndTime-end.Hour);
                end = end.AddMinutes(minForEndTime-end.Minute);
            }
            if (this.EverydaycheckBox.Checked)
            {
                task = new EnglishLearningModel(TaskNameTextBox.Text, start, end, remind, 1, TheTaskStatus.未完成, (TaskType)Enum.Parse(typeof(TaskType), TaskClassComboBox.SelectedItem.ToString()));
            }
            else 
            {
            task = new TaskModel(TaskNameTextBox.Text, start, end, remind, 1, TheTaskStatus.未完成, (TaskType)Enum.Parse(typeof(TaskType), TaskClassComboBox.SelectedItem.ToString()));
            //taskService.createTask(null,task.Name, task.StartTime, task.Deadline, task.ReminderTime, task.RepetitionRate, task.TaskType, task.TaskStatus);
            }
            if (this.isImportant_checkBox.Checked) 
            {
                task.TaskStatus = TheTaskStatus.紧急;
            }
            taskService.createTask(task);
            MainForm newMainForm = new MainForm();
            this.Hide();
            newMainForm.ShowDialog();
            Application.ExitThread();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {

            MainForm newMainForm = new MainForm();
            this.Hide();
            newMainForm.ShowDialog();
            Application.ExitThread();
        }

        private void ReminderTime10MinEarliercheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ReminderTime10MinEarliercheckBox.Checked) 
            {
                ReminderTime20MinEarliercheckbox.CheckState = CheckState.Unchecked;
                ReminderTimeByYourselfcheckbox.CheckState = CheckState.Unchecked;
            }
        }

        private void ReminderTime20MinEarliercheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (ReminderTime20MinEarliercheckbox.Checked)
            {
                ReminderTime10MinEarliercheckBox.CheckState = CheckState.Unchecked;
                ReminderTimeByYourselfcheckbox.CheckState = CheckState.Unchecked;
            }
        }

        private void ReminderTimeByYourselfcheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (ReminderTimeByYourselfcheckbox.Checked)
            {
                ReminderTime10MinEarliercheckBox.CheckState = CheckState.Unchecked;
                ReminderTime20MinEarliercheckbox.CheckState = CheckState.Unchecked;
            }
        }

        private void EndTimeOneDayLatercheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (EndTimeOneDayLatercheckBox.Checked)
            {
                EndTimeOneWeekLatercheckBox.CheckState = CheckState.Unchecked;
                EndTimeByYourselfcheckBox.CheckState = CheckState.Unchecked;
            }
        }

        private void EndTimeOneWeekLatercheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (EndTimeOneWeekLatercheckBox.Checked)
            {
                EndTimeOneDayLatercheckBox.CheckState = CheckState.Unchecked;
                EndTimeByYourselfcheckBox.CheckState = CheckState.Unchecked;
            }
        }

        private void EndTimeByYourselfcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (EndTimeByYourselfcheckBox.Checked)
            {
                EndTimeOneDayLatercheckBox.CheckState = CheckState.Unchecked;
                EndTimeOneWeekLatercheckBox.CheckState = CheckState.Unchecked;
            }
        }
    }
}
