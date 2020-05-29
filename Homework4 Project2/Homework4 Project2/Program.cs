using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace homework4project2
{
    public delegate void TickHandler(object sender, Tick args);
    public delegate void AlarmHandler(object sender, Alarm args);
    public class Tick
    {
        public Tick()
        {

        }
    }
    public class Alarm
    {
        public Alarm()
        {

        }
    }
    public class AlarmClock
    {
        public event TickHandler OnTick;
        public event AlarmHandler OnAlarm;
        public int count;
        public void setAlarm(int c)
        {
            this.count = c;
        }
        public void turnOn()
        {
            for (int i = 1; ; i++)
            {
                Thread.Sleep(1000);
                ClockTick();
                if (i % count == 0)
                    ClockAlarm();
            }
        }
        public void ClockTick()
        {
            Tick args = new Tick();
            OnTick(this, args);
        }
        public void ClockAlarm()
        {
            Alarm args = new Alarm();
            OnAlarm(this, args);
        }
    }
    public class Manage
    {
        public AlarmClock clock1 = new AlarmClock();
        public Manage()
        {
            clock1.OnTick += new TickHandler(Clock_Tick);
            clock1.OnAlarm += new AlarmHandler(Clock_Alarm);
        }
        void Clock_Tick(object sender, Tick args)
        {
            Console.WriteLine("Tick");

        }
        void Clock_Alarm(object sender, Alarm args)
        {
            Console.WriteLine("Alarm");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Manage m1 = new Manage();
            m1.clock1.setAlarm(10);
            m1.clock1.turnOn();
        }
    }
}