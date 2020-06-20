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
    public partial class MainForm : Form
    {
        TaskService taskService = new TaskService();
        List<TaskModel> Tasks = new List<TaskModel>();
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.timer2.Interval = 1000;
            this.timer2.Enabled = true;
            //taskService.createTask(1, "任务一", DateTime.Now, DateTime.Now.AddDays(3), DateTime.Now.AddDays(2), 0, TaskType.学习任务, TheTaskStatus.未完成);
            //taskService.createTask(2, "任务二", DateTime.Now, DateTime.Now.AddDays(4), DateTime.Now.AddDays(3), 0, TaskType.学习任务, TheTaskStatus.未完成);
            //taskService.createTask(3, "任务三", DateTime.Now, DateTime.Now.AddDays(5), DateTime.Now.AddDays(4), 1, TaskType.工作任务, TheTaskStatus.已完成);
            //taskService.createTask(4, "任务四", DateTime.Now, DateTime.Now.AddDays(6), DateTime.Now.AddDays(5), 1, TaskType.工作任务, TheTaskStatus.已完成);
            //taskService.createTask(5, "任务五", DateTime.Now, DateTime.Now.AddDays(7), DateTime.Now.AddDays(6), 2, TaskType.生活任务, TheTaskStatus.紧急);
            //taskService.createTask(6, "任务六", DateTime.Now.AddDays(3), DateTime.Now.AddDays(8), DateTime.Now.AddDays(9), 0, TaskType.学习任务, TheTaskStatus.未完成);
            //taskService.createTask(7, "任务七", DateTime.Now.AddDays(4), DateTime.Now.AddDays(9), DateTime.Now.AddDays(10), 1, TaskType.工作任务, TheTaskStatus.已完成);
            //taskService.createTask(8, "任务八", DateTime.Now.AddDays(5), DateTime.Now.AddDays(10), DateTime.Now.AddDays(11), 0, TaskType.学习任务, TheTaskStatus.未完成);
            //taskService.createTask(9, "任务九", DateTime.Now.AddDays(6), DateTime.Now.AddDays(7), DateTime.Now.AddDays(7).AddHours(12), 2, TaskType.生活任务, TheTaskStatus.紧急);
            //taskService.createTask(10, "任务十", DateTime.Now.AddDays(8), DateTime.Now.AddDays(9), DateTime.Now.AddDays(10), 1, TaskType.工作任务, TheTaskStatus.已完成);
            //taskService.createTask(11, "任务11", DateTime.Now, DateTime.Now.AddHours(2), DateTime.Now.AddHours(1), 0, TaskType.学习任务, TheTaskStatus.未完成);
            //taskService.createTask(12, "任务12", DateTime.Now, DateTime.Now.AddHours(3), DateTime.Now.AddHours(2), 0, TaskType.学习任务, TheTaskStatus.未完成);
            Tasks = taskService.searchAllTasks();
            this.TaskDataGridView.DataSource = Tasks;
        }

        private void AddTaskButton_Click(object sender, EventArgs e)
        {
            AddTaskForm newAddTaskForm = new AddTaskForm(taskService);
            this.Hide();
            newAddTaskForm.ShowDialog();
            Application.ExitThread();
        }

        private void SettingButton_Click(object sender, EventArgs e)
        {
            taskService.deleteTasksByStatus(TheTaskStatus.已完成);
            Tasks = taskService.searchAllTasks();
            this.TaskDataGridView.DataSource = Tasks;
            this.TaskDataGridView.Refresh();
        }

        //今日任务
        private void TodayTaskButton_Click(object sender, EventArgs e)
        {
            Tasks = taskService.searchTodayTasks();
            this.TaskDataGridView.DataSource = Tasks;
        }

        //紧急任务
        private void ImportantTaskButton_Click(object sender, EventArgs e)
        {
            Tasks = taskService.searchTasksByStatus(TheTaskStatus.紧急);
            this.TaskDataGridView.DataSource = Tasks;
        }

        //一周计划
        private void WeekTaskButton_Click(object sender, EventArgs e)
        {
            Tasks = taskService.searchThisWeekTasks();
            this.TaskDataGridView.DataSource = Tasks;
        }

        //全部任务
        private void ScheduledButton_Click(object sender, EventArgs e)
        {
            Tasks = taskService.searchAllTasks();
            this.TaskDataGridView.DataSource = Tasks;
        }


        
        

        private void deleteTaskBtn_Click(object sender, EventArgs e)
        {
            int id;
            int index = TaskDataGridView.CurrentRow.Index;
            int.TryParse(TaskDataGridView.Rows[index].Cells["Id"].Value.ToString(), out id);
            TaskModel task = taskService.GetById(id);
            if (task.GetType() == typeof(EnglishLearningModel))
            {
                task.Deadline.AddDays(1);
                task.ReminderTime.AddDays(1);
                task.StartTime.AddDays(1);
                taskService.updateTask(task);
            }
            else
            {
                taskService.deleteTaskById(id);
                Tasks = this.taskService.searchAllTasks();
                this.TaskDataGridView.DataSource = Tasks;
                this.TaskDataGridView.Refresh();
            }
        }

        private void Search_TextChanged(object sender, EventArgs e)
        {
            Tasks = taskService.GetTaskByName(Search.Text);
            this.TaskDataGridView.DataSource = Tasks;
            this.TaskDataGridView.Refresh();

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            DateTime nt = DateTime.Now;
            List<TaskModel> Tasks = new List<TaskModel>();
            Tasks = taskService.GetTaskByRemindTime();
            if (Tasks.Count != 0)
            {
                if (DateTime.Equals(nt, Tasks[0].ReminderTime))
                {
                    Tasks[0].TaskStatus = TheTaskStatus.已完成;
                    this.taskService.updateTask(Tasks[0]);
                    Reminder r = new Reminder();
                    this.Hide();
                    r.ShowDialog();
                    Application.ExitThread();
                    this.taskService.updateTask(Tasks[0]);
                }
            }

        }

        private void TaskDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show("选中行" + (e.RowIndex + 1));
            //MessageBox.Show(TaskDataGridView.Rows[e.RowIndex].Cells["startTime"].Value.ToString());//获取选中行指定列的值

            int id = Convert.ToInt32(TaskDataGridView.Rows[e.RowIndex].Cells["Id"].Value.ToString());
            String name = TaskDataGridView.Rows[e.RowIndex].Cells["name"].Value.ToString();
            DateTime startTime = Convert.ToDateTime(TaskDataGridView.Rows[e.RowIndex].Cells["startTime"].Value.ToString());
            DateTime endTime = Convert.ToDateTime(TaskDataGridView.Rows[e.RowIndex].Cells["Deadline"].Value.ToString());
            DateTime remindTime = Convert.ToDateTime(TaskDataGridView.Rows[e.RowIndex].Cells["ReminderTime"].Value.ToString());
            int reptitionRate = Convert.ToInt32(TaskDataGridView.Rows[e.RowIndex].Cells["RepetitionRate"].Value.ToString());
            TaskType taskType = (TaskType)System.Enum.Parse(typeof(TaskType), TaskDataGridView.Rows[e.RowIndex].Cells["TaskType"].Value.ToString());
            TheTaskStatus taskStatus = (TheTaskStatus)System.Enum.Parse(typeof(TheTaskStatus), TaskDataGridView.Rows[e.RowIndex].Cells["TaskStatus"].Value.ToString());

            TaskModel selectTask = new TaskModel(id, name, startTime, endTime, remindTime, reptitionRate, taskType, taskStatus);

            //MessageBox.Show(selectTask.ToString());

            ViewTaskForm newViewTaskForm = new ViewTaskForm(selectTask, taskService);
            this.Hide();
            newViewTaskForm.ShowDialog();
            Application.ExitThread();

        }

        private void chooseByTaskTypescheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Tasks = new List<TaskModel>();
            if (this.chooseByTaskTypescheckedListBox.GetItemChecked(0))
            {
                if (this.chooseByTaskStatuscheckedListBox.GetItemChecked(0))
                {
                    Tasks.AddRange(taskService.searchTaskByTypeAndStatus(TaskType.学习任务, TheTaskStatus.已完成));
                }
                if (this.chooseByTaskStatuscheckedListBox.GetItemChecked(1))
                {
                    Tasks.AddRange(taskService.searchTaskByTypeAndStatus(TaskType.学习任务, TheTaskStatus.未完成));
                }
                if (this.chooseByTaskStatuscheckedListBox.GetItemChecked(2))
                {
                    Tasks.AddRange(taskService.searchTaskByTypeAndStatus(TaskType.学习任务, TheTaskStatus.紧急));
                }
            }
            if (this.chooseByTaskTypescheckedListBox.GetItemChecked(1))
            {
                if (this.chooseByTaskStatuscheckedListBox.GetItemChecked(0))
                {
                    Tasks.AddRange(taskService.searchTaskByTypeAndStatus(TaskType.工作任务, TheTaskStatus.已完成));
                }
                if (this.chooseByTaskStatuscheckedListBox.GetItemChecked(1))
                {
                    Tasks.AddRange(taskService.searchTaskByTypeAndStatus(TaskType.工作任务, TheTaskStatus.未完成));
                }
                if (this.chooseByTaskStatuscheckedListBox.GetItemChecked(2))
                {
                    Tasks.AddRange(taskService.searchTaskByTypeAndStatus(TaskType.工作任务, TheTaskStatus.紧急));
                }
            }
            if (this.chooseByTaskTypescheckedListBox.GetItemChecked(2))
            {
                if (this.chooseByTaskStatuscheckedListBox.GetItemChecked(0))
                {
                    Tasks.AddRange(taskService.searchTaskByTypeAndStatus(TaskType.生活任务, TheTaskStatus.已完成));
                }
                if (this.chooseByTaskStatuscheckedListBox.GetItemChecked(1))
                {
                    Tasks.AddRange(taskService.searchTaskByTypeAndStatus(TaskType.生活任务, TheTaskStatus.未完成));
                }
                if (this.chooseByTaskStatuscheckedListBox.GetItemChecked(2))
                {
                    Tasks.AddRange(taskService.searchTaskByTypeAndStatus(TaskType.生活任务, TheTaskStatus.紧急));
                }
            }
            this.TaskDataGridView.DataSource = Tasks;
            this.TaskDataGridView.Refresh();
        }

        private void chooseByTaskStatuscheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Tasks = new List<TaskModel>();
            if (this.chooseByTaskTypescheckedListBox.GetItemChecked(0))
            {
                if (this.chooseByTaskStatuscheckedListBox.GetItemChecked(0))
                {
                    Tasks.AddRange(taskService.searchTaskByTypeAndStatus(TaskType.学习任务, TheTaskStatus.已完成));
                }
                if (this.chooseByTaskStatuscheckedListBox.GetItemChecked(1))
                {
                    Tasks.AddRange(taskService.searchTaskByTypeAndStatus(TaskType.学习任务, TheTaskStatus.未完成));
                }
                if (this.chooseByTaskStatuscheckedListBox.GetItemChecked(2))
                {
                    Tasks.AddRange(taskService.searchTaskByTypeAndStatus(TaskType.学习任务, TheTaskStatus.紧急));
                }
            }
            if (this.chooseByTaskTypescheckedListBox.GetItemChecked(1))
            {
                if (this.chooseByTaskStatuscheckedListBox.GetItemChecked(0))
                {
                    Tasks.AddRange(taskService.searchTaskByTypeAndStatus(TaskType.工作任务, TheTaskStatus.已完成));
                }
                if (this.chooseByTaskStatuscheckedListBox.GetItemChecked(1))
                {
                    Tasks.AddRange(taskService.searchTaskByTypeAndStatus(TaskType.工作任务, TheTaskStatus.未完成));
                }
                if (this.chooseByTaskStatuscheckedListBox.GetItemChecked(2))
                {
                    Tasks.AddRange(taskService.searchTaskByTypeAndStatus(TaskType.工作任务, TheTaskStatus.紧急));
                }
            }
            if (this.chooseByTaskTypescheckedListBox.GetItemChecked(2))
            {
                if (this.chooseByTaskStatuscheckedListBox.GetItemChecked(0))
                {
                    Tasks.AddRange(taskService.searchTaskByTypeAndStatus(TaskType.生活任务, TheTaskStatus.已完成));
                }
                if (this.chooseByTaskStatuscheckedListBox.GetItemChecked(1))
                {
                    Tasks.AddRange(taskService.searchTaskByTypeAndStatus(TaskType.生活任务, TheTaskStatus.未完成));
                }
                if (this.chooseByTaskStatuscheckedListBox.GetItemChecked(2))
                {
                    Tasks.AddRange(taskService.searchTaskByTypeAndStatus(TaskType.生活任务, TheTaskStatus.紧急));
                }
            }
            this.TaskDataGridView.DataSource = Tasks;
            this.TaskDataGridView.Refresh();
        }

        private void SortcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.SortcomboBox.SelectedIndex == 0) //根据开始时间
            {
                Tasks = Tasks.OrderBy(o => o.StartTime).ToList();
            }
            if(this.SortcomboBox.SelectedIndex == 1) //根据截止时间
            {
                Tasks = Tasks.OrderBy(o => o.Deadline).ToList();
            }
            if (this.SortcomboBox.SelectedIndex == 2) //根据提醒时间
            {
                Tasks = Tasks.OrderBy(o => o.ReminderTime).ToList();
            }
            this.TaskDataGridView.DataSource = Tasks;
        }
    }
}
