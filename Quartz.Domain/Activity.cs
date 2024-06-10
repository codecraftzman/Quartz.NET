using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quartz.Domain
{
    public class Activity
    {
        public int ActivityId { get; set; }
        public int SessionId { get; set; }

        [ForeignKey("SessionId")]
        public Session Session { get; set; } = default!;
        public ActivityType Type { get; set; }
        public TimeOnly StartTime { get; set; }
        public TimeOnly EndTime { get; set; }
        public string Comments { get; set; } = default!;
    }
}
