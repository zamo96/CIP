using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CIP.Models
{
    public class TimeHelp
    {
        public DateTime TimeStart { get; set; }
        public DateTime TimeEnd { get; set; }
        public TimeHelp(DateTime start, DateTime end)
        {
            TimeStart = start;
            TimeEnd = end;
        }
    }
}