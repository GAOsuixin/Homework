using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.utils;

namespace TaskManager.model
{
    //Task 实体类
    public class TaskModel : IEquatable<TaskModel>
    {
        public int? Id { set; get; }                 //任务ID

        public string Name { set; get; }            //任务名

        public DateTime StartTime { set; get; }     //开始时间

        public DateTime Deadline { set; get; }      //截止时间

        public DateTime ReminderTime { set; get; }  //任务提醒时间
        
        public int RepetitionRate { set; get; }   //每周重复多少次

        public TaskType TaskType { set; get; }  //任务类型

        public TheTaskStatus TaskStatus { set; get; }  //任务状态

        //无参构造器
        public TaskModel()
        {

        }

        public TaskModel(int? id, string name, DateTime startTime, DateTime deadline, DateTime reminderTime)
        {
            Id = id;
            Name = name;
            StartTime = startTime;
            Deadline = deadline;
            ReminderTime = reminderTime;
        }

        public TaskModel(string name,DateTime startTime,DateTime deadline,DateTime reminderTime)
        {
            Name = name;
            StartTime = startTime;
            Deadline = deadline;
            ReminderTime = reminderTime;
            RepetitionRate = 0;
            TaskType = TaskType.未归类;
            TaskStatus = TheTaskStatus.未完成;
        }


        public TaskModel(string name, DateTime startTime, DateTime deadline, DateTime reminderTime,int repetitionRate,TheTaskStatus taskStatus,TaskType  taskType)
        {
            Name = name;
            StartTime = startTime;
            Deadline = deadline;
            ReminderTime = reminderTime;
            RepetitionRate = repetitionRate;
            TaskType = taskType;
            TaskStatus = taskStatus;
        }

        public TaskModel(int? id, string name, DateTime startTime, DateTime deadline, DateTime reminderTime, int repetitionRate, TaskType taskType, TheTaskStatus taskStatus)
        {
            Id = id;
            Name = name ?? throw new ArgumentNullException(nameof(name));
            StartTime = startTime;
            Deadline = deadline;
            ReminderTime = reminderTime;
            RepetitionRate = repetitionRate;
            TaskType = taskType;
            TaskStatus = taskStatus;
        }

        public override string ToString()
        {
            return "任务[ id=" + Id + "\n" +
                " name=" + Name + "\n" +
                "startTime=" + StartTime + "\n" +
                "deadline=" + Deadline + "\n" +
                "reminderTime=" + ReminderTime + "\n" +
                "repetitonRate=" + RepetitionRate + "\n" +
                "taskType=" + TaskType + "\n" +
                "taskStatus=" + TaskStatus +" ]" ;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as TaskModel);
        }

        public bool Equals(TaskModel other)
        {
            return other != null &&
                   Id == other.Id &&
                   Name == other.Name &&
                   StartTime == other.StartTime &&
                   Deadline == other.Deadline &&
                   ReminderTime == other.ReminderTime &&
                   RepetitionRate == other.RepetitionRate &&
                   TaskType == other.TaskType &&
                   TaskStatus == other.TaskStatus;
        }

        public override int GetHashCode()
        {
            int hashCode = 1281583153;
            hashCode = hashCode * -1521134295 + Id.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + StartTime.GetHashCode();
            hashCode = hashCode * -1521134295 + Deadline.GetHashCode();
            hashCode = hashCode * -1521134295 + ReminderTime.GetHashCode();
            hashCode = hashCode * -1521134295 + RepetitionRate.GetHashCode();
            hashCode = hashCode * -1521134295 + TaskType.GetHashCode();
            hashCode = hashCode * -1521134295 + TaskStatus.GetHashCode();
            return hashCode;
        }

        public static bool operator ==(TaskModel left, TaskModel right)
        {
            return EqualityComparer<TaskModel>.Default.Equals(left, right);
        }

        public static bool operator !=(TaskModel left, TaskModel right)
        {
            return !(left == right);
        }
    }
}
