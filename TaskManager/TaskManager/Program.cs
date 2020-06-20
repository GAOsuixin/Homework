using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskManager.ui;
using System.Data.SQLite;

namespace TaskManager
{
    static class Program
    {
        // <summary>
        // 应用程序的主入口点。
        // </summary>
        [STAThread]
        static void Main()
        {
            //如果没有数据库文件则创建数据库文件并建表
            if (!File.Exists("Task.sqlite")) 
            {
                SQLiteConnection.CreateFile("Task.sqlite");
                using (SQLiteConnection m_dbConnection = new SQLiteConnection("Data Source=Task.sqlite;Version=3;")) 
                {
                    m_dbConnection.Open();
                    string sql = "create table task " +
                        "(Id integer primary Key autoincrement, Name varchar(20), StartTime TimeStamp, Deadline TimeStamp, ReminderTime TimeStamp," +
                        "RepetitionRate int, TaskType varchar, TaskStatus varchar)";
                    using (SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection))
                    {
                        command.ExecuteNonQuery();
                    }
                }
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
