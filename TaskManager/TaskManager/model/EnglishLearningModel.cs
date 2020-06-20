using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.utils;

namespace TaskManager.model
{
    class EnglishLearningModel:TaskModel
    {
        public EnglishLearningModel(string name, DateTime startTime, DateTime deadline, DateTime reminderTime, int repetitionRate, TheTaskStatus taskStatus, TaskType taskType)
        {
            Name = name;
            StartTime = startTime;
            Deadline = deadline;
            ReminderTime = reminderTime;
            RepetitionRate = repetitionRate;
            TaskType = taskType;
            TaskStatus = taskStatus;
        }
    }
}
