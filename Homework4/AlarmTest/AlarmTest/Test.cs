using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlarmTest
{
    public class Test
    {
        static void Main()
        {
            string time = "9:22:00";
            Form form = new Form();
            form.clock.alarm(time);

        }
    }
}
