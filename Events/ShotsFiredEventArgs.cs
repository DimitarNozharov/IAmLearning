using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    public class ShotsFiredEventArgs : EventArgs
    {
        public DateTime TimeOfKill { get; set; }

        public ShotsFiredEventArgs(DateTime time)
        {
            TimeOfKill = time;
        }

        public ShotsFiredEventArgs()
        {
            TimeOfKill = DateTime.UtcNow;
        }
    }
}
