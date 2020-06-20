using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.model;
using TaskManager.utils;
using System.Data.SQLite;
using System.Data.SqlClient;


//TaskDao层实现类
namespace TaskManager.dao.impl
{
    class TaskDaoImpl : ITaskDao
    {

       public List<TaskModel> Tasks { set; get; }

        public TaskDaoImpl()
        {
            Tasks = new List<TaskModel>();
        }

        //保留
        //public void createTask()
        //{
        //    throw new NotImplementedException();
        //}


        ////数据库用
        public void createTask(TaskModel task)
        {
            try
            {
                using (SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=Task.sqlite;Version=3;"))
                {
                    m_dbConnection.Open();
                    string sql = "insert into task(Id, Name, StartTime, DeadLine, ReminderTime, RepetitionRate, TaskType, TaskStatus)" +
                        "values (@Id, @Name, @StartTime, @DeadLine, @ReminderTime, @RepetitionRate, @TaskType, @TaskStatus)";
                    using (SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection))
                    {
                        command.Prepare();
                        command.Parameters.AddWithValue("@Id", task.Id);
                        command.Parameters.AddWithValue("@Name", task.Name);
                        command.Parameters.AddWithValue("@StartTime", task.StartTime);
                        command.Parameters.AddWithValue("@DeadLine", task.Deadline);
                        command.Parameters.AddWithValue("@ReminderTime", task.ReminderTime);
                        command.Parameters.AddWithValue("@RepetitionRate", task.RepetitionRate);
                        command.Parameters.AddWithValue("@TaskType", task.TaskType.ToString());
                        command.Parameters.AddWithValue("@TaskStatus", task.TaskStatus.ToString());
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException)
            {
                throw;
            }
            searchAllTasks();
        }
        //public void createTask(string name, DateTime startTime, DateTime deadline, DateTime reminderTime)
        //{
        //    using (SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=Task.sqlite;Version=3;"))
        //    {
        //        m_dbConnection.Open();
        //        string sql = "insert into task(Id, Name, StartTime, DeadLine, ReminderTime, RepetitionRate, TaskType, TaskStatus)" +
        //            "values (@Id, @Name, @StartTime, @DeadLine, @ReminderTime, @RepetitionRate, @TaskType, @TaskStatus)";
        //        using (SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection))
        //        {
        //            command.Prepare();
        //            command.Parameters.AddWithValue("@Name", name);
        //            command.Parameters.AddWithValue("@StartTime", startTime);
        //            command.Parameters.AddWithValue("@DeadLine", deadline);
        //            command.Parameters.AddWithValue("@ReminderTime", reminderTime);
        //            command.ExecuteNonQuery();
        //        }
        //    }
        //    //刷新Tasks
        //    searchAllTasks();
        //}

        ////测试用
        //public void createTask(int? id,string name, DateTime startTime, DateTime deadline, DateTime reminderTime)
        //{
        //    using (SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=Task.sqlite;Version=3;"))
        //    {
        //        m_dbConnection.Open();
        //        string sql = "insert into task(Id, Name, StartTime, DeadLine, ReminderTime, RepetitionRate, TaskType, TaskStatus)" +
        //            "values (@Id, @Name, @StartTime, @DeadLine, @ReminderTime, @RepetitionRate, @TaskType, @TaskStatus)";
        //        using (SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection))
        //        {
        //            command.Prepare();
        //            command.Parameters.AddWithValue("@Id", id);
        //            command.Parameters.AddWithValue("@Name", name);
        //            command.Parameters.AddWithValue("@StartTime", startTime);
        //            command.Parameters.AddWithValue("@DeadLine", deadline);
        //            command.Parameters.AddWithValue("@ReminderTime", reminderTime);
        //            command.ExecuteNonQuery();
        //        }
        //    }
        //    //刷新Tasks
        //    searchAllTasks();
        //}

        ////数据库用
        //public void createTask(string name, DateTime startTime, DateTime deadline, DateTime reminderTime, int repetitionRate,  TaskType taskType, TheTaskStatus taskStatus)
        //{
        //    using (SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=Task.sqlite;Version=3;"))
        //    {
        //        m_dbConnection.Open();
        //        string sql = "insert into task(Id, Name, StartTime, DeadLine, ReminderTime, RepetitionRate, TaskType, TaskStatus)" +
        //            "values (@Id, @Name, @StartTime, @DeadLine, @ReminderTime, @RepetitionRate, @TaskType, @TaskStatus)";
        //        using (SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection))
        //        {
        //            command.Prepare();
        //            command.Parameters.AddWithValue("@Name", name);
        //            command.Parameters.AddWithValue("@StartTime", startTime);
        //            command.Parameters.AddWithValue("@DeadLine", deadline);
        //            command.Parameters.AddWithValue("@ReminderTime", reminderTime);
        //            command.Parameters.AddWithValue("@RepetitionRate", repetitionRate);
        //            command.Parameters.AddWithValue("@TaskType", taskType.ToString());
        //            command.Parameters.AddWithValue("@TaskStatus", taskStatus.ToString());
        //            command.ExecuteNonQuery();
        //        }
        //    }
        //    //刷新Tasks
        //    searchAllTasks();
        //}

        //测试用
        public void createTask(int? id, string name, DateTime startTime, DateTime deadline, DateTime reminderTime, int repetitionRate, TaskType taskType, TheTaskStatus taskStatus)
        {
            try
            {
                using (SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=Task.sqlite;Version=3;"))
                {
                    m_dbConnection.Open();
                    string sql = "insert into task(Id, Name, StartTime, DeadLine, ReminderTime, RepetitionRate, TaskType, TaskStatus)" +
                        "values (@Id, @Name, @StartTime, @DeadLine, @ReminderTime, @RepetitionRate, @TaskType, @TaskStatus)";
                    using (SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection))
                    {
                        command.Prepare();
                        command.Parameters.AddWithValue("@Id", id);
                        command.Parameters.AddWithValue("@Name", name);
                        command.Parameters.AddWithValue("@StartTime", startTime);
                        command.Parameters.AddWithValue("@DeadLine", deadline);
                        command.Parameters.AddWithValue("@ReminderTime", reminderTime);
                        command.Parameters.AddWithValue("@RepetitionRate", repetitionRate);
                        command.Parameters.AddWithValue("@TaskType", taskType.ToString());
                        command.Parameters.AddWithValue("@TaskStatus", taskStatus.ToString());
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException)
            {
                throw;
            }
                
            //刷新Tasks
            searchAllTasks();
        }

        //根据ID删除任务
        public void deleteTaskById(int? id)
        {
            using (SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=Task.sqlite;Version=3;"))
            {
                m_dbConnection.Open();
                string sql = "delete from task where Id=@Id";
                using (SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection))
                {
                    command.Prepare();
                    command.Parameters.AddWithValue("@Id", id);
                    command.ExecuteNonQuery();
                }
            }

            //刷新Tasks
            searchAllTasks();
        }

        //根据任务状态删除任务
        public void deleteTasksByStatus(TheTaskStatus status)
        {
            using (SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=Task.sqlite;Version=3;"))
            {
                m_dbConnection.Open();
                string sql = "delete from task where TaskStatus=@Status";
                using (SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection))
                {
                    command.Prepare();
                    command.Parameters.AddWithValue("@Status", status.ToString());
                    command.ExecuteNonQuery();
                }
            }

            //刷新Tasks
            searchAllTasks();
        }

        //更新任务
        public void updateTask(TaskModel task)
        {
            using (SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=Task.sqlite;Version=3;"))
            {
                m_dbConnection.Open();
                string sql = "update task set Name=@Name, StartTime=@StartTime, DeadLine=@DeadLine, ReminderTime=@ReminderTime, RepetitionRate=@RepetitionRate, TaskType=@TaskType, TaskStatus=@TaskStatus where Id=@Id";
                using (SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection))
                {
                    command.Prepare();
                    command.Parameters.AddWithValue("@Name", task.Name);
                    command.Parameters.AddWithValue("@StartTime", task.StartTime);
                    command.Parameters.AddWithValue("@DeadLine", task.Deadline);
                    command.Parameters.AddWithValue("@ReminderTime", task.ReminderTime);
                    command.Parameters.AddWithValue("@RepetitionRate", task.RepetitionRate);
                    command.Parameters.AddWithValue("@TaskType", task.TaskType.ToString());
                    command.Parameters.AddWithValue("@TaskStatus", task.TaskStatus.ToString());
                    command.Parameters.AddWithValue("@id", task.Id);  //之前漏了id，补上
                    command.ExecuteNonQuery();
                }
            }

            //刷新Tasks
            searchAllTasks();
        }

        //查询所有的任务
        public List<TaskModel> searchAllTasks()
        {
            using (SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=Task.sqlite;Version=3;"))
            {
                m_dbConnection.Open();
                string sql = "select * from task";
                using (SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection))
                {
                    command.Prepare();
                    using (SQLiteDataReader reader = command.ExecuteReader()) 
                    {
                        List<TaskModel> taskModels = GetTaskModelListByReader(reader);
                        Tasks = taskModels;
                        return taskModels;
                    }
                }
            }
        }


        /*
         * 查询的话只需要在“查询全部”的时候从数据库读取
         * 然后将数据存入 Tasks 里面
         * 其他的条件查询直接从 Tasks 里面读取就可以
         * 
         * 如果发生了增删改：那就重新查询全部，更新 Tasks 值
         * 
         */

        //查询所有指定状态的任务
        public List<TaskModel> searchTaskByStatus(TheTaskStatus taskStatus)
        {
            //1. 建立新的列表
            List<TaskModel> tasks = new List<TaskModel>();
            //2. 遍历所有任务
            foreach (TaskModel task in Tasks)
            {
                //3. 存储符合条件的任务
                if (task.TaskStatus.Equals(taskStatus))
                {
                    tasks.Add(task);
                }
            }
            //4. 返回查询到的符合条件的任务列表
            return tasks;
     
        }

        //根据任务类型查询任务
        public List<TaskModel> searchTaskByType(TaskType taskType)
        {
            //1. 建立新的列表
            List<TaskModel> tasks = new List<TaskModel>();
            //2. 遍历所有任务
            foreach (TaskModel task in Tasks)
            {
                //3. 存储符合条件的任务
                if (task.TaskType.Equals(taskType))
                {
                    tasks.Add(task);
                }
            }
            //4. 返回查询到的符合条件的任务列表
            return tasks;
        }

        //根据任务类型和任务状态查任务
        public List<TaskModel> searchTaskByTypeAndStatus(TaskType taskType, TheTaskStatus taskStatus) 
        {
            using (SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=Task.sqlite;Version=3;"))
            {
                m_dbConnection.Open();
                string sql = "select * from task where TaskType = @TaskType intersect select * from task where TaskStatus = @TaskStatus";
                using (SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection))
                {
                    command.Prepare();
                    command.Parameters.AddWithValue("@TaskType", taskType.ToString());
                    command.Parameters.AddWithValue("@TaskStatus", taskStatus.ToString());
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        List<TaskModel> taskModels = GetTaskModelListByReader(reader);
                        Tasks = taskModels;
                        return taskModels;
                    }
                }
            }
        }

        //查询一周内的任务
        public List<TaskModel> searchTasksInWeek()
        {
            //1. 获得今天的0点
            DateTime startOfToday = DateTime.Now.Date;
            //2. 获得本周的第一天的0点
            DateTime startOfWeek = startOfToday.AddDays((-(double)startOfToday.DayOfWeek) + 1);
            //3. 获得本周的最后一天的24点
            DateTime endOfWeek = startOfWeek.AddDays(7);
            //4. 建立新的列表
            List<TaskModel> tasks = new List<TaskModel>();
            //5. 遍历所有任务
            foreach (TaskModel task in Tasks)
            {
                //6. 存储符合条件的任务
                if (task.Deadline >= startOfWeek && task.Deadline <= endOfWeek)
                {
                    tasks.Add(task);
                }
            }
            //7. 返回查询到的符合条件的任务列表
            return tasks;
        }

        //查询今日任务
        public List<TaskModel> searchTasksToday()
        {
            //1. 获得今天的0点
            DateTime startOfToday = DateTime.Now.Date;
            //2. 获得今天的24点
            DateTime endOfToday = startOfToday.AddDays(1);
            //4. 建立新的列表
            List<TaskModel> tasks = new List<TaskModel>();
            //5. 遍历所有任务
            foreach (TaskModel task in Tasks)
            {
                //6. 存储符合条件的任务
                if (task.Deadline >= startOfToday && task.Deadline <= endOfToday)
                {
                    tasks.Add(task);
                }
            }
            //7. 返回查询到的符合条件的任务列表
            return tasks;
        }





        //从reader中直接得到TaskModel对象
        public TaskModel GetTaskModelByReader(SQLiteDataReader reader) 
        {
            TaskModel task = new TaskModel(reader.GetInt32(0),reader.GetString(1),reader.GetDateTime(2),reader.GetDateTime(3), reader.GetDateTime(4),reader.GetInt32(5), (TaskType)Enum.Parse(typeof(TaskType), reader.GetString(6)), (TheTaskStatus)Enum.Parse(typeof(TheTaskStatus), reader.GetString(7)));
            return task;
        }

        //从reader中得到List<TaskModel>
        public List<TaskModel> GetTaskModelListByReader(SQLiteDataReader reader) 
        {
            List<TaskModel> taskModels = new List<TaskModel>();
            while (reader.Read()) //逐行读取
            {
                taskModels.Add(GetTaskModelByReader(reader));
            }
            return taskModels;
        }
        public List<TaskModel> GetTaskByDDL() 
        {
            using (SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=Task.sqlite;Version=3;"))
            {
                m_dbConnection.Open();
                string sql = "select * from task Order by Deadline";
                using (SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection))
                {
                    command.Prepare();
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        List<TaskModel> taskModels = GetTaskModelListByReader(reader);
                        Tasks = taskModels;
                        return taskModels;
                    }
                }
            }
        }
        public List<TaskModel> GetTaskByRemindTime()
        {
            using (SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=Task.sqlite;Version=3;"))
            {
                m_dbConnection.Open();
                string sql = "select * from task Order by ReminderTime";
                using (SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection))
                {
                    command.Prepare();
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        List<TaskModel> taskModels = GetTaskModelListByReader(reader);
                        Tasks = taskModels;
                        return taskModels;
                    }
                }
            }
        }

        public List<TaskModel> GetTaskByName(string name) 
        {
            using (SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=Task.sqlite;Version=3;"))
            {
                m_dbConnection.Open();
                string sql = "select * from task where Name = @Name";
                using (SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection))
                {
                    command.Prepare();
                    command.Parameters.AddWithValue("@Name", name);
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        List<TaskModel> taskModels = GetTaskModelListByReader(reader);
                        Tasks = taskModels;
                        return taskModels;
                    }
                }
            }
        }

        public List<TaskModel> GetTaskByNameLike(string name)
        {
            using (SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=Task.sqlite;Version=3;"))
            {
                m_dbConnection.Open();
                string sql = "select * from task where Name like @Name";
                using (SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection))
                {
                    name = "%" + name + "%";
                    command.Prepare();
                    command.Parameters.AddWithValue("@Name", name);
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        List<TaskModel> taskModels = GetTaskModelListByReader(reader);
                        Tasks = taskModels;
                        return taskModels;
                    }
                }
            }
        }

        public TaskModel GetById(int id) 
        {
            using (SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=Task.sqlite;Version=3;"))
            {
                m_dbConnection.Open();
                string sql = "select * from task where Id = @Id";
                using (SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection))
                {
                    command.Prepare();
                    command.Parameters.AddWithValue("@Id", id);
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        List<TaskModel> taskModels = GetTaskModelListByReader(reader);
                        Tasks = taskModels;
                        return taskModels[0];
                    }
                }
            }
        }
    }
}
