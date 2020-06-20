using Org.BouncyCastle.Crypto.Tls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskManager.model;
using TaskManager.service;
using TaskManager.utils;


//此类为双击Task后，跳转的查看task信息页面

namespace TaskManager.ui
{
    public partial class ViewTaskForm : Form
    {

        private TaskModel task;
        private TaskService taskService;

        public ViewTaskForm(TaskModel newTask, TaskService newTaskService)
        {
            this.task = newTask;
            this.taskService = newTaskService;

            InitializeComponent();
        }

        private void TaskModifyButton_Click(object sender, EventArgs e)
        {
            bool isChange = false;
            if(TaskNameTextBox.Text != task.Name)
            {
                isChange = true;
                task.Name = TaskNameTextBox.Text;
            }
          
            if(TaskClassComboBox.SelectedItem.ToString() != task.TaskType.ToString())
            {
                isChange = true;
                task.TaskType = (TaskType)Enum.Parse(typeof(TaskType), TaskClassComboBox.SelectedItem.ToString());
            }
            
            if(TaskStatusComboBox.SelectedItem.ToString() != task.TaskStatus.ToString())
            {
                isChange = true;
                task.TaskStatus = (TheTaskStatus)Enum.Parse(typeof(TheTaskStatus), TaskStatusComboBox.SelectedItem.ToString());
            }

            if (TaskRemindTimeCheckBox.Checked)
            {
                DateTime temp = TaskRemindDateTimePicker.Value;
                double hour;
                double.TryParse(TaskRemindHourTextBox.Text, out hour);
                double min;
                double.TryParse(TaskRemindMinTextBox.Text, out min);
                temp = temp.AddHours(hour-temp.Hour);
                temp = temp.AddMinutes(min-temp.Minute);
                
                if(temp != task.ReminderTime)
                {
                    isChange = true;
                    task.ReminderTime = temp;
                }

            }
            if (TaskStartTimeCheckBox.Checked)
            {
                DateTime temp = TaskStartDateTimePicker.Value;
                double hour;
                double.TryParse(TaskStartHourTextBox.Text, out hour);
                double min;
                double.TryParse(TaskStartMinTextBox.Text, out min);
                temp = temp.AddHours(hour - temp.Hour);
                temp = temp.AddMinutes(min - temp.Minute);

                if (temp != task.StartTime)
                {
                    isChange = true;
                    task.StartTime = temp;
                }
            }
            if (TaskEndTimeCheckBox.Checked)
            {
                DateTime temp = TaskEndDateTimePicker.Value;
                double hour;
                double.TryParse(TaskEndHourTextBox.Text, out hour);
                double min;
                double.TryParse(TaskEndMinTextBox.Text, out min);
                temp = temp.AddHours(hour - temp.Hour);
                temp = temp.AddMinutes(min - temp.Minute);

                if (temp != task.Deadline)
                {
                    isChange = true;
                    task.Deadline = temp;
                }
            }

            if (isChange)
            {
                taskService.updateTask(task);
            }
            MainForm newMainForm = new MainForm();
            this.Hide();
            newMainForm.ShowDialog();
            Application.ExitThread();
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            MainForm newMainForm = new MainForm();
            this.Hide();
            newMainForm.ShowDialog();
            Application.ExitThread();
        }

        private void ViewTaskForm_Load(object sender, EventArgs e)
        {
            TaskNameTextBox.Text = task.Name;
            TaskClassComboBox.Text = task.TaskType.ToString();
            TaskStatusComboBox.SelectedItem = task.TaskStatus.ToString();

            if(task.ReminderTime.ToString() != "0001/1/1 0:00:00")
            {
                TaskRemindTimeCheckBox.Checked = true;
                TaskRemindDateTimePicker.Value = task.ReminderTime;
                TaskRemindHourTextBox.Text = task.ReminderTime.Hour.ToString();
                TaskRemindMinTextBox.Text = task.ReminderTime.Minute.ToString();
            }
            if(task.StartTime.ToString() != "0001/1/1 0:00:00")
            {
                TaskStartTimeCheckBox.Checked = true;
                TaskStartDateTimePicker.Value = task.StartTime;
                TaskStartHourTextBox.Text = task.StartTime.Hour.ToString();
                TaskStartMinTextBox.Text = task.StartTime.Minute.ToString();
            }
            if (task.Deadline.ToString() != "0001/1/1 0:00:00")
            {
                TaskEndTimeCheckBox.Checked = true;
                TaskEndDateTimePicker.Value = task.Deadline;
                TaskEndHourTextBox.Text = task.Deadline.Hour.ToString();
                TaskEndMinTextBox.Text = task.Deadline.Minute.ToString();
            }

        }
    }
}
