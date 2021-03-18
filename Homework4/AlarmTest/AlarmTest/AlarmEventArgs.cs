using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
namespace AlarmTest
{

    public class AlarmEventArgs : EventArgs
    {
        public static string Time { get; set; }
    }

    public delegate void AlarmEventHandler(object sender, AlarmEventArgs e);
     
}

