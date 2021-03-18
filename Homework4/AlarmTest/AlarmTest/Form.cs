using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace AlarmTest
{
    public class Form
    {
        public AlarmClock clock = new AlarmClock();
        public Form()
        {
            clock.onAlarm += Tick;
            clock.onAlarm += Alarm;
        }

        public void Tick(object sender, AlarmEventArgs args)
        {
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("滴答");
        }
        public void Alarm(object sender, AlarmEventArgs args)
        {
            if (AlarmEventArgs.Time == DateTime.Now.ToLongTimeString().ToString())
            {
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine($"{AlarmEventArgs.Time}!时间到了!");
            }
        }

    }
}