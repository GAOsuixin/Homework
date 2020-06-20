using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.dao;
using TaskManager.dao.impl;
using TaskManager.model;
using TaskManager.utils;


//Task服务层
namespace TaskManager.service
{
    public class TaskService
    {

        public ITaskDao taskDao { set; get; }

        public TaskService()
        {
            this.taskDao = new TaskDaoImpl();
        }

        //创建任务
        public void createTask(TaskModel task)
        {
            taskDao.createTask(task);
        }

        //根据ID删除任务
        public void deleteTaskById(int? id)
        {
            taskDao.deleteTaskById(id);
        }

        //根据任务状态删除任务
        public void deleteTasksByStatus(TheTaskStatus status)
        {
            taskDao.deleteTasksByStatus(status);
        }

        //更新任务
        public void updateTask(TaskModel task)
        {
            taskDao.updateTask(task);
        }

        //查询所有任务
        public List<TaskModel> searchAllTasks()
        {
            return taskDao.searchAllTasks();
        }

        //查询今日任务
        public List<TaskModel> searchTodayTasks()
        {
            return taskDao.searchTasksToday();
        }

        //查询一周计划
        public List<TaskModel> searchThisWeekTasks()
        {
            return taskDao.searchTasksInWeek();
        }

        //根据状态查询任务
        public List<TaskModel> searchTasksByStatus(TheTaskStatus theTaskStatus)
        {
            return taskDao.searchTaskByStatus(theTaskStatus);
        }

        //根据类型查询任务
        public List<TaskModel> searchTasksByType(TaskType taskType)
        {
            return taskDao.searchTaskByType(taskType);
        }
        public List<TaskModel> searchTaskByTypeAndStatus(TaskType taskType, TheTaskStatus taskStatus) 
        {
            return taskDao.searchTaskByTypeAndStatus(taskType, taskStatus);
        }
        public TaskModel GetById(int id) 
        {
            return taskDao.GetById(id);
        }
        public List<TaskModel> GetTaskByName(string name) 
        {
            //return taskDao.GetTaskByName(name);
            return taskDao.GetTaskByNameLike(name);
        }
        public List<TaskModel> GetTaskByDDL() 
        {
            return taskDao.GetTaskByDDL();
        }
        public List<TaskModel> GetTaskByRemindTime() 
        {
            return taskDao.GetTaskByRemindTime();
        }
    }
}
