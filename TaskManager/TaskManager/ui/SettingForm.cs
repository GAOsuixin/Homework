using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskManager.service;

namespace TaskManager.ui
{
    public partial class SettingForm : Form
    {
        TaskService taskService;
        public SettingForm(TaskService taskService)
        {
            this.taskService = taskService;
            InitializeComponent();
        }

        private void SettingModifyButton_Click(object sender, EventArgs e)
        {
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
    }
}
