using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using TaskManager.model;
using TaskManager.utils;

namespace TaskManager.dao
{
    public interface ITaskDao
    {

        //增
        void createTask(TaskModel task);

        void createTask(int? id, string name, DateTime startTime, DateTime deadline, DateTime reminderTime, int repetitionRate, TaskType taskType, TheTaskStatus taskStatus);
        

        //删
        void deleteTaskById(int? id);  //根据任务 ID 删除 task

        void deleteTasksByStatus(TheTaskStatus status);     //根据任务状态删除 tasks


        //改
        void updateTask(TaskModel task);  //根据id查找task然后修改task


        //查
        List<TaskModel> searchAllTasks();  //查询所有任务

        List<TaskModel> searchTasksInWeek();  //查询一周内的任务

        List<TaskModel> searchTasksToday();  //查询一天内的任务

        List<TaskModel> searchTaskByStatus(TheTaskStatus taskStatus);  //根据任务状态查询任务

        List<TaskModel> searchTaskByType(TaskType taskType);   //根据任务类型查询任务

        List<TaskModel> searchTaskByTypeAndStatus(TaskType taskType, TheTaskStatus taskStatus); //根据任务类型和任务状态查任务

        List<TaskModel> GetTaskByDDL(); //根据创建时间来排序
        List<TaskModel> GetTaskByRemindTime();

        List<TaskModel> GetTaskByName(string name); //根据名称来选取

        List<TaskModel> GetTaskByNameLike(string name);//模糊查询

        TaskModel GetById(int id);


    }
}
