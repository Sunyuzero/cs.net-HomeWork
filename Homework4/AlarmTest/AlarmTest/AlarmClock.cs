using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlarmTest
{
    public class AlarmClock
    {
        public event AlarmEventHandler onAlarm;
        public void alarm(String time)
        {
            AlarmEventArgs args = new AlarmEventArgs();
            AlarmEventArgs.Time = time;
            while (true)  onAlarm(this, args);
        }
    }
}
