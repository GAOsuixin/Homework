using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.test
{
    class SmallPointsTest
    {

        public void testDateTime()
        {
            //获取当前时间
            DateTime dateTime = DateTime.Now;
            Console.WriteLine(dateTime);

            //获取今天的 0点 
            DateTime nowDate = DateTime.Now.Date;
            Console.WriteLine(nowDate);

            //获取所在周的第一天的0点
            DateTime startOfWeek = nowDate.AddDays((-(double)DateTime.Now.DayOfWeek) + 1);
            Console.WriteLine(startOfWeek);

            //获取所在周的最后一天的0点
            DateTime endOfWeek = startOfWeek.AddDays(7);
            Console.WriteLine(endOfWeek);

            //判断当前时间是否在本周内
            if (dateTime > startOfWeek && dateTime < endOfWeek)
            {
                Console.WriteLine("时间在访问内");
            }
            else
            {
                Console.WriteLine("时间不在访问内");
            }
        }
    }
}
