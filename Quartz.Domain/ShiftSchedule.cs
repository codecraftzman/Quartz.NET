using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quartz.Domain
{
    public class ShiftSchedule
    {
        public int ScheduleId { get; set; }
        public int EmployeeId { get; set; }
        public DateOnly ShiftDate { get; set; }
        public TimeOnly StartTime { get; set; }
        public TimeOnly EndTime { get; set; }

        [ForeignKey("EmployeeId")]
        public Employee Employee { get; set; } = default!;
        public ShiftType ShiftType { get; set; } = default!;
        public Region Region { get; set; } = default!;
        public int Offset { get; set; }

        
    }
}
